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
    /// Логика взаимодействия для EditWorkersPage.xaml
    /// </summary>
    public partial class EditWorkersPage : Page
    {
        private Workers selectedItem;
        public EditWorkersPage(Workers selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            surnameTxb.Text = selectedItem.Surname;
            nameTxb.Text = selectedItem.Name;
            patronymicTxb.Text = selectedItem.Patronymic;
            usStaff.Text = selectedItem.Post;
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Редактирование
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var editStaff = ConnectClass.db.Workers.FirstOrDefault(item => item.ID == selectedItem.ID);

            editStaff.Surname = surnameTxb.Text;
            editStaff.Name = nameTxb.Text;
            editStaff.Patronymic = patronymicTxb.Text;
            editStaff.Post = usStaff.Text;

            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно изменены!");
            NavigationService.GoBack();
        }
    }
}
