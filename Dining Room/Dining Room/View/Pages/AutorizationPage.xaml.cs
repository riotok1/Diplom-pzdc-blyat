using Dining_Room.Classes;
using Dining_Room.View.Pages.Admin;
using Dining_Room.View.Pages.Admin.DishesRep;
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

namespace Dining_Room.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        //Войти от имени администратора
        private void adminBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = ConnectClass.db.Manager.FirstOrDefault(item => item.SignIn.LogIn == loginTxb.Text && item.SignIn.Password == passTxb.Password);
                var secondCurrentUser = ConnectClass.db.Workers.FirstOrDefault(item => item.SignIn.LogIn == loginTxb.Text && item.SignIn.Password == passTxb.Password);
                if(currentUser != null)
                {
                    switch (currentUser.SignIn.RoleID)
                    {
                        case "A":
                            NavigationService.Navigate(new AdminMainPage(currentUser));
                            break;
                    }
                }
                else
                {
                    if (secondCurrentUser != null)
                    {
                        switch (secondCurrentUser.SignIn.RoleID)
                        {
                            case "C":
                                NavigationService.Navigate(new DishesMainPage());
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception("Проверьте корректность введенных данных!");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
