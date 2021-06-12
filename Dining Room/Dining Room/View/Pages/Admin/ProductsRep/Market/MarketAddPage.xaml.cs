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
    /// Логика взаимодействия для MarketAddPage.xaml
    /// </summary>
    public partial class MarketAddPage : Page
    {
        public MarketAddPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Products newProduct = new Products();

            MemoryStream stream = new MemoryStream();
            JpegBitmapEncoder encorder = new JpegBitmapEncoder();
            encorder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
            encorder.Save(stream);
            newProduct.ProductImage = stream.ToArray();

            newProduct.ProductName = productTxb.Text;
            newProduct.Price = Convert.ToInt32(priceTxb.Text);

            ConnectClass.db.Products.Add(newProduct);
            ConnectClass.db.SaveChanges();

            MessageBox.Show("Добавление продукта прошло успешно!");
            NavigationService.GoBack();
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
    }
}
