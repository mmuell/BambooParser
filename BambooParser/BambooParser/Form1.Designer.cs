namespace BambooParser
{
    partial class MainView
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
            this.LogFileST = new System.Windows.Forms.Label();
            this.ParsePB = new System.Windows.Forms.Button();
            this.LogFileET = new System.Windows.Forms.TextBox();
            this.ResultsET = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogFileST
            // 
            this.LogFileST.AutoSize = true;
            this.LogFileST.Location = new System.Drawing.Point(12, 18);
            this.LogFileST.Name = "LogFileST";
            this.LogFileST.Size = new System.Drawing.Size(61, 20);
            this.LogFileST.TabIndex = 0;
            this.LogFileST.Text = "LogFile";
            // 
            // ParsePB
            // 
            this.ParsePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParsePB.Location = new System.Drawing.Point(954, 8);
            this.ParsePB.Name = "ParsePB";
            this.ParsePB.Size = new System.Drawing.Size(75, 41);
            this.ParsePB.TabIndex = 1;
            this.ParsePB.Text = "Parse";
            this.ParsePB.UseVisualStyleBackColor = true;
            this.ParsePB.Click += new System.EventHandler(this.ParsePB_Click);
            // 
            // LogFileET
            // 
            this.LogFileET.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFileET.Location = new System.Drawing.Point(79, 15);
            this.LogFileET.Name = "LogFileET";
            this.LogFileET.Size = new System.Drawing.Size(869, 26);
            this.LogFileET.TabIndex = 2;
            this.LogFileET.Text = "C:\\Users\\mmuel_000\\Dropbox\\Scripts and Notes\\2016\\04 - April\\ASC-LCC-BLD-6455.log" +
    "";
            // 
            // ResultsET
            // 
            this.ResultsET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsET.Location = new System.Drawing.Point(16, 59);
            this.ResultsET.Multiline = true;
            this.ResultsET.Name = "ResultsET";
            this.ResultsET.ReadOnly = true;
            this.ResultsET.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsET.Size = new System.Drawing.Size(1013, 380);
            this.ResultsET.TabIndex = 3;
            this.ResultsET.WordWrap = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 451);
            this.Controls.Add(this.ResultsET);
            this.Controls.Add(this.LogFileET);
            this.Controls.Add(this.ParsePB);
            this.Controls.Add(this.LogFileST);
            this.Name = "MainView";
            this.Text = "Bamboo Log Parsee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogFileST;
        private System.Windows.Forms.Button ParsePB;
        private System.Windows.Forms.TextBox LogFileET;
        private System.Windows.Forms.TextBox ResultsET;
    }
}

