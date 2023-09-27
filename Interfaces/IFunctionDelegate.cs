using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo.Interfaces
{
    public interface IFunctionDelegate<TInput, TOutput>
    {
        TOutput Execute(TInput input);
    }
}
