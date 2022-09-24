namespace ShopRite
{
    partial class staffLogin
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
            this.staffUsername = new System.Windows.Forms.Label();
            this.userNamestaff = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInbtn = new System.Windows.Forms.Button();
            this.resetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(51, 92);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(266, 72);
            this.staffUsername.TabIndex = 0;
            this.staffUsername.Text = "Username:";
            // 
            // userNamestaff
            // 
            this.userNamestaff.BackColor = System.Drawing.Color.MistyRose;
            this.userNamestaff.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamestaff.Location = new System.Drawing.Point(355, 92);
            this.userNamestaff.Name = "userNamestaff";
            this.userNamestaff.Size = new System.Drawing.Size(383, 72);
            this.userNamestaff.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.MistyRose;
            this.Password.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(355, 195);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(383, 72);
            this.Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // logInbtn
            // 
            this.logInbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.logInbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInbtn.Location = new System.Drawing.Point(531, 303);
            this.logInbtn.Name = "logInbtn";
            this.logInbtn.Size = new System.Drawing.Size(207, 69);
            this.logInbtn.TabIndex = 4;
            this.logInbtn.Text = "Log In";
            this.logInbtn.UseVisualStyleBackColor = false;
            this.logInbtn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // resetPassword
            // 
            this.resetPassword.AutoSize = true;
            this.resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.Location = new System.Drawing.Point(305, 334);
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(186, 25);
            this.resetPassword.TabIndex = 5;
            this.resetPassword.TabStop = true;
            this.resetPassword.Text = "Forgot Password?";
            this.resetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPassword_LinkClicked);
            // 
            // staffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(801, 427);
            this.Controls.Add(this.resetPassword);
            this.Controls.Add(this.logInbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNamestaff);
            this.Controls.Add(this.staffUsername);
            this.Name = "staffLogin";
            this.Text = "staffLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox userNamestaff;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInbtn;
        private System.Windows.Forms.LinkLabel resetPassword;
    }
}