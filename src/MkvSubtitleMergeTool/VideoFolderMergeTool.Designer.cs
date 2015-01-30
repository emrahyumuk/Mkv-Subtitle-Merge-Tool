namespace MkvSubtitleMergeTool {
    partial class VideoFolderMergeTool {
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
            this.btnStartMerge = new System.Windows.Forms.Button();
            this.txtOutputFolderPath = new System.Windows.Forms.TextBox();
            this.txtInputFolderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartMerge
            // 
            this.btnStartMerge.Location = new System.Drawing.Point(378, 109);
            this.btnStartMerge.Name = "btnStartMerge";
            this.btnStartMerge.Size = new System.Drawing.Size(141, 23);
            this.btnStartMerge.TabIndex = 15;
            this.btnStartMerge.Text = "Start Merge";
            this.btnStartMerge.UseVisualStyleBackColor = true;
            this.btnStartMerge.Click += new System.EventHandler(this.btnStartMerge_Click);
            // 
            // txtOutputFolderPath
            // 
            this.txtOutputFolderPath.Location = new System.Drawing.Point(153, 60);
            this.txtOutputFolderPath.Name = "txtOutputFolderPath";
            this.txtOutputFolderPath.Size = new System.Drawing.Size(366, 20);
            this.txtOutputFolderPath.TabIndex = 14;
            // 
            // txtInputFolderPath
            // 
            this.txtInputFolderPath.Location = new System.Drawing.Point(153, 22);
            this.txtInputFolderPath.Name = "txtInputFolderPath";
            this.txtInputFolderPath.Size = new System.Drawing.Size(366, 20);
            this.txtInputFolderPath.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output Folder Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input Folder Path";
            // 
            // FolderMergeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 150);
            this.Controls.Add(this.btnStartMerge);
            this.Controls.Add(this.txtOutputFolderPath);
            this.Controls.Add(this.txtInputFolderPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FolderMergeTool";
            this.Text = "Folder Merge Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartMerge;
        private System.Windows.Forms.TextBox txtOutputFolderPath;
        private System.Windows.Forms.TextBox txtInputFolderPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}