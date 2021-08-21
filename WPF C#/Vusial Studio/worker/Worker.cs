using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
                DateTime data = new DateTime(2021,5,23,13,8,0);
                if (DateTimeOffset.Now == data)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!");
                    break;
                }
            }
        }
    }
}
