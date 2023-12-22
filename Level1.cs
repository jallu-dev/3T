using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3T
{
    public partial class level1 : Form
    {
        level2 level2 = null;
        public level1()
        {
            InitializeComponent();
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

        private void target1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target1.Location.X + e.X - 10 / 2;
            int y = target1.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox( new Point(x, y));
            target1.Visible = false;
            if(!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target2.Location.X + e.X - 10 / 2;
            int y = target2.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target2.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target3_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target3.Location.X + e.X - 10 / 2;
            int y = target3.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target3.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target4_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target4.Location.X + e.X - 10 / 2;
            int y = target4.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target4.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void level1_MouseClick(object sender, MouseEventArgs e)
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
                level2 = new level2();
            }

            level2.Show();
            this.Hide();
        }
    }
}
