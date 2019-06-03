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
                var fileText = File.ReadAllText(filePaths[i], Encoding.Default);
                if (!fileText.Any(x => x == 'ð' || x == 'Ð' || x == 'ý' || x == 'Ý' || x == 'þ' || x == 'Þ'))
                {
                    progressBar.Value += 2;
                    continue;
                }

                var fixedText = SpecialCharacterFixer(fileText);
                progressBar.Value++;
                File.WriteAllText(filePaths[i], fixedText, Encoding.UTF8);
                dropList.Items[i].Checked = true;
                progressBar.Value++;
            }
            return;
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
