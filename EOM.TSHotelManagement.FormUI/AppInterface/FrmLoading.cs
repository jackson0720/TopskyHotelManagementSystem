/*
 * MIT License
 *Copyright (c) 2021 易开元(EOM)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
using AntdUI;
using EOM.TSHotelManagement.Common;
using Newtonsoft.Json;
using Sunny.UI;
using System.Diagnostics;
using System.Text;

namespace EOM.TSHotelManagement.FormUI
{
    public partial class FrmLoading : UIForm
    {
        private string CurrentVersion => ApplicationUtil.GetApplicationVersion().ToString();
        private string GithubRepoUrl = "https://api.github.com/repos/easy-open-meta/TopskyHotelManagerSystem/releases/latest";
        private string GiteeRepoUrl = "https://gitee.com/api/v5/repos/java-and-net/TopskyHotelManagerSystem/releases/latest";
        private string FileName { get; set; }
        private string CurrentExecutablePath => Application.ExecutablePath;
        private string CurrentExecutableName => Path.GetFileName(CurrentExecutablePath);
        private string FallbackUrl = "https://pan.gkhive.com/%E6%9C%AC%E5%9C%B0%E7%A3%81%E7%9B%98/blog_files/TS%E9%85%92%E5%BA%97%E7%AE%A1%E7%90%86%E7%B3%BB%E7%BB%9F%E7%89%88%E6%9C%AC%E5%BA%93";

        private ProgressBar progressBar;

        public FrmLoading()
        {
            InitializeComponent();
            progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = 100,
                Dock = DockStyle.Top
            };
            this.Controls.Add(progressBar);
        }

        private async void CheckForUpdate()
        {
            using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
            client.DefaultRequestHeaders.Add("User-Agent", await GetDefaultUserAgentAsync());
            try
            {
                // Gitee 优先检查
                var giteeResponse = await client.GetAsync(GiteeRepoUrl);
                if (giteeResponse.IsSuccessStatusCode)
                {
                    var giteeResult = await giteeResponse.Content.ReadAsStringAsync();
                    var giteeRelease = JsonConvert.DeserializeObject<GiteeRelease>(giteeResult);
                    HandleReleaseInfo<GiteeAsset>(giteeRelease.TagName, giteeRelease.Assets, isGitee: true);
                    return;
                }

                // GitHub 回退检查
                var githubResponse = await client.GetAsync(GithubRepoUrl);
                if (githubResponse.IsSuccessStatusCode)
                {
                    var githubResult = await githubResponse.Content.ReadAsStringAsync();
                    var githubRelease = JsonConvert.DeserializeObject<GitHubRelease>(githubResult);
                    HandleReleaseInfo<GitHubAsset>(githubRelease.TagName, githubRelease.Assets, isGitee: false);
                    return;
                }
            }
            catch (Exception ex)
            {
                AntdUI.Modal.open(this, "系统提示", $"检查更新时发生错误: {ex.Message}", TType.Info);
                OpenFallbackUrl();
            }
            finally
            {
                progressBar.Visible = false;
            }
        }

        private void HandleReleaseInfo<TAsset>(
                string tagName,
                List<TAsset> assets,
                bool isGitee) where TAsset : class
        {
            dynamic executableAsset = assets.FirstOrDefault(a =>
                ((dynamic)a).Name?.EndsWith(".exe") == true ||
                ((dynamic)a).FileName?.EndsWith(".exe") == true
            );

            if (executableAsset == null) return;

            string downloadUrl = isGitee ?
                executableAsset.DownloadUrl :
                executableAsset.BrowserDownloadUrl;

            DownloadAndInstallUpdate(downloadUrl, "TS酒店管理系统", new Progress<double>(ReportProgress));
        }

        private async Task<string> GetDefaultUserAgentAsync()
        {
            using var webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            var tcs = new TaskCompletionSource<bool>();
            webBrowser.DocumentCompleted += (sender, e) => tcs.TrySetResult(true);

            webBrowser.Navigate(FallbackUrl);

            await tcs.Task;

            string? userAgent = webBrowser.Document?.InvokeScript("eval", new object[] { "navigator.userAgent;" })?.ToString();
            return userAgent ?? string.Empty;
        }

        private async Task<bool> DownloadAndInstallUpdate(string downloadUrl, string fileName, IProgress<double> progress)
        {
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                var tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

                var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
                var contentLength = response.Content.Headers.ContentLength;

                using var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
                using var stream = await response.Content.ReadAsStreamAsync();

                var totalBytesRead = 0L;
                var buffer = new byte[8192];
                int bytesRead;

                AntdUI.Modal.open(this, "下载提示",
                    $"已通过浏览器发起下载，请查看浏览器的下载列表。\n文件名称: {fileName}",
                    TType.Info);

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                    totalBytesRead += bytesRead;

                    if (contentLength.HasValue)
                    {
                        var progressPercentage = (double)totalBytesRead / contentLength.Value * 100;
                        progress.Report(progressPercentage);
                    }
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = $"/select, \"{tempFilePath}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });

                ExitApplication();

                return true;
            }
            catch (OperationCanceledException)
            {
                AntdUI.Modal.open(this, "系统提示", "网络连接超时，无法下载更新。", TType.Info);
                OpenFallbackUrl();
            }
            catch (Exception ex)
            {
                AntdUI.Modal.open(this, "系统提示", $"下载更新时发生错误: {ex.Message}", TType.Info);
                OpenFallbackUrl();
            }
            return false;
        }

        private void ReportProgress(double percentage)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<double>(ReportProgress), percentage);
            }
            else
            {
                progressBar.Value = (int)percentage;
            }
        }

        private void OpenFallbackUrl()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = FallbackUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"打开浏览器时发生错误: {ex.Message}");
            }
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = ApplicationUtil.GetApplicationVersion().ToString();
            CheckForUpdate();
        }

        public void threadPro()
        {
            System.Windows.Forms.MethodInvoker MethInvo = new System.Windows.Forms.MethodInvoker(ShowLoginForm);
            BeginInvoke(MethInvo);
        }

        public void ShowLoginForm()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);
            this.Close();
        }

        private void FrmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        public class GitHubRelease
        {
            [JsonProperty("tag_name")]
            public string TagName { get; set; }

            [JsonProperty("assets")]
            public List<GitHubAsset> Assets { get; set; }
        }

        public class GitHubAsset
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("browser_download_url")]
            public string BrowserDownloadUrl { get; set; }
        }

        public class GiteeRelease
        {
            [JsonProperty("tag_name")]
            public string TagName { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("assets")]
            public List<GiteeAsset> Assets { get; set; }

            [JsonProperty("author")]
            public GiteeAuthor Author { get; set; }

            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }
        }

        public class GiteeAsset
        {
            [JsonProperty("browser_download_url")]
            public string DownloadUrl { get; set; }

            [JsonProperty("name")]
            public string FileName { get; set; }
        }

        public class GiteeAuthor
        {
            [JsonProperty("login")]
            public string Login { get; set; }

            [JsonProperty("avatar_url")]
            public string AvatarUrl { get; set; }
        }
    }
}
