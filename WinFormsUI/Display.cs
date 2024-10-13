using FileHasherLibrary;
using System.Collections;
using System.IO;

namespace WinFormsUI
{
    public partial class DisplayForm : Form
    {
        byte[] fileBytes = new byte[0];

        public DisplayForm()
        {
            InitializeComponent();
            PopulateForm();
            ShowHashesPanel();
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

            HashesPanel_MD5ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.MD5)).Replace("-", ""), 15);
            HashesPanel_SHA1ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA1)).Replace("-", ""), 15);
            HashesPanel_SHA256ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA256)).Replace("-", ""), 15);
            HashesPanel_SHA384ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA384)).Replace("-", ""), 15);
            HashesPanel_SHA512ValueLabel.Text = TruncateText(BitConverter.ToString(Hasher.Hash(fileBytes, Algorithm.SHA512)).Replace("-", ""), 15);
            HashesPanel_FileNameValueLabel.Text = TruncateText(Path.GetFileName(path), 30);
            ValidatePanel_FileNameValueLabel.Text = TruncateText(Path.GetFileName(path), 30);

            HashesPanel_MD5ValueLabel.Visible = true;
            HashesPanel_SHA1ValueLabel.Visible = true;
            HashesPanel_SHA256ValueLabel.Visible = true;
            HashesPanel_SHA384ValueLabel.Visible = true;
            HashesPanel_SHA512ValueLabel.Visible = true;
            HashesPanel_FileNameValueLabel.Visible = true;
            HashesPanel_TrashLabel.Visible = true;
            ValidatePanel_FileNameValueLabel.Visible = true;
            ValidatePanel_TrashLabel.Visible = true;

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

            if (paths.Length != 1)
            {
                MessageBox.Show("Please drop one file at a time.");
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
            Clipboard.SetText(HashesPanel_MD5ValueLabel.Text);
        }

        private void HashesPanel_SHA1ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashesPanel_SHA1ValueLabel.Text);
        }

        private void HashesPanel_SHA256ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashesPanel_SHA256ValueLabel.Text);
        }

        private void HashesPanel_SHA384ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashesPanel_SHA384ValueLabel.Text);
        }

        private void HashesPanel_SHA512ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HashesPanel_SHA512ValueLabel.Text);
        }

        private void HashesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHashesPanel();
        }

        private void ShowHashesPanel()
        {
            HashesPanel.Visible = true;
            ValidatePanel.Visible = false;
        }

        private void ValidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowValidatePanel();
        }

        private void ShowValidatePanel()
        {
            HashesPanel.Visible = false;
            ValidatePanel.Visible = true;
        }

        private void ValidatePanel_ExpectedHashTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ValidatePanel_ExpectedHashTextBox.Text))
            {
                ValidatePanel_ValidateResultLabel.Visible = false;
                return;
            }

            if (fileBytes.Length > 0)
            {
                Algorithm algorithm = (Algorithm)ValidatePanel_AlgorithmComboBox.SelectedItem;
                string computedHash = BitConverter.ToString(Hasher.Hash(fileBytes, algorithm)).Replace("-", "");
                string expectedHash = ValidatePanel_ExpectedHashTextBox.Text.ToUpper();

                if (computedHash == expectedHash)
                {
                    ValidatePanel_ValidateResultLabel.Visible = true;
                    ValidatePanel_ValidateResultLabel.ForeColor = Color.DarkGreen;
                    ValidatePanel_ValidateResultLabel.Text = "Valid Hash";
                }
                else
                {
                    ValidatePanel_ValidateResultLabel.Visible = true;
                    ValidatePanel_ValidateResultLabel.ForeColor = Color.Red;
                    ValidatePanel_ValidateResultLabel.Text = "Invalid Hash";
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
    }
}
