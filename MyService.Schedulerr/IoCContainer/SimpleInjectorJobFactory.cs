using Quartz;
using Quartz.Spi;
using SimpleInjector;

namespace MyService.Schedulerr.IoCContainer
{
    public class SimpleInjectorJobFactory : IJobFactory
    {
        private Container Container { get; }

        public SimpleInjectorJobFactory(Container container)
        {
            Container = container;
        }
        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            return (IJob)Container.GetInstance(bundle.JobDetail.JobType);
        }

        public void ReturnJob(IJob job)
        {

        }
    }
}
