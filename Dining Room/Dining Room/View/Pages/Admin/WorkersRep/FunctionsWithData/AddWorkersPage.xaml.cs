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

namespace Dining_Room.View.Pages.Admin.WorkersRep.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для AddWorkersPage.xaml
    /// </summary>
    public partial class AddWorkersPage : Page
    {
        public AddWorkersPage()
        {
            InitializeComponent();

            loginTxb.IsEnabled = false;
            passTxb.IsEnabled = false;
        }
        
        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Workers newWorkers = new Workers();
            SignIn newSignIn = new SignIn();

            newSignIn.LogIn = loginTxb.Text;
            newSignIn.Password = passTxb.Text;
            newSignIn.RoleID = "C";

            newWorkers.SignInID = newSignIn.ID;
            newWorkers.Surname = surnameTxb.Text;
            newWorkers.Name = nameTxb.Text;
            newWorkers.Patronymic = patronymicTxb.Text;
            newWorkers.Post = usStaff.Text;

            ConnectClass.db.SignIn.Add(newSignIn);
            ConnectClass.db.Workers.Add(newWorkers);
            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно добавлены!");
            NavigationService.GoBack();
        }

        private void usStaff_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(usStaff.Text == "Повар")
            {
                loginTxb.IsEnabled = true;
                passTxb.IsEnabled = true;
            }
            else
            {
                loginTxb.IsEnabled = false;
                passTxb.IsEnabled = false;
            }
        }
    }
}
