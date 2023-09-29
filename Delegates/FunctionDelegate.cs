using DelegatesDemo.Interfaces;

namespace DelegatesDemo.Delegates
{
    public class FunctionDelegate<TInput, TOutput> : IFunctionDelegate<TInput, TOutput>
    {
        private readonly Func<TInput, TOutput> _function;
        public FunctionDelegate(Func<TInput, TOutput> function)
        {
            _function = function;
        }

        public TOutput Execute(TInput input)
        {
            return _function(input);
        }
    }
}
