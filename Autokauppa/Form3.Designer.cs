namespace Autokauppa
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Welcome = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.toyotakuva;
            pictureBox1.Location = new Point(352, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lexusKuva;
            pictureBox2.Location = new Point(841, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(344, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.DodgerBlue;
            Welcome.BorderStyle = BorderStyle.Fixed3D;
            Welcome.Font = new Font("Segoe UI", 30F);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(352, 23);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(833, 83);
            Welcome.TabIndex = 3;
            Welcome.Text = "Tervettuloa katsomaan autoja!";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(300, 128);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(970, 333);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(466, 413);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 5;
            label1.Text = "Uudet autot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(979, 413);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 6;
            label2.Text = "Vanhat autot";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 594);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Welcome);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Welcome;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}