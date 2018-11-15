using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Command;
using LoginExample.Annotations;

namespace LoginExample
{
    class ViewModel : INotifyPropertyChanged
    {
        List<User> userList = new List<User>();
        private RelayCommand _buttonCommand;

        public ViewModel()
        {
            userList.Add(new User("Nikolaj", "Passw123"));
            userList.Add(new User("Johan", "Passw321"));
            userList.Add(new User("Jonas", "Passw213"));

            _buttonCommand = new RelayCommand(LoginProcess);
        }

        public RelayCommand ButtonCommand
        {
            get { return _buttonCommand; }
            set { _buttonCommand = value; }
        }
        
        public void LoginProcess()
        {
            UsernameInput.Text;

        }

        private void CheckLogin(string user, string pass)
        {
            if 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
