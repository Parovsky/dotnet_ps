using StudentInfoSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem.Command
{
    public class LoginCommand : ICommand
    {
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

        public bool CanExecute(object? parameter)
        {
            var userLogin = parameter as UserLoginModel;
            return userLogin != null && userLogin.UserName.Count() > 0 && userLogin.Password.Count() > 0;
        }

        public void Execute(object? parameter)
        {
            var userLogin = parameter as UserLoginModel;
            var user = UserData.IsUserPassCorrect(userLogin.UserName, userLogin.Password);
            var studentInfoView = new StudentInfo(user);
            studentInfoView.Show();
        }
    }
}
