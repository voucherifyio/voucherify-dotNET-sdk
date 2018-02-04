using System.Threading.Tasks;

namespace Voucherify.Example.net45
{
    public interface IUseCase
    {
        Task Run(Voucherify.Api api);
    }
}
