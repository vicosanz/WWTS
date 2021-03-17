using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using Squirrel;
using Squirrel.SimpleSplat;

namespace Infoware.Updates
{
    public class GitHubFileDownloader : IFileDownloader, IEnableLogger
    {
        private Release latest;
        private GitHubClient github;

        public GitHubFileDownloader(GitHubClient github, Release latest)
        {
            this.github = github;
            this.latest = latest;
        }

        public async Task DownloadFile(string url, string targetFile, Action<int> progress)
        {
            try
            {
                this.Log().Info("Downloading file: " + url);
                
                var response = await github.Connection.Get<object>(new Uri(url), new Dictionary<string, string>(), "application/octet-stream");
                File.WriteAllBytes(targetFile, (byte[])response.HttpResponse.Body);
                progress(100);
            }
            catch (Exception ex)
            {
                this.Log().ErrorException("Failed downloading URL: " + url, ex);
                throw;
            }
        }

        public async Task<byte[]> DownloadUrl(string url)
        {
            try
            {
                this.Log().Info("Downloading url: " + url);

                //var response = await github.Connection.GetRaw(new Uri(url), new Dictionary<string, string>());
                var response = await github.Connection.Get<object>(new Uri(url), new Dictionary<string, string>(), "application/octet-stream");
                return (byte[])response.HttpResponse.Body;
            }
            catch (Exception ex)
            {
                this.Log().ErrorException("Failed downloading URL: " + url, ex);
                throw;
            }
        }

        public string GetDownloadUrl(ReleaseEntry releaseEntry)
        {
            return GetDownloadUrl(releaseEntry.Filename);
        }

        public string GetDownloadUrl(string assetName)
        {
            string result = latest.Assets.Where(x => string.Equals(x.Name, assetName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault().Url;
            return result;
        }
    }
}
