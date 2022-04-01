using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NCrontab;
using PayxApi.Configuration;
using PayxApi.Interfaces.Services;

namespace PayxApi.BackgroundTasks
{
    public class WeeklyGenerator : BackgroundService
    {
        private readonly PayxPayrollConfig _configuration;
        private CrontabSchedule _schedule;
        private DateTime _nextRun;
        private readonly ILogger<WeeklyGenerator> _logger;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public WeeklyGenerator(IServiceScopeFactory serviceScopeFactory,
        IOptions<PayxPayrollConfig> configuration, ILogger<WeeklyGenerator> logger)
        {
            _configuration = configuration.Value;
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
            _schedule = CrontabSchedule.Parse(_configuration.CronExpression);
            _nextRun = _schedule.GetNextOccurrence(DateTime.UtcNow);
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var now = DateTime.UtcNow;
                try
                {
                    using (var scope = _serviceScopeFactory.CreateScope())
                    {
                        var payrollService = scope.ServiceProvider.GetRequiredService<IPayrollService>();
                        await payrollService.GeneratePayrollForWeeklyPayee();
                    }

                }
                catch(Exception ex)
                {
                    _logger.LogError($"Error occured generating the weekly payroll. {ex.Message}");
                    _logger.LogError(ex, ex.Message);
                }
                _logger.LogInformation($"Background hosted service for {nameof(WeeklyGenerator)} is stopping");
                var timespan = _nextRun - now;
                await Task.Delay(timespan, stoppingToken);
                _nextRun = _schedule.GetNextOccurrence(DateTime.UtcNow);


            }
        }
    }
}