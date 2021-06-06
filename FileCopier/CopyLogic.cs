using System;
using System.Threading.Tasks;

namespace FileCopier
{
    /// <summary>
    /// A singleton that handles off the logic in order to copy information
    /// </summary>
    public class CopyLogic
    {
        public event EventHandler<CopyCompleteEventArgs> CopyComplete;
        private static CopyLogic instance = null;
        private string inputLocation;
        private string outputLocation;
        private ICopier copier;
        private CopyLogic() { }

        /// <summary>
        /// gets the instance of object to ensure there is only ever one version.
        /// </summary>
        public static CopyLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CopyLogic();
                }
                return instance;

            }
        }

        /// <summary>
        /// sets the input location the item is copied from
        /// </summary>
        /// <param name="copier">the means of copying the item</param>
        /// <param name="location">the location the item is copied from</param>
        /// <returns></returns>
        internal string SetInput(ICopier copier, string location)
        {
            inputLocation = location;
            this.copier = copier;
            return location;
        }

        /// <summary>
        /// sets the output location the item is copied to
        /// </summary>
        /// <param name="location">The output location that the items will be copied to</param>
        /// <returns></returns>
        internal string SetOutput(string location)
        {
            outputLocation = location;
            return location;
        }
        /// <summary>
        /// copies items from one location to the next
        /// </summary>
        /// <param name="callback">the funtion that is called during the copy.</param>
        internal void StartCopy(Func<string, string, bool> callback)
        {
            if (string.IsNullOrWhiteSpace(inputLocation) || string.IsNullOrWhiteSpace(outputLocation))
                throw new ArgumentException("Missing input or output.");

            var t = Task.Factory.StartNew(() => copier.Copy(inputLocation, outputLocation, callback));
            t.ContinueWith((task) => CopyComplete?.Invoke(this, new CopyCompleteEventArgs() { Task = task }));
        }
    }
}
