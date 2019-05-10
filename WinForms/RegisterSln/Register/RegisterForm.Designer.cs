namespace Register
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
            this.regTitlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.regPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.regTitlePanel.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regTitlePanel
            // 
            this.regTitlePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.regTitlePanel.Controls.Add(this.label1);
            this.regTitlePanel.Location = new System.Drawing.Point(213, 12);
            this.regTitlePanel.Name = "regTitlePanel";
            this.regTitlePanel.Size = new System.Drawing.Size(329, 86);
            this.regTitlePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.regPanel.Controls.Add(this.linkLabel1);
            this.regPanel.Controls.Add(this.registerButton);
            this.regPanel.Controls.Add(this.password);
            this.regPanel.Controls.Add(this.email);
            this.regPanel.Controls.Add(this.username);
            this.regPanel.Controls.Add(this.surname);
            this.regPanel.Controls.Add(this.passwordBox);
            this.regPanel.Controls.Add(this.emailBox);
            this.regPanel.Controls.Add(this.usernameBox);
            this.regPanel.Controls.Add(this.surnameBox);
            this.regPanel.Controls.Add(this.nameBox);
            this.regPanel.Controls.Add(this.name);
            this.regPanel.Location = new System.Drawing.Point(213, 104);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(329, 334);
            this.regPanel.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(117, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 25);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(27, 218);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(272, 51);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Sign Up";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.CreateUser);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(23, 161);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(92, 24);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(23, 122);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 24);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(23, 84);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(97, 24);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(23, 48);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(87, 24);
            this.surname.TabIndex = 2;
            this.surname.Text = "Surname";
            // 
            // passwordBox
            // 
            this.passwordBox.HideSelection = false;
            this.passwordBox.Location = new System.Drawing.Point(152, 161);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(147, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(152, 126);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(147, 20);
            this.emailBox.TabIndex = 4;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(152, 88);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(147, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(152, 53);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(147, 20);
            this.surnameBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(152, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 20);
            this.nameBox.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.LightSeaGreen;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(23, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 24);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.regTitlePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.regTitlePanel.ResumeLayout(false);
            this.regTitlePanel.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regTitlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

