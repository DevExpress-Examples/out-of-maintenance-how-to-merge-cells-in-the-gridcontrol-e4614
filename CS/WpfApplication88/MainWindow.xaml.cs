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

namespace WpfApplication88
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Product> customers = new ObservableCollection<Product>();
            customers.Add(new Product() { ID = 0, Name = "Product1", Category = "Category1" });
            customers.Add(new Product() { ID = 1, Name = "Product2", Category = "Category1" });
            customers.Add(new Product() { ID = 2, Name = "Product3", Category = "Category2" });
            customers.Add(new Product() { ID = 3, Name = "Product4", Category = "Category2" });
            customers.Add(new Product() { ID = 4, Name = "Product5", Category = "Category1" });
            customers.Add(new Product() { ID = 5, Name = "Product6", Category = "Category3" });
            grid.ItemsSource = customers;
        }
    }

    public class Product
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
    }
}
