﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3T
{
    public partial class Home : Form
    {
        string highscore = null;
        public Home()
        {
            InitializeComponent();
            lblHighscore.Text = Convert.ToInt32(ReadFromFile()).ToString("D4") ;
        }

        Level1 level1 = null;
        Level2 level2 = null;

        private void Home_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "resources/intro2.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.setMode("loop",true);
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;


        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Check if the new state is "wmppsPaused" (paused)
            if (e.newState == 3) // 3 corresponds to wmppsPaused
            {
                // Resume playback immediately (preventing pause)
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = this.ClientSize;
           

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.close();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (level1 == null || level1.IsDisposed)
            {
                level1 = new Level1(lblHighscore.Text);
            }

            level1.Show();
            this.Hide();
        }


        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            
            btnPlay.Size = new Size(220, 110);
            btnPlay.Location = new Point(btnPlay.Location.X-10, btnPlay.Location.Y - 5);
            btnPlay.BackColor = Color.Red; 
            btnPlay.ForeColor = Color.Black;
            
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            
            btnPlay.Size = new Size(200, 100);
            btnPlay.Location = new Point(btnPlay.Location.X + 10, btnPlay.Location.Y + 5);
            btnPlay.BackColor = Color.Black;
            btnPlay.ForeColor = Color.Red;
            
        }

        static string ReadFromFile()
        {
            string retrievedValue = "";

            try
            {
                using (StreamReader reader = new StreamReader("highscore.txt"))
                {
                    retrievedValue = reader.ReadLine();
                }

                Console.WriteLine("Value read from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading from file: " + ex.Message);
            }

            return retrievedValue;
        }
    }
}
