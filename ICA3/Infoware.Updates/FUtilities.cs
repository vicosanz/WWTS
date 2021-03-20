using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Squirrel;
using Squirrel.SimpleSplat;

namespace Infoware.Updates
{
    public static class FUtilities
    {
        #region Web
        public static WebClient CreateWebClient()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var ret = new WebClient();
            var wp = WebRequest.DefaultWebProxy;
            if (wp != null)
            {
                wp.Credentials = CredentialCache.DefaultCredentials;
                ret.Proxy = wp;
            }

            return ret;
        }

        public static bool IsHttpUrl(string urlOrPath)
        {
            if (!Uri.TryCreate(urlOrPath, UriKind.Absolute, out Uri uri))
            {
                return false;
            }

            return uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps;
        }

        public static Uri EnsureTrailingSlash(Uri uri)
        {
            return AppendPathToUri(uri, "");
        }

        public static Uri AppendPathToUri(Uri uri, string path)
        {
            var builder = new UriBuilder(uri);
            if (!builder.Path.EndsWith("/"))
            {
                builder.Path += "/";
            }

            builder.Path += path;
            return builder.Uri;
        }
        #endregion

        #region Helpers
        public static string GetLocalAppDataDirectory(string assemblyLocation = null)
        {
            // Try to divine our our own install location via reading tea leaves
            //
            // * We're Update.exe, running in the app's install folder
            // * We're Update.exe, running on initial install from SquirrelTemp
            // * We're a C# EXE with Squirrel linked in

            var assembly = Assembly.GetEntryAssembly();
            if (assemblyLocation == null && assembly == null)
            {
                // dunno lol
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            }

            assemblyLocation = assemblyLocation ?? assembly.Location;

            if (Path.GetFileName(assemblyLocation).Equals("update.exe", StringComparison.OrdinalIgnoreCase))
            {
                // NB: Both the "SquirrelTemp" case and the "App's folder" case 
                // mean that the root app dir is one up
                var oneFolderUpFromAppFolder = Path.Combine(Path.GetDirectoryName(assemblyLocation), "..");
                return Path.GetFullPath(oneFolderUpFromAppFolder);
            }

            var twoFoldersUpFromAppFolder = Path.Combine(Path.GetDirectoryName(assemblyLocation), "..\\..");
            return Path.GetFullPath(twoFoldersUpFromAppFolder);
        }

        public static IEnumerable<ReleaseEntry> LoadLocalReleases(string localReleaseFile)
        {
            var file = File.OpenRead(localReleaseFile);

            // NB: sr disposes file
            using (var sr = new StreamReader(file, Encoding.UTF8))
            {
                return ReleaseEntry.ParseReleaseFile(sr.ReadToEnd());
            }
        }

        public static string GetApplicationName()
        {
            FileInfo fi = new FileInfo(GetUpdateExe());
            return fi.Directory.Name;
        }


        public static string GetUpdateExe()
        {
            var assembly = Assembly.GetEntryAssembly();

            // Are we update.exe?
            if (assembly != null &&
                Path.GetFileName(assembly.Location).Equals("update.exe", StringComparison.OrdinalIgnoreCase) &&
                assembly.Location.IndexOf("app-", StringComparison.OrdinalIgnoreCase) == -1 &&
                assembly.Location.IndexOf("SquirrelTemp", StringComparison.OrdinalIgnoreCase) == -1)
            {
                return Path.GetFullPath(assembly.Location);
            }

            assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();

            var updateDotExe = Path.Combine(Path.GetDirectoryName(assembly.Location), "..\\Update.exe");
            var target = new FileInfo(updateDotExe);

            if (!target.Exists) throw new Exception("Update.exe not found, not a Squirrel-installed app?");
            return target.FullName;
        }

        public static string AppDirForRelease(string rootAppDirectory, ReleaseEntry entry)
        {
            return Path.Combine(rootAppDirectory, "app-" + entry.Version.ToString());
        }

        public static ReleaseEntry FindCurrentVersion(IEnumerable<ReleaseEntry> localReleases)
        {
            if (!localReleases.Any())
            {
                return null;
            }

            return localReleases.OrderByDescending(x => x.Version).FirstOrDefault(x => !x.IsDelta);
        }

