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
using demo_ekz.DataApp;
using System;
using System.Globalization;
using System.Windows.Data;

namespace demo_ekz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public Products products = new Products();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = products;
            ProductGrid.ItemsSource = demo_yag_tolEntities.GetContext().Products.ToList();
            
        }

    }
}
