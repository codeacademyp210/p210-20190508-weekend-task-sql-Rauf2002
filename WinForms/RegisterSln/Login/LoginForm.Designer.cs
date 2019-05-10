namespace Login
{
    partial class Form1
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
            this.loginTitlePanel = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.signInButton = new System.Windows.Forms.Button();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.Label();
            this.loginUsernameBox = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.Label();
            this.loginTitlePanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTitlePanel
            // 
            this.loginTitlePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginTitlePanel.Controls.Add(this.login);
            this.loginTitlePanel.Location = new System.Drawing.Point(213, 12);
            this.loginTitlePanel.Name = "loginTitlePanel";
            this.loginTitlePanel.Size = new System.Drawing.Size(329, 86);
            this.loginTitlePanel.TabIndex = 0;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(133, 30);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(80, 31);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginPanel.Controls.Add(this.registerLink);
            this.loginPanel.Controls.Add(this.signInButton);
            this.loginPanel.Controls.Add(this.loginPasswordBox);
            this.loginPanel.Controls.Add(this.loginPassword);
            this.loginPanel.Controls.Add(this.loginUsernameBox);
            this.loginPanel.Controls.Add(this.loginUsername);
            this.loginPanel.Location = new System.Drawing.Point(213, 104);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(329, 334);
            this.loginPanel.TabIndex = 1;
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLink.LinkColor = System.Drawing.Color.White;
            this.registerLink.Location = new System.Drawing.Point(119, 234);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(88, 25);
            this.registerLink.TabIndex = 4;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Sign Up";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(35, 156);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(264, 39);
            this.signInButton.TabIndex = 3;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.Login);
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Location = new System.Drawing.Point(139, 83);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.Size = new System.Drawing.Size(160, 20);
            this.loginPasswordBox.TabIndex = 2;
            // 
            // loginPassword
            // 
            this.loginPassword.AutoSize = true;
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPassword.ForeColor = System.Drawing.Color.White;
            this.loginPassword.Location = new System.Drawing.Point(31, 83);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(92, 24);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.Text = "Password";
            // 
            // loginUsernameBox
            // 
            this.loginUsernameBox.Location = new System.Drawing.Point(139, 31);
            this.loginUsernameBox.Name = "loginUsernameBox";
            this.loginUsernameBox.Size = new System.Drawing.Size(160, 20);
            this.loginUsernameBox.TabIndex = 1;
            // 
            // loginUsername
            // 
            this.loginUsername.AutoSize = true;
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUsername.ForeColor = System.Drawing.Color.White;
            this.loginUsername.Location = new System.Drawing.Point(31, 31);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(97, 24);
            this.loginUsername.TabIndex = 0;
            this.loginUsername.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.loginTitlePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loginTitlePanel.ResumeLayout(false);
            this.loginTitlePanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginTitlePanel;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label loginUsername;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.Label loginPassword;
        private System.Windows.Forms.TextBox loginUsernameBox;
        private System.Windows.Forms.LinkLabel registerLink;
    }
}