        public static string LocalReleaseFileForAppDir(string rootAppDirectory)
        {
            return Path.Combine(PackageDirectoryForAppDir(rootAppDirectory), "RELEASES");
        }

        public static string PackageDirectoryForAppDir(string rootAppDirectory)
        {
            return Path.Combine(rootAppDirectory, "packages");
        }

        #endregion

        #region SHA
        public static string CalculateStreamSHA1(Stream file)
        {
            Contract.Requires(file != null && file.CanRead);

            using (var sha1 = SHA1.Create())
            {
                return BitConverter.ToString(sha1.ComputeHash(file)).Replace("-", string.Empty);
            }
        }
        #endregion

        #region Log
        public static IFullLogger logger;
        public static IFullLogger Log()
        {
            return logger ??
                (logger = SquirrelLocator.CurrentMutable.GetService<ILogManager>().GetLogger(typeof(FUtilities)));
        }
        #endregion

        #region Foreach
        public static Task ForEachAsync<T>(this IEnumerable<T> source, Action<T> body, int degreeOfParallelism = 4)
        {
            return ForEachAsync(source, x => Task.Run(() => body(x)), degreeOfParallelism);
        }

        public static Task ForEachAsync<T>(this IEnumerable<T> source, Func<T, Task> body, int degreeOfParallelism = 4)
        {
            return Task.WhenAll(
                from partition in Partitioner.Create(source).GetPartitions(degreeOfParallelism)
                select Task.Run(async () =>
                {
                    using (partition)
                        while (partition.MoveNext())
                            await body(partition.Current);
                }));
        }
        #endregion

        #region GUID
        /// <summary>
        /// The namespace for ISO OIDs (from RFC 4122, Appendix C).
        /// </summary>
        public static readonly Guid IsoOidNamespace = new Guid("6ba7b812-9dad-11d1-80b4-00c04fd430c8");

        public static Guid CreateGuidFromHash(string text)
        {
            return CreateGuidFromHash(text, IsoOidNamespace);
        }
        public static Guid CreateGuidFromHash(byte[] data)
        {
            return CreateGuidFromHash(data, IsoOidNamespace);
        }

        public static Guid CreateGuidFromHash(string text, Guid namespaceId)
        {
            return CreateGuidFromHash(Encoding.UTF8.GetBytes(text), namespaceId);
        }

        public static Guid CreateGuidFromHash(byte[] nameBytes, Guid namespaceId)
        {
            // convert the namespace UUID to network order (step 3)
            byte[] namespaceBytes = namespaceId.ToByteArray();
            SwapByteOrder(namespaceBytes);

            // comput the hash of the name space ID concatenated with the 
            // name (step 4)
            byte[] hash;
            using (var algorithm = SHA1.Create())
            {
                algorithm.TransformBlock(namespaceBytes, 0, namespaceBytes.Length, null, 0);
                algorithm.TransformFinalBlock(nameBytes, 0, nameBytes.Length);
                hash = algorithm.Hash;
            }

            // most bytes from the hash are copied straight to the bytes of 
            // the new GUID (steps 5-7, 9, 11-12)
            var newGuid = new byte[16];
            Array.Copy(hash, 0, newGuid, 0, 16);

            // set the four most significant bits (bits 12 through 15) of 
            // the time_hi_and_version field to the appropriate 4-bit 
            // version number from Section 4.1.3 (step 8)
            newGuid[6] = (byte)((newGuid[6] & 0x0F) | (5 << 4));

            // set the two most significant bits (bits 6 and 7) of the 
            // clock_seq_hi_and_reserved to zero and one, respectively 
            // (step 10)
            newGuid[8] = (byte)((newGuid[8] & 0x3F) | 0x80);

            // convert the resulting UUID to local byte order (step 13)
            SwapByteOrder(newGuid);
            return new Guid(newGuid);
        }

        public static void SwapByteOrder(byte[] guid)
        {
            SwapBytes(guid, 0, 3);
            SwapBytes(guid, 1, 2);
            SwapBytes(guid, 4, 5);
            SwapBytes(guid, 6, 7);
        }

