using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DZ_WPF04
{
    public class RemoveFromCollection : ICommand
    {
        private readonly Action<object> _action;
        private readonly Predicate<object> _predicate;

        public RemoveFromCollection (Action<object> action, Predicate<object> predicate)
        {
            _action = action;
            _predicate = predicate;
        }

        public RemoveFromCollection(Action<object> action)
        {
            _action = action;
            _predicate = p => true;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return _predicate?.Invoke(parameter) ?? false;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke(parameter);
        }

    }
}
