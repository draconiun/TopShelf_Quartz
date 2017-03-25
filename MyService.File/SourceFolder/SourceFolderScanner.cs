using MyService.Files.Models;
using MyService.Files.SourceFolder;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyService.Files.SourceFolder
{
    public class SourceFolderScanner : ISourceFolderScanner
    {
        public IEnumerable<FileInfoWrapper> Get()
        {
            var directoryInfo = new DirectoryInfo(@"C:\Tmp");
            var files = directoryInfo.GetFiles();

            foreach (var ioFileInfo in files)
            {
                yield return new FileInfoWrapper(ioFileInfo);
            }
        }
    }
}
