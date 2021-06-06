using System;

namespace FileCopier
{
    /// <summary>
    /// used to copy folders
    /// </summary>
    public class FolderCopier : ICopier
    {
        public bool Copy(string copyLocation, string pasteLocation, Func<string, string, bool> callback)
        {
            return Copy_Directory.Copier.CopyDirectory(copyLocation, pasteLocation, callback);
        }
    }
}
