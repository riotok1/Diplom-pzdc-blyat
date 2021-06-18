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

namespace Dining_Room.View.Pages.Admin.DishesRep.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для YesterdayMenuPage.xaml
    /// </summary>
    public partial class YesterdayMenuPage : Page
    {
        private int _balance = 1;
        private int _countDish { get; set; }

        private int _count = 1;
        private float _total { get; set; }
        private float _price { get; set; }
        public YesterdayMenuPage()
        {
            InitializeComponent();

            txbCount.Visibility = Visibility.Hidden;

            dishCmb.ItemsSource = ConnectClass.db.Dish.ToList();
            dishCmb.DisplayMemberPath = "fullDish";

            staffCmb.ItemsSource = ConnectClass.db.Workers.ToList();
            staffCmb.DisplayMemberPath = "fullName";

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                YesterdayMenu newDish = new YesterdayMenu();
                DishBacket newDishBasket = new DishBacket();

                _idClient = (staffCmb.SelectedItem as Workers).ID;
                _idDish = (dishCmb.SelectedItem as Dish).ID;

                newDish.CookID = _idClient;
                newDish.DishID = _idDish;
                newDish.TotalSum = _total;
                newDish.Count = _count;
                ConnectClass.db.YesterdayMenu.Add(newDish);

                var selectedCount = ConnectClass.db.Dish.FirstOrDefault(item => item.ID == newDish.DishID);
                selectedCount.Count = _balance;
                newDishBasket.WorkerID = _idClient;
                newDishBasket.DishID = _idDish;
                newDishBasket.TotalSum = _total;
                newDishBasket.Count = _count;
                ConnectClass.db.DishBacket.Add(newDishBasket);

                ConnectClass.db.SaveChanges();
                BasketView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var basket = ConnectClass.db.DishBacket.ToList();
                ConnectClass.db.DishBacket.RemoveRange(basket);

                ConnectClass.db.SaveChanges();

                BasketView();
                MessageBox.Show("Меню было успешно сформировано!");

                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedRemove = dataView.SelectedItem as DishBacket;
            if (selectedRemove != null)
            {
                ConnectClass.db.DishBacket.Remove(selectedRemove);
                ConnectClass.db.SaveChanges();
                BasketView();
            }
        }

        private void dishCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _countDish = (dishCmb.SelectedItem as Dish).Count;
            _total = (dishCmb.SelectedItem as Dish).Price;
            _price = _total;
            txbCount.Visibility = Visibility.Visible;
            if (_countDish != 0)
            {
                _count = 1;
                txbCount.Text = _count.ToString();
                totalSum.Text = _total.ToString();
            }
            else
            {
                MessageBox.Show("Данного блюда нет в наличии.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txbCount.Text = "0";
                totalSum.Text = "0";
            }
        }

        private void totalSum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void staffCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddCount_Click(object sender, RoutedEventArgs e)
        {
            txbCount.Visibility = Visibility.Visible;
            if (_countDish != 0)
            {
                if (_countDish == _count)
                {
                    MessageBox.Show("Данного блюда не осталось на кухне", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    _count++;
                    _balance = _countDish - _count;
                    _total += _price;

                }
                totalSum.Text = _total.ToString();
                txbCount.Text = _count.ToString();
            }
            else
            {
                MessageBox.Show("Данного блюда не осталось на кухне", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnRemoveCount_Click(object sender, RoutedEventArgs e)
        {
            if (_count != 0)
            {
                _count--;
                _total -= _price;
            }
            _balance = _countDish + _count;
            totalSum.Text = _total.ToString();
            txbCount.Text = _count.ToString();
        }

        private int _idClient;
        private int _idDish;

        private void BasketView()
        {
            dataView.ItemsSource = ConnectClass.db.DishBacket.Where(item => item.WorkerID == _idClient).ToList();
        }
    }
}
