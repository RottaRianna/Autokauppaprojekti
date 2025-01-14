namespace Autokauppa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Welcome = new Label();
            LogInText = new Label();
            UsernameText = new Label();
            Password = new Label();
            UserNameBox = new TextBox();
            PasswordBox = new TextBox();
            ContinueButton = new Button();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.DodgerBlue;
            Welcome.BorderStyle = BorderStyle.Fixed3D;
            Welcome.Font = new Font("Segoe UI", 30F);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(358, 45);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(833, 83);
            Welcome.TabIndex = 0;
            Welcome.Text = "Tervettuloa katsomaan autoja!";
            // 
            // LogInText
            // 
            LogInText.AutoSize = true;
            LogInText.BackColor = Color.White;
            LogInText.Font = new Font("Segoe UI", 15F);
            LogInText.Location = new Point(542, 150);
            LogInText.Name = "LogInText";
            LogInText.Size = new Size(470, 41);
            LogInText.TabIndex = 1;
            LogInText.Text = "Ensin sinun täytyy kirjautua sisään.";
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.BackColor = Color.White;
            UsernameText.Font = new Font("Segoe UI", 20F);
            UsernameText.Location = new Point(654, 222);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(240, 54);
            UsernameText.TabIndex = 2;
            UsernameText.Text = "Käyttäjänimi";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.White;
            Password.Font = new Font("Segoe UI", 20F);
            Password.Location = new Point(694, 338);
            Password.Name = "Password";
            Password.Size = new Size(174, 54);
            Password.TabIndex = 3;
            Password.Text = "Salasana";
            // 
            // UserNameBox
            // 
            UserNameBox.BackColor = Color.LightSteelBlue;
            UserNameBox.Font = new Font("Segoe UI", 15F);
            UserNameBox.Location = new Point(455, 279);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(631, 47);
            UserNameBox.TabIndex = 4;
            UserNameBox.TextChanged += UserNameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.LightSteelBlue;
            PasswordBox.Font = new Font("Segoe UI", 15F);
            PasswordBox.Location = new Point(455, 395);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(631, 47);
            PasswordBox.TabIndex = 5;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.DodgerBlue;
            ContinueButton.Font = new Font("Segoe UI", 15F);
            ContinueButton.ForeColor = Color.White;
            ContinueButton.Location = new Point(654, 471);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(240, 91);
            ContinueButton.TabIndex = 6;
            ContinueButton.Text = "Jatka";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 650);
            Controls.Add(ContinueButton);
            Controls.Add(PasswordBox);
            Controls.Add(UserNameBox);
            Controls.Add(Password);
            Controls.Add(UsernameText);
            Controls.Add(LogInText);
            Controls.Add(Welcome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private Label LogInText;
        private Label UsernameText;
        private Label Password;
        private TextBox UserNameBox;
        private TextBox PasswordBox;
        private Button ContinueButton;
    }
}
