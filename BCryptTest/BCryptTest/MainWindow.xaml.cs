using DevOne.Security.Cryptography.BCrypt;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BCryptTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string hashedPassword;
        private string login;
        private string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            GetInputUserData(out login, out password);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                //зашифровать и сохранить
                hashedPassword = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());
                MessageBox.Show(hashedPassword);
            }
        }

        private void CheckUser_Click(object sender, RoutedEventArgs e)
        {
            GetInputUserData(out login,out password);
            if (CheckUserInputOnEmptyString())
            {
                string newHashString = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());
                MessageBox.Show(newHashString);

                bool isEquals = BCryptHelper.CheckPassword(password, hashedPassword);

                if (isEquals) MessageBox.Show("Equals");
                else MessageBox.Show("Не Equals");
            }
        }

        private bool CheckUserInputOnEmptyString()
        {
            return !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
        }

        private void GetInputUserData(out string login, out string password)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;
            
        }
    }
}
