using MyService.Files.SourceFolder;
using SimpleInjector;

namespace MyService.Schedulerr.IoCContainer
{
    public static class SimpleInjectorConfig
    {
        private static Container _container = new Container();

        public static Container Container
        {
            get
            {
                return _container;
            }
        }
        public static void RegisterInjections()
        {
            _container.Register<ISourceFolderScanner, SourceFolderScanner>();
            _container.Verify();
        }
    }
}
