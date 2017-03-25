using Common.Logging;
using MyService.Schedulerr;
using System;
using Topshelf;

namespace ConsoleApplication5
{
    public class MyService : IDisposable
    {
        private readonly ILog _logger;
        private readonly JobScheduler _scheduler;

        public MyService()
        {
            _scheduler = new JobScheduler();
            _logger = LogManager.GetLogger("ServiceContainer");
        }

        public void Dispose()
        {
            Stop(null);
        }

        public bool Start(HostControl control)
        {
            _logger.Debug("Starting worker...");
            _scheduler.Run();
            _logger.Debug("Waiting for messages...");
            return true;
        }
        public bool Stop(HostControl control)
        {
            _logger.Debug("Stopping worker...");
            _scheduler.Stop();

            return true;
        }
    }
}
