using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExecution
{
    public class OperationManager
    {
        private int _first;
        private int _second;
        private readonly ExecutionManager _executionManager;

        public OperationManager(int first, int second, ExecutionManager executionManager)
        {
            _first = first;
            _second = second;
            _executionManager = executionManager;
            _executionManager.PopulateFunctions(Sum, Subtract, Multiply);
            _executionManager.PrepareExecution();
        }

        private int Sum()
        {
            return _first + _second;
        }

        private int Subtract()
        {
            return _first - _second;
        }

        private int Multiply()
        {
            return _first * _second;
        }

        public int Execute(Operation operation)
        {
            return _executionManager.FuncExecute.ContainsKey(operation) ?
                _executionManager.FuncExecute[operation]() :
                -1;
        }
    }
}
