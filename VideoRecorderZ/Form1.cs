using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Collections;
using System.Collections.Specialized;

using System.Xml.Linq;
using System.Drawing.Text;
using AForge.Video.FFMPEG;
using AForge.Video;





namespace VideoRecorderZ
{
    public partial class Form1 : Form
    {
        //обработчик записи видео
        VideoFileWriter writer = new VideoFileWriter();
        ScreenCaptureStream stream;
        Captura.Recorder capture;

        //идет ли запись видео
        public bool RecordOn=false;

        //настройки видео
        int videoPoint11;
        int videoPoint12;
        int videoPoint21;
        int videoPoint22;

        public int timerCoint=0;

        

        public delegate void frameSetText();
        public frameSetText delegateFrame;

        public Form1()
        {
            InitializeComponent();

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Roboto-Regular.ttf");
            this.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);

            delegateFrame = new frameSetText(addFrameCount);
            SaveFolder.Text = Directory.GetCurrentDirectory();

            if (VideoRecorderZ.Properties.Settings.Default.saveDirectory != "")
            {
                if (Directory.Exists(VideoRecorderZ.Properties.Settings.Default.saveDirectory))
                {
                    SaveFolder.Text = VideoRecorderZ.Properties.Settings.Default.saveDirectory;
                }
                else
                {
                    VideoRecorderZ.Properties.Settings.Default.saveDirectory = "";
                    VideoRecorderZ.Properties.Settings.Default.Save();
                }
            }
        }

        public void getVideoPoints()
        {
            XDocument xdoc = XDocument.Load("settings.xml");
            foreach (XElement point in xdoc.Element("Settings").Element("Points").Elements("Point"))
            {
                if (point.Attribute("Name").Value.ToString() == "p11")
                {
                    videoPoint11 = int.Parse(point.Value);
                }
                else if (point.Attribute("Name").Value.ToString() == "p12")
                {
                    videoPoint12 = int.Parse(point.Value);
                }
                else if (point.Attribute("Name").Value.ToString() == "p21")
                {
                    videoPoint21 = int.Parse(point.Value);
                }
                else if (point.Attribute("Name").Value.ToString() == "p22")
                {
                    videoPoint22 = int.Parse(point.Value);
                }
                Console.WriteLine(point.Name);
            }
            if ((videoPoint21 - videoPoint11) % 2 != 0)
            {
                videoPoint11++;
            }
            if ((videoPoint22 - videoPoint12) % 2 != 0)
            {
                videoPoint22++;
            }
        }


        public void loadVideoSite()
        {


            try
            {
                if (File.Exists(SaveFolder.Text + @"\" + VideoName.Text+".avi"))
                {
                    WebClient client = new WebClient();
                    NameValueCollection parameters = new NameValueCollection();
                    parameters.Add("idI", VideoRecorderZ.Properties.Settings.Default.userId);
                    client.QueryString = parameters;
                    

                    string myFile = SaveFolder.Text + @"\" + VideoName.Text + ".avi";
                    client.Credentials = CredentialCache.DefaultCredentials;
                    client.Headers.Add("Content-Type", "binary/octet-stream");

                    client.UploadFileAsync(new Uri(@"http://videorecorder.ru/api/app/videoSend.php"), "POST", myFile);


                    client.Dispose();
                }
                else
                {
                    MessageBox.Show("Файл не найден!");
                }

                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void addFrameCount()
        {
            FrameRateDisplay.Text = (int.Parse(FrameRateDisplay.Text) + 1).ToString();
        }

        private async void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
                    FrameRateDisplay.Invoke(new Action(() => {
                        FrameRateDisplay.Text = (int.Parse(FrameRateDisplay.Text) + 1).ToString();
                    }));
        }


        public void addVideoInfoXml()
        {
            if (!File.Exists("videosList.xml"))
            {
                XDocument xdoc = new XDocument();
                XElement videos = new XElement("videos");

                XElement video = new XElement("video");
                XElement directoryVideo = new XElement("directory", SaveFolder.Text);
                XElement videoName = new XElement("name", VideoName.Text+".avi");
                XElement videoStatus = new XElement("status", "Не загружено");

                video.Add(directoryVideo);
                video.Add(videoName);
                video.Add(videoStatus);

                videos.Add(video);

                xdoc.Save("videosList.xml");
            }
            else
            {
                XDocument xdoc = XDocument.Load("videosList.xml");
                XElement videos = xdoc.Element("videos");

                XElement video = new XElement("video");
                XElement directoryVideo = new XElement("directory", SaveFolder.Text);
                XElement videoName = new XElement("name", VideoName.Text+".avi");
                XElement videoStatus = new XElement("status", "Не загружено");

                video.Add(directoryVideo);
                video.Add(videoName);
                video.Add(videoStatus);

                videos.Add(video);

                xdoc.Save("videosList.xml");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screenSizeSelect s = new screenSizeSelect();
            s.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (RecordOn)
            {
                button3.Text = "Start";
                RecordOn = false;
                
            }
            else
            {
                button3.Text = "Stop";
                RecordOn = true;
                addVideoInfoXml();
            }
            getVideoPoints();
            StartOrStopVideo();

            
        }

        public async void StartOrStopVideo()
        {
            if (RecordOn)
            {
                if (VideoName.Text != ""&&SaveFolder.Text!="")
                {
                    capture = new Captura.Recorder(new Captura.RecorderParams(SaveFolder.Text+"/"+VideoName.Text+".avi",trackBar1.Value , SharpAvi.KnownFourCCs.Codecs.MotionJpeg, trackBar2.Value, videoPoint11, videoPoint12, videoPoint21, videoPoint22));
                    capture.StartVideoRecord();
                }

                
            }
            else
            {
               
                capture.Dispose();
                MessageBox.Show("stop record");

                VideoRecorderZ.Properties.Settings.Default.fileTurn = SaveFolder.Text + "/" + VideoName.Text + ".avi";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RecordOn)
            {

            }
        }

        private void openFolderDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                VideoRecorderZ.Properties.Settings.Default.saveDirectory = dialog.SelectedPath;
                VideoRecorderZ.Properties.Settings.Default.Save();
                SaveFolder.Text= dialog.SelectedPath;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            frameCountUI.Value = trackBar1.Value;
        }

        private void frameCountUI_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value =Decimal.ToInt32(frameCountUI.Value);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            qualityVideoNum.Value = trackBar2.Value;
        }

        private void qualityVideoNum_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Decimal.ToInt32(qualityVideoNum.Value);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            enterForm ef = new enterForm();
            ef.Show();
        }

        private void videoManagerBtn_Click(object sender, EventArgs e)
        {
            VideoManager vm = new VideoManager();
            vm.Show();
        }
    }
}
