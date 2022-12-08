namespace InstagramDesign
{
    partial class Account_Settings
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
            this.NewUserName = new System.Windows.Forms.TextBox();
            this.UpdateUserName = new System.Windows.Forms.Button();
            this.UpdateFullName = new System.Windows.Forms.Button();
            this.NewFullName = new System.Windows.Forms.TextBox();
            this.UpdateNumber = new System.Windows.Forms.Button();
            this.NewNumber = new System.Windows.Forms.TextBox();
            this.UpdateAge = new System.Windows.Forms.Button();
            this.NewAge = new System.Windows.Forms.TextBox();
            this.UpdateGender = new System.Windows.Forms.Button();
            this.NewGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UpdatePicture = new System.Windows.Forms.Button();
            this.NewPicture = new System.Windows.Forms.TextBox();
            this.TerminateAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUserName
            // 
            this.NewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewUserName.Location = new System.Drawing.Point(24, 28);
            this.NewUserName.Name = "NewUserName";
            this.NewUserName.Size = new System.Drawing.Size(232, 29);
            this.NewUserName.TabIndex = 0;
            this.NewUserName.Text = "New UserName";
            // 
            // UpdateUserName
            // 
            this.UpdateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdateUserName.Location = new System.Drawing.Point(43, 73);
            this.UpdateUserName.Name = "UpdateUserName";
            this.UpdateUserName.Size = new System.Drawing.Size(184, 36);
            this.UpdateUserName.TabIndex = 1;
            this.UpdateUserName.Text = "Update UserName";
            this.UpdateUserName.UseVisualStyleBackColor = true;
            this.UpdateUserName.Click += new System.EventHandler(this.UpdateUserName_Click);
            // 
            // UpdateFullName
            // 
            this.UpdateFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdateFullName.Location = new System.Drawing.Point(314, 73);
            this.UpdateFullName.Name = "UpdateFullName";
            this.UpdateFullName.Size = new System.Drawing.Size(184, 36);
            this.UpdateFullName.TabIndex = 3;
            this.UpdateFullName.Text = "Update FullName";
            this.UpdateFullName.UseVisualStyleBackColor = true;
            this.UpdateFullName.Click += new System.EventHandler(this.UpdateFullName_Click);
            // 
            // NewFullName
            // 
            this.NewFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewFullName.Location = new System.Drawing.Point(288, 28);
            this.NewFullName.Name = "NewFullName";
            this.NewFullName.Size = new System.Drawing.Size(230, 29);
            this.NewFullName.TabIndex = 2;
            this.NewFullName.Text = "New Full Name";
            // 
            // UpdateNumber
            // 
            this.UpdateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdateNumber.Location = new System.Drawing.Point(549, 73);
            this.UpdateNumber.Name = "UpdateNumber";
            this.UpdateNumber.Size = new System.Drawing.Size(239, 36);
            this.UpdateNumber.TabIndex = 5;
            this.UpdateNumber.Text = "Update Mobile Number";
            this.UpdateNumber.UseVisualStyleBackColor = true;
            this.UpdateNumber.Click += new System.EventHandler(this.UpdateNumber_Click);
            // 
            // NewNumber
            // 
            this.NewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewNumber.Location = new System.Drawing.Point(549, 28);
            this.NewNumber.Name = "NewNumber";
            this.NewNumber.Size = new System.Drawing.Size(239, 29);
            this.NewNumber.TabIndex = 4;
            this.NewNumber.Text = "New Mobile Number";
            // 
            // UpdateAge
            // 
            this.UpdateAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdateAge.Location = new System.Drawing.Point(43, 182);
            this.UpdateAge.Name = "UpdateAge";
            this.UpdateAge.Size = new System.Drawing.Size(184, 36);
            this.UpdateAge.TabIndex = 7;
            this.UpdateAge.Text = "Update Age";
            this.UpdateAge.UseVisualStyleBackColor = true;
            // 
            // NewAge
            // 
            this.NewAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewAge.Location = new System.Drawing.Point(24, 137);
            this.NewAge.Name = "NewAge";
            this.NewAge.Size = new System.Drawing.Size(232, 29);
            this.NewAge.TabIndex = 6;
            this.NewAge.Text = "New Age";
            this.NewAge.TextChanged += new System.EventHandler(this.NewAge_TextChanged);
            // 
            // UpdateGender
            // 
            this.UpdateGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdateGender.Location = new System.Drawing.Point(575, 182);
            this.UpdateGender.Name = "UpdateGender";
            this.UpdateGender.Size = new System.Drawing.Size(193, 36);
            this.UpdateGender.TabIndex = 9;
            this.UpdateGender.Text = "Update Gender";
            this.UpdateGender.UseVisualStyleBackColor = true;
            this.UpdateGender.Click += new System.EventHandler(this.UpdateGender_Click);
            // 
            // NewGender
            // 
            this.NewGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewGender.FormattingEnabled = true;
            this.NewGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.NewGender.Location = new System.Drawing.Point(549, 134);
            this.NewGender.Name = "NewGender";
            this.NewGender.Size = new System.Drawing.Size(239, 32);
            this.NewGender.TabIndex = 10;
            this.NewGender.Text = "New Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(19, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Old Password:";
            // 
            // OldPassword
            // 
            this.OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OldPassword.Location = new System.Drawing.Point(165, 253);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(232, 29);
            this.OldPassword.TabIndex = 12;
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewPassword.Location = new System.Drawing.Point(165, 301);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(232, 29);
            this.NewPassword.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(19, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Password:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(24, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BackButton.Location = new System.Drawing.Point(666, 390);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(122, 48);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Get Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(38, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 18;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StatusLabel.Location = new System.Drawing.Point(19, 401);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(83, 25);
            this.StatusLabel.TabIndex = 19;
            this.StatusLabel.Text = "Status...";
            // 
            // UpdatePicture
            // 
            this.UpdatePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdatePicture.Location = new System.Drawing.Point(549, 269);
            this.UpdatePicture.Name = "UpdatePicture";
            this.UpdatePicture.Size = new System.Drawing.Size(239, 36);
            this.UpdatePicture.TabIndex = 21;
            this.UpdatePicture.Text = "Update Profile Picture";
            this.UpdatePicture.UseVisualStyleBackColor = true;
            this.UpdatePicture.Click += new System.EventHandler(this.UpdatePicture_Click);
            // 
            // NewPicture
            // 
            this.NewPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewPicture.Location = new System.Drawing.Point(549, 224);
            this.NewPicture.Name = "NewPicture";
            this.NewPicture.Size = new System.Drawing.Size(239, 29);
            this.NewPicture.TabIndex = 20;
            this.NewPicture.Text = "Profile Picture Url";
            // 
            // TerminateAccount
            // 
            this.TerminateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TerminateAccount.Location = new System.Drawing.Point(464, 399);
            this.TerminateAccount.Name = "TerminateAccount";
            this.TerminateAccount.Size = new System.Drawing.Size(178, 36);
            this.TerminateAccount.TabIndex = 22;
            this.TerminateAccount.Text = "Terminate Account";
            this.TerminateAccount.UseVisualStyleBackColor = true;
            this.TerminateAccount.Click += new System.EventHandler(this.TerminateAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::InstagramDesign.Properties.Resources.Logo;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(325, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Account_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TerminateAccount);
            this.Controls.Add(this.UpdatePicture);
            this.Controls.Add(this.NewPicture);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewGender);
            this.Controls.Add(this.UpdateGender);
            this.Controls.Add(this.UpdateAge);
            this.Controls.Add(this.NewAge);
            this.Controls.Add(this.UpdateNumber);
            this.Controls.Add(this.NewNumber);
            this.Controls.Add(this.UpdateFullName);
            this.Controls.Add(this.NewFullName);
            this.Controls.Add(this.UpdateUserName);
            this.Controls.Add(this.NewUserName);
            this.Name = "Account_Settings";
            this.Text = "Account_Settings";
            this.Load += new System.EventHandler(this.Account_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewUserName;
        private System.Windows.Forms.Button UpdateUserName;
        private System.Windows.Forms.Button UpdateFullName;
        private System.Windows.Forms.TextBox NewFullName;
        private System.Windows.Forms.Button UpdateNumber;
        private System.Windows.Forms.TextBox NewNumber;
        private System.Windows.Forms.Button UpdateAge;
        private System.Windows.Forms.TextBox NewAge;
        private System.Windows.Forms.Button UpdateGender;
        private System.Windows.Forms.ComboBox NewGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldPassword;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button UpdatePicture;
        private System.Windows.Forms.TextBox NewPicture;
        private System.Windows.Forms.Button TerminateAccount;
    }
}