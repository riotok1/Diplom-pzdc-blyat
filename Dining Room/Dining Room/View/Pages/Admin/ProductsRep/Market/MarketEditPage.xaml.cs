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

namespace Dining_Room.View.Pages.Admin.ProductsRep.Market
{
    /// <summary>
    /// Логика взаимодействия для MarketEditPage.xaml
    /// </summary>
    public partial class MarketEditPage : Page
    {
        private Products selectedItem;
        public MarketEditPage(Products selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            if (selectedItem.ProductImage != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.ProductImage))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                imgLoad.Source = bitmap;
            }

            productTxb.Text = selectedItem.ProductName;
            priceTxb.Text = Convert.ToString(selectedItem.Price);
        }

        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog imgFile = new OpenFileDialog();
                imgFile.Filter = "Image (*.jpg; *.png;) | *.jpg; *.png;";
                if (imgFile.ShowDialog() == true)
                {
                    BitmapImage imgBitmap = new BitmapImage(new Uri(imgFile.FileName));
                    imgLoad.Source = imgBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var editProduct = ConnectClass.db.Products.FirstOrDefault(item => item.ID == selectedItem.ID);

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encorder = new JpegBitmapEncoder();
            encorder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encorder.Save(stream);
            editProduct.ProductImage = stream.ToArray();

            editProduct.ProductName = productTxb.Text;
            editProduct.Price = Convert.ToInt32(priceTxb.Text);

            ConnectClass.db.SaveChanges();

            MessageBox.Show("Редактирование прошло успешно!");

            NavigationService.GoBack();
        }
    }
}
