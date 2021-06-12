using Dining_Room.Classes;
using Dining_Room.View.Pages.Admin.ProductsRep.FunctionsWithData;
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
    /// Логика взаимодействия для DeliveryMainPage.xaml
    /// </summary>
    public partial class DeliveryMainPage : Page
    {
        public DeliveryMainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Supply.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage());
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
