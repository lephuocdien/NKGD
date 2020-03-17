namespace TheWay1._0
{
    partial class Note_Close_Position
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
            this.rtbNoteClose = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTypeclose = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbNoteClose
            // 
            this.rtbNoteClose.Location = new System.Drawing.Point(3, 2);
            this.rtbNoteClose.Name = "rtbNoteClose";
            this.rtbNoteClose.Size = new System.Drawing.Size(408, 195);
            this.rtbNoteClose.TabIndex = 0;
            this.rtbNoteClose.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Image and save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbTypeclose);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(416, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(131, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Close Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Close Result";
            // 
            // cbbTypeclose
            // 
            this.cbbTypeclose.FormattingEnabled = true;
            this.cbbTypeclose.Location = new System.Drawing.Point(7, 45);
            this.cbbTypeclose.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTypeclose.Name = "cbbTypeclose";
            this.cbbTypeclose.Size = new System.Drawing.Size(92, 21);
            this.cbbTypeclose.TabIndex = 2;
            // 
            // Note_Close_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbNoteClose);
            this.Name = "Note_Close_Position";
            this.Text = "Note_Close_Position";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Note_Close_Position_FormClosing);
            this.Load += new System.EventHandler(this.Note_Close_Position_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNoteClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTypeclose;
    }
}