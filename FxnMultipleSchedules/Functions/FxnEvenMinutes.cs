using FxnMultipleSchedules.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FxnMultipleSchedules.Functions
{
    public class FxnEvenMinutes
    {
        private readonly INumberGeneratorService _nbrGenSvc;

        public FxnEvenMinutes(INumberGeneratorService nbrGenSvc)
        {
            _nbrGenSvc = nbrGenSvc;
        }

        [FunctionName("FxnEvenMinutes")]
        public async Task Run([TimerTrigger("0 0-58/2 * * * *")] TimerInfo myTimer, ILogger log)
        {
            var nbr = await _nbrGenSvc.GenerateANumber();
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            log.LogInformation($"The Even minutes function generated this number : {nbr}");
        }

    }
}
