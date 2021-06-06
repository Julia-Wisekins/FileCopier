using System.Windows.Forms;

namespace FileCopier
{
    /// <summary>
    /// displays the folder search
    /// </summary>
    internal class FolderSearchDialog : ISearchDialog
    {
        private readonly FolderBrowserDialog fbd;
        public FolderSearchDialog()
        {
            fbd = new FolderBrowserDialog();
        }
        public string OpenDialog()
        {
            var dialogResult = fbd.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return fbd.SelectedPath;
            
            //if no dialog result was found
            return string.Empty;

        }
    }
}
