namespace TheWay1._0
{
    partial class HistoryOfTheTrue
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.rtbNoteOpen = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(825, 354);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // rtbNoteOpen
            // 
            this.rtbNoteOpen.Location = new System.Drawing.Point(12, 372);
            this.rtbNoteOpen.Name = "rtbNoteOpen";
            this.rtbNoteOpen.Size = new System.Drawing.Size(825, 117);
            this.rtbNoteOpen.TabIndex = 1;
            this.rtbNoteOpen.Text = "";
            // 
            // HistoryOfTheTrue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 492);
            this.Controls.Add(this.rtbNoteOpen);
            this.Controls.Add(this.picImage);
            this.Name = "HistoryOfTheTrue";
            this.Text = "HistoryOfTheTrue";
            this.Load += new System.EventHandler(this.HistoryOfTheTrue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.RichTextBox rtbNoteOpen;
    }
}