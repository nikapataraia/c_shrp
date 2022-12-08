namespace InstagramDesign
{
    partial class Terminate
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
            this.label2 = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to do this?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.label2.Location = new System.Drawing.Point(1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hitting yes will perminantly delete your account";
            // 
            // NoButton
            // 
            this.NoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.NoButton.Location = new System.Drawing.Point(38, 78);
            this.NoButton.Name = "NoButton";
            this.NoButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoButton.Size = new System.Drawing.Size(134, 71);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.YesButton.Location = new System.Drawing.Point(230, 78);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(134, 71);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // Terminate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 183);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Terminate";
            this.Text = "Terminate";
            this.Load += new System.EventHandler(this.Terminate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
    }
}