        public static void SwapBytes(byte[] guid, int left, int right)
        {
            byte temp = guid[left];
            guid[left] = guid[right];
            guid[right] = temp;
        }
        #endregion

        #region LogErrors
        public static void ErrorIfThrows(this IEnableLogger This, Action block, string message = null)
        {
            This.Log().LogIfThrows(LogLevel.Error, message, block);
        }

        public static Task<T> ErrorIfThrows<T>(this IEnableLogger This, Func<Task<T>> block, string message = null)
        {
            return This.Log().LogIfThrows(LogLevel.Error, message, block);
        }

        public static Task ErrorIfThrows(this IEnableLogger This, Func<Task> block, string message = null)
        {
            return This.Log().LogIfThrows(LogLevel.Error, message, block);
        }

        public static void WarnIfThrows(this IEnableLogger This, Action block, string message = null)
        {
            This.Log().LogIfThrows(LogLevel.Warn, message, block);
        }

        public static Task WarnIfThrows(this IEnableLogger This, Func<Task> block, string message = null)
        {
            return This.Log().LogIfThrows(LogLevel.Warn, message, block);
        }

        public static Task<T> WarnIfThrows<T>(this IEnableLogger This, Func<Task<T>> block, string message = null)
        {
            return This.Log().LogIfThrows(LogLevel.Warn, message, block);
        }

        public static void LogIfThrows(this IFullLogger This, LogLevel level, string message, Action block)
        {
            try
            {
                block();
            }
            catch (Exception ex)
            {
                switch (level)
                {
                    case LogLevel.Debug:
                        This.DebugException(message ?? "", ex);
                        break;
                    case LogLevel.Info:
                        This.InfoException(message ?? "", ex);
                        break;
                    case LogLevel.Warn:
                        This.WarnException(message ?? "", ex);
                        break;
                    case LogLevel.Error:
                        This.ErrorException(message ?? "", ex);
                        break;
                }

                throw;
            }
        }

        public static async Task<T> LogIfThrows<T>(this IFullLogger This, LogLevel level, string message, Func<Task<T>> block)
        {
            try
            {
                return await block();
            }
            catch (Exception ex)
            {
                switch (level)
                {
                    case LogLevel.Debug:
                        This.DebugException(message ?? "", ex);
                        break;
                    case LogLevel.Info:
                        This.InfoException(message ?? "", ex);
                        break;
                    case LogLevel.Warn:
                        This.WarnException(message ?? "", ex);
                        break;
                    case LogLevel.Error:
                        This.ErrorException(message ?? "", ex);
                        break;
                }
                throw;
            }
        }

        public static async Task LogIfThrows(this IFullLogger This, LogLevel level, string message, Func<Task> block)
        {
            try
            {
                await block();
            }
            catch (Exception ex)
            {
                switch (level)
                {
                    case LogLevel.Debug:
                        This.DebugException(message ?? "", ex);
                        break;
                    case LogLevel.Info:
                        This.InfoException(message ?? "", ex);
                        break;
                    case LogLevel.Warn:
                        This.WarnException(message ?? "", ex);
                        break;
                    case LogLevel.Error:
                        This.ErrorException(message ?? "", ex);
                        break;
                }
                throw;
            }
        }

        #endregion

        #region Progress
        public static int CalculateProgress(int percentageOfCurrentStep, int stepStartPercentage, int stepEndPercentage)
        {
            // Ensure we are between 0 and 100
            percentageOfCurrentStep = Math.Max(Math.Min(percentageOfCurrentStep, 100), 0);

            var range = stepEndPercentage - stepStartPercentage;
            var singleValue = range / 100d;
            var totalPercentage = (singleValue * percentageOfCurrentStep) + stepStartPercentage;

            return (int)totalPercentage;
        }
        #endregion

