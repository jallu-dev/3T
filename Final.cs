using System;
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
    public partial class Final : Form
    {
        Home home = null;
        public Final(string score, string highScore)
        {
            InitializeComponent();
            lblScore.Text = score;
            lblHighScore.Text = Convert.ToInt32(score) > Convert.ToInt32(lblHighScore.Text) ? score: highScore;

            WriteToFile("highscore.txt", lblHighScore.Text);
        }

        private void Final_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "resources/game-over.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
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

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if(home == null || home.IsDisposed)
            {
                home = new Home();
            }

            home.Show();
            this.Hide();
        }

        static void WriteToFile(string filePath, string valueToWrite)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the value to the file
                    writer.WriteLine(valueToWrite);
                }

                Console.WriteLine("Value written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
    }
}
