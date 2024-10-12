namespace WinFormsUI
{
    partial class DisplayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            MD5Label = new Label();
            SHA1Label = new Label();
            SHA256Label = new Label();
            SHA512Label = new Label();
            SHA384Label = new Label();
            SHA512ValueLabel = new Label();
            SHA384ValueLabel = new Label();
            SHA256ValueLabel = new Label();
            SHA1ValueLabel = new Label();
            MD5ValueLabel = new Label();
            MD5ClipboardLabel = new Label();
            SHA1ClipboardLabel = new Label();
            SHA256ClipboardLabel = new Label();
            SHA384ClipboardLabel = new Label();
            SHA512ClipboardLabel = new Label();
            DragAndDropPictureBox = new PictureBox();
            panel1 = new Panel();
            FileLabel = new Label();
            FileNameValueLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DragAndDropPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MD5Label
            // 
            MD5Label.AutoSize = true;
            MD5Label.Font = new Font("Segoe UI Emoji", 10F);
            MD5Label.ForeColor = SystemColors.ButtonFace;
            MD5Label.Location = new Point(54, 39);
            MD5Label.Name = "MD5Label";
            MD5Label.Size = new Size(43, 19);
            MD5Label.TabIndex = 0;
            MD5Label.Text = "MD5:";
            // 
            // SHA1Label
            // 
            SHA1Label.AutoSize = true;
            SHA1Label.Font = new Font("Segoe UI Emoji", 10F);
            SHA1Label.ForeColor = SystemColors.ButtonFace;
            SHA1Label.Location = new Point(51, 60);
            SHA1Label.Name = "SHA1Label";
            SHA1Label.Size = new Size(46, 19);
            SHA1Label.TabIndex = 1;
            SHA1Label.Text = "SHA1:";
            // 
            // SHA256Label
            // 
            SHA256Label.AutoSize = true;
            SHA256Label.Font = new Font("Segoe UI Emoji", 10F);
            SHA256Label.ForeColor = SystemColors.ButtonFace;
            SHA256Label.Location = new Point(35, 81);
            SHA256Label.Name = "SHA256Label";
            SHA256Label.Size = new Size(62, 19);
            SHA256Label.TabIndex = 2;
            SHA256Label.Text = "SHA256:";
            // 
            // SHA512Label
            // 
            SHA512Label.AutoSize = true;
            SHA512Label.Font = new Font("Segoe UI Emoji", 10F);
            SHA512Label.ForeColor = SystemColors.ButtonFace;
            SHA512Label.Location = new Point(35, 123);
            SHA512Label.Name = "SHA512Label";
            SHA512Label.Size = new Size(62, 19);
            SHA512Label.TabIndex = 4;
            SHA512Label.Tag = "";
            SHA512Label.Text = "SHA512:";
            // 
            // SHA384Label
            // 
            SHA384Label.AutoSize = true;
            SHA384Label.Font = new Font("Segoe UI Emoji", 10F);
            SHA384Label.ForeColor = SystemColors.ButtonFace;
            SHA384Label.Location = new Point(35, 102);
            SHA384Label.Name = "SHA384Label";
            SHA384Label.Size = new Size(62, 19);
            SHA384Label.TabIndex = 3;
            SHA384Label.Text = "SHA384:";
            // 
            // SHA512ValueLabel
            // 
            SHA512ValueLabel.AutoSize = true;
            SHA512ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            SHA512ValueLabel.ForeColor = SystemColors.ButtonFace;
            SHA512ValueLabel.Location = new Point(108, 123);
            SHA512ValueLabel.Name = "SHA512ValueLabel";
            SHA512ValueLabel.Size = new Size(79, 19);
            SHA512ValueLabel.TabIndex = 12;
            SHA512ValueLabel.Tag = "";
            SHA512ValueLabel.Text = "<SHA512>";
            SHA512ValueLabel.Visible = false;
            // 
            // SHA384ValueLabel
            // 
            SHA384ValueLabel.AutoSize = true;
            SHA384ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            SHA384ValueLabel.ForeColor = SystemColors.ButtonFace;
            SHA384ValueLabel.Location = new Point(108, 102);
            SHA384ValueLabel.Name = "SHA384ValueLabel";
            SHA384ValueLabel.Size = new Size(79, 19);
            SHA384ValueLabel.TabIndex = 11;
            SHA384ValueLabel.Text = "<SHA384>";
            SHA384ValueLabel.Visible = false;
            // 
            // SHA256ValueLabel
            // 
            SHA256ValueLabel.AutoSize = true;
            SHA256ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            SHA256ValueLabel.ForeColor = SystemColors.ButtonFace;
            SHA256ValueLabel.Location = new Point(108, 81);
            SHA256ValueLabel.Name = "SHA256ValueLabel";
            SHA256ValueLabel.Size = new Size(79, 19);
            SHA256ValueLabel.TabIndex = 10;
            SHA256ValueLabel.Text = "<SHA256>";
            SHA256ValueLabel.Visible = false;
            // 
            // SHA1ValueLabel
            // 
            SHA1ValueLabel.AutoSize = true;
            SHA1ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            SHA1ValueLabel.ForeColor = SystemColors.ButtonFace;
            SHA1ValueLabel.Location = new Point(108, 60);
            SHA1ValueLabel.Name = "SHA1ValueLabel";
            SHA1ValueLabel.Size = new Size(63, 19);
            SHA1ValueLabel.TabIndex = 9;
            SHA1ValueLabel.Text = "<SHA1>";
            SHA1ValueLabel.Visible = false;
            // 
            // MD5ValueLabel
            // 
            MD5ValueLabel.AutoSize = true;
            MD5ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            MD5ValueLabel.ForeColor = SystemColors.ButtonFace;
            MD5ValueLabel.Location = new Point(108, 39);
            MD5ValueLabel.Name = "MD5ValueLabel";
            MD5ValueLabel.Size = new Size(60, 19);
            MD5ValueLabel.TabIndex = 8;
            MD5ValueLabel.Text = "<MD5>";
            MD5ValueLabel.Visible = false;
            // 
            // MD5ClipboardLabel
            // 
            MD5ClipboardLabel.AutoSize = true;
            MD5ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            MD5ClipboardLabel.Location = new Point(1, 39);
            MD5ClipboardLabel.Name = "MD5ClipboardLabel";
            MD5ClipboardLabel.Size = new Size(29, 21);
            MD5ClipboardLabel.TabIndex = 13;
            MD5ClipboardLabel.Text = "📋";
            MD5ClipboardLabel.Click += MD5ClipboardLabel_Click;
            MD5ClipboardLabel.MouseEnter += Label_MouseEnter;
            MD5ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // SHA1ClipboardLabel
            // 
            SHA1ClipboardLabel.AutoSize = true;
            SHA1ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            SHA1ClipboardLabel.Location = new Point(1, 60);
            SHA1ClipboardLabel.Name = "SHA1ClipboardLabel";
            SHA1ClipboardLabel.Size = new Size(29, 21);
            SHA1ClipboardLabel.TabIndex = 14;
            SHA1ClipboardLabel.Text = "📋";
            SHA1ClipboardLabel.Click += SHA1ClipboardLabel_Click;
            SHA1ClipboardLabel.MouseEnter += Label_MouseEnter;
            SHA1ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // SHA256ClipboardLabel
            // 
            SHA256ClipboardLabel.AutoSize = true;
            SHA256ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            SHA256ClipboardLabel.Location = new Point(1, 81);
            SHA256ClipboardLabel.Name = "SHA256ClipboardLabel";
            SHA256ClipboardLabel.Size = new Size(29, 21);
            SHA256ClipboardLabel.TabIndex = 15;
            SHA256ClipboardLabel.Text = "📋";
            SHA256ClipboardLabel.Click += SHA256ClipboardLabel_Click;
            SHA256ClipboardLabel.MouseEnter += Label_MouseEnter;
            SHA256ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // SHA384ClipboardLabel
            // 
            SHA384ClipboardLabel.AutoSize = true;
            SHA384ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            SHA384ClipboardLabel.Location = new Point(1, 102);
            SHA384ClipboardLabel.Name = "SHA384ClipboardLabel";
            SHA384ClipboardLabel.Size = new Size(29, 21);
            SHA384ClipboardLabel.TabIndex = 16;
            SHA384ClipboardLabel.Text = "📋";
            SHA384ClipboardLabel.Click += SHA384ClipboardLabel_Click;
            SHA384ClipboardLabel.MouseEnter += Label_MouseEnter;
            SHA384ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // SHA512ClipboardLabel
            // 
            SHA512ClipboardLabel.AutoSize = true;
            SHA512ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            SHA512ClipboardLabel.Location = new Point(1, 123);
            SHA512ClipboardLabel.Name = "SHA512ClipboardLabel";
            SHA512ClipboardLabel.Size = new Size(29, 21);
            SHA512ClipboardLabel.TabIndex = 17;
            SHA512ClipboardLabel.Text = "📋";
            SHA512ClipboardLabel.Click += SHA512ClipboardLabel_Click;
            SHA512ClipboardLabel.MouseEnter += Label_MouseEnter;
            SHA512ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // DragAndDropPictureBox
            // 
            DragAndDropPictureBox.Image = (Image)resources.GetObject("DragAndDropPictureBox.Image");
            DragAndDropPictureBox.Location = new Point(24, 28);
            DragAndDropPictureBox.Margin = new Padding(3, 2, 3, 2);
            DragAndDropPictureBox.Name = "DragAndDropPictureBox";
            DragAndDropPictureBox.Size = new Size(267, 183);
            DragAndDropPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DragAndDropPictureBox.TabIndex = 18;
            DragAndDropPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(FileLabel);
            panel1.Controls.Add(FileNameValueLabel);
            panel1.Controls.Add(SHA256ValueLabel);
            panel1.Controls.Add(MD5Label);
            panel1.Controls.Add(SHA1Label);
            panel1.Controls.Add(SHA512ClipboardLabel);
            panel1.Controls.Add(SHA256Label);
            panel1.Controls.Add(SHA384ClipboardLabel);
            panel1.Controls.Add(SHA384Label);
            panel1.Controls.Add(SHA256ClipboardLabel);
            panel1.Controls.Add(SHA512Label);
            panel1.Controls.Add(SHA1ClipboardLabel);
            panel1.Controls.Add(MD5ValueLabel);
            panel1.Controls.Add(MD5ClipboardLabel);
            panel1.Controls.Add(SHA1ValueLabel);
            panel1.Controls.Add(SHA512ValueLabel);
            panel1.Controls.Add(SHA384ValueLabel);
            panel1.Location = new Point(24, 229);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 153);
            panel1.TabIndex = 19;
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Font = new Font("Segoe UI Emoji", 10F);
            FileLabel.ForeColor = SystemColors.ButtonFace;
            FileLabel.Location = new Point(65, 7);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(32, 19);
            FileLabel.TabIndex = 18;
            FileLabel.Tag = "";
            FileLabel.Text = "File:";
            // 
            // FileNameValueLabel
            // 
            FileNameValueLabel.AutoSize = true;
            FileNameValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            FileNameValueLabel.ForeColor = SystemColors.ButtonFace;
            FileNameValueLabel.Location = new Point(108, 7);
            FileNameValueLabel.Name = "FileNameValueLabel";
            FileNameValueLabel.Size = new Size(89, 19);
            FileNameValueLabel.TabIndex = 19;
            FileNameValueLabel.Tag = "";
            FileNameValueLabel.Text = "<File Name>";
            FileNameValueLabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 89);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // DisplayForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(326, 396);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(DragAndDropPictureBox);
            Font = new Font("Segoe UI Emoji", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DisplayForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FileHasher";
            DragDrop += DisplayForm_DragDrop;
            DragEnter += DisplayForm_DragEnter;
            ((System.ComponentModel.ISupportInitialize)DragAndDropPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label MD5Label;
        private Label SHA1Label;
        private Label SHA256Label;
        private Label SHA512Label;
        private Label SHA384Label;
        private Label SHA512ValueLabel;
        private Label SHA384ValueLabel;
        private Label SHA256ValueLabel;
        private Label SHA1ValueLabel;
        private Label MD5ValueLabel;
        private Label MD5ClipboardLabel;
        private Label SHA1ClipboardLabel;
        private Label SHA256ClipboardLabel;
        private Label SHA384ClipboardLabel;
        private Label SHA512ClipboardLabel;
        private PictureBox DragAndDropPictureBox;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label FileLabel;
        private Label FileNameValueLabel;
    }
}
