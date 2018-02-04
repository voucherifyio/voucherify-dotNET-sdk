using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voucherify.Client.Example.net45
{
    public interface IUseCase
    {
        Task Run(Voucherify.Client.Api api);
    }
}
