using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using NuGet;
using Squirrel;
using Squirrel.SimpleSplat;

namespace Infoware.Updates
{
    public class FUpdateManager : IUpdateManager
    {
        private readonly string applicationName;
        private readonly string rootDirectory;
        private readonly GitHubFileDownloader urlDownloader;
        private string rootAppDirectory;

        IDisposable updateLock;

        public FUpdateManager(string applicationName, string rootDirectory, GitHubFileDownloader urlDownloader)
        {
            this.applicationName = applicationName;
            this.rootDirectory = rootDirectory;
            this.urlDownloader = urlDownloader;
            Contract.Requires(!string.IsNullOrEmpty(applicationName));

            this.applicationName = applicationName ?? FUtilities.GetApplicationName();
            this.urlDownloader = urlDownloader;

            if (rootDirectory != null)
            {
                rootAppDirectory = Path.Combine(rootDirectory, this.applicationName);
                return;
            }

            rootAppDirectory = Path.Combine(rootDirectory ?? FUtilities.GetLocalAppDataDirectory(), this.applicationName);
        }

        public async Task<string> ApplyReleases(UpdateInfo updateInfo, Action<int> progress = null)
        {
            var applyReleases = new GitHubApplyReleasesImpl(rootAppDirectory);
            await AcquireUpdateLock();

            return await applyReleases.ApplyReleases(updateInfo, false, false, progress);
        }

        public async Task<UpdateInfo> CheckForUpdate(bool ignoreDeltaUpdates = false, Action<int> progress = null, UpdaterIntention intention = UpdaterIntention.Update)
        {
            var checkForUpdate = new GitHubCheckForUpdateImpl(rootAppDirectory);

            await AcquireUpdateLock();
            return await checkForUpdate.CheckForUpdate(intention, FUtilities.LocalReleaseFileForAppDir(rootAppDirectory), ignoreDeltaUpdates, progress, urlDownloader);
        }

        private Task<IDisposable> AcquireUpdateLock()
        {
            if (updateLock != null) return Task.FromResult(updateLock);

            return Task.Run(() => {
                var key = FUtilities.CalculateStreamSHA1(new MemoryStream(Encoding.UTF8.GetBytes(rootAppDirectory)));

                IDisposable theLock;
                try
                {
                    theLock = ModeDetector.InUnitTestRunner() ?
                        FDisposable.Create(() => { }) : new FSingleGlobalInstance(key, TimeSpan.FromMilliseconds(2000));
                }
                catch (TimeoutException)
                {
                    throw new TimeoutException("Couldn't acquire update lock, another instance may be running updates");
                }

                var ret = FDisposable.Create(() => {
                    theLock.Dispose();
                    updateLock = null;
                });

                updateLock = ret;
                return ret;
            });
        }

        public void CreateShortcutsForExecutable(string exeName, ShortcutLocation locations, bool updateOnly, string programArguments = null, string icon = null)
        {
            var installHelpers = new GitHubApplyReleasesImpl(rootAppDirectory);
            installHelpers.CreateShortcutsForExecutable(exeName, locations, updateOnly, programArguments, icon);
        }

        public Task<RegistryKey> CreateUninstallerRegistryEntry(string uninstallCmd, string quietSwitch)
        {
            var installHelpers = new GitHubInstallHelperImpl(applicationName, rootAppDirectory);
            return installHelpers.CreateUninstallerRegistryEntry(uninstallCmd, quietSwitch);
        }

        public Task<RegistryKey> CreateUninstallerRegistryEntry()
        {
            var installHelpers = new GitHubInstallHelperImpl(applicationName, rootAppDirectory);
            return installHelpers.CreateUninstallerRegistryEntry();
        }

        public SemanticVersion CurrentlyInstalledVersion(string executable = null)
        {
            executable = executable ??
                Path.GetDirectoryName(typeof(UpdateManager).Assembly.Location);

            if (!executable.StartsWith(rootAppDirectory, StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            var appDirName = executable.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                .FirstOrDefault(x => x.StartsWith("app-", StringComparison.OrdinalIgnoreCase));

            if (appDirName == null) return null;
            return appDirName.ToSemanticVersion();
        }

        public void Dispose()
        {
            var disp = Interlocked.Exchange(ref updateLock, null);
            if (disp != null)
            {
                disp.Dispose();
            }
        }

        public async Task DownloadReleases(IEnumerable<ReleaseEntry> releasesToDownload, Action<int> progress = null)
        {
            var downloadReleases = new GitHubDownloadReleasesImpl(rootAppDirectory);
            await AcquireUpdateLock();

            await downloadReleases.DownloadReleases(releasesToDownload, progress, urlDownloader);
        }

        public async Task FullInstall(bool silentInstall = false, Action<int> progress = null)
        {
            var updateInfo = await CheckForUpdate(intention: UpdaterIntention.Install);
            await DownloadReleases(updateInfo.ReleasesToApply);

            var applyReleases = new GitHubApplyReleasesImpl(rootAppDirectory);
            await AcquireUpdateLock();

            await applyReleases.ApplyReleases(updateInfo, silentInstall, true, progress);
        }

        public async Task FullUninstall()
        {
            var applyReleases = new GitHubApplyReleasesImpl(rootAppDirectory);
            await AcquireUpdateLock();

            this.KillAllExecutablesBelongingToPackage();
            await applyReleases.FullUninstall();
        }

        public void KillAllExecutablesBelongingToPackage()
        {
            var installHelpers = new GitHubInstallHelperImpl(applicationName, rootAppDirectory);
            installHelpers.KillAllProcessesBelongingToPackage();
        }

        public void RemoveShortcutsForExecutable(string exeName, ShortcutLocation locations)
        {
            var installHelpers = new GitHubApplyReleasesImpl(rootAppDirectory);
            installHelpers.RemoveShortcutsForExecutable(exeName, locations);
        }

        public void RemoveUninstallerRegistryEntry()
        {
            var installHelpers = new GitHubInstallHelperImpl(applicationName, rootAppDirectory);
            installHelpers.RemoveUninstallerRegistryEntry();
        }
    }
}