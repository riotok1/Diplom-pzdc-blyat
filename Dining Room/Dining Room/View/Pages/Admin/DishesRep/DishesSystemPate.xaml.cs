using Dining_Room.View.Pages.Admin.DishesRep.FunctionsWithData;
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

namespace Dining_Room.View.Pages.Admin.DishesRep
{
    /// <summary>
    /// Логика взаимодействия для DishesSystemPate.xaml
    /// </summary>
    public partial class DishesSystemPate : Page
    {
        public DishesSystemPate()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void yesterdayMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new YesterdayMenuPage());
        }

        private void yesterdayMenuViewBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new YesterdayMenuViewPage());
        }
    }
}
