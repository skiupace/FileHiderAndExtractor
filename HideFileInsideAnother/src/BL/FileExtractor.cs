using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HideFileInsideAnother.src.BL {
    public class FileExtractor {
        public static void ExtractHiddenFile(string destFilePath, int fileLength) {
            byte[] destFileBytes = File.ReadAllBytes(destFilePath);
            int hiddenFileDataLength = fileLength;

            // Find the last occurrence of the '.' delimiter in destFileBytes.
            int lastDotIndex = Array.LastIndexOf(destFileBytes, (byte)'.');
            if (lastDotIndex == -1) {
                MessageBox.Show("Extension delimiter not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Everything from the lastDotIndex to the end is considered the extension.
            int extLength = destFileBytes.Length - lastDotIndex;
            string extension = Encoding.UTF8.GetString(destFileBytes, lastDotIndex, extLength);

            // The hidden file data is the bytes just before the extension.
            int hiddenFileStart = destFileBytes.Length - (hiddenFileDataLength + extLength);

            if (hiddenFileStart < 0) {
                MessageBox.Show("The calculated start of the hidden file is invalid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] originalFileBytes = new byte[hiddenFileDataLength];
            Array.Copy(destFileBytes, hiddenFileStart, originalFileBytes, 0, hiddenFileDataLength);

            Array.Clear(destFileBytes, hiddenFileStart, hiddenFileDataLength + extLength);
            Array.Resize(ref destFileBytes, destFileBytes.Length - (hiddenFileDataLength + extLength));
            File.WriteAllBytes(destFilePath, destFileBytes);

            // Save the extracted file with the retrieved extension appended to the file name.
            string outputFilePath = $@"D:\extracted_file{extension}";
            File.WriteAllBytes(outputFilePath, originalFileBytes);
            MessageBox.Show($"Hidden file extracted as: {outputFilePath}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
