using System;
using System.Threading.Tasks;

namespace FxnMultipleSchedules.Services
{
    public class NumberGeneratorService : INumberGeneratorService
    {
        public async Task<int> GenerateANumber()
        {
            var random = new Random();
            return await Task.Run(() => random.Next(1, 1000));
        }
    }
}
