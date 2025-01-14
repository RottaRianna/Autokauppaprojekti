namespace Autokauppa
{
    partial class Form4
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
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            BackButton = new Button();
            NextButton = new Button();
            ESC = new Button();
            labelDecription = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.DodgerBlue;
            Welcome.BorderStyle = BorderStyle.Fixed3D;
            Welcome.Font = new Font("Segoe UI", 20F);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(339, 40);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(829, 56);
            Welcome.TabIndex = 4;
            Welcome.Text = "Tässä voit selailla kuvia uusista auto malleista!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Näyttökuva_2025_01_07_141711;
            pictureBox1.Location = new Point(339, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 455);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.Location = new Point(292, 357);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(41, 69);
            BackButton.TabIndex = 6;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Transparent;
            NextButton.Font = new Font("Segoe UI", 20F);
            NextButton.Location = new Point(1174, 357);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(41, 69);
            NextButton.TabIndex = 7;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // ESC
            // 
            ESC.Font = new Font("Segoe UI", 15F);
            ESC.Location = new Point(12, 40);
            ESC.Name = "ESC";
            ESC.Size = new Size(180, 56);
            ESC.TabIndex = 8;
            ESC.Text = "Takaisin";
            ESC.UseVisualStyleBackColor = true;
            ESC.Click += ESC_Click;
            // 
            // labelDecription
            // 
            labelDecription.BackColor = Color.Black;
            labelDecription.FlatStyle = FlatStyle.Flat;
            labelDecription.Font = new Font("Segoe UI", 20F);
            labelDecription.ForeColor = SystemColors.ButtonHighlight;
            labelDecription.Location = new Point(339, 502);
            labelDecription.MinimumSize = new Size(120, 10);
            labelDecription.Name = "labelDecription";
            labelDecription.Size = new Size(829, 121);
            labelDecription.TabIndex = 9;
            labelDecription.Text = "label1";
            labelDecription.TextAlign = ContentAlignment.MiddleCenter;
            labelDecription.Visible = false;
            labelDecription.Click += labelDecription_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 673);
            Controls.Add(labelDecription);
            Controls.Add(ESC);
            Controls.Add(NextButton);
            Controls.Add(BackButton);
            Controls.Add(pictureBox1);
            Controls.Add(Welcome);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private PictureBox pictureBox1;
        private Button BackButton;
        private Button NextButton;
        private Button ESC;
        private Label labelDecription;
    }
}