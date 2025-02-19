namespace HideFileInsideAnother.src.PL {
    partial class FRM_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.titleBar_Panel = new System.Windows.Forms.Panel();
            this.aboutProgram_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeWindow_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeWindow_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.windowTitle_Label = new System.Windows.Forms.Label();
            this.windowBody_Panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileLength_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retriveTheHiddenFile_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.destFile_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.sourceFile_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.titleBar_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutProgram_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow_Button)).BeginInit();
            this.windowBody_Panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar_Panel
            // 
            this.titleBar_Panel.BackColor = System.Drawing.Color.LightGray;
            this.titleBar_Panel.Controls.Add(this.aboutProgram_Button);
            this.titleBar_Panel.Controls.Add(this.minimizeWindow_Button);
            this.titleBar_Panel.Controls.Add(this.closeWindow_Button);
            this.titleBar_Panel.Controls.Add(this.windowTitle_Label);
            this.titleBar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar_Panel.Location = new System.Drawing.Point(0, 0);
            this.titleBar_Panel.Name = "titleBar_Panel";
            this.titleBar_Panel.Size = new System.Drawing.Size(652, 39);
            this.titleBar_Panel.TabIndex = 0;
            this.titleBar_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Panel_MouseDown);
            this.titleBar_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Panel_MouseMove);
            this.titleBar_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Panel_MouseUp);
            // 
            // aboutProgram_Button
            // 
            this.aboutProgram_Button.BackColor = System.Drawing.Color.Transparent;
            this.aboutProgram_Button.Image = global::HideFileInsideAnother.Properties.Resources.information_button;
            this.aboutProgram_Button.ImageActive = null;
            this.aboutProgram_Button.Location = new System.Drawing.Point(9, 5);
            this.aboutProgram_Button.Name = "aboutProgram_Button";
            this.aboutProgram_Button.Size = new System.Drawing.Size(33, 30);
            this.aboutProgram_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutProgram_Button.TabIndex = 1;
            this.aboutProgram_Button.TabStop = false;
            this.aboutProgram_Button.Zoom = 10;
            this.aboutProgram_Button.Click += new System.EventHandler(this.AboutProgram_Button_Click);
            // 
            // minimizeWindow_Button
            // 
            this.minimizeWindow_Button.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow_Button.Image = global::HideFileInsideAnother.Properties.Resources.minimize_window;
            this.minimizeWindow_Button.ImageActive = null;
            this.minimizeWindow_Button.Location = new System.Drawing.Point(570, 5);
            this.minimizeWindow_Button.Name = "minimizeWindow_Button";
            this.minimizeWindow_Button.Size = new System.Drawing.Size(33, 30);
            this.minimizeWindow_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeWindow_Button.TabIndex = 1;
            this.minimizeWindow_Button.TabStop = false;
            this.minimizeWindow_Button.Zoom = 10;
            this.minimizeWindow_Button.Click += new System.EventHandler(this.MinimizeWindow_Button_Click);
            // 
            // closeWindow_Button
            // 
            this.closeWindow_Button.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow_Button.Image = global::HideFileInsideAnother.Properties.Resources.close_window;
            this.closeWindow_Button.ImageActive = null;
            this.closeWindow_Button.Location = new System.Drawing.Point(609, 5);
            this.closeWindow_Button.Name = "closeWindow_Button";
            this.closeWindow_Button.Size = new System.Drawing.Size(33, 30);
            this.closeWindow_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeWindow_Button.TabIndex = 1;
            this.closeWindow_Button.TabStop = false;
            this.closeWindow_Button.Zoom = 10;
            this.closeWindow_Button.Click += new System.EventHandler(this.CloseWindow_Button_Click);
            // 
            // windowTitle_Label
            // 
            this.windowTitle_Label.AutoSize = true;
            this.windowTitle_Label.Location = new System.Drawing.Point(265, 8);
            this.windowTitle_Label.Name = "windowTitle_Label";
            this.windowTitle_Label.Size = new System.Drawing.Size(122, 25);
            this.windowTitle_Label.TabIndex = 0;
            this.windowTitle_Label.Text = "إخفاء الملفات";
            // 
            // windowBody_Panel
            // 
            this.windowBody_Panel.Controls.Add(this.groupBox2);
            this.windowBody_Panel.Controls.Add(this.groupBox1);
            this.windowBody_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowBody_Panel.Location = new System.Drawing.Point(0, 39);
            this.windowBody_Panel.Name = "windowBody_Panel";
            this.windowBody_Panel.Size = new System.Drawing.Size(652, 475);
            this.windowBody_Panel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileLength_TextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(631, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طول الملف";
            // 
            // fileLength_TextBox
            // 
            this.fileLength_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileLength_TextBox.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLength_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileLength_TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.fileLength_TextBox.HintText = "";
            this.fileLength_TextBox.isPassword = false;
            this.fileLength_TextBox.LineFocusedColor = System.Drawing.Color.Teal;
            this.fileLength_TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.fileLength_TextBox.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.fileLength_TextBox.LineThickness = 5;
            this.fileLength_TextBox.Location = new System.Drawing.Point(191, 29);
            this.fileLength_TextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fileLength_TextBox.Name = "fileLength_TextBox";
            this.fileLength_TextBox.Size = new System.Drawing.Size(249, 35);
            this.fileLength_TextBox.TabIndex = 4;
            this.fileLength_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(317, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "قُم بحفظ الحجم حتى تستطيع إسترداد الملف";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retriveTheHiddenFile_Button);
            this.groupBox1.Controls.Add(this.destFile_LinkLabel);
            this.groupBox1.Controls.Add(this.sourceFile_LinkLabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(631, 334);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "رفع الملفات";
            // 
            // retriveTheHiddenFile_Button
            // 
            this.retriveTheHiddenFile_Button.ActiveBorderThickness = 1;
            this.retriveTheHiddenFile_Button.ActiveCornerRadius = 20;
            this.retriveTheHiddenFile_Button.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.retriveTheHiddenFile_Button.ActiveForecolor = System.Drawing.Color.White;
            this.retriveTheHiddenFile_Button.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.retriveTheHiddenFile_Button.BackColor = System.Drawing.SystemColors.Control;
            this.retriveTheHiddenFile_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retriveTheHiddenFile_Button.BackgroundImage")));
            this.retriveTheHiddenFile_Button.ButtonText = "إسترداد الملف المخفي";
            this.retriveTheHiddenFile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retriveTheHiddenFile_Button.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retriveTheHiddenFile_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.retriveTheHiddenFile_Button.IdleBorderThickness = 1;
            this.retriveTheHiddenFile_Button.IdleCornerRadius = 20;
            this.retriveTheHiddenFile_Button.IdleFillColor = System.Drawing.Color.White;
            this.retriveTheHiddenFile_Button.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.retriveTheHiddenFile_Button.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.retriveTheHiddenFile_Button.Location = new System.Drawing.Point(228, 272);
            this.retriveTheHiddenFile_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.retriveTheHiddenFile_Button.Name = "retriveTheHiddenFile_Button";
            this.retriveTheHiddenFile_Button.Size = new System.Drawing.Size(175, 51);
            this.retriveTheHiddenFile_Button.TabIndex = 5;
            this.retriveTheHiddenFile_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.retriveTheHiddenFile_Button.Click += new System.EventHandler(this.RetriveTheHiddenFile_Button_Click);
            // 
            // destFile_LinkLabel
            // 
            this.destFile_LinkLabel.AutoSize = true;
            this.destFile_LinkLabel.Location = new System.Drawing.Point(132, 225);
            this.destFile_LinkLabel.Name = "destFile_LinkLabel";
            this.destFile_LinkLabel.Size = new System.Drawing.Size(148, 25);
            this.destFile_LinkLabel.TabIndex = 4;
            this.destFile_LinkLabel.TabStop = true;
            this.destFile_LinkLabel.Text = "حدد ملف الوجهه";
            this.destFile_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DestFile_LinkLabel_LinkClicked);
            // 
            // sourceFile_LinkLabel
            // 
            this.sourceFile_LinkLabel.AutoSize = true;
            this.sourceFile_LinkLabel.Location = new System.Drawing.Point(353, 225);
            this.sourceFile_LinkLabel.Name = "sourceFile_LinkLabel";
            this.sourceFile_LinkLabel.Size = new System.Drawing.Size(146, 25);
            this.sourceFile_LinkLabel.TabIndex = 5;
            this.sourceFile_LinkLabel.TabStop = true;
            this.sourceFile_LinkLabel.Text = "حدد ملف المصدر";
            this.sourceFile_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceFile_LinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HideFileInsideAnother.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(343, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HideFileInsideAnother.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(121, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 20;
            this.bunifuElipse.TargetControl = this;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 514);
            this.Controls.Add(this.windowBody_Panel);
            this.Controls.Add(this.titleBar_Panel);
            this.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.titleBar_Panel.ResumeLayout(false);
            this.titleBar_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutProgram_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow_Button)).EndInit();
            this.windowBody_Panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar_Panel;
        private System.Windows.Forms.Panel windowBody_Panel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Label windowTitle_Label;
        private Bunifu.Framework.UI.BunifuImageButton aboutProgram_Button;
        private Bunifu.Framework.UI.BunifuImageButton minimizeWindow_Button;
        private Bunifu.Framework.UI.BunifuImageButton closeWindow_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel destFile_LinkLabel;
        private System.Windows.Forms.LinkLabel sourceFile_LinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fileLength_TextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 retriveTheHiddenFile_Button;
    }
}

