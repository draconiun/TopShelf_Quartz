using MyService.Files.Models;
using System.Collections.Generic;

namespace MyService.Files.SourceFolder
{
    public interface ISourceFolderScanner
    {
        IEnumerable<FileInfoWrapper> Get();
    }
}
