using Dining_Room.Classes;
using Dining_Room.DB;
using Dining_Room.View.Pages.Admin.WorkersRep.FunctionsWithData;
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
using Word = Microsoft.Office.Interop.Word;

namespace Dining_Room.View.Pages.Admin.WorkersRep
{
    /// <summary>
    /// Логика взаимодействия для StaffMainPage.xaml
    /// </summary>
    public partial class StaffMainPage : Page
    {
        public StaffMainPage()
        {
            InitializeComponent();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Инициализация даннах
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Workers.ToList();
        }

        //Добавление
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddWorkersPage());
        }

        //Редактирование
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Workers editWorkers = (Workers)listDataView.SelectedItem;
                if (editWorkers != null)
                {
                    NavigationService.Navigate(new EditWorkersPage(editWorkers));
                }
                else
                {
                    throw new Exception("Выберите элемент!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Удаление
        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Workers removeWorkers = (Workers)listDataView.SelectedItem;
                if(removeWorkers != null)
                {
                    if(MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Workers.Remove(removeWorkers);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                }
                else
                {
                    throw new Exception("Выберите элемент!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        //Экспорт в WORD
        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();

            try
            {
                var document = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var workersList = ConnectClass.db.Workers.ToList();
                var table = document.Tables.Add(tableRange, workersList.Count, 4);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Фамилия";
                table.Cell(1, 2).Range.Text = "Имя";
                table.Cell(1, 3).Range.Text = "Отчество";
                table.Cell(1, 5).Range.Text = "Должность";

                int i = 2;
                foreach (var item in workersList)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.Surname;
                    table.Cell(i, 2).Range.Text = item.Name;
                    table.Cell(i, 3).Range.Text = item.Patronymic;
                    table.Cell(i, 5).Range.Text = item.Post;
                    i++;
                }
                document.SaveAs2(@"D:\workers.docx");
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение!", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }

        //Поиск
        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Workers.Where(item => item.Surname.Contains(searchTxb.Text) || item.Name.Contains(searchTxb.Text) || item.Patronymic.Contains(searchTxb.Text)).ToList();
        }
    }
}
