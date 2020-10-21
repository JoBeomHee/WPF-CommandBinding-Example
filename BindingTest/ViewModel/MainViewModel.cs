using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace BindingTest
{
    public class MainViewModel
    {
        private ICommand connectCommand;
        public ICommand ConnectCommand
        {
            get
            {
                return (this.connectCommand) ?? 
                    (this.connectCommand = new DelegateCommand(Connect));
            }
        }

        private ICommand cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                return (this.cancelCommand) ?? 
                    (this.cancelCommand = new DelegateCommand(Cancel));
            }
        }

        private ICommand updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                return (this.updateCommand) ?? (this.updateCommand = new DelegateCommand(Update));
            }
        }

        private void Update()
        {
            MessageBox.Show($"Update");
        }

        private void Connect()
        {
            MessageBox.Show($"Connect");
        }

        private void Cancel()
        {
            MessageBox.Show($"Cancel");
        }
    }
}
