namespace TheWay1._0
{
    partial class HistoryOfTheResult
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
            this.gbopen = new System.Windows.Forms.GroupBox();
            this.gbclosed = new System.Windows.Forms.GroupBox();
            this.pbopen = new System.Windows.Forms.PictureBox();
            this.rtbopen = new System.Windows.Forms.RichTextBox();
            this.pbclosed = new System.Windows.Forms.PictureBox();
            this.rtbclosed = new System.Windows.Forms.RichTextBox();
            this.gbopen.SuspendLayout();
            this.gbclosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbopen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclosed)).BeginInit();
            this.SuspendLayout();
            // 
            // gbopen
            // 
            this.gbopen.Controls.Add(this.rtbopen);
            this.gbopen.Controls.Add(this.pbopen);
            this.gbopen.Location = new System.Drawing.Point(13, 2);
            this.gbopen.Name = "gbopen";
            this.gbopen.Size = new System.Drawing.Size(451, 436);
            this.gbopen.TabIndex = 0;
            this.gbopen.TabStop = false;
            this.gbopen.Text = "Position";
            // 
            // gbclosed
            // 
            this.gbclosed.Controls.Add(this.rtbclosed);
            this.gbclosed.Controls.Add(this.pbclosed);
            this.gbclosed.Location = new System.Drawing.Point(470, 2);
            this.gbclosed.Name = "gbclosed";
            this.gbclosed.Size = new System.Drawing.Size(451, 436);
            this.gbclosed.TabIndex = 0;
            this.gbclosed.TabStop = false;
            this.gbclosed.Text = "Closed Position";
            // 
            // pbopen
            // 
            this.pbopen.Location = new System.Drawing.Point(6, 19);
            this.pbopen.Name = "pbopen";
            this.pbopen.Size = new System.Drawing.Size(439, 313);
            this.pbopen.TabIndex = 0;
            this.pbopen.TabStop = false;
            // 
            // rtbopen
            // 
            this.rtbopen.Location = new System.Drawing.Point(7, 338);
            this.rtbopen.Name = "rtbopen";
            this.rtbopen.Size = new System.Drawing.Size(438, 92);
            this.rtbopen.TabIndex = 1;
            this.rtbopen.Text = "";
            // 
            // pbclosed
            // 
            this.pbclosed.Location = new System.Drawing.Point(6, 19);
            this.pbclosed.Name = "pbclosed";
            this.pbclosed.Size = new System.Drawing.Size(439, 313);
            this.pbclosed.TabIndex = 0;
            this.pbclosed.TabStop = false;
            // 
            // rtbclosed
            // 
            this.rtbclosed.Location = new System.Drawing.Point(7, 338);
            this.rtbclosed.Name = "rtbclosed";
            this.rtbclosed.Size = new System.Drawing.Size(438, 92);
            this.rtbclosed.TabIndex = 1;
            this.rtbclosed.Text = "";
            // 
            // HistoryOfTheResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.gbclosed);
            this.Controls.Add(this.gbopen);
            this.Name = "HistoryOfTheResult";
            this.Text = "HistoryOfTheResult";
            this.Load += new System.EventHandler(this.HistoryOfTheResult_Load);
            this.gbopen.ResumeLayout(false);
            this.gbclosed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbopen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclosed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbopen;
        private System.Windows.Forms.RichTextBox rtbopen;
        private System.Windows.Forms.PictureBox pbopen;
        private System.Windows.Forms.GroupBox gbclosed;
        private System.Windows.Forms.RichTextBox rtbclosed;
        private System.Windows.Forms.PictureBox pbclosed;
    }
}