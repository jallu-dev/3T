using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace _3T
{
    public partial class Level1 : Form
    {
        private int elapsedMinutes = 0; // Set the initial minutes
        private int elapsedSeconds = 10;  // Set the initial seconds
        private System.Timers.Timer timer;

        string highScore = null;

        Level2 level2 = null;
        Final final = null;
        public Level1(string highScore)
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

            this.highScore = highScore;
        }

        private PictureBox CreatePictureBox(Point location)
        {
            // Create a new PictureBox at the specified location
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.gunshothole2; // Set your image here
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Size = new Size(10,10);
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
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible)
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
            targetShot(target1,e);
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

        private void Level1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X - 10 / 2;
            int y = e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
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
            if(level2 == null || level2.IsDisposed)
            {
                level2 = new Level2(lblScore.Text, highScore);
            }

            level2.Show();
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
                    if(final == null || final.IsDisposed)
                    {
                        final = new Final(lblScore.Text, highScore);
                    }
                    this.Hide();
                    final.ShowDialog();

                }
            }));
        }

        // Dispose of the timer when the form is closed
        private void Level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }

    }
}
