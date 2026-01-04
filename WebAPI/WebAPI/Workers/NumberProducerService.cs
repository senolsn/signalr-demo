using Microsoft.AspNetCore.SignalR;
using WebAPI.Helpers;
using WebAPI.Hubs;

namespace WebAPI.Workers
{
    public class NumberProducerService : BackgroundService
    {
        private readonly GenerateRandomNumberService _generateRandomNumberService;
        private readonly IHubContext<NumberHub> _hubContext;
        public NumberProducerService(GenerateRandomNumberService generateRandomNumberService, IHubContext<NumberHub> hubContext)
        {
            _generateRandomNumberService = generateRandomNumberService;
            _hubContext = hubContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _generateRandomNumberService.Generate();

                await _hubContext.Clients.All.SendAsync("ReceiveNumber", _generateRandomNumberService.CurrentValue);

                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}
