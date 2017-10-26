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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Products> products;
        public MainWindow()
        {
            InitializeComponent();
            
            products = new ObservableCollection<Products>
            (
                new List<Products>
                {
                    new Products
                    {
                        Id = 1, Name = "Хлеб", Price = 120, Date = DateTime.Today
                    },
                    new Products
                    {
                        Id = 2, Name = "Молоко", Price = 400, Date = DateTime.Today
                    },
                    new Products
                    {
                        Id = 3, Name = "Мука", Price = 200, Date = DateTime.Today
                    },
                }
            );
            productsGrid.ItemsSource = products;
        }
    }
}
