namespace MkvMergeTool {
    partial class VideoMergeTool {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.txtSubtitlePath = new System.Windows.Forms.TextBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnStartMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtitle Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output Path";
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(168, 31);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.Size = new System.Drawing.Size(366, 20);
            this.txtInputPath.TabIndex = 4;
            // 
            // txtSubtitlePath
            // 
            this.txtSubtitlePath.Location = new System.Drawing.Point(168, 73);
            this.txtSubtitlePath.Name = "txtSubtitlePath";
            this.txtSubtitlePath.Size = new System.Drawing.Size(366, 20);
            this.txtSubtitlePath.TabIndex = 5;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(168, 119);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(366, 20);
            this.txtOutputPath.TabIndex = 6;
            // 
            // btnStartMerge
            // 
            this.btnStartMerge.Location = new System.Drawing.Point(393, 172);
            this.btnStartMerge.Name = "btnStartMerge";
            this.btnStartMerge.Size = new System.Drawing.Size(141, 23);
            this.btnStartMerge.TabIndex = 8;
            this.btnStartMerge.Text = "Start Merge";
            this.btnStartMerge.UseVisualStyleBackColor = true;
            this.btnStartMerge.Click += new System.EventHandler(this.btnStartMerge_Click);
            // 
            // VideoMergeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 225);
            this.Controls.Add(this.btnStartMerge);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtSubtitlePath);
            this.Controls.Add(this.txtInputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VideoMergeTool";
            this.Text = "Video Merge Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.TextBox txtSubtitlePath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnStartMerge;
    }
}

