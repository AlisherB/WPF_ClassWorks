using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        ObservableCollection<User> users;
        public UsersWindow()
        {
            InitializeComponent();

            users = new ObservableCollection<User>
            (
                new List<User>
                {
                    new User
                    {
                        Id=1,Login="Alisher",Password="123"
                    },
                    new User
                    {
                        Id=2,Login="Alisher1",Password="123"
                    },
                    new User
                    {
                        Id=3,Login="Alisher2",Password="123"
                    },
                    new User
                    {
                        Id=4,Login="Alisher3",Password="123"
                    }
                }
            );
            usersGrid.ItemsSource = users;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            users[0].Login = loginTextBox.Text;
        }
    }
}
