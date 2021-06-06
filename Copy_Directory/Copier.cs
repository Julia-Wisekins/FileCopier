using System;
using System.IO;

namespace Copy_Directory
{
    /// <summary>
    /// Used to copy files or folders from one location to another.
    /// </summary>
    public static class Copier
    {
        /// <summary>
        /// Copies one folder to another location
        /// </summary>
        /// <param name="copyLocation">the location the folder is copied from</param>
        /// <param name="pasteLocation">the location the folder is pasted to</param>
        /// <param name="callback">method returns once each file is copied</param>
        /// <returns></returns>
        public static bool CopyDirectory(string copyLocation, string pasteLocation, Func<string, string, bool> callback)
        {
            if (!Directory.Exists(copyLocation))            
                throw new IOException($"The copy location \"{copyLocation}\" was not found");
           
            foreach (var d in Directory.GetDirectories(copyLocation))            
                CopyDirectory(d, Path.Combine(pasteLocation, Path.GetFileName(d)), callback);

            Directory.CreateDirectory(pasteLocation);
            foreach (var inputLocation in Directory.GetFiles(copyLocation))
            {
                var outPutLocation = Path.Combine(pasteLocation, Path.GetFileName(inputLocation));
                File.Copy(inputLocation, outPutLocation, true);
                callback?.Invoke(inputLocation, outPutLocation);
            }
            return true;
        }
        /// <summary>
        /// Copies one file to another location
        /// </summary>
        /// <param name="copyLocation">the location the file is copied from</param>
        /// <param name="pasteLocation">the location the file is pasted to</param>
        /// <param name="callback">method returns once each file is copied</param>
        /// <returns></returns>
        public static bool CopyFile(string copyLocation, string pasteLocation, Func<string, string, bool> callback)
        {
            if (!File.Exists(copyLocation))
                throw new IOException($"The copy location \"{copyLocation}\" was not found");

            Directory.CreateDirectory(pasteLocation);
            foreach (var inputLocation in Directory.GetFiles(copyLocation))
            {
                var outPutLocation = Path.Combine(pasteLocation, Path.GetFileName(inputLocation));
                File.Copy(inputLocation, outPutLocation, true); 
                callback?.Invoke(inputLocation, outPutLocation);
            }
            return true;
        }
    }
}
