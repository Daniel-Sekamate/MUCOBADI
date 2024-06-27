using MUCOBADI.Emailhelper;
using MUCOBADI.Models;
using Quartz;
using System.Threading.Tasks;

namespace MUCOBADI.ScheduleTask
{
    public class MonthlySchedule : IJob
    {
        EmailSender email = new EmailSender();
        private SPToCoreContext db;
        public Task Execute(IJobExecutionContext context)
        {
            var serviceScope = ServiceActivator.GetScope();
            db = (SPToCoreContext)serviceScope.ServiceProvider.GetService(typeof(SPToCoreContext));
            LoadData();
            return Task.CompletedTask;
        }
        private async void LoadData()
        {

        }
    }
}
