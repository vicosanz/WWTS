using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Infoware.Updates
{
    public partial class GitHubUpdateManager : FUpdateManager
    {
        public GitHubUpdateManager(string applicationName, string rootDirectory, GitHubFileDownloader urlDownloader) :
            base(applicationName, rootDirectory, urlDownloader)
        {
        }

        public static async Task<FUpdateManager> GetUpdateManager(
            string gitUser,
            string gitRepo,
            string ensamblado = null,
            bool prerelease = false)
        {
            var github = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("Squirrel", Assembly.GetExecutingAssembly().GetName().Version.ToString()));

            var releases = await github.Repository.Release.GetAll(gitUser, gitRepo);
            var latest = releases
                .Where(x => prerelease || !x.Prerelease)
                .OrderByDescending(x => x.PublishedAt)
                .First();

            GitHubFileDownloader urlDownloader = new GitHubFileDownloader(github, latest);

            string applicationName = null;
            string rootDirectory = null;
            if (!string.IsNullOrWhiteSpace(ensamblado))
            {
                applicationName = Path.GetFileNameWithoutExtension(ensamblado);
                rootDirectory = FUtilities.GetLocalAppDataDirectory(ensamblado);
            }

            return new FUpdateManager(
                applicationName,
                rootDirectory,
                urlDownloader);
        }
    }

}
