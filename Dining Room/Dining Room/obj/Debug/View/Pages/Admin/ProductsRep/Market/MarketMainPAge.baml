   M S B A M L   `   `   `  ����F  BDining Room, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Dining_Room.View.Pages.Admin.ProductsRep.Market/Dining_Room.View.Pages.Admin.ProductsRep.Market  5      D    >Dining_Room.View.Pages.Admin.ProductsRep.Market.MarketMainPAge   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:Dining_Room.View.Pages.Admin.ProductsRep.Market     5      -   5          N� Title$  MarketMainPAge��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   5      � 5   
   $��1��6   .+�5      �� -   5         ��Name$ listDataView��5      ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   $��* �63   �� 5   "   $��* �63   .+�5       � $��0��6#   $��0,0,20,0q�5!   #   .+�5"   "   �� $	��200��5#   (   $	��150��5$   (   ��5"   (   �� *ProductImage+5$   (   5%      � 5'      $��1��6#   .+�5(   "   �� $��Center=�6-   $��Center=�5)   -    �� Orientation$ Vertical=�5*   -   .+�5+   &   ��  �� ContentStringFormat$ Продукт: {0}��6L   $��14(�6o   $
��Bold"�6}   ��6,   �� *ProductName+6}   �� 5,   &   $ Цена: {0}��6F   $��14(�6f   ��6,   �� *Price+6f   5-   #   5.      5/      50      52      53      � 55   
   $��2��6   .+�56      �� $��Center=�6   $
��Left=�57      $��20q�58      .+�59      �� -   5         ��Name$ backBtn��59      $��
Назад��5:      
���   �
���   �
�������$	��120��5>      $��35��5?      6%   5@      �� 5A      $��Center=�6   $��Center=�5B      $ 
Horizontal=�5C      $��20q�5D      .+�5E      �� -   5        $ addBtn��5E      $��Добавить��5F      
���   �
���   �
�������$	��120��5J      $��35��5K      $��0,0,20,0q�5L      6+   �� 5M      -   5        $ editBtn��5M      $��Изменить��5N      
���   �
���   �
�������$	��120��5R      $��35��5S      $��0,0,20,0q�5T      6+   �� 5U      -   5        $ 	removeBtn��5U      $��Удалить��5V      
���   �
���   �
�������$	��120��5Z      $��35��5[      6%   5\      5]      5^      5_      