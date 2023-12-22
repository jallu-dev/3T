namespace _3T
{
    partial class level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level1));
            this.target1 = new System.Windows.Forms.PictureBox();
            this.target2 = new System.Windows.Forms.PictureBox();
            this.target4 = new System.Windows.Forms.PictureBox();
            this.target3 = new System.Windows.Forms.PictureBox();
            this.level = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.target1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target3)).BeginInit();
            this.SuspendLayout();
            // 
            // target1
            // 
            this.target1.BackColor = System.Drawing.Color.Red;
            this.target1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.target1.Location = new System.Drawing.Point(304, 154);
            this.target1.Name = "target1";
            this.target1.Size = new System.Drawing.Size(33, 29);
            this.target1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target1.TabIndex = 2;
            this.target1.TabStop = false;
            this.target1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.target1_MouseClick);
            // 
            // target2
            // 
            this.target2.BackColor = System.Drawing.Color.Red;
            this.target2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.target2.Location = new System.Drawing.Point(304, 399);
            this.target2.Name = "target2";
            this.target2.Size = new System.Drawing.Size(33, 29);
            this.target2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target2.TabIndex = 3;
            this.target2.TabStop = false;
            this.target2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.target2_MouseClick);
            // 
            // target4
            // 
            this.target4.BackColor = System.Drawing.Color.Red;
            this.target4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.target4.Location = new System.Drawing.Point(833, 399);
            this.target4.Name = "target4";
            this.target4.Size = new System.Drawing.Size(33, 29);
            this.target4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target4.TabIndex = 4;
            this.target4.TabStop = false;
            this.target4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.target4_MouseClick);
            // 
            // target3
            // 
            this.target3.BackColor = System.Drawing.Color.Red;
            this.target3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.target3.Location = new System.Drawing.Point(833, 154);
            this.target3.Name = "target3";
            this.target3.Size = new System.Drawing.Size(33, 29);
            this.target3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target3.TabIndex = 5;
            this.target3.TabStop = false;
            this.target3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.target3_MouseClick);
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(107, 601);
            this.level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(26, 33);
            this.level.TabIndex = 7;
            this.level.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "LEVEL";
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnNextLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLevel.Location = new System.Drawing.Point(995, 587);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(156, 47);
            this.btnNextLevel.TabIndex = 8;
            this.btnNextLevel.Text = "NEXT LEVEL";
            this.btnNextLevel.UseVisualStyleBackColor = false;
            this.btnNextLevel.Visible = false;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            this.btnNextLevel.MouseEnter += new System.EventHandler(this.btnNextLevel_MouseEnter);
            this.btnNextLevel.MouseLeave += new System.EventHandler(this.btnNextLevel_MouseLeave);
            // 
            // level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnNextLevel);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.target3);
            this.Controls.Add(this.target4);
            this.Controls.Add(this.target2);
            this.Controls.Add(this.target1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Level 1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.level1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.target1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox target1;
        private System.Windows.Forms.PictureBox target2;
        private System.Windows.Forms.PictureBox target4;
        private System.Windows.Forms.PictureBox target3;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextLevel;
    }
}