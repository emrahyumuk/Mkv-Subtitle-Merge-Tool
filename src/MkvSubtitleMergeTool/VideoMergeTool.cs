using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkvMergeTool {
    public partial class VideoMergeTool : Form {
        public VideoMergeTool() {
            InitializeComponent();
        }

        private void btnStartMerge_Click(object sender, EventArgs e) {
            Helper.MkvMerge(txtInputPath.Text, txtSubtitlePath.Text, txtOutputPath.Text);
        }
    }

    
}
