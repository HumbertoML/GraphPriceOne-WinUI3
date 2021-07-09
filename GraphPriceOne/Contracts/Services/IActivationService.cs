using System.Threading.Tasks;

namespace GraphPriceOne.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
