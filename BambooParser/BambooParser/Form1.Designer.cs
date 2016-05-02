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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ThresholdST = new System.Windows.Forms.Label();
            this.ThresholdET = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdET)).BeginInit();
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
            this.ResultsET.Location = new System.Drawing.Point(16, 135);
            this.ResultsET.Multiline = true;
            this.ResultsET.Name = "ResultsET";
            this.ResultsET.ReadOnly = true;
            this.ResultsET.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsET.Size = new System.Drawing.Size(1013, 304);
            this.ResultsET.TabIndex = 3;
            this.ResultsET.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ThresholdET);
            this.groupBox1.Controls.Add(this.ThresholdST);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ThresholdST
            // 
            this.ThresholdST.AutoSize = true;
            this.ThresholdST.Location = new System.Drawing.Point(6, 28);
            this.ThresholdST.Name = "ThresholdST";
            this.ThresholdST.Size = new System.Drawing.Size(133, 20);
            this.ThresholdST.TabIndex = 1;
            this.ThresholdST.Text = "Threshold (in MS)";
            // 
            // ThresholdET
            // 
            this.ThresholdET.Location = new System.Drawing.Point(145, 26);
            this.ThresholdET.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ThresholdET.Name = "ThresholdET";
            this.ThresholdET.Size = new System.Drawing.Size(120, 26);
            this.ThresholdET.TabIndex = 5;
            this.ThresholdET.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ResultsET);
            this.Controls.Add(this.LogFileET);
            this.Controls.Add(this.ParsePB);
            this.Controls.Add(this.LogFileST);
            this.Name = "MainView";
            this.Text = "Bamboo Log Parsee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogFileST;
        private System.Windows.Forms.Button ParsePB;
        private System.Windows.Forms.TextBox LogFileET;
        private System.Windows.Forms.TextBox ResultsET;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ThresholdET;
        private System.Windows.Forms.Label ThresholdST;
    }
}

