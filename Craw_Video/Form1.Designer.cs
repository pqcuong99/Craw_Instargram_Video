namespace Craw_Video
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.rdiInstargram = new System.Windows.Forms.RadioButton();
            this.rdiTiktok = new System.Windows.Forms.RadioButton();
            this.btnDownload = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathSave = new System.Windows.Forms.TextBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link user:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(30, 40);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(268, 28);
            this.txtLink.TabIndex = 1;
            this.txtLink.Text = "https://www.instagram.com/dailyart/reels/";
            // 
            // rdiInstargram
            // 
            this.rdiInstargram.AutoSize = true;
            this.rdiInstargram.Checked = true;
            this.rdiInstargram.Location = new System.Drawing.Point(29, 152);
            this.rdiInstargram.Name = "rdiInstargram";
            this.rdiInstargram.Size = new System.Drawing.Size(74, 17);
            this.rdiInstargram.TabIndex = 2;
            this.rdiInstargram.TabStop = true;
            this.rdiInstargram.Text = "Instargram";
            this.rdiInstargram.UseVisualStyleBackColor = true;
            // 
            // rdiTiktok
            // 
            this.rdiTiktok.AutoSize = true;
            this.rdiTiktok.Location = new System.Drawing.Point(130, 152);
            this.rdiTiktok.Name = "rdiTiktok";
            this.rdiTiktok.Size = new System.Drawing.Size(55, 17);
            this.rdiTiktok.TabIndex = 3;
            this.rdiTiktok.Text = "Tiktok";
            this.rdiTiktok.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(29, 186);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(268, 36);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(29, 264);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(268, 203);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(118, 235);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path save";
            // 
            // txtPathSave
            // 
            this.txtPathSave.Location = new System.Drawing.Point(30, 100);
            this.txtPathSave.Multiline = true;
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(215, 26);
            this.txtPathSave.TabIndex = 8;
            this.txtPathSave.Text = "D:\\TEST_SAVE_IMAGE";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(251, 100);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(47, 26);
            this.btnAddFile.TabIndex = 9;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 479);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.txtPathSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.rdiTiktok);
            this.Controls.Add(this.rdiInstargram);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.RadioButton rdiInstargram;
        private System.Windows.Forms.RadioButton rdiTiktok;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathSave;
        private System.Windows.Forms.Button btnAddFile;
    }
}

