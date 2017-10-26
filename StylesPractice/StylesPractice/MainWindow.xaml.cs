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

namespace StylesPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string> { "LightDictionary", "DarkDictionary", "PurpleDictionary" };
            comboBox.SelectionChanged += ThemeChange;
            comboBox.ItemsSource = styles;
            comboBox.SelectedItem = "dark";
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = comboBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        private void LightComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void DarkComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void PurpleComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
