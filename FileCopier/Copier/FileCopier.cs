using System;

namespace FileCopier
{
    /// <summary>
    /// used to copy files
    /// </summary>
    public class FileCopier : ICopier
    {
        bool ICopier.Copy(string copyLocation, string pasteLocation, Func<string, string, bool> callback)
        {
            return Copy_Directory.Copier.CopyFile(copyLocation, pasteLocation, callback);
        }
    }
}
