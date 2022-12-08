namespace InstagramDesign
{
    partial class Direct_Messages
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
            this.dataGridViewFollowing = new System.Windows.Forms.DataGridView();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSentMessages = new System.Windows.Forms.DataGridView();
            this.dataGridViewRecievedMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecievedMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFollowing
            // 
            this.dataGridViewFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFollowing.Location = new System.Drawing.Point(929, 4);
            this.dataGridViewFollowing.Name = "dataGridViewFollowing";
            this.dataGridViewFollowing.ReadOnly = true;
            this.dataGridViewFollowing.Size = new System.Drawing.Size(232, 433);
            this.dataGridViewFollowing.TabIndex = 0;
            this.dataGridViewFollowing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFollowing_CellClick);
            // 
            // MessageText
            // 
            this.MessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MessageText.Location = new System.Drawing.Point(12, 266);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(688, 171);
            this.MessageText.TabIndex = 2;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.SendMessageButton.Location = new System.Drawing.Point(727, 266);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(177, 84);
            this.SendMessageButton.TabIndex = 3;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.BackButton.Location = new System.Drawing.Point(805, 397);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 41);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recieved Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(622, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sent Messages";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // dataGridViewSentMessages
            // 
            this.dataGridViewSentMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSentMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSentMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSentMessages.Location = new System.Drawing.Point(468, 35);
            this.dataGridViewSentMessages.Name = "dataGridViewSentMessages";
            this.dataGridViewSentMessages.ReadOnly = true;
            this.dataGridViewSentMessages.Size = new System.Drawing.Size(455, 221);
            this.dataGridViewSentMessages.TabIndex = 7;
            // 
            // dataGridViewRecievedMessages
            // 
            this.dataGridViewRecievedMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRecievedMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecievedMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecievedMessages.Location = new System.Drawing.Point(4, 35);
            this.dataGridViewRecievedMessages.Name = "dataGridViewRecievedMessages";
            this.dataGridViewRecievedMessages.ReadOnly = true;
            this.dataGridViewRecievedMessages.Size = new System.Drawing.Size(458, 221);
            this.dataGridViewRecievedMessages.TabIndex = 8;
            // 
            // Direct_Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.dataGridViewRecievedMessages);
            this.Controls.Add(this.dataGridViewSentMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.dataGridViewFollowing);
            this.Name = "Direct_Messages";
            this.Text = "Direct_Messages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFollowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecievedMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFollowing;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSentMessages;
        private System.Windows.Forms.DataGridView dataGridViewRecievedMessages;
    }
}