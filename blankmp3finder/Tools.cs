using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace blankmp3finder
{
    static class Tools
    {

        public static List<string> GetListOfBlankMP3(ProgressBar progressBar, string path)
        {
            List<string> blankMP3paths = new List<string>();
            string[] pathsToMP3s = Directory.GetFiles(path, "*.mp3", SearchOption.AllDirectories);

            progressBar.Invoke((MethodInvoker)(() => progressBar.Maximum = pathsToMP3s.Length));

            foreach (string mp3 in pathsToMP3s)
            {

                TagLib.File tagFile = TagLib.File.Create(mp3);

                string comment = tagFile.Tag.Comment;
                string album = tagFile.Tag.Album;
                string artist = tagFile.Tag.FirstAlbumArtist;
                string title = tagFile.Tag.Title;

                //check to see if tags are blank
                if (comment == null &&
                    album == null &&
                    artist == null &&
                    title == null)
                {
                    blankMP3paths.Add(mp3);
                }

                progressBar.Invoke((MethodInvoker)(() => progressBar.PerformStep()));
            }

            return blankMP3paths;
        }

        public static void AddABlankSpaceToTags(ProgressBar progressBar, List<string> mp3Paths)
        {
            progressBar.Invoke((MethodInvoker)(() => progressBar.Maximum = mp3Paths.Count));

            foreach (string mp3 in mp3Paths)
            {
                TagLib.File tagFile = TagLib.File.Create(mp3);

                tagFile.Tag.Comment = " ";
                tagFile.Save();
                progressBar.Invoke((MethodInvoker)(() => progressBar.PerformStep()));
            }
        }
    }
}
