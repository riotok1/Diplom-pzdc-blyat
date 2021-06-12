﻿using Dining_Room.Classes;
using Dining_Room.DB;
using Dining_Room.View.Pages.Admin.DishesRep.FunctionsWithData;
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
    /// Логика взаимодействия для DishesMainPage.xaml
    /// </summary>
    public partial class DishesMainPage : Page
    {
        public DishesMainPage()
        {
            InitializeComponent();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Инициализация данных
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Dish.ToList();
        }

        //Добавлениe
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        //Редактирование
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Dish editDish = (Dish)listDataView.SelectedItem;
                if (editDish != null)
                {
                    NavigationService.Navigate(new EditPage(editDish));
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
                Dish removeDish = (Dish)listDataView.SelectedItem;
                if (removeDish != null)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Dish.Remove(removeDish);
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

        //Поиск
        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Dish.Where(item => item.NameOfDish.Contains(searchTxb.Text) || item.Volume.Contains(searchTxb.Text)).ToList();
        }

        //Эксопрт в WORD
        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();

            try
            {
                var document = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var dishList = ConnectClass.db.Dish.ToList();
                var table = document.Tables.Add(tableRange, dishList.Count, 4);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Блюдо";
                table.Cell(1, 2).Range.Text = "Категория";
                table.Cell(1, 3).Range.Text = "Объем";
                table.Cell(1, 4).Range.Text = "Стоимость";

                int i = 2;
                foreach (var item in dishList)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.NameOfDish;
                    table.Cell(i, 2).Range.Text = item.Category.Title;
                    table.Cell(i, 3).Range.Text = item.Volume;
                    table.Cell(i, 4).Range.Text = Convert.ToString(item.Price) + " руб.";
                    i++;
                }
                document.SaveAs2(@"D:\dishes.docx");
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

        private void Update(string sortCategory = "", string search = "")
        {
            var dish = ConnectClass.db.Dish.ToList();
            int all = ConnectClass.db.Dish.Count();

            if (!string.IsNullOrEmpty(sortCategory) && !string.IsNullOrEmpty(sortCategory))
            {
                if (sortCategory == "Горячее")
                    dish = dish.Where(item => item.Category.Title == "Горячее").ToList();
                if (sortCategory == "Холодное")
                    dish = dish.Where(item => item.Category.Title == "Холодное").ToList();
            }
            else
            {
                dish = dish.ToList();
            }
            if (!string.IsNullOrEmpty(search) && !string.IsNullOrEmpty(search))
                dish = dish.Where(item => item.NameOfDish.ToLower().Contains(searchTxb.Text.ToLower()) || item.Volume.ToLower().Contains(searchTxb.Text.ToLower())).ToList();
            countDishes.Text = $"{dish.Count} из {all}";
            listDataView.ItemsSource = dish;
        }

        private void dishCategoryCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update((dishCategoryCmb.SelectedItem as ComboBoxItem).Content.ToString(), searchTxb.Text);
        }
    }
}
