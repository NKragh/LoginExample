using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace LoginExample
{
    class ViewModel
    {
        List<User> userList = new List<User>();
        private RelayCommand _buttonCommand;

        public ViewModel()
        {
            userList.Add(new User("Nikolaj", "Passw123"));
            userList.Add(new User("Johan", "Passw321"));
            userList.Add(new User("Jonas", "Passw213"));
            
            _buttonCommand = new RelayCommand(CheckLogin());
        }

        public RelayCommand ButtonCommand
        {
            get { return _buttonCommand; }
            set { _buttonCommand = value; }
        }


        public void CheckLogin()
        {
            bool placeholder = false;

            foreach (var t in userList)
            {
                if (t == inputUser)
                {
                    placeholder = true;
                }
            }

            if (placeholder)
            {
                
            }
        }
    }
}
