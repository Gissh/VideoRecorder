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
using System.Xml.Linq;
using System.Net;
using System.Collections.Specialized;
using System.Diagnostics;

namespace VideoRecorderZ
{
    public partial class VideoManager : Form
    {
        public VideoManager()
        {
            InitializeComponent();
            if (!File.Exists("videosList.xml"))
            {
                XDocument xdoc = new XDocument();
                XElement videos = new XElement("videos");

                xdoc.Add(videos);

                xdoc.Save("videosList.xml");
            }
            else
            {
                XDocument xdoc = XDocument.Load("videosList.xml");

                foreach(XElement video in xdoc.Element("videos").Elements("video"))
                {
                    dataGridView1.Rows.Add(video.Element("name").Value,video.Element("directory").Value, video.Element("status").Value);
                }

                
            }


        }



        public void loadSelectedVideo(string VideoName,string SaveFolder)
        {
            if (File.Exists(SaveFolder + @"\" + VideoName))
            {

                UploadVideo sendVideo = new UploadVideo();
                sendVideo.videoName = VideoName;
                sendVideo.videoPath = SaveFolder;
                sendVideo.progressBar = progressBar1;
                sendVideo.loadButton = loadBtn;
                sendVideo.videoLoad();

            }
            else
            {
                MessageBox.Show("Файл не найден! "+ SaveFolder + @"\" + VideoName);
            }
        }

        void WebClientUploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        void WebClientUploadCompleted(object sender, UploadFileCompletedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "completeSound.wav";
            player.Play();
        }

        private void folderOpenBtn_Click(object sender, EventArgs e)
        {
            
            if(File.Exists(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString() + @"\" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
            {
                Process.Start(new ProcessStartInfo("explorer.exe", " /select, " + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString() + @"\" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadSelectedVideo(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VideoManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loadBtn.Enabled==false)
            {
                e.Cancel = true;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("videosList.xml");

            foreach (XElement video in xdoc.Element("videos").Elements("video"))
            {
                if(video.Element("name").Value == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() && video.Element("directory").Value == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString())
                {
                    video.Remove();
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Index);
                }
            }
            xdoc.Save("videosList.xml");
        }
    }
}
