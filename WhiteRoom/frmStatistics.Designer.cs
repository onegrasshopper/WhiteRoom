namespace WhiteRoom
{
    partial class frmStatistics
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
            this.cmdOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblCharNoSpaces = new System.Windows.Forms.Label();
            this.lblCharSpaces = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOk.Location = new System.Drawing.Point(141, 98);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "&OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Characters (no spaces):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Characters (with spaces):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lines:";
            // 
            // lblWords
            // 
            this.lblWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWords.Location = new System.Drawing.Point(23, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(49, 13);
            this.lblWords.TabIndex = 5;
            this.lblWords.Text = "WORDS";
            this.lblWords.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCharNoSpaces
            // 
            this.lblCharNoSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharNoSpaces.Location = new System.Drawing.Point(7, 22);
            this.lblCharNoSpaces.Name = "lblCharNoSpaces";
            this.lblCharNoSpaces.Size = new System.Drawing.Size(65, 13);
            this.lblCharNoSpaces.TabIndex = 6;
            this.lblCharNoSpaces.Text = "NOSPACES";
            this.lblCharNoSpaces.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCharSpaces
            // 
            this.lblCharSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharSpaces.Location = new System.Drawing.Point(23, 46);
            this.lblCharSpaces.Name = "lblCharSpaces";
            this.lblCharSpaces.Size = new System.Drawing.Size(49, 13);
            this.lblCharSpaces.TabIndex = 7;
            this.lblCharSpaces.Text = "SPACES";
            this.lblCharSpaces.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLines
            // 
            this.lblLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLines.Location = new System.Drawing.Point(34, 70);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(38, 13);
            this.lblLines.TabIndex = 8;
            this.lblLines.Text = "LINES";
            this.lblLines.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWords);
            this.panel1.Controls.Add(this.lblLines);
            this.panel1.Controls.Add(this.lblCharNoSpaces);
            this.panel1.Controls.Add(this.lblCharSpaces);
            this.panel1.Location = new System.Drawing.Point(144, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 83);
            this.panel1.TabIndex = 9;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 127);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStatistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblCharNoSpaces;
        private System.Windows.Forms.Label lblCharSpaces;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Panel panel1;
    }
}