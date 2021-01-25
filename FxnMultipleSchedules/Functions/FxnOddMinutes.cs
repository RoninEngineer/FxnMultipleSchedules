using FxnMultipleSchedules.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FxnMultipleSchedules
{
    public class FxnOddMinutes
    {
        private readonly INumberGeneratorService _nbrGenSvc;

        public FxnOddMinutes(INumberGeneratorService nbrGenSvc)
        {
            _nbrGenSvc = nbrGenSvc;
        }

        [FunctionName("FxnOddMinutes")]
        public async Task Run([TimerTrigger("0 1-59/2 * * * *")]TimerInfo myTimer, ILogger log)
        {
            var nbr = await _nbrGenSvc.GenerateANumber();
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            log.LogInformation($"The Odd minutes function generated this number : {nbr}");
        }
    }
}
