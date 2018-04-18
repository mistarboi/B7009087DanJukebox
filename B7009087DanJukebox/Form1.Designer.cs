namespace B7009087DanJukebox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Copyright = new System.Windows.Forms.TextBox();
            this.listBox_Genre_Title = new System.Windows.Forms.ListBox();
            this.hScrollBar_Genre = new System.Windows.Forms.HScrollBar();
            this.listBox_Playlist = new System.Windows.Forms.ListBox();
            this.textBox_Now_Playing = new System.Windows.Forms.TextBox();
            this.listBox_Genre_List = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Copyright
            // 
            this.textBox_Copyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Copyright.Location = new System.Drawing.Point(265, 3);
            this.textBox_Copyright.Name = "textBox_Copyright";
            this.textBox_Copyright.Size = new System.Drawing.Size(163, 13);
            this.textBox_Copyright.TabIndex = 1;
            this.textBox_Copyright.Text = "Copyright (C) 2018 Daniel Bowns";
            // 
            // listBox_Genre_Title
            // 
            this.listBox_Genre_Title.Location = new System.Drawing.Point(131, 72);
            this.listBox_Genre_Title.Name = "listBox_Genre_Title";
            this.listBox_Genre_Title.Size = new System.Drawing.Size(159, 17);
            this.listBox_Genre_Title.TabIndex = 4;
            // 
            // hScrollBar_Genre
            // 
            this.hScrollBar_Genre.LargeChange = 4;
            this.hScrollBar_Genre.Location = new System.Drawing.Point(131, 163);
            this.hScrollBar_Genre.Maximum = 3;
            this.hScrollBar_Genre.Name = "hScrollBar_Genre";
            this.hScrollBar_Genre.Size = new System.Drawing.Size(159, 17);
            this.hScrollBar_Genre.TabIndex = 9;
            this.hScrollBar_Genre.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Genre_Scroll);
            // 
            // listBox_Playlist
            // 
            this.listBox_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBox_Playlist.Location = new System.Drawing.Point(159, 209);
            this.listBox_Playlist.Name = "listBox_Playlist";
            this.listBox_Playlist.Size = new System.Drawing.Size(106, 95);
            this.listBox_Playlist.TabIndex = 8;
            // 
            // textBox_Now_Playing
            // 
            this.textBox_Now_Playing.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox_Now_Playing.Location = new System.Drawing.Point(131, 183);
            this.textBox_Now_Playing.Name = "textBox_Now_Playing";
            this.textBox_Now_Playing.ReadOnly = true;
            this.textBox_Now_Playing.Size = new System.Drawing.Size(159, 20);
            this.textBox_Now_Playing.TabIndex = 7;
            // 
            // listBox_Genre_List
            // 
            this.listBox_Genre_List.Location = new System.Drawing.Point(131, 95);
            this.listBox_Genre_List.Name = "listBox_Genre_List";
            this.listBox_Genre_List.Size = new System.Drawing.Size(159, 69);
            this.listBox_Genre_List.TabIndex = 6;
            this.listBox_Genre_List.DoubleClick += new System.EventHandler(this.listBox_Genre_List_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 366);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(430, 390);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.hScrollBar_Genre);
            this.Controls.Add(this.listBox_Playlist);
            this.Controls.Add(this.textBox_Now_Playing);
            this.Controls.Add(this.listBox_Genre_List);
            this.Controls.Add(this.listBox_Genre_Title);
            this.Controls.Add(this.textBox_Copyright);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jukebox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Copyright;
        private System.Windows.Forms.ListBox listBox_Genre_Title;
        private System.Windows.Forms.HScrollBar hScrollBar_Genre;
        private System.Windows.Forms.ListBox listBox_Playlist;
        private System.Windows.Forms.TextBox textBox_Now_Playing;
        private System.Windows.Forms.ListBox listBox_Genre_List;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

