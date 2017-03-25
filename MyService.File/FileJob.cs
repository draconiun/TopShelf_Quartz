using Common.Logging;
using MyService.Files.SourceFolder;
using Quartz;
using System.IO;

namespace MyService.Files
{
    public class FileJob : IJob
    {
        private readonly ISourceFolderScanner _sourceFolderScanner;
        private ILog _logger = LogManager.GetLogger<FileJob>();
        public FileJob(ISourceFolderScanner sourceFolderScanner)
        {
            _sourceFolderScanner = sourceFolderScanner;
        }
        public void Execute(IJobExecutionContext context)
        {
            var filess = _sourceFolderScanner.Get();

            foreach (var file in filess)
            {
                
                var file2 = new FileInfo(file.FullName);

                var newFile = $@"C:\Tmp\destino\{file.Name}";
                if (File.Exists(newFile))
                {
                    _logger.Info($"Deleting file : {file.FullName}");
                    File.Delete(newFile);
                }
                _logger.Info($"Moving file : {file.FullName}");
                file2.MoveTo(newFile);
                
                
            }
        }
    }
}
