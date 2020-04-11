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
using System.Runtime.InteropServices;

namespace Ven3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\Ori\\Pictures\\background");
            FileInfo[] fileInfo = dir.GetFiles();
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            double miles = ts.TotalMilliseconds;
            Console.WriteLine("TimeStamp : " + Convert.ToInt64(miles));

            foreach (FileInfo file in fileInfo)
            {
                //Console.WriteLine("File Path: " + file.FullName);
                PictureBox newPic= new PictureBox();
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.LoadAsync(file.FullName);
                newPic.Size = new System.Drawing.Size(247, 166);
                newPic.Click += new System.EventHandler(imgClick);
                this.imgpannel.Controls.Add(newPic);
            }


        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        private void imgClick(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        private void mainPageResize(object sender, EventArgs e)
        {

            Console.WriteLine("width : " + this.Width + ", height : " + this.Height );
            this.imgpannel.Size = new System.Drawing.Size(this.Width - 40, this.Height - 40);
        }
    }
}
