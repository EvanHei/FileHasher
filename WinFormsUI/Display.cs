using FileHasherLibrary;

namespace WinFormsUI
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void UpdateControls(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);

            MD5ValueLabel.Text = TruncateText(BitConverter.ToString(Md5Hasher.Hash(bytes)).Replace("-", ""));
            SHA1ValueLabel.Text = TruncateText(BitConverter.ToString(Sha1Hasher.Hash(bytes)).Replace("-", ""));
            SHA256ValueLabel.Text = TruncateText(BitConverter.ToString(Sha256Hasher.Hash(bytes)).Replace("-", ""));
            SHA384ValueLabel.Text = TruncateText(BitConverter.ToString(Sha384Hasher.Hash(bytes)).Replace("-", ""));
            SHA512ValueLabel.Text = TruncateText(BitConverter.ToString(Sha512Hasher.Hash(bytes)).Replace("-", ""));
            FileNameValueLabel.Text = TruncateText(Path.GetFileName(path));

            MD5ValueLabel.Visible = true;
            SHA1ValueLabel.Visible = true;
            SHA256ValueLabel.Visible = true;
            SHA384ValueLabel.Visible = true;
            SHA512ValueLabel.Visible = true;
            FileNameValueLabel.Visible = true;
        }

        private string TruncateText(string text)
        {
            return text.Length > 15 ? text.Substring(0, 15) + "..." : text;
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

        private void MD5ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MD5ValueLabel.Text);
        }

        private void SHA1ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA1ValueLabel.Text);
        }

        private void SHA256ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA256ValueLabel.Text);
        }

        private void SHA384ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA384ValueLabel.Text);
        }

        private void SHA512ClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SHA512ValueLabel.Text);
        }
    }
}
