using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkvSubtitleMergeTool {
    public partial class VideoFolderMergeTool : Form {
        public VideoFolderMergeTool() {
            InitializeComponent();
        }

        private void btnStartMerge_Click(object sender, EventArgs e) {
            var inputVideoPaths = Helper.GetVideoFiles(txtInputFolderPath.Text);
            if (!Directory.Exists(txtOutputFolderPath.Text)) {
                Directory.CreateDirectory(txtOutputFolderPath.Text);
            }
            var outputVideoFileNames = Helper.GetVideoFiles(txtOutputFolderPath.Text).Select(Path.GetFileNameWithoutExtension).ToList();
            foreach (var inputVideoPath in inputVideoPaths) {
                var fileName = Path.GetFileNameWithoutExtension(inputVideoPath);
                if (fileName == null || outputVideoFileNames.Contains(fileName)) continue;
                var subtitlePath = Path.Combine(txtInputFolderPath.Text, fileName) + ".srt";
                if (!File.Exists(subtitlePath)) continue;
                var outputFilePath = Path.Combine(txtOutputFolderPath.Text, fileName) + ".mkv";

                Helper.MkvMerge(inputVideoPath, subtitlePath, outputFilePath);
            }

        }
    }
}
