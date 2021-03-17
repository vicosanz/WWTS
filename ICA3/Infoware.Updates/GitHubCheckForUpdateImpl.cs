using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squirrel;
using Squirrel.SimpleSplat;

namespace Infoware.Updates
{
    internal class GitHubCheckForUpdateImpl : IEnableLogger
    {
        private string rootAppDirectory;

        public GitHubCheckForUpdateImpl(string rootAppDirectory)
        {
            this.rootAppDirectory = rootAppDirectory;
        }

        public async Task<UpdateInfo> CheckForUpdate(
            UpdaterIntention intention,
            string localReleaseFile,
            bool ignoreDeltaUpdates = false,
            Action<int> progress = null,
            GitHubFileDownloader urlDownloader = null)
        {
            progress = progress ?? (_ => { });

            var localReleases = Enumerable.Empty<ReleaseEntry>();
            var stagingId = intention == UpdaterIntention.Install ? null : GetOrCreateStagedUserId();

            bool shouldInitialize = intention == UpdaterIntention.Install;

            if (intention != UpdaterIntention.Install)
            {
                try
                {
                    localReleases = FUtilities.LoadLocalReleases(localReleaseFile);
                }
                catch (Exception ex)
                {
                    // Something has gone pear-shaped, let's start from scratch
                    this.Log().WarnException("Failed to load local releases, starting from scratch", ex);
                    shouldInitialize = true;
                }
            }

            if (shouldInitialize) await InitializeClientAppDirectory();

            string releaseFile;

            var latestLocalRelease = localReleases.Count() > 0 ?
                localReleases.MaxBy(x => x.Version).First() :
                default;

            // Fetch the remote RELEASES file, whether it's a local dir or an
            // HTTP URL
            var data = await urlDownloader.DownloadUrl(urlDownloader.GetDownloadUrl("RELEASES"));
            releaseFile = Encoding.UTF8.GetString(data);
            progress(33);

            var ret = default(UpdateInfo);
            var remoteReleases = ReleaseEntry.ParseReleaseFileAndApplyStaging(releaseFile, stagingId);
            progress(66);

            if (!remoteReleases.Any())
            {
                throw new Exception("Remote release File is empty or corrupted");
            }

            ret = DetermineUpdateInfo(intention, localReleases, remoteReleases, ignoreDeltaUpdates);
            progress(100);
            return ret;
        }

        async Task InitializeClientAppDirectory()
        {
            // On bootstrap, we won't have any of our directories, create them
            var pkgDir = Path.Combine(rootAppDirectory, "packages");
            if (Directory.Exists(pkgDir))
            {
                await FUtilities.DeleteDirectory(pkgDir);
            }

            Directory.CreateDirectory(pkgDir);
        }

        UpdateInfo DetermineUpdateInfo(UpdaterIntention intention, IEnumerable<ReleaseEntry> localReleases, IEnumerable<ReleaseEntry> remoteReleases, bool ignoreDeltaUpdates)
        {
            var packageDirectory = FUtilities.PackageDirectoryForAppDir(rootAppDirectory);
            localReleases = localReleases ?? Enumerable.Empty<ReleaseEntry>();

            if (remoteReleases == null)
            {
                this.Log().Warn("Release information couldn't be determined due to remote corrupt RELEASES file");
                throw new Exception("Corrupt remote RELEASES file");
            }

            var latestFullRelease = FUtilities.FindCurrentVersion(remoteReleases);
            var currentRelease = FUtilities.FindCurrentVersion(localReleases);

            if (latestFullRelease == currentRelease)
            {
                this.Log().Info("No updates, remote and local are the same");

                var info = UpdateInfo.Create(currentRelease, new[] { latestFullRelease }, packageDirectory);
                return info;
            }

            if (ignoreDeltaUpdates)
            {
                remoteReleases = remoteReleases.Where(x => !x.IsDelta);
            }

            if (!localReleases.Any())
            {
                if (intention == UpdaterIntention.Install)
                {
                    this.Log().Info("First run, starting from scratch");
                }
                else
                {
                    this.Log().Warn("No local releases found, starting from scratch");
                }

                return UpdateInfo.Create(null, new[] { latestFullRelease }, packageDirectory);
            }

            if (localReleases.Max(x => x.Version) > remoteReleases.Max(x => x.Version))
            {
                this.Log().Warn("hwhat, local version is greater than remote version");
                return UpdateInfo.Create(FUtilities.FindCurrentVersion(localReleases), new[] { latestFullRelease }, packageDirectory);
            }

            return UpdateInfo.Create(currentRelease, remoteReleases, packageDirectory);
        }

        internal Guid? GetOrCreateStagedUserId()
        {
            var stagedUserIdFile = Path.Combine(rootAppDirectory, "packages", ".betaId");
            var ret = default(Guid);

            try
            {
                if (!Guid.TryParse(File.ReadAllText(stagedUserIdFile, Encoding.UTF8), out ret))
                {
                    throw new Exception("File was read but contents were invalid");
                }

                this.Log().Info("Using existing staging user ID: {0}", ret.ToString());
                return ret;
            }
            catch (Exception ex)
            {
                this.Log().DebugException("Couldn't read staging user ID, creating a blank one", ex);
            }

            var prng = new Random();
            var buf = new byte[4096];
            prng.NextBytes(buf);

            ret = FUtilities.CreateGuidFromHash(buf);
            try
            {
                File.WriteAllText(stagedUserIdFile, ret.ToString(), Encoding.UTF8);
                this.Log().Info("Generated new staging user ID: {0}", ret.ToString());
                return ret;
            }
            catch (Exception ex)
            {
                this.Log().WarnException("Couldn't write out staging user ID, this user probably shouldn't get beta anything", ex);
                return null;
            }
        }
    }

}