using System;
using System.Windows.Forms;

namespace FileCopier
{
    /// <summary>
    /// Options the user can pick
    /// </summary>
    public enum FolderFileCancel { Cancel, Folder, File }
    /// <summary>
    /// Allows the user to chose what kind of item they wish to copy
    /// </summary>
    public partial class FolderFileChoice : Form
    {
        /// <summary>
        /// The Result of the dialog
        /// </summary>
        public FolderFileCancel Result { get; private set; }
        public FolderFileChoice()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sets the user input to folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFolder_Click(object sender, EventArgs e)
        {
            Result = FolderFileCancel.Folder;
            this.Close();
        }
        /// <summary>
        /// sets the user input to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            Result = FolderFileCancel.File;
            this.Close();
        }
        /// <summary>
        /// cancels the action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
