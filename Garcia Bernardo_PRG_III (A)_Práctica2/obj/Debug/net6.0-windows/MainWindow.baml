   M S B A M L   `   `   `  ����a  ]Garcia Bernardo_PRG_III (A)_Práctica2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Garcia_Bernardo_PRG_III__A__Práctica2&Garcia_Bernardo_PRG_III__A__Práctica2  5   	   7    1Garcia_Bernardo_PRG_III__A__Práctica2.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Garcia_Bernardo_PRG_III__A__Práctica2     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��7* �6   .+�5   
   �� $
��Left=�6   $��	95,10,0,0q�6/   $
��Wrap=�6B   $��
PRACTICA 2��6V   $	��Top=�6h   $��20(�6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�   $��1��6�   $��27��6�   $	��138��6�   �� 5   
   -   5         ��Name$ lstVisualizar��5      $��18,83,288,124q�6T   $��1��6k   �� 5   
   $
��Left=�6   $��
146,59,0,0q�6/   $
��Wrap=�6C   $��MENÚ��6W   $	��Top=�6c   $ Center=�6{   $��14(�6�   $
��Bold"�6�   $��1��6�   $��19��6�   $��68��6�   �� 5   
   -   5        $ 
lstPedidos��5      $��361,83,14,124q�6Q   $��1��6h   �� 5   
   $
��Left=�6   $��
463,59,0,0q�6/   $
��Wrap=�6C   $��PEDIDO��6W   $	��Top=�6e   $��14(�6}   $
��Bold"�6�   $��1��6�   $��19��6�   $��52��6�   �� 5   
   -   5         ��Name$ 
btnComprar��5      $��COMPRAR��6%   $
��Left=�67   $��510,499,0,0q�6R   $	��Top=�6g   $��35��6   $	��106��6�   $��1��6�   6�   �� 5   
   -   5        $ btnSalir��5      $��Salir��6#   $
��Left=�63   $��127,499,0,0q�6N   $	��Top=�6c   $��35��6{   $	��106��6�   $��1��6�   �� 5   
   $
��Left=�6   $��
85,391,0,0q�6/   $
��Wrap=�6C   $��¿Que plato desea?��6W   $	��Top=�6p   �� 5   
   -   5         ��Name$ txbPlato��5      $��Center=�6$   $��	0,412,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ 
btnAgregar��5      $��AGREGAR��6%   $��Center=�67   $��	0,480,0,0q�6T   $	��Top=�6g   $��35��6   $	��120��6�   6�   �� 5   
   $��Center=�6   $��	0,353,0,0q�61   $
��Wrap=�6D   $4��.----------------------------------------------��6X   $	��Top=�6�   �� 5   
   -   5         ��Name$ 	cmbQuiero��5      $��Center=�6&   $��	0,132,0,0q�6C   $	��Top=�6V   $	��120��6n   �� 5   
   -   5        $ cmbNoQuiero��5      $��Center=�6(   $��	0,236,0,0q�6E   $	��Top=�6X   $	��120��6p   �� 5   
   $��Center=�6   $��0,94,0,0q�61   $
��Wrap=�6C   $��QUIERO:��6W   $	��Top=�6f   $
��Bold"�6~   �� 5   
   $��Center=�6   $��	0,192,0,0q�61   $
��Wrap=�6D   $��
NO QUIERO:��6X   $	��Top=�6j   $
��Bold"�6�   �� 5   
   -	   5        $ 
btnFiltrar��5      $��FILTRAR��6%   $
��Left=�67   $��
75,302,0,0q�6R   $	��Top=�6f   6~   �� 5   
   -
   5        $ btnReset��5      $��RESET��6#   $
��Left=�63   $��159,302,0,0q�6N   $	��Top=�6c   6{   �� 5   
   -   5        $ btnBorrarPedido��5      $��1��6*   $��BORRAR PEDIDO��6:   $
��Left=�6R   $��361,499,0,0q�6m   $	��Top=�6�   $��35��6�   $	��106��6�   6�   5!      5"      