namespace Inlämning_Affär
{
    partial class RegisterScreen
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
            regButton = new Button();
            regUsernameLabel = new Label();
            regPasswordLabel = new Label();
            enterPasswordTB = new TextBox();
            enterUsernameTB = new TextBox();
            errorLabel = new Label();
            successLabel = new Label();
            SuspendLayout();
            // 
            // regButton
            // 
            regButton.Location = new Point(161, 187);
            regButton.Name = "regButton";
            regButton.Size = new Size(88, 41);
            regButton.TabIndex = 0;
            regButton.Text = "Register";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // regUsernameLabel
            // 
            regUsernameLabel.AutoSize = true;
            regUsernameLabel.Location = new Point(108, 49);
            regUsernameLabel.Name = "regUsernameLabel";
            regUsernameLabel.Size = new Size(90, 15);
            regUsernameLabel.TabIndex = 1;
            regUsernameLabel.Text = "Enter Username";
            // 
            // regPasswordLabel
            // 
            regPasswordLabel.AutoSize = true;
            regPasswordLabel.Location = new Point(108, 98);
            regPasswordLabel.Name = "regPasswordLabel";
            regPasswordLabel.Size = new Size(87, 15);
            regPasswordLabel.TabIndex = 1;
            regPasswordLabel.Text = "Enter Password";
            regPasswordLabel.Click += label2_Click;
            // 
            // enterPasswordTB
            // 
            enterPasswordTB.Location = new Point(204, 95);
            enterPasswordTB.Name = "enterPasswordTB";
            enterPasswordTB.Size = new Size(100, 23);
            enterPasswordTB.TabIndex = 2;
            // 
            // enterUsernameTB
            // 
            enterUsernameTB.Location = new Point(204, 46);
            enterUsernameTB.Name = "enterUsernameTB";
            enterUsernameTB.Size = new Size(100, 23);
            enterUsernameTB.TabIndex = 2;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(114, 144);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(182, 21);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Username allready exists";
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            successLabel.ForeColor = Color.Lime;
            successLabel.Location = new Point(146, 144);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(128, 21);
            successLabel.TabIndex = 4;
            successLabel.Text = "Register success!";
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 267);
            Controls.Add(successLabel);
            Controls.Add(errorLabel);
            Controls.Add(enterUsernameTB);
            Controls.Add(enterPasswordTB);
            Controls.Add(regPasswordLabel);
            Controls.Add(regUsernameLabel);
            Controls.Add(regButton);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            Load += RegisterScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regButton;
        private Label regUsernameLabel;
        private Label regPasswordLabel;
        private TextBox enterPasswordTB;
        private TextBox enterUsernameTB;
        private Label errorLabel;
        private Label successLabel;
    }
}