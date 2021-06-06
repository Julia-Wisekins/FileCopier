using System.Windows.Forms;

namespace FileCopier
{
    /// <summary>
    ///displays the file search
    /// </summary>
    class FileSearchDialog : ISearchDialog
    {
        private readonly OpenFileDialog ofd;
        public FileSearchDialog()
        {
            ofd = new OpenFileDialog();
        }

        public string OpenDialog()
        {
            var dialogResult = ofd.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return ofd.FileName;

            //if no dialog result was found
            return string.Empty;

        }
    }
}
