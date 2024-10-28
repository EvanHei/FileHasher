using FileHasherLibrary;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace WinFormsUI
{
    public partial class DisplayForm : Form
    {
        byte[] fileBytes;
        byte[] ComparePanel_FileBytes1;
        byte[] ComparePanel_FileBytes2;

        public DisplayForm()
        {
            InitializeComponent();
            PopulateForm();
            HashesToolStripMenuItem_Click(null, null);
        }

        private void PopulateForm()
        {
            ValidatePanel_AlgorithmComboBox.DataSource = Enum.GetValues(typeof(Algorithm));
        }

        private void UpdateControls(string path)
        {
            if (!File.Exists(path))
            {
                ResetControls();
                return;
            }

            fileBytes = File.ReadAllBytes(path);

            HashesPanel_FileNameValueLabel.Text = TruncateText(Path.GetFileName(path), 22);
            HashesPanel_MD5ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.MD5)).Replace("-", ""), 15);
            HashesPanel_SHA1ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA1)).Replace("-", ""), 15);
            HashesPanel_SHA256ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA256)).Replace("-", ""), 15);
            HashesPanel_SHA384ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA384)).Replace("-", ""), 15);
            HashesPanel_SHA512ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA512)).Replace("-", ""), 15);
            HashesPanel_MD5ValueLabel.Visible = true;
            HashesPanel_SHA1ValueLabel.Visible = true;
            HashesPanel_SHA256ValueLabel.Visible = true;
            HashesPanel_SHA384ValueLabel.Visible = true;
            HashesPanel_SHA512ValueLabel.Visible = true;
            HashesPanel_FileNameValueLabel.Visible = true;
            HashesPanel_TrashLabel.Visible = true;
            ValidatePanel_FileNameValueLabel.Visible = true;
            ValidatePanel_TrashLabel.Visible = true;

            ValidatePanel_FileNameValueLabel.Text = TruncateText(Path.GetFileName(path), 22);

            ValidatePanel_ExpectedHashTextBox_TextChanged(null, null);
        }

        private void ResetControls()
        {
            HashesPanel_MD5ValueLabel.Visible = false;
            HashesPanel_SHA1ValueLabel.Visible = false;
            HashesPanel_SHA256ValueLabel.Visible = false;
            HashesPanel_SHA384ValueLabel.Visible = false;
            HashesPanel_SHA512ValueLabel.Visible = false;
            HashesPanel_FileNameValueLabel.Visible = false;
            HashesPanel_TrashLabel.Visible = false;
            ValidatePanel_FileNameValueLabel.Visible = false;
            ValidatePanel_TrashLabel.Visible = false;
        }

        private string TruncateText(string text, int length)
        {
            return text.Length > length ? text.Substring(0, length) + "..." : text;
        }

        private void DisplayForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);

            // loads file(s) into compare panel
            if (paths.Length > 0)
            {
                if (ComparePanel_FileBytes1 == null)
                {
                    ComparePanel_SetFile1(paths[0]);
                }
                else if (ComparePanel_FileBytes2 == null)
                {
                    ComparePanel_SetFile2(paths[0]);
                }
            }
            if (paths.Length > 1)
            {
                ComparePanel_SetFile2(paths[0]);
                ComparePanel_SetFile2(paths[1]);
            }

            UpdateControls(paths[0]);
        }

        private void DisplayForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = SystemColors.Highlight;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = SystemColors.ButtonFace;
        }

        private void HashesPanel_MD5ClipboardLabel_Click(object sender, EventArgs e)
        {
            string hash = BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.MD5)).Replace("-", "");
            Clipboard.SetText(hash);
        }

        private void HashesPanel_SHA1ClipboardLabel_Click(object sender, EventArgs e)
        {
            string hash = BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA1)).Replace("-", "");
            Clipboard.SetText(hash);
        }

        private void HashesPanel_SHA256ClipboardLabel_Click(object sender, EventArgs e)
        {
            string hash = BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA256)).Replace("-", "");
            Clipboard.SetText(hash);
        }

        private void HashesPanel_SHA384ClipboardLabel_Click(object sender, EventArgs e)
        {
            string hash = BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA384)).Replace("-", "");
            Clipboard.SetText(hash);
        }

        private void HashesPanel_SHA512ClipboardLabel_Click(object sender, EventArgs e)
        {
            string hash = BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA512)).Replace("-", "");
            Clipboard.SetText(hash);
        }

        private void HashesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHashesPanel();
            HashesToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Bold);
            ValidateToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Regular);
            CompareToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void ValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowValidatePanel();
            HashesToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Regular);
            ValidateToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Bold);
            CompareToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void ShowHashesPanel()
        {
            HashesPanel.Visible = true;
            ValidatePanel.Visible = false;
            ComparePanel.Visible = false;
        }

        private void ShowValidatePanel()
        {
            HashesPanel.Visible = false;
            ValidatePanel.Visible = true;
            ComparePanel.Visible = false;
        }

        private void ShowComparePanel()
        {
            HashesPanel.Visible = false;
            ValidatePanel.Visible = false;
            ComparePanel.Visible = true;
        }

        private void ValidatePanel_ExpectedHashTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ValidatePanel_ExpectedHashTextBox.Text))
            {
                ValidatePanel_ResultValueLabel.Visible = false;
                return;
            }

            if (fileBytes != null)
            {
                Algorithm algorithm = (Algorithm)ValidatePanel_AlgorithmComboBox.SelectedItem;
                string computedHash = BitConverter.ToString(Hasher.Hash(fileBytes, algorithm)).Replace("-", "");
                string expectedHash = ValidatePanel_ExpectedHashTextBox.Text.ToUpper();

                if (computedHash == expectedHash)
                {
                    ValidatePanel_ResultValueLabel.Visible = true;
                    ValidatePanel_ResultValueLabel.ForeColor = Color.DarkGreen;
                    ValidatePanel_ResultValueLabel.Text = "Valid";
                }
                else
                {
                    ValidatePanel_ResultValueLabel.Visible = true;
                    ValidatePanel_ResultValueLabel.ForeColor = Color.Red;
                    ValidatePanel_ResultValueLabel.Text = "Invalid";
                }
            }
        }

        private void ValidatePanel_AlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidatePanel_ExpectedHashTextBox_TextChanged(null, null);
        }

        private void HashesPanel_TrashLabel_Click(object sender, EventArgs e)
        {
            UpdateControls("");
        }

        private void ValidatePanel_TrashLabel_Click(object sender, EventArgs e)
        {
            UpdateControls("");
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            UpdateControls(openFileDialog.FileName);
        }

        private void ComparePanel_BrowseLabel1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Title = "Select File 1";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog.FileName;
            if (!File.Exists(path))
            {
                ResetControls();
                return;
            }

            ComparePanel_SetFile1(path);
        }

        private void ComparePanel_BrowseLabel2_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Title = "Select File 2";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog.FileName;
            if (!File.Exists(path))
            {
                ResetControls();
                return;
            }

            ComparePanel_SetFile2(path);
        }

        private void ComparePanel_SetFile1(string path)
        {
            ComparePanel_FileNameValueLabel1.Text = TruncateText(Path.GetFileName(path), 22);
            ComparePanel_TrashLabel1.Visible = true;
            ComparePanel_FileBytes1 = File.ReadAllBytes(path);

            if (ComparePanel_FileBytes2 != null)
            {
                UpdateComparePanelControls();
            }
        }

        private void ComparePanel_SetFile2(string path)
        {
            ComparePanel_FileNameValueLabel2.Text = TruncateText(Path.GetFileName(path), 22);
            ComparePanel_TrashLabel2.Visible = true;
            ComparePanel_FileBytes2 = File.ReadAllBytes(path);

            if (ComparePanel_FileBytes1 != null)
            {
                UpdateComparePanelControls();
            }
        }

        private void UpdateComparePanelControls()
        {
            if (ComparePanel_FileBytes1 == null || ComparePanel_FileBytes2 == null)
                return;

            string hash_1 = BitConverter.ToString(Hasher.Hash(ComparePanel_FileBytes1, Algorithm.SHA512));
            string hash_2 = BitConverter.ToString(Hasher.Hash(ComparePanel_FileBytes2, Algorithm.SHA512));

            if (hash_1 == hash_2)
            {
                ComparePanel_ResultValueLabel.Visible = true;
                ComparePanel_ResultValueLabel.ForeColor = Color.DarkGreen;
                ComparePanel_ResultValueLabel.Text = "Identical";
            }
            else
            {
                ComparePanel_ResultValueLabel.Visible = true;
                ComparePanel_ResultValueLabel.ForeColor = Color.Red;
                ComparePanel_ResultValueLabel.Text = "Different";
            }
        }

        private void ComparePanel_TrashLabel1_Click(object sender, EventArgs e)
        {
            ComparePanel_FileNameValueLabel1.Text = "Choose file...";
            ComparePanel_FileBytes1 = null;
            ComparePanel_ResultValueLabel.Visible = false;
            ComparePanel_TrashLabel1.Visible = false;
        }

        private void ComparePanel_TrashLabel2_Click(object sender, EventArgs e)
        {
            ComparePanel_FileNameValueLabel2.Text = "Choose file...";
            ComparePanel_FileBytes2 = null;
            ComparePanel_ResultValueLabel.Visible = false;
            ComparePanel_TrashLabel2.Visible = false;
        }

        private void CompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowComparePanel();
            HashesToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Regular);
            ValidateToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Regular);
            CompareToolStripMenuItem.Font = new(CompareToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void QuestionMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new()
            {
                FileName = "https://github.com/EvanHei/FileHasher/blob/main/README.md",
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }
    }
}
