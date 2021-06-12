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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            categoryTxb.ItemsSource = ConnectClass.db.Category.Select(item => item.Title).ToList();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Кнопка добавления
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Dish newDish = new Dish();

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encoder.Save(stream);
            newDish.DishImg = stream.ToArray();

            newDish.NameOfDish = dishTxb.Text;
            var dishCategory = ConnectClass.db.Category.FirstOrDefault(item => item.Title == categoryTxb.Text);
            newDish.CategoryID = dishCategory.ID;
            newDish.Volume = volumeTxb.Text;
            newDish.Price = Convert.ToInt64(priceTxb.Text);

            ConnectClass.db.Dish.Add(newDish);
            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно добавлены!");
            NavigationService.GoBack();
        }

        //Кнопка открытия изображения
        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
            if(file.ShowDialog() == true)
            {
                BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                imgLoad.Source = imgBitmap;
            }
        }
    }
}
