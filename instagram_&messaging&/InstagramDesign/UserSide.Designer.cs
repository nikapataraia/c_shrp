namespace InstagramDesign
{
    partial class UserSide
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
            this.LogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFollowers = new System.Windows.Forms.DataGridView();
            this.dataGridViewFollowing = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.FollowUserName = new System.Windows.Forms.TextBox();
            this.FollowButton = new System.Windows.Forms.Button();
            this.FollowingLabel = new System.Windows.Forms.Label();
            this.FollowersLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountSettingsButton = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.UnFollowButton = new System.Windows.Forms.Button();
            this.UnfollowUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LikesLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogOut.Location = new System.Drawing.Point(692, 399);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(105, 50);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(62, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Following";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(277, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Followers";
            // 
            // dataGridViewFollowers
            // 
            this.dataGridViewFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowers.Location = new System.Drawing.Point(227, 248);
            this.dataGridViewFollowers.Name = "dataGridViewFollowers";
            this.dataGridViewFollowers.Size = new System.Drawing.Size(187, 190);
            this.dataGridViewFollowers.TabIndex = 5;
            // 
            // dataGridViewFollowing
            // 
            this.dataGridViewFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowing.Location = new System.Drawing.Point(12, 248);
            this.dataGridViewFollowing.Name = "dataGridViewFollowing";
            this.dataGridViewFollowing.Size = new System.Drawing.Size(187, 190);
            this.dataGridViewFollowing.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(615, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Follow Someone";
            // 
            // FollowUserName
            // 
            this.FollowUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FollowUserName.Location = new System.Drawing.Point(616, 60);
            this.FollowUserName.Name = "FollowUserName";
            this.FollowUserName.Size = new System.Drawing.Size(157, 29);
            this.FollowUserName.TabIndex = 8;
            this.FollowUserName.Text = "UserName";
            // 
            // FollowButton
            // 
            this.FollowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FollowButton.Location = new System.Drawing.Point(620, 108);
            this.FollowButton.Name = "FollowButton";
            this.FollowButton.Size = new System.Drawing.Size(153, 34);
            this.FollowButton.TabIndex = 9;
            this.FollowButton.Text = "Follow";
            this.FollowButton.UseVisualStyleBackColor = true;
            this.FollowButton.Click += new System.EventHandler(this.FollowButton_Click);
            // 
            // FollowingLabel
            // 
            this.FollowingLabel.AutoSize = true;
            this.FollowingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FollowingLabel.Location = new System.Drawing.Point(12, 165);
            this.FollowingLabel.Name = "FollowingLabel";
            this.FollowingLabel.Size = new System.Drawing.Size(100, 25);
            this.FollowingLabel.TabIndex = 10;
            this.FollowingLabel.Text = "Following:";
            // 
            // FollowersLabel
            // 
            this.FollowersLabel.AutoSize = true;
            this.FollowersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FollowersLabel.Location = new System.Drawing.Point(222, 165);
            this.FollowersLabel.Name = "FollowersLabel";
            this.FollowersLabel.Size = new System.Drawing.Size(101, 25);
            this.FollowersLabel.TabIndex = 11;
            this.FollowersLabel.Text = "Followers:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(613, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 76);
            this.button1.TabIndex = 12;
            this.button1.Text = "Direct Messages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AccountSettingsButton
            // 
            this.AccountSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AccountSettingsButton.Location = new System.Drawing.Point(507, 399);
            this.AccountSettingsButton.Name = "AccountSettingsButton";
            this.AccountSettingsButton.Size = new System.Drawing.Size(167, 50);
            this.AccountSettingsButton.TabIndex = 13;
            this.AccountSettingsButton.Text = "Account settings";
            this.AccountSettingsButton.UseVisualStyleBackColor = true;
            this.AccountSettingsButton.Click += new System.EventHandler(this.AccountSettingsButton_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(640, 248);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(133, 130);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 14;
            this.ProfilePicture.TabStop = false;
            // 
            // UnFollowButton
            // 
            this.UnFollowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UnFollowButton.Location = new System.Drawing.Point(435, 108);
            this.UnFollowButton.Name = "UnFollowButton";
            this.UnFollowButton.Size = new System.Drawing.Size(153, 34);
            this.UnFollowButton.TabIndex = 17;
            this.UnFollowButton.Text = "UnFollow";
            this.UnFollowButton.UseVisualStyleBackColor = true;
            this.UnFollowButton.Click += new System.EventHandler(this.UnFollowButton_Click);
            // 
            // UnfollowUserName
            // 
            this.UnfollowUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UnfollowUserName.Location = new System.Drawing.Point(431, 60);
            this.UnfollowUserName.Name = "UnfollowUserName";
            this.UnfollowUserName.Size = new System.Drawing.Size(157, 29);
            this.UnfollowUserName.TabIndex = 16;
            this.UnfollowUserName.Text = "UserName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(416, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "UnFollow Someone";
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HomeButton.Location = new System.Drawing.Point(448, 301);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(93, 55);
            this.HomeButton.TabIndex = 18;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LikesLabel
            // 
            this.LikesLabel.AutoSize = true;
            this.LikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LikesLabel.Location = new System.Drawing.Point(430, 212);
            this.LikesLabel.Name = "LikesLabel";
            this.LikesLabel.Size = new System.Drawing.Size(64, 25);
            this.LikesLabel.TabIndex = 19;
            this.LikesLabel.Text = "Likes:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UsernameLabel.Location = new System.Drawing.Point(12, 47);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 25);
            this.UsernameLabel.TabIndex = 20;
            this.UsernameLabel.Text = "Username:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FullNameLabel.Location = new System.Drawing.Point(11, 91);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FullNameLabel.TabIndex = 21;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AgeLabel.Location = new System.Drawing.Point(14, 131);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(54, 25);
            this.AgeLabel.TabIndex = 22;
            this.AgeLabel.Text = "Age:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GenderLabel.Location = new System.Drawing.Point(145, 131);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(83, 25);
            this.GenderLabel.TabIndex = 23;
            this.GenderLabel.Text = "Gender:";
            // 
            // UserSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LikesLabel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.UnFollowButton);
            this.Controls.Add(this.UnfollowUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.AccountSettingsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FollowersLabel);
            this.Controls.Add(this.FollowingLabel);
            this.Controls.Add(this.FollowButton);
            this.Controls.Add(this.FollowUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewFollowing);
            this.Controls.Add(this.dataGridViewFollowers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label1);
            this.Name = "UserSide";
            this.Text = "UserSide";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFollowers;
        private System.Windows.Forms.DataGridView dataGridViewFollowing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FollowUserName;
        private System.Windows.Forms.Button FollowButton;
        private System.Windows.Forms.Label FollowingLabel;
        private System.Windows.Forms.Label FollowersLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AccountSettingsButton;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button UnFollowButton;
        private System.Windows.Forms.TextBox UnfollowUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label LikesLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
    }
}