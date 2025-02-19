using System;
using System.IO;
using System.Windows.Forms;
using HideFileInsideAnother.src.BL;

namespace HideFileInsideAnother.src.PL {
    public partial class FRM_Main : Form {
        public FRM_Main() => InitializeComponent();

        #region TitleBar Buttons

        private void CloseWindow_Button_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MinimizeWindow_Button_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;
        }

        #endregion

        #region Make Title Bar Draggable

        private void TitleBar_Panel_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
            mouseXCoord = e.X;
            mouseYCoord = e.Y;
        }

        private void TitleBar_Panel_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
        }

        private void TitleBar_Panel_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown) {
                int currentMouseCoordX = MousePosition.X - mouseXCoord;
                int currentMouseCoordY = MousePosition.Y - mouseYCoord;
                SetDesktopLocation(currentMouseCoordX, currentMouseCoordY);
            }
        }

        #endregion

        #region File Uploading

        private void SourceFile_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select the source file";
            openFile.Filter = "All Files|*.*";
            
            try {
                DialogResult result = openFile.ShowDialog();
                if (result == DialogResult.OK) {
                    sourceFilePath = openFile.FileName;
                    sourceFileBytes = File.ReadAllBytes(openFile.FileName);
                    fileLength_TextBox.Text = sourceFileBytes.Length.ToString();
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DestFile_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select the destination file";
            openFile.Filter = "All Files|*.*";

            try {
                DialogResult result = openFile.ShowDialog();
                if (result == DialogResult.OK) {
                    if (!int.TryParse(fileLength_TextBox.Text, out int fileLength)) {
                        MessageBox.Show("Can't input a text inside file length field!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FileHider.HideFile(openFile.FileName, sourceFilePath, fileLength);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Retrive Hidden File

        private void RetriveTheHiddenFile_Button_Click(object sender, EventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select the source file";
            openFile.Filter = "All Files|*.*";
            
            try {
                if (string.IsNullOrEmpty(fileLength_TextBox.Text)) {
                    MessageBox.Show("Can't leave the length empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = openFile.ShowDialog();
                if (result == DialogResult.OK) {
                    if (!int.TryParse(fileLength_TextBox.Text, out int fileLength)) {
                        MessageBox.Show("Can't input a text inside file length field!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    FileExtractor.ExtractHiddenFile(openFile.FileName, fileLength);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region About Program

        private void AboutProgram_Button_Click(object sender, EventArgs e) {
            MessageBox.Show(@"Made with love by : 
            @skiupace => x.com and github", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Form Attributes

        private int mouseXCoord;
        private int mouseYCoord;
        private bool isMouseDown;

        private string sourceFilePath;
        private byte[] sourceFileBytes;

        #endregion
    }
}
