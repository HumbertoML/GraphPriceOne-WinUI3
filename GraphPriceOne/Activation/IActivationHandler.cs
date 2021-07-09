using System.Threading.Tasks;

namespace GraphPriceOne.Activation
{
    public interface IActivationHandler
    {
        bool CanHandle(object args);

        Task HandleAsync(object args);
    }
}
