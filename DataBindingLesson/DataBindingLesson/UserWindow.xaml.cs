using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBindingLesson
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();

            User user = new User
            {
                Id = 1,
                Login = "admin",
                Password = "admin"
            };

            loginLabel.Content = user.Login;
            passwordLabel.Content = user.Password;

            //loginTextBox.Text = user.Login;
            //passwordTextBox.Text = user.Password;
        }
    }
}
