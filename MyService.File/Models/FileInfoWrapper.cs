using System.IO;

namespace MyService.Files.Models
{
    public class FileInfoWrapper
    {
        public FileInfoWrapper(FileInfo fileInfo)
        {
            Name = fileInfo.Name;
            FullName = fileInfo.FullName;
            Extension = fileInfo.Extension;
            DirectoryPath = fileInfo.DirectoryName;
            OriginalDirectoryPath = fileInfo.DirectoryName;

        }

        public string Name { get; }
        public string FullName { get; }
        public string Extension { get; }
        public string DirectoryPath { get; }
        public string OriginalDirectoryPath { get; }
    }
}
