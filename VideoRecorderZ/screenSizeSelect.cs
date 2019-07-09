using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Linq;

namespace VideoRecorderZ
{
    public partial class screenSizeSelect : Form
        
    {

        public int checkMouse=0;
        public bool drawCheck=false;
        public int point11;
        public int point12;
        public int point21;
        public int point22;

        public screenSizeSelect()
        {
            InitializeComponent();
            this.Width = SystemInformation.VirtualScreen.Width;
            this.Height = SystemInformation.VirtualScreen.Height;

            
        }



        private void screenSizeSelect_MouseDown(object sender, MouseEventArgs e)
        {

            point11 = Cursor.Position.X;
            point12 = Cursor.Position.Y;
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.White);
            drawCheck = true;

        }

        private void screenSizeSelect_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawCheck == true)
            {
                point21 = Cursor.Position.X;
                point22 = Cursor.Position.Y;

                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                Pen gg = new Pen(myBrush);
                formGraphics.Clear(Color.White);
                formGraphics.DrawRectangle(gg, new Rectangle(point11, point12, point21 - point11, point22 - point12));
                
                myBrush.Dispose();
                formGraphics.Dispose();
            }
        }

        private void screenSizeSelect_MouseUp(object sender, MouseEventArgs e)
        {
            drawCheck = false;
            XDocument xdoc = new XDocument(new XElement("Settings"
                , new XElement("Points",
                    new XElement("Point", point11,
                        new XAttribute("Name", "p11")),

                    new XElement("Point", point12,
                        new XAttribute("Name", "p12")),

                    new XElement("Point", point21,
                        new XAttribute("Name", "p21")),

                    new XElement("Point", point22,
                        new XAttribute("Name", "p22"))

            )
                ));

            xdoc.Save("settings.xml");
            this.Close();
        }


    }
}
