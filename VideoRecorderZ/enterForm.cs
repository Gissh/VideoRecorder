using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.Drawing.Text;

namespace VideoRecorderZ
{
    public partial class enterForm : Form
    {



        public enterForm()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Roboto-Regular.ttf");
            this.Font= new Font(pfc.Families[0], 8, FontStyle.Regular);


            InitializeComponent();

            Dictionary<string, string> users=new Dictionary<string, string>();

            WebClient web = new WebClient();
            String json = Encoding.UTF8.GetString(web.DownloadData("http://videorecorder.ru/api/app/getUsers.php"));

            List <Dictionary<string, string>> FIO = JsonConvert.DeserializeObject<List<Dictionary<string,string>>>(json);
            
            foreach(Dictionary<string,string> j in FIO)
            {
                string Iid ="0";
                string Ifio="0";
                foreach (KeyValuePair<string, string> item in j)
                {
                    if (item.Key == "id")
                    {
                        Iid = item.Value;
                    }
                    else
                    {
                        Ifio = item.Value;
                    }

                }
                users.Add(Iid, Ifio);

            }

            prepodOrStudBox.DataSource= new BindingSource(users, null);
            prepodOrStudBox.DisplayMember = "Value";
            prepodOrStudBox.ValueMember = "Key";


        }

        private void enterBtn_Click(object sender, EventArgs e)
        {

            WebClient web = new WebClient();
            String json = Encoding.UTF8.GetString(web.DownloadData("http://videorecorder.ru/api/app/login.php?id="+ ((KeyValuePair<string, string>)prepodOrStudBox.SelectedItem).Key+ "&password="+PasswordBox.Text));

            
            if (json == "0")
            {
                MessageBox.Show("Вы ввели не верный пароль!");
            }
            else
            {
                VideoRecorderZ.Properties.Settings.Default.userId= ((KeyValuePair<string, string>)prepodOrStudBox.SelectedItem).Key;
                VideoRecorderZ.Properties.Settings.Default.userHash = json;
                VideoRecorderZ.Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
