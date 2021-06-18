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
using Word = Microsoft.Office.Interop.Word;

namespace Dining_Room.View.Pages.Admin.DishesRep
{
    /// <summary>
    /// Логика взаимодействия для YesterdayMenuViewPage.xaml
    /// </summary>
    public partial class YesterdayMenuViewPage : Page
    {
        public YesterdayMenuViewPage()
        {
            InitializeComponent();
            
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.YesterdayMenu.ToList();
        }

        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();

            try
            {
                var document = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var dishList = ConnectClass.db.YesterdayMenu.ToList();
                var table = document.Tables.Add(tableRange, dishList.Count, 3);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Блюдо";
                table.Cell(1, 2).Range.Text = "Стоимость";
                table.Cell(1, 3).Range.Text = "Количество";

                int i = 2;
                foreach (var item in dishList)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.Dish.NameOfDish;
                    table.Cell(i, 2).Range.Text = item.Dish.Price.ToString();
                    table.Cell(i, 3).Range.Text = item.Count.ToString();
                    i++;
                }
                document.SaveAs2(@"D:\todayMenu.docx");
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
    }
}
