using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherApp.Commands
{
    public class SettingsCommand : ICommand
    {
        readonly Action<object> action;
        readonly Predicate<object> predicate;

        public SettingsCommand(Action<object> action, Predicate<object> predicate = null)
        {
            this.action = action;
            this.predicate = predicate;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            if (predicate != null)
                return predicate(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
