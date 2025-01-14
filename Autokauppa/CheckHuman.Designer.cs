namespace Autokauppa
{
    partial class CheckHuman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckHuman));
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            checkHumanText = new Label();
            LaskuBox = new TextBox();
            Image1 = new PictureBox();
            Image2 = new PictureBox();
            Image3 = new PictureBox();
            Image4 = new PictureBox();
            KuvatText = new Label();
            label1 = new Label();
            Photo1CheckBox = new CheckBox();
            Photo2CheckBox = new CheckBox();
            Photo3CheckBox = new CheckBox();
            Photo4CheckBox = new CheckBox();
            ContinueButton2 = new Button();
            CheckButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(553, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkHumanText
            // 
            checkHumanText.AutoSize = true;
            checkHumanText.BackColor = Color.DodgerBlue;
            checkHumanText.Font = new Font("Segoe UI", 20F);
            checkHumanText.ForeColor = SystemColors.ControlLightLight;
            checkHumanText.Location = new Point(206, 9);
            checkHumanText.Name = "checkHumanText";
            checkHumanText.Size = new Size(967, 54);
            checkHumanText.TabIndex = 1;
            checkHumanText.Text = "Olethan ihminen? Laske tulos ja valitse oikein kuvista.";
            // 
            // LaskuBox
            // 
            LaskuBox.BackColor = Color.Gainsboro;
            LaskuBox.Font = new Font("Segoe UI", 15F);
            LaskuBox.Location = new Point(468, 206);
            LaskuBox.Name = "LaskuBox";
            LaskuBox.Size = new Size(411, 47);
            LaskuBox.TabIndex = 2;
            LaskuBox.TextChanged += LaskuBox_TextChanged;
            // 
            // Image1
            // 
            Image1.Image = (Image)resources.GetObject("Image1.Image");
            Image1.Location = new Point(135, 346);
            Image1.Name = "Image1";
            Image1.Size = new Size(263, 198);
            Image1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image1.TabIndex = 3;
            Image1.TabStop = false;
            // 
            // Image2
            // 
            Image2.Image = (Image)resources.GetObject("Image2.Image");
            Image2.Location = new Point(404, 346);
            Image2.Name = "Image2";
            Image2.Size = new Size(263, 198);
            Image2.SizeMode = PictureBoxSizeMode.StretchImage;
            Image2.TabIndex = 4;
            Image2.TabStop = false;
            // 
            // Image3
            // 
            Image3.Image = (Image)resources.GetObject("Image3.Image");
            Image3.Location = new Point(673, 346);
            Image3.Name = "Image3";
            Image3.Size = new Size(263, 198);
            Image3.SizeMode = PictureBoxSizeMode.StretchImage;
            Image3.TabIndex = 5;
            Image3.TabStop = false;
            // 
            // Image4
            // 
            Image4.Image = (Image)resources.GetObject("Image4.Image");
            Image4.Location = new Point(942, 346);
            Image4.Name = "Image4";
            Image4.Size = new Size(263, 198);
            Image4.SizeMode = PictureBoxSizeMode.StretchImage;
            Image4.TabIndex = 6;
            Image4.TabStop = false;
            // 
            // KuvatText
            // 
            KuvatText.AutoSize = true;
            KuvatText.BackColor = Color.Gainsboro;
            KuvatText.Font = new Font("Segoe UI", 15F);
            KuvatText.ForeColor = Color.Black;
            KuvatText.Location = new Point(468, 302);
            KuvatText.Name = "KuvatText";
            KuvatText.Size = new Size(411, 41);
            KuvatText.TabIndex = 7;
            KuvatText.Text = "Valitse kuvat joissa tie kaartuu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(491, 167);
            label1.Name = "label1";
            label1.Size = new Size(352, 36);
            label1.TabIndex = 8;
            label1.Text = "Kirjoita vain numero kenttään";
            label1.Click += label1_Click;
            // 
            // Photo1CheckBox
            // 
            Photo1CheckBox.AutoSize = true;
            Photo1CheckBox.Location = new Point(206, 547);
            Photo1CheckBox.Name = "Photo1CheckBox";
            Photo1CheckBox.Size = new Size(91, 29);
            Photo1CheckBox.TabIndex = 9;
            Photo1CheckBox.Text = "Kuva 1";
            Photo1CheckBox.UseVisualStyleBackColor = true;
            Photo1CheckBox.CheckedChanged += Photo1CheckBox_CheckedChanged;
            // 
            // Photo2CheckBox
            // 
            Photo2CheckBox.AutoSize = true;
            Photo2CheckBox.Location = new Point(468, 547);
            Photo2CheckBox.Name = "Photo2CheckBox";
            Photo2CheckBox.Size = new Size(91, 29);
            Photo2CheckBox.TabIndex = 10;
            Photo2CheckBox.Text = "Kuva 2";
            Photo2CheckBox.UseVisualStyleBackColor = true;
            Photo2CheckBox.CheckedChanged += Photo2CheckBox_CheckedChanged;
            // 
            // Photo3CheckBox
            // 
            Photo3CheckBox.AutoSize = true;
            Photo3CheckBox.Location = new Point(788, 547);
            Photo3CheckBox.Name = "Photo3CheckBox";
            Photo3CheckBox.Size = new Size(91, 29);
            Photo3CheckBox.TabIndex = 11;
            Photo3CheckBox.Text = "Kuva 3";
            Photo3CheckBox.UseVisualStyleBackColor = true;
            Photo3CheckBox.CheckedChanged += Photo3CheckBox_CheckedChanged;
            // 
            // Photo4CheckBox
            // 
            Photo4CheckBox.AutoSize = true;
            Photo4CheckBox.Location = new Point(1037, 547);
            Photo4CheckBox.Name = "Photo4CheckBox";
            Photo4CheckBox.Size = new Size(91, 29);
            Photo4CheckBox.TabIndex = 12;
            Photo4CheckBox.Text = "Kuva 4";
            Photo4CheckBox.UseVisualStyleBackColor = true;
            Photo4CheckBox.CheckedChanged += Photo4CheckBox_CheckedChanged;
            // 
            // ContinueButton2
            // 
            ContinueButton2.Location = new Point(616, 577);
            ContinueButton2.Name = "ContinueButton2";
            ContinueButton2.Size = new Size(112, 34);
            ContinueButton2.TabIndex = 13;
            ContinueButton2.Text = "Jatka";
            ContinueButton2.UseVisualStyleBackColor = true;
            ContinueButton2.Click += ContinueButton2_Click_1;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(616, 259);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(112, 34);
            CheckButton.TabIndex = 14;
            CheckButton.Text = "Tarkista";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // CheckHuman
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1273, 634);
            Controls.Add(CheckButton);
            Controls.Add(ContinueButton2);
            Controls.Add(Photo4CheckBox);
            Controls.Add(Photo3CheckBox);
            Controls.Add(Photo2CheckBox);
            Controls.Add(Photo1CheckBox);
            Controls.Add(label1);
            Controls.Add(KuvatText);
            Controls.Add(Image4);
            Controls.Add(Image3);
            Controls.Add(Image2);
            Controls.Add(Image1);
            Controls.Add(LaskuBox);
            Controls.Add(checkHumanText);
            Controls.Add(pictureBox1);
            Name = "CheckHuman";
            Text = "CheckHuman";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Label checkHumanText;
        private TextBox LaskuBox;
        private PictureBox Image1;
        private PictureBox Image2;
        private PictureBox Image3;
        private PictureBox Image4;
        private Label KuvatText;
        private Label label1;
        private CheckBox Photo1CheckBox;
        private CheckBox Photo2CheckBox;
        private CheckBox Photo3CheckBox;
        private CheckBox Photo4CheckBox;
        private Button ContinueButton2;
        private Button CheckButton;
    }
}