using System;
using System.Windows.Forms;

namespace FileCopier
{
    public partial class FileCopying : Form
    {
        public FileCopying()
        {
            InitializeComponent();
        }

        private void FileCopyingTest_test_Load(object sender, EventArgs e) { }
        /// <summary>
        /// loads a dialog box to let the user decide whether they wish to copy a folder or a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            var folderOrFile = new FolderFileChoice();
            folderOrFile.ShowDialog();
            var result = folderOrFile.Result;
            ICopier copier;

            ISearchDialog dialog;
            switch (result)
            {
                case FolderFileCancel.Folder:
                    dialog = new FolderSearchDialog();
                    copier = new FolderCopier();
                    break;
                case FolderFileCancel.File:
                    dialog = new FileSearchDialog();
                    copier = new FileCopier();
                    break;
                default:
                    return;
            }

            txtInputDirectory.Text = CopyLogic.Instance.SetInput(copier, dialog.OpenDialog());

        }
        /// <summary>
        /// selects the location the items will be copied too 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutputFolderLocation_Click(object sender, EventArgs e)
        {
            txtOutputDirectory.Text = CopyLogic.Instance.SetOutput(new FolderSearchDialog().OpenDialog());

        }
        /// <summary>
        /// Copies the items the user has selected from one location to the next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCopying_Click(object sender, EventArgs e)
        {
            try
            {
                CopyLogic.Instance.CopyComplete += CopyLogic_CopyComplete;
                CopyLogic.Instance.StartCopy(new Func<string, string, bool>(CallBack));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Updates the UI to let the user know which files have been copied
        /// </summary>
        /// <param name="inputLocation">the location the item was copied from</param>
        /// <param name="outputLocation">the location the item was copied too</param>
        /// <returns></returns>
        private bool CallBack(string inputLocation, string outputLocation)
        {
            this.dgvInputOutputDisplay.Invoke((MethodInvoker)delegate { dgvInputOutputDisplay.Rows.Add(true, inputLocation, outputLocation); });

            return true;
        }
        /// <summary>
        /// Displays a message once all itemes have been copied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyLogic_CopyComplete(object sender, CopyCompleteEventArgs e)
        {
            if (e.Task.IsFaulted)
                MessageBox.Show(e.Task.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Copy Complete", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CopyLogic.Instance.CopyComplete -= CopyLogic_CopyComplete;
        }
    }
}
