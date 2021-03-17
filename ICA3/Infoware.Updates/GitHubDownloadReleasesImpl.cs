using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Squirrel;
using Squirrel.SimpleSplat;

namespace Infoware.Updates
{
    public class GitHubDownloadReleasesImpl : IEnableLogger
    {
        private string rootAppDirectory;

        public GitHubDownloadReleasesImpl(string rootAppDirectory)
        {
            this.rootAppDirectory = rootAppDirectory;
        }

        public async Task DownloadReleases(IEnumerable<ReleaseEntry> releasesToDownload, Action<int> progress = null, GitHubFileDownloader urlDownloader = null)
        {
            progress = progress ?? (_ => { });
            var packagesDirectory = Path.Combine(rootAppDirectory, "packages");

            double current = 0;
            double toIncrement = 100.0 / releasesToDownload.Count();

            // From Internet
            await releasesToDownload.ForEachAsync(async x => {
                var targetFile = Path.Combine(packagesDirectory, x.Filename);
                double component = 0;
                await downloadRelease(x, urlDownloader, targetFile, p => {
                    lock (progress)
                    {
                        current -= component;
                        component = toIncrement / 100.0 * p;
                        progress((int)Math.Round(current += component));
                    }
                });

                checksumPackage(x);
            });
        }

        bool isReleaseExplicitlyHttp(ReleaseEntry x)
        {
            return x.BaseUrl != null &&
                Uri.IsWellFormedUriString(x.BaseUrl, UriKind.Absolute);
        }

        Task downloadRelease(ReleaseEntry releaseEntry, GitHubFileDownloader urlDownloader, string targetFile, Action<int> progress)
        {
            string sourceFileUrl = urlDownloader.GetDownloadUrl(releaseEntry);
            File.Delete(targetFile);

            return urlDownloader.DownloadFile(sourceFileUrl, targetFile, progress);
        }

        Task checksumAllPackages(IEnumerable<ReleaseEntry> releasesDownloaded)
        {
            return releasesDownloaded.ForEachAsync(x => checksumPackage(x));
        }

        void checksumPackage(ReleaseEntry downloadedRelease)
        {
            var targetPackage = new FileInfo(
                Path.Combine(rootAppDirectory, "packages", downloadedRelease.Filename));

            if (!targetPackage.Exists)
            {
                this.Log().Error("File {0} should exist but doesn't", targetPackage.FullName);

                throw new Exception("Checksummed file doesn't exist: " + targetPackage.FullName);
            }

            if (targetPackage.Length != downloadedRelease.Filesize)
            {
                this.Log().Error("File Length should be {0}, is {1}", downloadedRelease.Filesize, targetPackage.Length);
                targetPackage.Delete();

                throw new Exception("Checksummed file size doesn't match: " + targetPackage.FullName);
            }

            using (var file = targetPackage.OpenRead())
            {
                var hash = FUtilities.CalculateStreamSHA1(file);

                if (!hash.Equals(downloadedRelease.SHA1, StringComparison.OrdinalIgnoreCase))
                {
                    this.Log().Error("File SHA1 should be {0}, is {1}", downloadedRelease.SHA1, hash);
                    targetPackage.Delete();
                    throw new Exception("Checksum doesn't match: " + targetPackage.FullName);
                }
            }
        }

    }
}