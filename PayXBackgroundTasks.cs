using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PayxApi.Interfaces.Services;

namespace PayxApi
{
    public class PayXBackgroundTasks : BackgroundService
    {
        protected readonly IServiceProvider _serviceProvider;
        public PayXBackgroundTasks(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (stoppingToken.IsCancellationRequested)
            {
                using(var scope = _serviceProvider.CreateScope())
                {
                    var payrollService = scope.ServiceProvider.GetRequiredService<IPayrollService>();
                    await payrollService.GeneratePayrollForWeeklyPayee();
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
            }
        }
    }
}