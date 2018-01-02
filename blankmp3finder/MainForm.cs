using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace blankmp3finder
{
    public partial class MainForm : Form
    {

        List<string> blankMP3s;
        int numberOfFiles;

        public MainForm()
        {
            blankMP3s = new List<string>();
            InitializeComponent();
            SetupDGV();

            searchButton.Enabled = false;
            blankButton.Enabled = false;
        }

        private void SetupDGV()
        {

            DataGridViewColumn pathColumn = dataGridView1.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            pathColumn.Width = dataGridView1.Width;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            string filePath = FolderBrowser.Show();
            sourcePathTextBox.Text = filePath;
            searchButton.Enabled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            SearchButtonClicked();
        }

        private async void SearchButtonClicked()
        {
            //clear the DGV rows
            dataGridView1.Rows.Clear();
            blankMP3s.Clear();
            searchProgress.Minimum = 1;
            searchProgress.Value = 1;
            searchProgress.Step = 1;

            searchButton.Enabled = false;
            browseButton.Enabled = false;

            blankMP3s = await Tools.GetListOfBlankMP3(searchProgress, sourcePathTextBox.Text);

            searchButton.Enabled = true;
            browseButton.Enabled = true;

            foreach (string path in blankMP3s)
            {

                dataGridView1.Rows.Add(path);
            }

            if (blankMP3s.Count > 0)
            {
                blankButton.Enabled = true;
            }

        }

        private void blankButton_Click(object sender, EventArgs e)
        {

            BlankSpaceButtonClicked();
        }

        private async void BlankSpaceButtonClicked()
        {

            searchProgress.Minimum = 1;
            searchProgress.Value = 1;
            searchProgress.Step = 1;

            searchButton.Enabled = false;
            browseButton.Enabled = false;
            blankButton.Enabled = false;

            await Tools.AddABlankSpaceToTagsAsync(searchProgress, blankMP3s);

            searchButton.Enabled = true;
            browseButton.Enabled = true;
        }
    }
}
