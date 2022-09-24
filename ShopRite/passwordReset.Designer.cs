namespace ShopRite
{
    partial class passwordReset
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
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNamestaff = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.MistyRose;
            this.Password.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(354, 203);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(383, 72);
            this.Password.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // userNamestaff
            // 
            this.userNamestaff.BackColor = System.Drawing.Color.MistyRose;
            this.userNamestaff.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamestaff.Location = new System.Drawing.Point(354, 106);
            this.userNamestaff.Name = "userNamestaff";
            this.userNamestaff.Size = new System.Drawing.Size(383, 72);
            this.userNamestaff.TabIndex = 5;
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(57, 106);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(266, 72);
            this.staffUsername.TabIndex = 4;
            this.staffUsername.Text = "Username:";
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.MistyRose;
            this.firstname.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(354, 16);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(383, 72);
            this.firstname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 72);
            this.label2.TabIndex = 8;
            this.label2.Text = "Firstname:";
            // 
            // retype
            // 
            this.retype.BackColor = System.Drawing.Color.MistyRose;
            this.retype.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retype.Location = new System.Drawing.Point(354, 298);
            this.retype.Name = "retype";
            this.retype.PasswordChar = '#';
            this.retype.Size = new System.Drawing.Size(383, 72);
            this.retype.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 72);
            this.label3.TabIndex = 10;
            this.label3.Text = "Re-Type Pass:";
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(101, 395);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(10);
            this.staffBtn.Size = new System.Drawing.Size(237, 151);
            this.staffBtn.TabIndex = 12;
            this.staffBtn.Text = "Admin Reset";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 395);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(221, 151);
            this.button1.TabIndex = 13;
            this.button1.Text = "Staff Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.retype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNamestaff);
            this.Controls.Add(this.staffUsername);
            this.Name = "passwordReset";
            this.Text = "Password Reset ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNamestaff;
        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox retype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button button1;
    }
}