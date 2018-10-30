using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            var executionManager = new ExecutionManager();
            var opManager = new OperationManager(20, 10, executionManager);
            var result = opManager.Execute(Operation.Sum);
            Console.WriteLine($"The result of the operation is {result}");

            Console.ReadKey();
        }
    }
}