        #region Invoke
        public static Task<Tuple<int, string>> InvokeProcessAsync(string fileName, string arguments, CancellationToken ct, string workingDirectory = "")
        {
            var psi = new ProcessStartInfo(fileName, arguments);
            if (Environment.OSVersion.Platform != PlatformID.Win32NT && fileName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
            {
                psi = new ProcessStartInfo("wine", fileName + " " + arguments);
            }

            psi.UseShellExecute = false;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.ErrorDialog = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.WorkingDirectory = workingDirectory;

            return InvokeProcessAsync(psi, ct);
        }

        public static async Task<Tuple<int, string>> InvokeProcessAsync(ProcessStartInfo psi, CancellationToken ct)
        {
            var pi = Process.Start(psi);
            await Task.Run(() =>
            {
                while (!ct.IsCancellationRequested)
                {
                    if (pi.WaitForExit(2000)) return;
                }

                if (ct.IsCancellationRequested)
                {
                    pi.Kill();
                    ct.ThrowIfCancellationRequested();
                }
            });

            string textResult = await pi.StandardOutput.ReadToEndAsync();
            if (String.IsNullOrWhiteSpace(textResult) || pi.ExitCode != 0)
            {
                textResult = (textResult ?? "") + "\n" + await pi.StandardError.ReadToEndAsync();

                if (String.IsNullOrWhiteSpace(textResult))
                {
                    textResult = String.Empty;
                }
            }

            return Tuple.Create(pi.ExitCode, textResult.Trim());
        }


        #endregion

        #region FileManager
        public static void DeleteFileHarder(string path, bool ignoreIfFails = false)
        {
            try
            {
                Retry(() => File.Delete(path), 2);
            }
            catch (Exception ex)
            {
                if (ignoreIfFails) return;

                LogHost.Default.ErrorException("Really couldn't delete file: " + path, ex);
                throw;
            }
        }

        public static async Task DeleteDirectoryOrJustGiveUp(string dir)
        {
            try
            {
                await DeleteDirectory(dir);
            }
            catch
            {
                var message = string.Format("Uninstall failed to delete dir '{0}'", dir);
            }
        }

        public static async Task DeleteDirectory(string directoryPath)
        {
            Contract.Requires(!string.IsNullOrEmpty(directoryPath));

            Log().Debug("Starting to delete folder: {0}", directoryPath);

            if (!Directory.Exists(directoryPath))
            {
                Log().Warn("DeleteDirectory: does not exist - {0}", directoryPath);
                return;
            }

            // From http://stackoverflow.com/questions/329355/cannot-delete-directory-with-directory-deletepath-true/329502#329502
            var files = new string[0];
            try
            {
                files = Directory.GetFiles(directoryPath);
            }
            catch (UnauthorizedAccessException ex)
            {
                var message = String.Format("The files inside {0} could not be read", directoryPath);
                Log().Warn(message, ex);
            }

            var dirs = new string[0];
            try
            {
                dirs = Directory.GetDirectories(directoryPath);
            }
            catch (UnauthorizedAccessException ex)
            {
                var message = String.Format("The directories inside {0} could not be read", directoryPath);
                Log().Warn(message, ex);
            }

            var fileOperations = files.ForEachAsync(file =>
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            });

            var directoryOperations =
                dirs.ForEachAsync(async dir => await DeleteDirectory(dir));

            await Task.WhenAll(fileOperations, directoryOperations);

            Log().Debug("Now deleting folder: {0}", directoryPath);
            File.SetAttributes(directoryPath, FileAttributes.Normal);

            try
            {
                Directory.Delete(directoryPath, false);
            }
            catch (Exception ex)
            {
                var message = string.Format("DeleteDirectory: could not delete - {0}", directoryPath);
                Log().ErrorException(message, ex);
            }
        }

        #endregion

        #region Retry
        public static void Retry(this Action block, int retries = 2)
        {
            Contract.Requires(retries > 0);

            Func<object> thunk = () =>
            {
                block();
                return null;
            };

            thunk.Retry(retries);
        }

        public static T Retry<T>(this Func<T> block, int retries = 2)
        {
            Contract.Requires(retries > 0);

            while (true)
            {
                try
                {
                    T ret = block();
                    return ret;
                }
                catch (Exception)
                {
                    if (retries == 0)
                    {
                        throw;
                    }

                    retries--;
                    Thread.Sleep(250);
                }
            }
        }
        #endregion
    }
}
