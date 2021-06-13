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

namespace Dining_Room.View.Pages.Admin.ProductsRep.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        private int _balance = 1;
        private int _countJew { get; set; }

        private int _count = 1;
        private float _total { get; set; }
        private float _price { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            txbCount.Visibility = Visibility.Visible;

            staffCmb.ItemsSource = ConnectClass.db.Workers.ToList();
            staffCmb.DisplayMemberPath = "fullName";

            productCmb.ItemsSource = ConnectClass.db.Products.ToList();
            productCmb.DisplayMemberPath = "fullProduct";

            weekDayCmb.ItemsSource = ConnectClass.db.WeekCategory.Select(item => item.Day).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var basket = ConnectClass.db.Basket.ToList();
                ConnectClass.db.Basket.RemoveRange(basket);

                ConnectClass.db.SaveChanges();
               
                BasketView();
                MessageBox.Show("Поставка была успешно оформлена!");

                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAddCount_Click(object sender, RoutedEventArgs e)
        {
            _count++;
            _total += _price;
            _balance = _countJew - _count;
            totalSum.Text = _total.ToString();
            txbCount.Text = _count.ToString();
            
        }

        private void btnRemoveCount_Click(object sender, RoutedEventArgs e)
        {
            if (_count != 0)
            {
                _count--;
                _total -= _price;
            }
            _balance = _countJew + _count;
            totalSum.Text = _total.ToString();
            txbCount.Text = _count.ToString();
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Supply newSupply = new Supply();
                Basket newBasket = new Basket();

                _idClient = (staffCmb.SelectedItem as Workers).ID;
                _idProduct = (productCmb.SelectedItem as Products).ID;

                newSupply.WorkersID = _idClient;
                newSupply.ProductID = _idProduct;
                newSupply.TotalSum = _total;
                newSupply.Count = _count;
                ConnectClass.db.Supply.Add(newSupply);

                newBasket.WorkersID = _idClient;
                newBasket.ProductID = _idProduct;
                newBasket.Count = _count;
                newBasket.TotalSum = _total;
                ConnectClass.db.Basket.Add(newBasket);
                
                ConnectClass.db.SaveChanges();
                BasketView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _total = (productCmb.SelectedItem as Products).Price;
            _price = _total;
            txbCount.Visibility = Visibility.Visible;
            if (_countJew != 0)
            {
                _count = 1;
                txbCount.Text = _count.ToString();
                totalSum.Text = _total.ToString();
            }
        }

        private int _idClient;
        private int _idProduct;

        private void BasketView()
        {
            dataView.ItemsSource = ConnectClass.db.Basket.Where(item => item.WorkersID == _idClient).ToList();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedRemove = dataView.SelectedItem as Basket;
            if (selectedRemove != null)
            {
                ConnectClass.db.Basket.Remove(selectedRemove);
                ConnectClass.db.SaveChanges();
                BasketView();
            }
        }
    }
}
