   M S B A M L   `   `   `  ����F  BDining Room, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Dining_Room.View.Pages.Admin.ProductsRep(Dining_Room.View.Pages.Admin.ProductsRep  5      <    6Dining_Room.View.Pages.Admin.ProductsRep.WarehousePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:Dining_Room.View.Pages.Admin.ProductsRep     5      -   5          N� Title$  WarehousePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ listDataView��5      ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   $��* �63   �� 5   "   $��* �63   .+�5      � $��0��6#   $��0,0,20,0q�5   #   .+�5   "   �� $	��200��5   (   $	��150��5   (   ��5   (   �� *Products.ProductImage+5   (   5       � 5"      $��1��6#   .+�5#   "   �� $��Center=�6-   $��Center=�5$   -    �� Orientation$ Vertical=�5%   -   .+�5&   &   ��  �� ContentStringFormat$ Продукт: {0}��6U   $��14(�6x   $
��Bold"�6�   ��6,   �� *Products.ProductName+6�   �� 5'   &   $ Цена: {0} руб.��6O   $��14(�6t   ��6,   �� *Products.Price+6t   �� 5(   &   $% Количество: {0} кг.��6F   $��14(�6p   ��6,   �� *Count+6p   �� 5)   &   $( "Общая сумма: {0} руб.��6I   $��14(�6u   ��6,   �� *
TotalSum+6u   5*   #   5+      5,      5-      5/      50      � 52   
   $��1��6   .+�53      �� $��Center=�6   $
��Left=�54      $��20q�55      .+�56      �� -   5         ��Name$ backBtn��56      $��
Назад��57      
���   �
���   �
�������$	��120��5;      $��35��5<      6%   5=      �� 5>      $��Center=�6   $��Center=�5?      .+�5@      �� -   5        $ picBtn��5@      $��Печать��5A      
���   �
���   �
�������$	��120��5E      $��35��5F      6%   5G      5H      5I      5J      