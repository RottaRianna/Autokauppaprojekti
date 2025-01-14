namespace Autokauppa
{
    partial class Form6
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
            labelDecription = new Label();
            ESC = new Button();
            NextButton = new Button();
            BackButton = new Button();
            pictureBox1 = new PictureBox();
            Welcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelDecription
            // 
            labelDecription.BackColor = Color.Black;
            labelDecription.FlatStyle = FlatStyle.Flat;
            labelDecription.Font = new Font("Segoe UI", 15F);
            labelDecription.ForeColor = SystemColors.ButtonHighlight;
            labelDecription.Location = new Point(484, 507);
            labelDecription.MinimumSize = new Size(120, 10);
            labelDecription.Name = "labelDecription";
            labelDecription.Size = new Size(829, 121);
            labelDecription.TabIndex = 15;
            labelDecription.Text = "label1";
            labelDecription.TextAlign = ContentAlignment.MiddleCenter;
            labelDecription.Visible = false;
            labelDecription.Click += labelDecription_Click_1;
            labelDecription.MouseEnter += labelDecription_MouseEnter;
            labelDecription.MouseLeave += labelDecription_MouseLeave;
            // 
            // ESC
            // 
            ESC.Font = new Font("Segoe UI", 15F);
            ESC.Location = new Point(157, 45);
            ESC.Name = "ESC";
            ESC.Size = new Size(180, 56);
            ESC.TabIndex = 14;
            ESC.Text = "Takaisin";
            ESC.UseVisualStyleBackColor = true;
            ESC.Click += ESC_Click_1;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Transparent;
            NextButton.Font = new Font("Segoe UI", 20F);
            NextButton.Location = new Point(1319, 362);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(41, 69);
            NextButton.TabIndex = 13;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click_1;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.Location = new Point(437, 362);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(41, 69);
            BackButton.TabIndex = 12;
            BackButton.Text = "<";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Näyttökuva_2025_01_07_141711;
            pictureBox1.Location = new Point(484, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(829, 455);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter_1;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave_1;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.DodgerBlue;
            Welcome.BorderStyle = BorderStyle.Fixed3D;
            Welcome.Font = new Font("Segoe UI", 20F);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(484, 45);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(829, 56);
            Welcome.TabIndex = 10;
            Welcome.Text = "Tässä voit selailla kuvia uusista auto malleista!";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 673);
            Controls.Add(labelDecription);
            Controls.Add(ESC);
            Controls.Add(NextButton);
            Controls.Add(BackButton);
            Controls.Add(pictureBox1);
            Controls.Add(Welcome);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDecription;
        private Button ESC;
        private Button NextButton;
        private Button BackButton;
        private PictureBox pictureBox1;
        private Label Welcome;
    }
}