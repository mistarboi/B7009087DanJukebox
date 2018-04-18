using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Allows writing and reading disk operations

namespace B7009087DanJukebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String track_dir = Directory.GetCurrentDirectory() + "\\Tracks\\"; //Locates Tracks folder, stores in variable
            String media_dir = Directory.GetCurrentDirectory() + "\\Media\\"; //Locates Media folder, stores in variable
            StreamReader media_content_read = File.OpenText(media_dir + "Media.txt"); //Reads content of Media.txt file previously located
            string GenreName = media_content_read.ReadLine();
            listBox_Genre_List.Items.Add(GenreName);
            string[] input = new string[3];
        }
    }
}
