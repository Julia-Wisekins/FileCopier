using System.Threading.Tasks;

namespace FileCopier
{
    public class CopyCompleteEventArgs
    {
        public Task Task { get; set; }
    }
}
