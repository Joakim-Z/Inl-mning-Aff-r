namespace Inlämning_Affär
{
    partial class LogInScreen
    {
        



        
        private System.ComponentModel.IContainer components = null;

        
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
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginUsername = new TextBox();
            loginPassword = new TextBox();
            logInButton = new Button();
            errorMassageLabel = new Label();
            registerButton = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(254, 117);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(60, 15);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(257, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            // 
            // loginUsername
            // 
            loginUsername.Location = new Point(344, 109);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(100, 23);
            loginUsername.TabIndex = 1;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(344, 155);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(100, 23);
            loginPassword.TabIndex = 1;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(257, 241);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(86, 40);
            logInButton.TabIndex = 2;
            logInButton.Text = "Login";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // errorMassageLabel
            // 
            errorMassageLabel.AutoSize = true;
            errorMassageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorMassageLabel.ForeColor = Color.Red;
            errorMassageLabel.Location = new Point(278, 328);
            errorMassageLabel.Name = "errorMassageLabel";
            errorMassageLabel.Size = new Size(222, 21);
            errorMassageLabel.TabIndex = 3;
            errorMassageLabel.Text = "Wrong Username or Password";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(445, 241);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(86, 40);
            registerButton.TabIndex = 2;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // LogInScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(errorMassageLabel);
            Controls.Add(logInButton);
            Controls.Add(loginPassword);
            Controls.Add(loginUsername);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Name = "LogInScreen";
            Text = "LogInScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox loginUsername;
        private TextBox loginPassword;
        private Button logInButton;
        private Label errorMassageLabel;
        private Button registerButton;
    }
}