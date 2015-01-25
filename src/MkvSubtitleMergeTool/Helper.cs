using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkvMergeTool {
    public static class Helper {

        public static void MkvMerge(string videoInputPath, string subtitleInputPath, string mkvOutputPath) {
            const string mkvMergeExePath = "mkvmerge.exe";
            var process = new Process();
            var startInfo = new ProcessStartInfo {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = mkvMergeExePath
            };

            var parameters = string.Format(" -o \"{0}\" \"{1}\" \"{2}\"", mkvOutputPath, videoInputPath, subtitleInputPath);
            startInfo.Arguments = parameters;
            process.StartInfo = startInfo;
            process.Start();
        }

        public static IEnumerable<string> GetVideoFiles(string folderPath) {
            var files = Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".mkv") || s.EndsWith(".avi") || s.EndsWith(".mp4") || s.EndsWith(".flv"));
            return files;
        }
    }
}
