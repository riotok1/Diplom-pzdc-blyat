using Dining_Room.Classes;
using Dining_Room.DB;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Dish selectedItem;
        public EditPage(Dish selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            categoryTxb.ItemsSource = ConnectClass.db.Category.Select(item => item.Title).ToList();

            if (selectedItem.DishImg != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.DishImg))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                imgLoad.Source = bitmap;
            }

            dishTxb.Text = selectedItem.NameOfDish;
            categoryTxb.SelectedItem = selectedItem.Category.Title;
            volumeTxb.Text = selectedItem.Volume;
            priceTxb.Text = Convert.ToString(selectedItem.Price);
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var editDish = ConnectClass.db.Dish.FirstOrDefault(item => item.ID == selectedItem.ID);

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encoder.Save(stream);
            editDish.DishImg = stream.ToArray();

            editDish.NameOfDish = dishTxb.Text;
            var dishCategory = ConnectClass.db.Category.FirstOrDefault(item => item.Title == categoryTxb.Text);
            editDish.CategoryID = dishCategory.ID;
            editDish.Volume = volumeTxb.Text;
            editDish.Price = Convert.ToInt64(priceTxb.Text);

            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно изменены!");
            NavigationService.GoBack();
        }

        //Кнопка открытия изображения
        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
            if (file.ShowDialog() == true)
            {
                BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                imgLoad.Source = imgBitmap;
            }
        }
    }
}
