using Quartz;
using SimpleInjector;
using Quartz.Impl;
using MyService.Schedulerr.IoCContainer;

namespace MyService.Schedulerr
{
    public class JobScheduler
    {
        public string Name => GetType().Name;
        private Container Container { get; }
        private IScheduler Scheduler { get; }

        public JobScheduler()
        {            
            SimpleInjectorConfig.RegisterInjections();

            Container = SimpleInjectorConfig.Container;

            ISchedulerFactory sf = new StdSchedulerFactory();
            Scheduler = sf.GetScheduler();
        }


        public void Run()
        {
            Scheduler.JobFactory = new SimpleInjectorJobFactory(Container);
            Scheduler.Start();
        }

        public void Stop()
        {
            if (Scheduler != null)
                Scheduler.Shutdown();
        }
    }
}
