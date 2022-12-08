namespace InstagramDesign
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.InUserName = new System.Windows.Forms.TextBox();
            this.InPassword = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign into Instagram!";
            // 
            // InUserName
            // 
            this.InUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InUserName.Location = new System.Drawing.Point(35, 149);
            this.InUserName.Name = "InUserName";
            this.InUserName.Size = new System.Drawing.Size(201, 29);
            this.InUserName.TabIndex = 1;
            this.InUserName.Text = "UserName";
            // 
            // InPassword
            // 
            this.InPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InPassword.Location = new System.Drawing.Point(35, 184);
            this.InPassword.Name = "InPassword";
            this.InPassword.Size = new System.Drawing.Size(201, 29);
            this.InPassword.TabIndex = 2;
            this.InPassword.Text = "Password";
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SignInButton.Location = new System.Drawing.Point(80, 237);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(105, 51);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BackButton.Location = new System.Drawing.Point(191, 271);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 36);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::InstagramDesign.Properties.Resources.InstagramText;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(13, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.InPassword);
            this.Controls.Add(this.InUserName);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InUserName;
        private System.Windows.Forms.TextBox InPassword;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}