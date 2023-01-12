
namespace Xerox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonFrom = new System.Windows.Forms.Button();
            this.buttonTo = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.labelFile1 = new System.Windows.Forms.Label();
            this.labelFile2 = new System.Windows.Forms.Label();
            this.labelFile3 = new System.Windows.Forms.Label();
            this.labelFile4 = new System.Windows.Forms.Label();
            this.labelCopied4 = new System.Windows.Forms.Label();
            this.labelCopied3 = new System.Windows.Forms.Label();
            this.labelCopied2 = new System.Windows.Forms.Label();
            this.labelCopied1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(14, 7);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(14, 55);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 13);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "To:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFrom.Location = new System.Drawing.Point(7, 28);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(565, 20);
            this.textBoxFrom.TabIndex = 2;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTo.Location = new System.Drawing.Point(7, 76);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(565, 20);
            this.textBoxTo.TabIndex = 3;
            // 
            // buttonFrom
            // 
            this.buttonFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFrom.Location = new System.Drawing.Point(578, 28);
            this.buttonFrom.Name = "buttonFrom";
            this.buttonFrom.Size = new System.Drawing.Size(89, 20);
            this.buttonFrom.TabIndex = 4;
            this.buttonFrom.Text = "Search...";
            this.buttonFrom.UseVisualStyleBackColor = true;
            this.buttonFrom.Click += new System.EventHandler(this.buttonFrom_Click);
            // 
            // buttonTo
            // 
            this.buttonTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTo.Location = new System.Drawing.Point(578, 76);
            this.buttonTo.Name = "buttonTo";
            this.buttonTo.Size = new System.Drawing.Size(89, 20);
            this.buttonTo.TabIndex = 5;
            this.buttonTo.Text = "Search...";
            this.buttonTo.UseVisualStyleBackColor = true;
            this.buttonTo.Click += new System.EventHandler(this.buttonTo_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonCopy.Location = new System.Drawing.Point(0, 310);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(676, 35);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(158, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(158, 132);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(385, 20);
            this.progressBar2.TabIndex = 8;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Location = new System.Drawing.Point(158, 159);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(385, 20);
            this.progressBar3.TabIndex = 9;
            // 
            // progressBar4
            // 
            this.progressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar4.Location = new System.Drawing.Point(158, 187);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(385, 20);
            this.progressBar4.TabIndex = 10;
            // 
            // labelFile1
            // 
            this.labelFile1.AutoSize = true;
            this.labelFile1.Location = new System.Drawing.Point(7, 111);
            this.labelFile1.Name = "labelFile1";
            this.labelFile1.Size = new System.Drawing.Size(51, 13);
            this.labelFile1.TabIndex = 11;
            this.labelFile1.Text = "labelFile1";
            // 
            // labelFile2
            // 
            this.labelFile2.AutoSize = true;
            this.labelFile2.Location = new System.Drawing.Point(7, 139);
            this.labelFile2.Name = "labelFile2";
            this.labelFile2.Size = new System.Drawing.Size(51, 13);
            this.labelFile2.TabIndex = 12;
            this.labelFile2.Text = "labelFile2";
            // 
            // labelFile3
            // 
            this.labelFile3.AutoSize = true;
            this.labelFile3.Location = new System.Drawing.Point(7, 166);
            this.labelFile3.Name = "labelFile3";
            this.labelFile3.Size = new System.Drawing.Size(51, 13);
            this.labelFile3.TabIndex = 13;
            this.labelFile3.Text = "labelFile3";
            // 
            // labelFile4
            // 
            this.labelFile4.AutoSize = true;
            this.labelFile4.Location = new System.Drawing.Point(7, 194);
            this.labelFile4.Name = "labelFile4";
            this.labelFile4.Size = new System.Drawing.Size(51, 13);
            this.labelFile4.TabIndex = 14;
            this.labelFile4.Text = "labelFile4";
            // 
            // labelCopied4
            // 
            this.labelCopied4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopied4.AutoSize = true;
            this.labelCopied4.Location = new System.Drawing.Point(549, 187);
            this.labelCopied4.Name = "labelCopied4";
            this.labelCopied4.Size = new System.Drawing.Size(68, 13);
            this.labelCopied4.TabIndex = 18;
            this.labelCopied4.Text = "labelCopied4";
            // 
            // labelCopied3
            // 
            this.labelCopied3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopied3.AutoSize = true;
            this.labelCopied3.Location = new System.Drawing.Point(549, 159);
            this.labelCopied3.Name = "labelCopied3";
            this.labelCopied3.Size = new System.Drawing.Size(68, 13);
            this.labelCopied3.TabIndex = 17;
            this.labelCopied3.Text = "labelCopied3";
            // 
            // labelCopied2
            // 
            this.labelCopied2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopied2.AutoSize = true;
            this.labelCopied2.Location = new System.Drawing.Point(549, 132);
            this.labelCopied2.Name = "labelCopied2";
            this.labelCopied2.Size = new System.Drawing.Size(68, 13);
            this.labelCopied2.TabIndex = 16;
            this.labelCopied2.Text = "labelCopied2";
            // 
            // labelCopied1
            // 
            this.labelCopied1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopied1.AutoSize = true;
            this.labelCopied1.Location = new System.Drawing.Point(549, 104);
            this.labelCopied1.Name = "labelCopied1";
            this.labelCopied1.Size = new System.Drawing.Size(68, 13);
            this.labelCopied1.TabIndex = 15;
            this.labelCopied1.Text = "labelCopied1";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 269);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(675, 34);
            this.progressBar.TabIndex = 19;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(552, 240);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 20);
            this.labelTotal.TabIndex = 20;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 346);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelCopied4);
            this.Controls.Add(this.labelCopied3);
            this.Controls.Add(this.labelCopied2);
            this.Controls.Add(this.labelCopied1);
            this.Controls.Add(this.labelFile4);
            this.Controls.Add(this.labelFile3);
            this.Controls.Add(this.labelFile2);
            this.Controls.Add(this.labelFile1);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonTo);
            this.Controls.Add(this.buttonFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.MinimumSize = new System.Drawing.Size(371, 380);
            this.Name = "Form1";
            this.Text = "Xerox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonFrom;
        private System.Windows.Forms.Button buttonTo;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label labelFile1;
        private System.Windows.Forms.Label labelFile2;
        private System.Windows.Forms.Label labelFile3;
        private System.Windows.Forms.Label labelFile4;
        private System.Windows.Forms.Label labelCopied4;
        private System.Windows.Forms.Label labelCopied3;
        private System.Windows.Forms.Label labelCopied2;
        private System.Windows.Forms.Label labelCopied1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelTotal;
    }
}

