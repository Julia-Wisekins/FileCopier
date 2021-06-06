namespace FileCopier
{
    /// <summary>
    /// Loads the Search Dialog to find the item location
    /// </summary>
    public interface ISearchDialog
    {
        /// <summary>
        /// Opens the Search Dialog
        /// </summary>
        /// <returns>returns the item location</returns>
        string OpenDialog();
    }
}
