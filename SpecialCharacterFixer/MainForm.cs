using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq;
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

        private void DragDropHandler(object sender, DragEventArgs e)
        {
            progressBar.Value = 0;
            dropList.Items.Clear();
            dropFilesLabel.Visible = false;

            var filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            var fixedItemCount = 0;

            progressBar.Maximum = filePaths.Length * 4;

            foreach (var filePath in filePaths)
            {
                var listItem = new ListViewItem(Path.GetFileName(filePath));
                listItem.ToolTipText = filePath;
                listItem = dropList.Items.Add(listItem);
                progressBar.Value++;

                var fileText = File.ReadAllText(filePath, Encoding.Default);
                progressBar.Value++;

                if (!fileText.Any(x => x == 'ð' || x == 'Ð' || x == 'ý' || x == 'Ý' || x == 'þ' || x == 'Þ'))
                {
                    progressBar.Value += 2;
                    dropList.Update();
                    continue;
                }

                var fixedText = SpecialCharacterFixer(fileText);
                progressBar.Value++;

                File.WriteAllText(filePath, fixedText, Encoding.UTF8);
                listItem.Checked = true;
                dropList.Update();
                fixedItemCount++;
                progressBar.Value++;
            }
            dropFilesLabel.Text = $"{fixedItemCount} file fixed!";
            dropFilesLabel.Visible = true;
        }

        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            return;
        }

        private string SpecialCharacterFixer(string text)
        {
            return text
                .Replace('ð', 'ğ').Replace('Ð', 'Ğ')
                .Replace('ý', 'ı').Replace('Ý', 'İ')
                .Replace('þ', 'ş').Replace('Þ', 'Ş');
        }
    }
}
