using MetroFramework.Forms;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SpecialCharacterFixer
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void DropList_DragDrop(object sender, DragEventArgs e)
        {
            progressBar.Value = 0;
            dropList.Items.Clear();
            dropFilesLabel.Visible = false;
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            progressBar.Maximum = filePaths.Length * 3;
            foreach (var item in filePaths)
            {
                var listItem = new ListViewItem(Path.GetFileName(item));
                listItem.ToolTipText = item;
                dropList.Items.Add(listItem);
            }

            for (int i = 0; i < filePaths.Length; i++)
            {
                progressBar.Value++;
                var fileText = SpecialCharacterFixer(File.ReadAllText(filePaths[i], Encoding.Default));
                progressBar.Value++;
                File.WriteAllText(filePaths[i], fileText);
                dropList.Items[i].Checked = true;
                progressBar.Value++;
            }
            return;
        }

        private void DropList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            return;
        }

        private string SpecialCharacterFixer(string text)
        {
            var fixedText = "";
            var chars = text.ToCharArray();
            foreach (var chr in chars)
            {
                switch (chr)
                {
                    case 'ð':
                        fixedText += 'ğ';
                        break;
                    case 'Ð':
                        fixedText += 'Ğ';
                        break;

                    case 'ý':
                        fixedText += 'ı';
                        break;
                    case 'Ý':
                        fixedText += 'İ';
                        break;

                    case 'þ':
                        fixedText += 'ş';
                        break;
                    case 'Þ':
                        fixedText += 'Ş';
                        break;

                    default:
                        fixedText += chr;
                        break;
                }
            }

            return fixedText;
        }
    }
}
