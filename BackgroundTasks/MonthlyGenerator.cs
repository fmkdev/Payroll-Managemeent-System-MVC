using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace PayxApi.BackgroundTasks
{
    public class MonthlyGenerator : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new System.NotImplementedException();
        }
    }
}