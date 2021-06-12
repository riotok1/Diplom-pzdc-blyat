using Dining_Room.Classes;
using Dining_Room.DB;
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

namespace Dining_Room.View.Pages.Admin.ProductsRep.Market
{
    /// <summary>
    /// Логика взаимодействия для MarketMainPAge.xaml
    /// </summary>
    public partial class MarketMainPAge : Page
    {
        public MarketMainPAge()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Products.ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarketAddPage());
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Products editProduct = (Products)listDataView.SelectedItem;
                if(editProduct != null)
                {
                    NavigationService.Navigate(new MarketEditPage(editProduct));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите элемент!");
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Products editProduct = (Products)listDataView.SelectedItem;
                if (editProduct != null)
                {
                    if(MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.OK, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Products.Remove(editProduct);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите элемент!");
            }
        }
    }
}
