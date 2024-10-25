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
            HashesPanel_MD5Label = new Label();
            HashesPanel_SHA1Label = new Label();
            HashesPanel_SHA256Label = new Label();
            HashesPanel_SHA512Label = new Label();
            HashesPanel_SHA384Label = new Label();
            HashesPanel_SHA512ValueLabel = new Label();
            HashesPanel_SHA384ValueLabel = new Label();
            HashesPanel_SHA256ValueLabel = new Label();
            HashesPanel_SHA1ValueLabel = new Label();
            HashesPanel_MD5ValueLabel = new Label();
            HashesPanel_MD5ClipboardLabel = new Label();
            HashesPanel_SHA1ClipboardLabel = new Label();
            HashesPanel_SHA256ClipboardLabel = new Label();
            HashesPanel_SHA384ClipboardLabel = new Label();
            HashesPanel_SHA512ClipboardLabel = new Label();
            HashesPanel_DragAndDropPictureBox = new PictureBox();
            HashesPanel_AlgorithmsPanel = new Panel();
            HashesPanel_FileNameValueLabel = new Label();
            HashesPanel_DropFilePictureBox = new PictureBox();
            MenuStrip = new MenuStrip();
            HashesToolStripMenuItem = new ToolStripMenuItem();
            ValidateToolStripMenuItem = new ToolStripMenuItem();
            CompareToolStripMenuItem = new ToolStripMenuItem();
            QuestionMarkToolStripMenuItem = new ToolStripMenuItem();
            HashesPanel = new Panel();
            HashesPanel_BrowseLabel = new Label();
            HashesPanel_TrashLabel = new Label();
            ValidatePanel = new Panel();
            ValidatePanel_BrowseLabel = new Label();
            ValidatePanel_TrashLabel = new Label();
            ValidatePanel_DropFilePictureBox = new PictureBox();
            ValidatePanel_FileNameValueLabel = new Label();
            ValidatePanel_DragAndDropPictureBox = new PictureBox();
            ValidatePanel_InputHashPanel = new Panel();
            ValidatePanel_ResultValueLabel = new Label();
            ValidatePanel_ResultLabel = new Label();
            ValidatePanel_ExpectedHashTextBox = new TextBox();
            ValidatePanel_AlgorithmComboBox = new ComboBox();
            ValidatePanel_ExpectedLabel = new Label();
            ComparePanel = new Panel();
            ComparePanel_DropFilePictureBox = new PictureBox();
            ComparePanel_DragAndDropPictureBox = new PictureBox();
            ComparePanel_ResultValueLabel = new Label();
            ComparePanel_ResultLabel = new Label();
            ComparePanel_BrowseLabel2 = new Label();
            ComparePanel_TrashLabel2 = new Label();
            ComparePanel_FileNameValueLabel2 = new Label();
            ComparePanel_BrowseLabel1 = new Label();
            ComparePanel_TrashLabel1 = new Label();
            ComparePanel_FileNameValueLabel1 = new Label();
            ((System.ComponentModel.ISupportInitialize)HashesPanel_DragAndDropPictureBox).BeginInit();
            HashesPanel_AlgorithmsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HashesPanel_DropFilePictureBox).BeginInit();
            MenuStrip.SuspendLayout();
            HashesPanel.SuspendLayout();
            ValidatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ValidatePanel_DropFilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValidatePanel_DragAndDropPictureBox).BeginInit();
            ValidatePanel_InputHashPanel.SuspendLayout();
            ComparePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComparePanel_DropFilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComparePanel_DragAndDropPictureBox).BeginInit();
            SuspendLayout();
            // 
            // HashesPanel_MD5Label
            // 
            HashesPanel_MD5Label.AutoSize = true;
            HashesPanel_MD5Label.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_MD5Label.ForeColor = SystemColors.ButtonFace;
            HashesPanel_MD5Label.Location = new Point(54, 26);
            HashesPanel_MD5Label.Name = "HashesPanel_MD5Label";
            HashesPanel_MD5Label.Size = new Size(43, 19);
            HashesPanel_MD5Label.TabIndex = 0;
            HashesPanel_MD5Label.Text = "MD5:";
            // 
            // HashesPanel_SHA1Label
            // 
            HashesPanel_SHA1Label.AutoSize = true;
            HashesPanel_SHA1Label.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA1Label.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA1Label.Location = new Point(51, 47);
            HashesPanel_SHA1Label.Name = "HashesPanel_SHA1Label";
            HashesPanel_SHA1Label.Size = new Size(46, 19);
            HashesPanel_SHA1Label.TabIndex = 1;
            HashesPanel_SHA1Label.Text = "SHA1:";
            // 
            // HashesPanel_SHA256Label
            // 
            HashesPanel_SHA256Label.AutoSize = true;
            HashesPanel_SHA256Label.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA256Label.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA256Label.Location = new Point(35, 68);
            HashesPanel_SHA256Label.Name = "HashesPanel_SHA256Label";
            HashesPanel_SHA256Label.Size = new Size(62, 19);
            HashesPanel_SHA256Label.TabIndex = 2;
            HashesPanel_SHA256Label.Text = "SHA256:";
            // 
            // HashesPanel_SHA512Label
            // 
            HashesPanel_SHA512Label.AutoSize = true;
            HashesPanel_SHA512Label.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA512Label.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA512Label.Location = new Point(35, 110);
            HashesPanel_SHA512Label.Name = "HashesPanel_SHA512Label";
            HashesPanel_SHA512Label.Size = new Size(62, 19);
            HashesPanel_SHA512Label.TabIndex = 4;
            HashesPanel_SHA512Label.Tag = "";
            HashesPanel_SHA512Label.Text = "SHA512:";
            // 
            // HashesPanel_SHA384Label
            // 
            HashesPanel_SHA384Label.AutoSize = true;
            HashesPanel_SHA384Label.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA384Label.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA384Label.Location = new Point(35, 89);
            HashesPanel_SHA384Label.Name = "HashesPanel_SHA384Label";
            HashesPanel_SHA384Label.Size = new Size(62, 19);
            HashesPanel_SHA384Label.TabIndex = 3;
            HashesPanel_SHA384Label.Text = "SHA384:";
            // 
            // HashesPanel_SHA512ValueLabel
            // 
            HashesPanel_SHA512ValueLabel.AutoSize = true;
            HashesPanel_SHA512ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA512ValueLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA512ValueLabel.Location = new Point(108, 110);
            HashesPanel_SHA512ValueLabel.Name = "HashesPanel_SHA512ValueLabel";
            HashesPanel_SHA512ValueLabel.Size = new Size(79, 19);
            HashesPanel_SHA512ValueLabel.TabIndex = 12;
            HashesPanel_SHA512ValueLabel.Tag = "";
            HashesPanel_SHA512ValueLabel.Text = "<SHA512>";
            HashesPanel_SHA512ValueLabel.Visible = false;
            // 
            // HashesPanel_SHA384ValueLabel
            // 
            HashesPanel_SHA384ValueLabel.AutoSize = true;
            HashesPanel_SHA384ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA384ValueLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA384ValueLabel.Location = new Point(108, 89);
            HashesPanel_SHA384ValueLabel.Name = "HashesPanel_SHA384ValueLabel";
            HashesPanel_SHA384ValueLabel.Size = new Size(79, 19);
            HashesPanel_SHA384ValueLabel.TabIndex = 11;
            HashesPanel_SHA384ValueLabel.Text = "<SHA384>";
            HashesPanel_SHA384ValueLabel.Visible = false;
            // 
            // HashesPanel_SHA256ValueLabel
            // 
            HashesPanel_SHA256ValueLabel.AutoSize = true;
            HashesPanel_SHA256ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA256ValueLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA256ValueLabel.Location = new Point(108, 68);
            HashesPanel_SHA256ValueLabel.Name = "HashesPanel_SHA256ValueLabel";
            HashesPanel_SHA256ValueLabel.Size = new Size(79, 19);
            HashesPanel_SHA256ValueLabel.TabIndex = 10;
            HashesPanel_SHA256ValueLabel.Text = "<SHA256>";
            HashesPanel_SHA256ValueLabel.Visible = false;
            // 
            // HashesPanel_SHA1ValueLabel
            // 
            HashesPanel_SHA1ValueLabel.AutoSize = true;
            HashesPanel_SHA1ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_SHA1ValueLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA1ValueLabel.Location = new Point(108, 47);
            HashesPanel_SHA1ValueLabel.Name = "HashesPanel_SHA1ValueLabel";
            HashesPanel_SHA1ValueLabel.Size = new Size(63, 19);
            HashesPanel_SHA1ValueLabel.TabIndex = 9;
            HashesPanel_SHA1ValueLabel.Text = "<SHA1>";
            HashesPanel_SHA1ValueLabel.Visible = false;
            // 
            // HashesPanel_MD5ValueLabel
            // 
            HashesPanel_MD5ValueLabel.AutoSize = true;
            HashesPanel_MD5ValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_MD5ValueLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_MD5ValueLabel.Location = new Point(108, 26);
            HashesPanel_MD5ValueLabel.Name = "HashesPanel_MD5ValueLabel";
            HashesPanel_MD5ValueLabel.Size = new Size(60, 19);
            HashesPanel_MD5ValueLabel.TabIndex = 8;
            HashesPanel_MD5ValueLabel.Text = "<MD5>";
            HashesPanel_MD5ValueLabel.Visible = false;
            // 
            // HashesPanel_MD5ClipboardLabel
            // 
            HashesPanel_MD5ClipboardLabel.AutoSize = true;
            HashesPanel_MD5ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_MD5ClipboardLabel.Location = new Point(1, 26);
            HashesPanel_MD5ClipboardLabel.Name = "HashesPanel_MD5ClipboardLabel";
            HashesPanel_MD5ClipboardLabel.Size = new Size(29, 21);
            HashesPanel_MD5ClipboardLabel.TabIndex = 13;
            HashesPanel_MD5ClipboardLabel.Text = "📋";
            HashesPanel_MD5ClipboardLabel.Click += HashesPanel_MD5ClipboardLabel_Click;
            HashesPanel_MD5ClipboardLabel.MouseEnter += Label_MouseEnter;
            HashesPanel_MD5ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // HashesPanel_SHA1ClipboardLabel
            // 
            HashesPanel_SHA1ClipboardLabel.AutoSize = true;
            HashesPanel_SHA1ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA1ClipboardLabel.Location = new Point(1, 47);
            HashesPanel_SHA1ClipboardLabel.Name = "HashesPanel_SHA1ClipboardLabel";
            HashesPanel_SHA1ClipboardLabel.Size = new Size(29, 21);
            HashesPanel_SHA1ClipboardLabel.TabIndex = 14;
            HashesPanel_SHA1ClipboardLabel.Text = "📋";
            HashesPanel_SHA1ClipboardLabel.Click += HashesPanel_SHA1ClipboardLabel_Click;
            HashesPanel_SHA1ClipboardLabel.MouseEnter += Label_MouseEnter;
            HashesPanel_SHA1ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // HashesPanel_SHA256ClipboardLabel
            // 
            HashesPanel_SHA256ClipboardLabel.AutoSize = true;
            HashesPanel_SHA256ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA256ClipboardLabel.Location = new Point(1, 68);
            HashesPanel_SHA256ClipboardLabel.Name = "HashesPanel_SHA256ClipboardLabel";
            HashesPanel_SHA256ClipboardLabel.Size = new Size(29, 21);
            HashesPanel_SHA256ClipboardLabel.TabIndex = 15;
            HashesPanel_SHA256ClipboardLabel.Text = "📋";
            HashesPanel_SHA256ClipboardLabel.Click += HashesPanel_SHA256ClipboardLabel_Click;
            HashesPanel_SHA256ClipboardLabel.MouseEnter += Label_MouseEnter;
            HashesPanel_SHA256ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // HashesPanel_SHA384ClipboardLabel
            // 
            HashesPanel_SHA384ClipboardLabel.AutoSize = true;
            HashesPanel_SHA384ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA384ClipboardLabel.Location = new Point(1, 89);
            HashesPanel_SHA384ClipboardLabel.Name = "HashesPanel_SHA384ClipboardLabel";
            HashesPanel_SHA384ClipboardLabel.Size = new Size(29, 21);
            HashesPanel_SHA384ClipboardLabel.TabIndex = 16;
            HashesPanel_SHA384ClipboardLabel.Text = "📋";
            HashesPanel_SHA384ClipboardLabel.Click += HashesPanel_SHA384ClipboardLabel_Click;
            HashesPanel_SHA384ClipboardLabel.MouseEnter += Label_MouseEnter;
            HashesPanel_SHA384ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // HashesPanel_SHA512ClipboardLabel
            // 
            HashesPanel_SHA512ClipboardLabel.AutoSize = true;
            HashesPanel_SHA512ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_SHA512ClipboardLabel.Location = new Point(1, 110);
            HashesPanel_SHA512ClipboardLabel.Name = "HashesPanel_SHA512ClipboardLabel";
            HashesPanel_SHA512ClipboardLabel.Size = new Size(29, 21);
            HashesPanel_SHA512ClipboardLabel.TabIndex = 17;
            HashesPanel_SHA512ClipboardLabel.Text = "📋";
            HashesPanel_SHA512ClipboardLabel.Click += HashesPanel_SHA512ClipboardLabel_Click;
            HashesPanel_SHA512ClipboardLabel.MouseEnter += Label_MouseEnter;
            HashesPanel_SHA512ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // HashesPanel_DragAndDropPictureBox
            // 
            HashesPanel_DragAndDropPictureBox.Image = (Image)resources.GetObject("HashesPanel_DragAndDropPictureBox.Image");
            HashesPanel_DragAndDropPictureBox.Location = new Point(5, 31);
            HashesPanel_DragAndDropPictureBox.Margin = new Padding(3, 2, 3, 2);
            HashesPanel_DragAndDropPictureBox.Name = "HashesPanel_DragAndDropPictureBox";
            HashesPanel_DragAndDropPictureBox.Size = new Size(267, 183);
            HashesPanel_DragAndDropPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            HashesPanel_DragAndDropPictureBox.TabIndex = 18;
            HashesPanel_DragAndDropPictureBox.TabStop = false;
            // 
            // HashesPanel_AlgorithmsPanel
            // 
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA256ValueLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_MD5Label);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA1Label);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA512ClipboardLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA256Label);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA384ClipboardLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA384Label);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA256ClipboardLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA512Label);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA1ClipboardLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_MD5ValueLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_MD5ClipboardLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA1ValueLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA512ValueLabel);
            HashesPanel_AlgorithmsPanel.Controls.Add(HashesPanel_SHA384ValueLabel);
            HashesPanel_AlgorithmsPanel.Location = new Point(5, 219);
            HashesPanel_AlgorithmsPanel.Margin = new Padding(3, 2, 3, 2);
            HashesPanel_AlgorithmsPanel.Name = "HashesPanel_AlgorithmsPanel";
            HashesPanel_AlgorithmsPanel.Size = new Size(267, 153);
            HashesPanel_AlgorithmsPanel.TabIndex = 19;
            // 
            // HashesPanel_FileNameValueLabel
            // 
            HashesPanel_FileNameValueLabel.AutoSize = true;
            HashesPanel_FileNameValueLabel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic);
            HashesPanel_FileNameValueLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_FileNameValueLabel.Location = new Point(3, 6);
            HashesPanel_FileNameValueLabel.Name = "HashesPanel_FileNameValueLabel";
            HashesPanel_FileNameValueLabel.Size = new Size(89, 19);
            HashesPanel_FileNameValueLabel.TabIndex = 19;
            HashesPanel_FileNameValueLabel.Tag = "";
            HashesPanel_FileNameValueLabel.Text = "<File Name>";
            HashesPanel_FileNameValueLabel.Visible = false;
            // 
            // HashesPanel_DropFilePictureBox
            // 
            HashesPanel_DropFilePictureBox.Image = (Image)resources.GetObject("HashesPanel_DropFilePictureBox.Image");
            HashesPanel_DropFilePictureBox.Location = new Point(112, 92);
            HashesPanel_DropFilePictureBox.Margin = new Padding(3, 2, 3, 2);
            HashesPanel_DropFilePictureBox.Name = "HashesPanel_DropFilePictureBox";
            HashesPanel_DropFilePictureBox.Size = new Size(53, 60);
            HashesPanel_DropFilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            HashesPanel_DropFilePictureBox.TabIndex = 20;
            HashesPanel_DropFilePictureBox.TabStop = false;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Items.AddRange(new ToolStripItem[] { HashesToolStripMenuItem, ValidateToolStripMenuItem, CompareToolStripMenuItem, QuestionMarkToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(297, 27);
            MenuStrip.TabIndex = 21;
            MenuStrip.Text = "menuStrip1";
            // 
            // HashesToolStripMenuItem
            // 
            HashesToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            HashesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            HashesToolStripMenuItem.Name = "HashesToolStripMenuItem";
            HashesToolStripMenuItem.Size = new Size(65, 23);
            HashesToolStripMenuItem.Text = "Hashes";
            HashesToolStripMenuItem.Click += HashesToolStripMenuItem_Click;
            // 
            // ValidateToolStripMenuItem
            // 
            ValidateToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            ValidateToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            ValidateToolStripMenuItem.Name = "ValidateToolStripMenuItem";
            ValidateToolStripMenuItem.Size = new Size(70, 23);
            ValidateToolStripMenuItem.Text = "Validate";
            ValidateToolStripMenuItem.Click += ValidateToolStripMenuItem_Click;
            // 
            // CompareToolStripMenuItem
            // 
            CompareToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            CompareToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            CompareToolStripMenuItem.Name = "CompareToolStripMenuItem";
            CompareToolStripMenuItem.Size = new Size(77, 23);
            CompareToolStripMenuItem.Text = "Compare";
            CompareToolStripMenuItem.Click += CompareToolStripMenuItem_Click;
            // 
            // QuestionMarkToolStripMenuItem
            // 
            QuestionMarkToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            QuestionMarkToolStripMenuItem.Font = new Font("Segoe UI Emoji", 9F);
            QuestionMarkToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            QuestionMarkToolStripMenuItem.Name = "QuestionMarkToolStripMenuItem";
            QuestionMarkToolStripMenuItem.Padding = new Padding(4, 0, 20, 0);
            QuestionMarkToolStripMenuItem.Size = new Size(46, 23);
            QuestionMarkToolStripMenuItem.Text = "❔";
            QuestionMarkToolStripMenuItem.Click += QuestionMarkToolStripMenuItem_Click;
            // 
            // HashesPanel
            // 
            HashesPanel.Controls.Add(HashesPanel_BrowseLabel);
            HashesPanel.Controls.Add(HashesPanel_TrashLabel);
            HashesPanel.Controls.Add(HashesPanel_DropFilePictureBox);
            HashesPanel.Controls.Add(HashesPanel_FileNameValueLabel);
            HashesPanel.Controls.Add(HashesPanel_DragAndDropPictureBox);
            HashesPanel.Controls.Add(HashesPanel_AlgorithmsPanel);
            HashesPanel.Location = new Point(12, 30);
            HashesPanel.Name = "HashesPanel";
            HashesPanel.Size = new Size(276, 376);
            HashesPanel.TabIndex = 22;
            // 
            // HashesPanel_BrowseLabel
            // 
            HashesPanel_BrowseLabel.AutoSize = true;
            HashesPanel_BrowseLabel.Cursor = Cursors.Hand;
            HashesPanel_BrowseLabel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Underline);
            HashesPanel_BrowseLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_BrowseLabel.Location = new Point(107, 160);
            HashesPanel_BrowseLabel.Name = "HashesPanel_BrowseLabel";
            HashesPanel_BrowseLabel.Size = new Size(62, 19);
            HashesPanel_BrowseLabel.TabIndex = 18;
            HashesPanel_BrowseLabel.Text = "Browse...";
            HashesPanel_BrowseLabel.Click += Browse_Click;
            // 
            // HashesPanel_TrashLabel
            // 
            HashesPanel_TrashLabel.AutoSize = true;
            HashesPanel_TrashLabel.Font = new Font("Segoe UI Emoji", 10F);
            HashesPanel_TrashLabel.ForeColor = SystemColors.ButtonFace;
            HashesPanel_TrashLabel.Location = new Point(246, 6);
            HashesPanel_TrashLabel.Name = "HashesPanel_TrashLabel";
            HashesPanel_TrashLabel.Size = new Size(28, 19);
            HashesPanel_TrashLabel.TabIndex = 26;
            HashesPanel_TrashLabel.Tag = "";
            HashesPanel_TrashLabel.Text = "🗑️";
            HashesPanel_TrashLabel.Visible = false;
            HashesPanel_TrashLabel.Click += HashesPanel_TrashLabel_Click;
            HashesPanel_TrashLabel.MouseEnter += Label_MouseEnter;
            HashesPanel_TrashLabel.MouseLeave += Label_MouseLeave;
            // 
            // ValidatePanel
            // 
            ValidatePanel.Controls.Add(ValidatePanel_BrowseLabel);
            ValidatePanel.Controls.Add(ValidatePanel_TrashLabel);
            ValidatePanel.Controls.Add(ValidatePanel_DropFilePictureBox);
            ValidatePanel.Controls.Add(ValidatePanel_FileNameValueLabel);
            ValidatePanel.Controls.Add(ValidatePanel_DragAndDropPictureBox);
            ValidatePanel.Controls.Add(ValidatePanel_InputHashPanel);
            ValidatePanel.Location = new Point(12, 30);
            ValidatePanel.Name = "ValidatePanel";
            ValidatePanel.Size = new Size(276, 376);
            ValidatePanel.TabIndex = 23;
            // 
            // ValidatePanel_BrowseLabel
            // 
            ValidatePanel_BrowseLabel.AutoSize = true;
            ValidatePanel_BrowseLabel.Cursor = Cursors.Hand;
            ValidatePanel_BrowseLabel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Underline);
            ValidatePanel_BrowseLabel.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_BrowseLabel.Location = new Point(107, 160);
            ValidatePanel_BrowseLabel.Name = "ValidatePanel_BrowseLabel";
            ValidatePanel_BrowseLabel.Size = new Size(62, 19);
            ValidatePanel_BrowseLabel.TabIndex = 27;
            ValidatePanel_BrowseLabel.Text = "Browse...";
            ValidatePanel_BrowseLabel.Click += Browse_Click;
            // 
            // ValidatePanel_TrashLabel
            // 
            ValidatePanel_TrashLabel.AutoSize = true;
            ValidatePanel_TrashLabel.Font = new Font("Segoe UI Emoji", 10F);
            ValidatePanel_TrashLabel.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_TrashLabel.Location = new Point(246, 6);
            ValidatePanel_TrashLabel.Name = "ValidatePanel_TrashLabel";
            ValidatePanel_TrashLabel.Size = new Size(28, 19);
            ValidatePanel_TrashLabel.TabIndex = 25;
            ValidatePanel_TrashLabel.Tag = "";
            ValidatePanel_TrashLabel.Text = "🗑️";
            ValidatePanel_TrashLabel.Visible = false;
            ValidatePanel_TrashLabel.Click += ValidatePanel_TrashLabel_Click;
            ValidatePanel_TrashLabel.MouseEnter += Label_MouseEnter;
            ValidatePanel_TrashLabel.MouseLeave += Label_MouseLeave;
            // 
            // ValidatePanel_DropFilePictureBox
            // 
            ValidatePanel_DropFilePictureBox.Image = (Image)resources.GetObject("ValidatePanel_DropFilePictureBox.Image");
            ValidatePanel_DropFilePictureBox.Location = new Point(112, 92);
            ValidatePanel_DropFilePictureBox.Margin = new Padding(3, 2, 3, 2);
            ValidatePanel_DropFilePictureBox.Name = "ValidatePanel_DropFilePictureBox";
            ValidatePanel_DropFilePictureBox.Size = new Size(53, 60);
            ValidatePanel_DropFilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ValidatePanel_DropFilePictureBox.TabIndex = 20;
            ValidatePanel_DropFilePictureBox.TabStop = false;
            // 
            // ValidatePanel_FileNameValueLabel
            // 
            ValidatePanel_FileNameValueLabel.AutoSize = true;
            ValidatePanel_FileNameValueLabel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic);
            ValidatePanel_FileNameValueLabel.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_FileNameValueLabel.Location = new Point(3, 6);
            ValidatePanel_FileNameValueLabel.Name = "ValidatePanel_FileNameValueLabel";
            ValidatePanel_FileNameValueLabel.Size = new Size(89, 19);
            ValidatePanel_FileNameValueLabel.TabIndex = 24;
            ValidatePanel_FileNameValueLabel.Tag = "";
            ValidatePanel_FileNameValueLabel.Text = "<File Name>";
            ValidatePanel_FileNameValueLabel.Visible = false;
            // 
            // ValidatePanel_DragAndDropPictureBox
            // 
            ValidatePanel_DragAndDropPictureBox.Image = (Image)resources.GetObject("ValidatePanel_DragAndDropPictureBox.Image");
            ValidatePanel_DragAndDropPictureBox.Location = new Point(5, 31);
            ValidatePanel_DragAndDropPictureBox.Margin = new Padding(3, 2, 3, 2);
            ValidatePanel_DragAndDropPictureBox.Name = "ValidatePanel_DragAndDropPictureBox";
            ValidatePanel_DragAndDropPictureBox.Size = new Size(267, 183);
            ValidatePanel_DragAndDropPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ValidatePanel_DragAndDropPictureBox.TabIndex = 18;
            ValidatePanel_DragAndDropPictureBox.TabStop = false;
            // 
            // ValidatePanel_InputHashPanel
            // 
            ValidatePanel_InputHashPanel.Controls.Add(ValidatePanel_ResultValueLabel);
            ValidatePanel_InputHashPanel.Controls.Add(ValidatePanel_ResultLabel);
            ValidatePanel_InputHashPanel.Controls.Add(ValidatePanel_ExpectedHashTextBox);
            ValidatePanel_InputHashPanel.Controls.Add(ValidatePanel_AlgorithmComboBox);
            ValidatePanel_InputHashPanel.Controls.Add(ValidatePanel_ExpectedLabel);
            ValidatePanel_InputHashPanel.Location = new Point(5, 218);
            ValidatePanel_InputHashPanel.Margin = new Padding(3, 2, 3, 2);
            ValidatePanel_InputHashPanel.Name = "ValidatePanel_InputHashPanel";
            ValidatePanel_InputHashPanel.Size = new Size(267, 153);
            ValidatePanel_InputHashPanel.TabIndex = 19;
            // 
            // ValidatePanel_ResultValueLabel
            // 
            ValidatePanel_ResultValueLabel.AutoSize = true;
            ValidatePanel_ResultValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            ValidatePanel_ResultValueLabel.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_ResultValueLabel.Location = new Point(48, 126);
            ValidatePanel_ResultValueLabel.Name = "ValidatePanel_ResultValueLabel";
            ValidatePanel_ResultValueLabel.Size = new Size(104, 19);
            ValidatePanel_ResultValueLabel.TabIndex = 33;
            ValidatePanel_ResultValueLabel.Tag = "";
            ValidatePanel_ResultValueLabel.Text = "<Valid/Invalid>";
            ValidatePanel_ResultValueLabel.Visible = false;
            // 
            // ValidatePanel_ResultLabel
            // 
            ValidatePanel_ResultLabel.AutoSize = true;
            ValidatePanel_ResultLabel.Font = new Font("Segoe UI Emoji", 10F);
            ValidatePanel_ResultLabel.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_ResultLabel.Location = new Point(0, 126);
            ValidatePanel_ResultLabel.Name = "ValidatePanel_ResultLabel";
            ValidatePanel_ResultLabel.Size = new Size(49, 19);
            ValidatePanel_ResultLabel.TabIndex = 32;
            ValidatePanel_ResultLabel.Tag = "";
            ValidatePanel_ResultLabel.Text = "Result:";
            // 
            // ValidatePanel_ExpectedHashTextBox
            // 
            ValidatePanel_ExpectedHashTextBox.BackColor = Color.FromArgb(32, 32, 32);
            ValidatePanel_ExpectedHashTextBox.BorderStyle = BorderStyle.FixedSingle;
            ValidatePanel_ExpectedHashTextBox.Font = new Font("Segoe UI Emoji", 10F);
            ValidatePanel_ExpectedHashTextBox.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_ExpectedHashTextBox.Location = new Point(86, 60);
            ValidatePanel_ExpectedHashTextBox.Name = "ValidatePanel_ExpectedHashTextBox";
            ValidatePanel_ExpectedHashTextBox.Size = new Size(178, 25);
            ValidatePanel_ExpectedHashTextBox.TabIndex = 21;
            ValidatePanel_ExpectedHashTextBox.TextChanged += ValidatePanel_ExpectedHashTextBox_TextChanged;
            // 
            // ValidatePanel_AlgorithmComboBox
            // 
            ValidatePanel_AlgorithmComboBox.BackColor = Color.FromArgb(32, 32, 32);
            ValidatePanel_AlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ValidatePanel_AlgorithmComboBox.Font = new Font("Segoe UI Emoji", 10F);
            ValidatePanel_AlgorithmComboBox.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_AlgorithmComboBox.FormattingEnabled = true;
            ValidatePanel_AlgorithmComboBox.Location = new Point(3, 60);
            ValidatePanel_AlgorithmComboBox.Name = "ValidatePanel_AlgorithmComboBox";
            ValidatePanel_AlgorithmComboBox.Size = new Size(80, 25);
            ValidatePanel_AlgorithmComboBox.TabIndex = 20;
            ValidatePanel_AlgorithmComboBox.SelectedIndexChanged += ValidatePanel_AlgorithmComboBox_SelectedIndexChanged;
            // 
            // ValidatePanel_ExpectedLabel
            // 
            ValidatePanel_ExpectedLabel.AutoSize = true;
            ValidatePanel_ExpectedLabel.Font = new Font("Segoe UI Emoji", 10F);
            ValidatePanel_ExpectedLabel.ForeColor = SystemColors.ButtonFace;
            ValidatePanel_ExpectedLabel.Location = new Point(-1, 34);
            ValidatePanel_ExpectedLabel.Name = "ValidatePanel_ExpectedLabel";
            ValidatePanel_ExpectedLabel.Size = new Size(66, 19);
            ValidatePanel_ExpectedLabel.TabIndex = 18;
            ValidatePanel_ExpectedLabel.Tag = "";
            ValidatePanel_ExpectedLabel.Text = "Expected:";
            // 
            // ComparePanel
            // 
            ComparePanel.Controls.Add(ComparePanel_DropFilePictureBox);
            ComparePanel.Controls.Add(ComparePanel_DragAndDropPictureBox);
            ComparePanel.Controls.Add(ComparePanel_ResultValueLabel);
            ComparePanel.Controls.Add(ComparePanel_ResultLabel);
            ComparePanel.Controls.Add(ComparePanel_BrowseLabel2);
            ComparePanel.Controls.Add(ComparePanel_TrashLabel2);
            ComparePanel.Controls.Add(ComparePanel_FileNameValueLabel2);
            ComparePanel.Controls.Add(ComparePanel_BrowseLabel1);
            ComparePanel.Controls.Add(ComparePanel_TrashLabel1);
            ComparePanel.Controls.Add(ComparePanel_FileNameValueLabel1);
            ComparePanel.Location = new Point(12, 30);
            ComparePanel.Name = "ComparePanel";
            ComparePanel.Size = new Size(276, 376);
            ComparePanel.TabIndex = 28;
            // 
            // ComparePanel_DropFilePictureBox
            // 
            ComparePanel_DropFilePictureBox.Image = (Image)resources.GetObject("ComparePanel_DropFilePictureBox.Image");
            ComparePanel_DropFilePictureBox.Location = new Point(112, 92);
            ComparePanel_DropFilePictureBox.Margin = new Padding(3, 2, 3, 2);
            ComparePanel_DropFilePictureBox.Name = "ComparePanel_DropFilePictureBox";
            ComparePanel_DropFilePictureBox.Size = new Size(53, 60);
            ComparePanel_DropFilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ComparePanel_DropFilePictureBox.TabIndex = 33;
            ComparePanel_DropFilePictureBox.TabStop = false;
            // 
            // ComparePanel_DragAndDropPictureBox
            // 
            ComparePanel_DragAndDropPictureBox.Image = (Image)resources.GetObject("ComparePanel_DragAndDropPictureBox.Image");
            ComparePanel_DragAndDropPictureBox.Location = new Point(5, 31);
            ComparePanel_DragAndDropPictureBox.Margin = new Padding(3, 2, 3, 2);
            ComparePanel_DragAndDropPictureBox.Name = "ComparePanel_DragAndDropPictureBox";
            ComparePanel_DragAndDropPictureBox.Size = new Size(267, 183);
            ComparePanel_DragAndDropPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ComparePanel_DragAndDropPictureBox.TabIndex = 32;
            ComparePanel_DragAndDropPictureBox.TabStop = false;
            // 
            // ComparePanel_ResultValueLabel
            // 
            ComparePanel_ResultValueLabel.AutoSize = true;
            ComparePanel_ResultValueLabel.Font = new Font("Segoe UI Emoji", 10F);
            ComparePanel_ResultValueLabel.ForeColor = SystemColors.ButtonFace;
            ComparePanel_ResultValueLabel.Location = new Point(53, 344);
            ComparePanel_ResultValueLabel.Name = "ComparePanel_ResultValueLabel";
            ComparePanel_ResultValueLabel.Size = new Size(138, 19);
            ComparePanel_ResultValueLabel.TabIndex = 31;
            ComparePanel_ResultValueLabel.Tag = "";
            ComparePanel_ResultValueLabel.Text = "<Identical/Different>";
            ComparePanel_ResultValueLabel.Visible = false;
            // 
            // ComparePanel_ResultLabel
            // 
            ComparePanel_ResultLabel.AutoSize = true;
            ComparePanel_ResultLabel.Font = new Font("Segoe UI Emoji", 10F);
            ComparePanel_ResultLabel.ForeColor = SystemColors.ButtonFace;
            ComparePanel_ResultLabel.Location = new Point(5, 344);
            ComparePanel_ResultLabel.Name = "ComparePanel_ResultLabel";
            ComparePanel_ResultLabel.Size = new Size(49, 19);
            ComparePanel_ResultLabel.TabIndex = 22;
            ComparePanel_ResultLabel.Tag = "";
            ComparePanel_ResultLabel.Text = "Result:";
            // 
            // ComparePanel_BrowseLabel2
            // 
            ComparePanel_BrowseLabel2.AutoSize = true;
            ComparePanel_BrowseLabel2.Cursor = Cursors.Hand;
            ComparePanel_BrowseLabel2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Underline);
            ComparePanel_BrowseLabel2.ForeColor = SystemColors.ButtonFace;
            ComparePanel_BrowseLabel2.Location = new Point(5, 316);
            ComparePanel_BrowseLabel2.Name = "ComparePanel_BrowseLabel2";
            ComparePanel_BrowseLabel2.Size = new Size(62, 19);
            ComparePanel_BrowseLabel2.TabIndex = 30;
            ComparePanel_BrowseLabel2.Text = "Browse...";
            ComparePanel_BrowseLabel2.Click += ComparePanel_BrowseLabel2_Click;
            // 
            // ComparePanel_TrashLabel2
            // 
            ComparePanel_TrashLabel2.AutoSize = true;
            ComparePanel_TrashLabel2.Font = new Font("Segoe UI Emoji", 10F);
            ComparePanel_TrashLabel2.ForeColor = SystemColors.ButtonFace;
            ComparePanel_TrashLabel2.Location = new Point(242, 291);
            ComparePanel_TrashLabel2.Name = "ComparePanel_TrashLabel2";
            ComparePanel_TrashLabel2.Size = new Size(28, 19);
            ComparePanel_TrashLabel2.TabIndex = 29;
            ComparePanel_TrashLabel2.Tag = "";
            ComparePanel_TrashLabel2.Text = "🗑️";
            ComparePanel_TrashLabel2.Visible = false;
            ComparePanel_TrashLabel2.Click += ComparePanel_TrashLabel2_Click;
            ComparePanel_TrashLabel2.MouseEnter += Label_MouseEnter;
            ComparePanel_TrashLabel2.MouseLeave += Label_MouseLeave;
            // 
            // ComparePanel_FileNameValueLabel2
            // 
            ComparePanel_FileNameValueLabel2.AutoSize = true;
            ComparePanel_FileNameValueLabel2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic);
            ComparePanel_FileNameValueLabel2.ForeColor = SystemColors.ButtonFace;
            ComparePanel_FileNameValueLabel2.Location = new Point(5, 291);
            ComparePanel_FileNameValueLabel2.Name = "ComparePanel_FileNameValueLabel2";
            ComparePanel_FileNameValueLabel2.Size = new Size(85, 19);
            ComparePanel_FileNameValueLabel2.TabIndex = 28;
            ComparePanel_FileNameValueLabel2.Tag = "";
            ComparePanel_FileNameValueLabel2.Text = "Choose file...";
            // 
            // ComparePanel_BrowseLabel1
            // 
            ComparePanel_BrowseLabel1.AutoSize = true;
            ComparePanel_BrowseLabel1.Cursor = Cursors.Hand;
            ComparePanel_BrowseLabel1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Underline);
            ComparePanel_BrowseLabel1.ForeColor = SystemColors.ButtonFace;
            ComparePanel_BrowseLabel1.Location = new Point(5, 253);
            ComparePanel_BrowseLabel1.Name = "ComparePanel_BrowseLabel1";
            ComparePanel_BrowseLabel1.Size = new Size(62, 19);
            ComparePanel_BrowseLabel1.TabIndex = 27;
            ComparePanel_BrowseLabel1.Text = "Browse...";
            ComparePanel_BrowseLabel1.Click += ComparePanel_BrowseLabel1_Click;
            // 
            // ComparePanel_TrashLabel1
            // 
            ComparePanel_TrashLabel1.AutoSize = true;
            ComparePanel_TrashLabel1.Font = new Font("Segoe UI Emoji", 10F);
            ComparePanel_TrashLabel1.ForeColor = SystemColors.ButtonFace;
            ComparePanel_TrashLabel1.Location = new Point(242, 228);
            ComparePanel_TrashLabel1.Name = "ComparePanel_TrashLabel1";
            ComparePanel_TrashLabel1.Size = new Size(28, 19);
            ComparePanel_TrashLabel1.TabIndex = 25;
            ComparePanel_TrashLabel1.Tag = "";
            ComparePanel_TrashLabel1.Text = "🗑️";
            ComparePanel_TrashLabel1.Visible = false;
            ComparePanel_TrashLabel1.Click += ComparePanel_TrashLabel1_Click;
            ComparePanel_TrashLabel1.MouseEnter += Label_MouseEnter;
            ComparePanel_TrashLabel1.MouseLeave += Label_MouseLeave;
            // 
            // ComparePanel_FileNameValueLabel1
            // 
            ComparePanel_FileNameValueLabel1.AutoSize = true;
            ComparePanel_FileNameValueLabel1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Italic);
            ComparePanel_FileNameValueLabel1.ForeColor = SystemColors.ButtonFace;
            ComparePanel_FileNameValueLabel1.Location = new Point(5, 228);
            ComparePanel_FileNameValueLabel1.Name = "ComparePanel_FileNameValueLabel1";
            ComparePanel_FileNameValueLabel1.Size = new Size(85, 19);
            ComparePanel_FileNameValueLabel1.TabIndex = 24;
            ComparePanel_FileNameValueLabel1.Tag = "";
            ComparePanel_FileNameValueLabel1.Text = "Choose file...";
            // 
            // DisplayForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(297, 414);
            Controls.Add(MenuStrip);
            Controls.Add(ValidatePanel);
            Controls.Add(HashesPanel);
            Controls.Add(ComparePanel);
            Font = new Font("Segoe UI Emoji", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4);
            Name = "DisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileHasher";
            DragDrop += DisplayForm_DragDrop;
            DragEnter += DisplayForm_DragEnter;
            ((System.ComponentModel.ISupportInitialize)HashesPanel_DragAndDropPictureBox).EndInit();
            HashesPanel_AlgorithmsPanel.ResumeLayout(false);
            HashesPanel_AlgorithmsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HashesPanel_DropFilePictureBox).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            HashesPanel.ResumeLayout(false);
            HashesPanel.PerformLayout();
            ValidatePanel.ResumeLayout(false);
            ValidatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ValidatePanel_DropFilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValidatePanel_DragAndDropPictureBox).EndInit();
            ValidatePanel_InputHashPanel.ResumeLayout(false);
            ValidatePanel_InputHashPanel.PerformLayout();
            ComparePanel.ResumeLayout(false);
            ComparePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ComparePanel_DropFilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComparePanel_DragAndDropPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HashesPanel_MD5Label;
        private Label HashesPanel_SHA1Label;
        private Label HashesPanel_SHA256Label;
        private Label HashesPanel_SHA512Label;
        private Label HashesPanel_SHA384Label;
        private Label HashesPanel_SHA512ValueLabel;
        private Label HashesPanel_SHA384ValueLabel;
        private Label HashesPanel_SHA256ValueLabel;
        private Label HashesPanel_SHA1ValueLabel;
        private Label HashesPanel_MD5ValueLabel;
        private Label HashesPanel_MD5ClipboardLabel;
        private Label HashesPanel_SHA1ClipboardLabel;
        private Label HashesPanel_SHA256ClipboardLabel;
        private Label HashesPanel_SHA384ClipboardLabel;
        private Label HashesPanel_SHA512ClipboardLabel;
        private PictureBox HashesPanel_DragAndDropPictureBox;
        private Panel HashesPanel_AlgorithmsPanel;
        private PictureBox HashesPanel_DropFilePictureBox;
        private Label HashesPanel_FileNameValueLabel;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem HashesToolStripMenuItem;
        private ToolStripMenuItem ValidateToolStripMenuItem;
        private ToolStripMenuItem CompareToolStripMenuItem;
        private Panel HashesPanel;
        private Panel ValidatePanel;
        private PictureBox ValidatePanel_DropFilePictureBox;
        private PictureBox ValidatePanel_DragAndDropPictureBox;
        private Panel ValidatePanel_InputHashPanel;
        private Label ValidatePanel_ExpectedLabel;
        private ComboBox ValidatePanel_AlgorithmComboBox;
        private TextBox ValidatePanel_ExpectedHashTextBox;
        private Label ValidatePanel_FileNameValueLabel;
        private Label ValidatePanel_TrashLabel;
        private Label HashesPanel_TrashLabel;
        private Label HashesPanel_BrowseLabel;
        private Label ValidatePanel_BrowseLabel;
        private Panel ComparePanel;
        private Label ComparePanel_ResultLabel;
        private Label ComparePanel_BrowseLabel2;
        private Label ComparePanel_TrashLabel2;
        private Label ComparePanel_FileNameValueLabel2;
        private Label ComparePanel_BrowseLabel1;
        private Label ComparePanel_TrashLabel1;
        private Label ComparePanel_FileNameValueLabel1;
        private ToolStripMenuItem QuestionMarkToolStripMenuItem;
        private Label ComparePanel_ResultValueLabel;
        private PictureBox ComparePanel_DropFilePictureBox;
        private PictureBox ComparePanel_DragAndDropPictureBox;
        private Label ValidatePanel_ResultValueLabel;
        private Label ValidatePanel_ResultLabel;
    }
}
