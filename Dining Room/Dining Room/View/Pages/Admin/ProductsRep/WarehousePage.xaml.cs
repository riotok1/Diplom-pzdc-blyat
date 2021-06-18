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

namespace Dining_Room.View.Pages.Admin.ProductsRep
{
    /// <summary>
    /// Логика взаимодействия для WarehousePage.xaml
    /// </summary>
    public partial class WarehousePage : Page
    {
        public WarehousePage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void picBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();

            try
            {
                var document = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var dishList = ConnectClass.db.Supply.ToList();
                var table = document.Tables.Add(tableRange, dishList.Count, 4);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Продукт";
                table.Cell(1, 2).Range.Text = "Цена";
                table.Cell(1, 3).Range.Text = "Количество";
                table.Cell(1, 4).Range.Text = "Общая сумма";

                int i = 2;
                foreach (var item in dishList)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.Products.ProductName;
                    table.Cell(i, 2).Range.Text = item.Products.Price.ToString();
                    table.Cell(i, 3).Range.Text = item.Count.ToString();
                    table.Cell(i, 4).Range.Text = item.TotalSum.ToString();
                    i++;
                }
                document.SaveAs2(@"D:\warehouse.docx");
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Supply.ToList();
        }
    }
}
