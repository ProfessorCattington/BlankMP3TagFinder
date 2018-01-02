using System;
using System.IO;
using System.Windows.Forms;

namespace blankmp3finder
{
    public class FolderBrowser
    {
        public static string Show()
        {
            string directory = null;
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = "c:\\",
                Description = "Select Source Folder"
            };

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                directory = folderDialog.SelectedPath;
            }
            return directory;
        }
    }
}
