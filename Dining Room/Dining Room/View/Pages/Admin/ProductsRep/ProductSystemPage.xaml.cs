using Dining_Room.View.Pages.Admin.ProductsRep.Market;
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

namespace Dining_Room.View.Pages.Admin.ProductsRep
{
    /// <summary>
    /// Логика взаимодействия для ProductSystemPage.xaml
    /// </summary>
    public partial class ProductSystemPage : Page
    {
        public ProductSystemPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void productsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketMainPAge());
        }

        private void deliveryBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeliveryMainPage());
        }
    }
}
