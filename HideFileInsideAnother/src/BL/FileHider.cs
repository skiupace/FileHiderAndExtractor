using System.IO;
using System.Windows.Forms;

namespace HideFileInsideAnother.src.BL {
    public class FileHider {
        public static void HideFile(string destFilePath, string sourceFilePath, int fileLength) {
            byte[] sourceFileBytes = File.ReadAllBytes(sourceFilePath);
            byte[] selectedFileBytes = File.ReadAllBytes(destFilePath);

            string extension = "." + Path.GetExtension(sourceFilePath).TrimStart('.');
            int extLength = extension.Length;

            int destFileBytesSize = selectedFileBytes.Length + fileLength + extLength;
            byte[] destFileBytes = new byte[destFileBytesSize];

            for (int i = 0; i < selectedFileBytes.Length; ++i)
                destFileBytes[i] = selectedFileBytes[i];


            int indexCounter = 0;
            int sourceFileStart = destFileBytesSize - fileLength - extLength;
            int sourceFileEnd = destFileBytesSize - extLength;

            for (int i = sourceFileStart; i < sourceFileEnd; ++i)
                destFileBytes[i] = sourceFileBytes[indexCounter++];

            indexCounter = 0;
            for (int i = sourceFileEnd; i < destFileBytesSize; ++i)
                destFileBytes[i] = (byte)extension[indexCounter++];
            File.WriteAllBytes(destFilePath, destFileBytes);

            DialogResult result = MessageBox.Show(
                "Do you want to delete the source file after hiding it?",
                "Alert!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                File.Delete(sourceFilePath);
        }
    }
}
