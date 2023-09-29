using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo.Interfaces
{
    public interface IActionDelegate<TInput>
    {
        void Execute(TInput input);
    }
}
