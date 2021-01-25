using System.Threading.Tasks;

namespace FxnMultipleSchedules.Services
{
    public interface INumberGeneratorService
    {
        Task<int> GenerateANumber();
    }
}
