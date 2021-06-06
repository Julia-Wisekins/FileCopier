using System;

namespace FileCopier
{
    /// <summary>
    /// used to copy from one location to another
    /// </summary>
    public interface ICopier
    {
        /// <summary>
        /// Copies from one location to another
        /// </summary>
        /// <param name="copyLocation">the location the item is copied from</param>
        /// <param name="pasteLocation">the location the item is pasted to</param>
        /// <param name="callback">method returns once each file is copied</param>
        /// <returns></returns>
        bool Copy(string copyLocation, string pasteLocation, Func<string, string, bool> callback);
    }
}
