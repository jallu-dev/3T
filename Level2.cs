
using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace _3T
{
    public partial class Level2 : Form
    {
        private int elapsedMinutes = 0; // Set the initial minutes
        private int elapsedSeconds = 30;  // Set the initial seconds
        private System.Timers.Timer timer;

        string highScore = null;

        Level3 level3 = null;
        Final final = null;
        public Level2(string curScore, string highScore)
        {
            InitializeComponent();
            lblMin.Text = elapsedMinutes.ToString("D2");
            lblSec.Text = elapsedSeconds.ToString("D2");
            // Set an interval of 1000 milliseconds (1 second)
            int interval = 1000;

            // Create a Timer with an Elapsed event handler
            timer = new System.Timers.Timer(interval);
            timer.Elapsed += TimerElapsed;
            timer.Start();

            lblScore.Text = curScore;
            this.highScore = highScore;

        }

        private PictureBox CreatePictureBox(Point location)
        {
            // Create a new PictureBox at the specified location
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.gunshothole2; // Set your image here
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Size = new Size(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = location;


            // Add the PictureBox to the form
            Controls.Add(pictureBox);
            pictureBox.BringToFront();

            return pictureBox; // Return the PictureBox for later reference
        }

        public void targetShot(PictureBox target, MouseEventArgs e)
        {
            lblScore.Text = (Convert.ToInt32(lblScore.Text) + 10).ToString("D4");
            int x = target.Location.X + e.X - 10 / 2;
            int y = target.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible && !target22.Visible)
            {
                lblMin.Visible = lblSec.Visible = lblColon.Visible = false;
                btnNextLevel.Visible = true;
                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            }
        }

        private void target1_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target1, e);
        }

        private void target2_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target2, e);
        }

        private void target3_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target3, e);

        }

        private void target4_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target4, e);

        }

        private void target5_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target5, e);

        }

        private void target6_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target6, e);

        }

        private void target7_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target7, e);


        }

        private void target8_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target8, e);

        }
        private void target9_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target9, e);

        }
        private void target10_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target10, e);

        }
        private void target11_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target11, e);

        }
        private void target13_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target13, e);

        }
        private void target14_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target14, e);

        }
        private void target15_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target15, e);


        }
        private void target16_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target16, e);

        }
        private void target17_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target17, e);

        }
        private void target18_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target18, e);

        }
        private void target19_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target19, e);

        }
        private void target20_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target20, e);

        }
        private void target21_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target21, e);

        }
        private void target22_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target22, e);

        }
        private void target12_MouseClick(object sender, MouseEventArgs e)
        {
            targetShot(target12, e);

        }

        private void btnNextLevel_MouseEnter(object sender, EventArgs e)
        {
            btnNextLevel.BackColor = Color.White;
            btnNextLevel.FlatAppearance.BorderSize = 0;
        }

        private void btnNextLevel_MouseLeave(object sender, EventArgs e)
        {
            btnNextLevel.BackColor = Color.Transparent;
            btnNextLevel.FlatAppearance.BorderSize = 1;

        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            if (level3 == null || level3.IsDisposed)
            {
                level3 = new Level3();
            }

            level3.Show();
            this.Hide();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Update elapsed time
            elapsedSeconds--;

            // Check if a minute has passed
            if (elapsedSeconds < 0)
            {
                elapsedMinutes--;
                elapsedSeconds = 59;
            }

            // Use Invoke to update UI controls from the UI thread
            Invoke(new Action(() =>
            {
                // Display the remaining time as a countdown
                lblMin.Text = elapsedMinutes.ToString("D2");
                lblSec.Text = elapsedSeconds.ToString("D2");

                // Check if the countdown has reached zero
                if (elapsedMinutes == 0 && elapsedSeconds == 0)
                {
                    // Stop the timer or take appropriate action when the countdown reaches zero
                    timer.Stop();
                    if (final == null || final.IsDisposed)
                    {
                        final = new Final(lblScore.Text, highScore);
                    }
                    this.Hide();
                    final.ShowDialog();

                }
            }));
        }

        // Dispose of the timer when the form is closed
        private void Level2_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void Level2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X - 10 / 2;
            int y = e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
        }

        
    }
}
