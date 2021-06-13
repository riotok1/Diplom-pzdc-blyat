using Dining_Room.DB;
using Dining_Room.View.Pages.Admin.DishesRep;
using Dining_Room.View.Pages.Admin.ProductsRep;
using Dining_Room.View.Pages.Admin.WorkersRep;
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

namespace Dining_Room.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMainPage.xaml
    /// </summary>
    public partial class AdminMainPage : Page
    {
        private Manager selectedItem;
        public AdminMainPage(Manager selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            managerSurnameTxb.Text = selectedItem.Surname;
            managerNameTxb.Text = selectedItem.Name;
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Переход на страницу должностей
        private void workersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StaffMainPage());
        }

        //Переход на страницу блюд
        private void dishesBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DishesSystemPate());
        }

        //Переход на страницу принятых продуктов
        private void productsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductSystemPage());
        }
    }
}
