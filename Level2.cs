using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3T
{
    public partial class Level2 : Form
    {
        Level3 level3 = null;
        public Level2()
        {
            InitializeComponent();
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

        

        private void level2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X - 10 / 2;
            int y = e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
        }

        private void target1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target1.Location.X + e.X - 10 / 2;
            int y = target1.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target1.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
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
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
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
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
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
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }


        private void target5_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target5.Location.X + e.X - 10 / 2;
            int y = target5.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target5.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target6_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target6.Location.X + e.X - 10 / 2;
            int y = target6.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target6.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target7_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target7.Location.X + e.X - 10 / 2;
            int y = target7.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target7.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target8_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target8.Location.X + e.X - 10 / 2;
            int y = target8.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target8.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target9_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target9.Location.X + e.X - 10 / 2;
            int y = target9.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target9.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target10_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target10.Location.X + e.X - 10 / 2;
            int y = target10.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target10.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target11_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target11.Location.X + e.X - 10 / 2;
            int y = target11.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target11.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target12_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target12.Location.X + e.X - 10 / 2;
            int y = target12.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target12.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target13_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target13.Location.X + e.X - 10 / 2;
            int y = target13.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target13.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target14_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target14.Location.X + e.X - 10 / 2;
            int y = target14.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target14.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target15_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target15.Location.X + e.X - 10 / 2;
            int y = target15.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target15.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target16_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target16.Location.X + e.X - 10 / 2;
            int y = target16.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target16.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target17_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target17.Location.X + e.X - 10 / 2;
            int y = target17.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target17.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target18_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target18.Location.X + e.X - 10 / 2;
            int y = target18.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target18.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target19_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target19.Location.X + e.X - 10 / 2;
            int y = target19.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target19.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target20_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target20.Location.X + e.X - 10 / 2;
            int y = target20.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target20.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target21_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target21.Location.X + e.X - 10 / 2;
            int y = target21.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target21.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
        }

        private void target22_MouseClick(object sender, MouseEventArgs e)
        {
            int x = target22.Location.X + e.X - 10 / 2;
            int y = target22.Location.Y + e.Y - 10 / 2;

            // Create a new PictureBox at the clicked location
            PictureBox newPictureBox = CreatePictureBox(new Point(x, y));
            target22.Visible = false;
            if (!target1.Visible && !target2.Visible && !target3.Visible && !target4.Visible && !target5.Visible && !target6.Visible && !target7.Visible && !target8.Visible && !target9.Visible && !target10.Visible && !target11.Visible && !target12.Visible && !target13.Visible && !target14.Visible && !target15.Visible && !target16.Visible && !target17.Visible && !target18.Visible && !target19.Visible && !target20.Visible && !target21.Visible)
            {
                btnNextLevel.Visible = true;
            }
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
    }
}
