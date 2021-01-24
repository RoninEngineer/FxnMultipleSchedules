using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FxnMultipleSchedules.Services
{
    public interface INumberGeneratorService
    {
        Task<int> GenerateANumber();
    }
}
