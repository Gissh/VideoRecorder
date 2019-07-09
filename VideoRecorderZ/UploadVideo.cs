using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using VkNet;
using System.Threading;

namespace VideoRecorderZ
{
    class UploadVideo
    {
        public string videoName;
        public string videoPath;
        public ProgressBar progressBar;
        public Button loadButton;

        private string videoOwner;
        private string videoId;
        private string videoHash;

        public void videoLoad()
        {
            Run();
        }


        private async Task Run()
        {
            loadButton.Enabled = false;

            string loginvk = "Write This Your Login";
            string passvk = "Write This Your Pass";
            var api = new VkApi();
           

            api.Authorize(new VkNet.Model.ApiAuthParams
            {
                ApplicationId = 1234567, //write this your vk application id
                Login = loginvk,
                Password = passvk,
                Settings = VkNet.Enums.Filters.Settings.Video
            });

            var vres = api.Video.Save(new VkNet.Model.RequestParams.VideoSaveParams
            {
                Name = videoName

            });
            
            videoId= vres.Id.ToString();

            videoOwner = vres.OwnerId.ToString();

            
            
            string sendurl = vres.UploadUrl.ToString();

            WebClient web = new WebClient();
            Uri uri = new Uri(sendurl);

            web.UploadFileCompleted += new UploadFileCompletedEventHandler(UploadFileCallback);
            web.UploadProgressChanged += new UploadProgressChangedEventHandler(WebClientUploadProgressChanged);
            web.UploadFileAsync(uri, videoPath+@"\"+videoName);

        }


        private async void UploadFileCallback(Object sender, UploadFileCompletedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "completeSound.wav";
            player.Play();


            WebClient we = new WebClient();
            string ss = we.DownloadString("https://vk.com/video" +   videoOwner + "_" + videoId);

            while(ss.IndexOf("<meta property=\"og:video\" content=\"") == -1)
            {
                ss = we.DownloadString("https://vk.com/video" + videoOwner + "_" + videoId);
                Thread.Sleep(10000);
            }
            
            string hash = ss.Substring(ss.IndexOf("<meta property=\"og:video\" content=\""), 150);

            string[] findHash;
            findHash = hash.Split(new char[] { '"' });
            videoHash = findHash[3];
            videoHash = videoHash.Replace("&", "%26");
            videoHash = videoHash.Replace("?", "%3F");
            videoHash = videoHash.Replace(";", "%3B");
            videoHash = videoHash.Replace("https:", "");
            we.DownloadString("http://videorecorder.ru/api/app/videoSend.php?id=" + VideoRecorderZ.Properties.Settings.Default.userId + "&name=" + videoName + "&link=" + videoHash);
            loadButton.Enabled = true;

        }


        void WebClientUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}
