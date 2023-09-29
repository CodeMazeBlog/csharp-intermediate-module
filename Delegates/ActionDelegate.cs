using DelegatesDemo.Interfaces;

namespace DelegatesDemo.Delegates
{
   
    public class ActionDelegate<TInput> : IActionDelegate<TInput>
    {
        private readonly Action<TInput> _action;

        public ActionDelegate(Action<TInput> action)
        {
            _action = action;
        }

        public void Execute(TInput input)
        {
            _action(input);
        }
    }
}
