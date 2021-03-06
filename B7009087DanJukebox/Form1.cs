﻿using System;
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
            //Pseudo code ***
            //string[0] = new ListBox();
            //string[0].Items.Add("Introduction.wma");
            //repeat for each string-array instance and their respective files
        }

        private void hScrollBar_Genre_Scroll(object sender, ScrollEventArgs e)
        {
            // *** Pseudo Code ***
            // int representing position of hscrollbar (1 to 3)
            // click right arrow = ++, left arrow = --
            // int above paired with corresponding variable for listbox
            // ie: hscrollbar = 1, listbox displayed = 1
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Setup(); //Generates popup of Setup tab
            newForm.Show(); //Displays Setup
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new About(); //Generates popup of About tab
            newForm.Show(); // Displays About tab
        }

        private void listBox_Genre_List_DoubleClick(object sender, EventArgs e)
        {
            //Pseudo code ***
            //if track double clicked and not currently playing a song
            //listBox_Now_Playing.Items.Add("x.wma/.mp3") -> x being the chosen song
            //system.Media.SoundPlayer = new system.Media.SoundPlayer()
            //else listBox_Playlist.Items.Add("x.wma/.mp3")
            //
        }
    }
}
