   M S B A M L   `   `   `  ����F  BDining Room, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Dining_Room.View.Pages.Admin.DishesRep&Dining_Room.View.Pages.Admin.DishesRep  5      B    <Dining_Room.View.Pages.Admin.DishesRep.YesterdayMenuViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:Dining_Room.View.Pages.Admin.DishesRep     5      -   5          N� Title$  YesterdayMenuViewPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $
��Left=�5      $��20q�5      .+�5      �� $"��Меню на сегодня��6   $��16(�5      $
��Bold"�5      5      5      � 5   
   $��1��6   .+�5      �� -   5         ��Name$ listDataView��5      ��5      �� 5      .R�5       �  � ColumnDefinitions 5!      �� 5"   "   $��* �63   �� 5#   "   $��* �63   .+�5&      � $��0��6#   $��0,0,20,0q�5'   '   .+�5(   "   �� $	��200��5)   ,   $	��200��5*   ,   ��5(   (   �� *Dish.DishImg+5*   ,   5+      � 5-      $��1��6#   .+�5.   "   �� $��Center=�6-   $��Center=�5/   1    �� Orientation$ Vertical=�50   1   .+�51   &   ��  �� ContentStringFormat$ Блюдо: {0}��6P   $��14(�6q   $
��Bold"�6   ��6,   �� *Dish.NameOfDish+6   �� 52   &   $ Категория: {0}��6T   $��14(�6y   ��6,   �� *Dish.Category.Title+6y   �� 53   &   $ Объем: {0}��6L   $��14(�6m   ��6,   �� *Dish.Volume+6m   �� 54   &   $, &Количество: {0} порций��6F   $��14(�6s   ��6,   �� *Count+6s   �� 55   &   $% Стоимость: {0} руб.��6K   $��14(�6u   ��6,   �� *
Dish.Price+6u   56   #   57      58      59      5;      5<      � 5>   
   $��2��6   .+�5?      �� $��Center=�6   $��Center=�5@      $ 
Horizontal=�5A      .+�5B      �� -   5         ��Name$ backBtn��5B      $��
Назад��5C      
���   �
���   �
�������$	��120��5G      $��35��5H      $��0,0,20,0q�5I      5J      �� 5K      -   5        $ wordBtn��5K      $��Печать��5L      
���   �
���   �
�������$	��120��5P      $��35��5Q      6%   5R      5S      5T      5U      