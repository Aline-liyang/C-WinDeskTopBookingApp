   M S B A M L   `   `   `  ����G  CBooking Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Booking_Test.ViewBooking_Test.View  5      ?$clr-namespace:Booking_Test.ViewModelBooking_Test.ViewModel  5      $    Booking_Test.View.CustomerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Booking_Test.View     5      :	viewModel$clr-namespace:Booking_Test.ViewModel     5      X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      .��5      �   � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��180 �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�5      $��0��5      .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Search=�6   $��20��6-   $��20��69      plainTextColor3   
Foreground# [  6D   �� 5      $��13(�5      $��24��5      $	��300��5      
������ $��Medium"�5       $��
Montserrat)�5!      #��[  5"       �� 
CaretBrush# [  5#      #��[  5$      $��0,0,0,1q�5%      $��Center=�5&      $��5,5,0,0q�5'      ��5      �� *	Firstname+ �� UpdateSourceTrigger$ PropertyChanged=�.��5(       5)      5+      �� 5,      $��1��6   $��Search Customer��5.      $��12(�5/      $��
Montserrat)�50       � Cursor$
 Hand��51      $��0q�52      $	��Top=�54        reservationButton#��[ 55      ��5-      �� *ShowAllCustomerCommand+57      58      �� 59   
   $��1��6   ���#200F53 �� CornerRadius$ 10��5;      	 �� Padding$	 20q�5<      ._�5=      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 reservationListDataGrid��5=         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5>      ���#200F53$��0q�5@         AutoGenerateColumns .  ��5A      �� *	Customers+ �� Mode$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5C      �� *SelectedItem+$ TwoWay=�   ColumnHeaderStyle 5E      �� 5F       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5G      ��  �� Property � �� �� Value
 ���� 67   �� 5H       � �� �#BCBEE067   �� 5I       � ��$ 	10,0,0,10q�64   �� 5J       � ��$ 
Montserrat)�67   �� 5K       � ��$ 15(�65   5L         Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@      Width$ 50 6L      CanUserResize .     FontSize$ 16Q�6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Id+6m     5Q      $ 
First name��6H    6)   �� *
First_name+6H     5R      $ 	Last name��6H    6)   �� *	Last_name+6H     5S      $ Title��6D    6)   �� *Title+6D     5T      $ Phone��6D   $	 150 6S    6)   �� *Phone+6S     5U      $ Email��6D   $	 150 6S    6)   �� *Email+6S     5V      $ Street��6E   $	 150 6U    6)   �� *Street+6U     5W      $
 City��6C    6)   �� *City+6C     5X      $ State��6D    6)   �� *State+6D     5Y      $ Country��6F    6)   �� *	Country+6F     5Z      $
 Post��6J    6)   �� *Postal_code+6J   5]      5_      � 5`   
   $��2��6   $��0, 20, 0, 0q�6     5b      �� 5c      $��* �6!   �� 5d      $��* �6!   �� 5e      $��* �6!   �� 5f      $��* �6!   �� 5g      $��* �6!   �� 5h      $��* �6!    5k      �� 5l      $��* �6#   �� 5m      $��2* �6#   �� 5n      $��* �6#   �� 5o      $��2* �6#   �� 5p      $��2* �6#   .+�5t      �� -   5         ��Name$ textBlockLastName��5t   7   $��0��6   $��0��6&   $
��Left=�6R   $��23��6m   $
��Wrap=�6y   $��Last Name :��5u      $��Center=�6-   $��66��6H   $��24,0,0,0q�6S   ���#BCBEE0$��
Montserrat)�6{   �� 5v      -   5        $ textBlockAddress��5v   6   $��1��6   $��0��6&   $
��Left=�6P   $��23��6k   $
��Wrap=�6x   $��Phone :��5w      $��Center=�6*   $��56��6E   $��24,0,0,0q�6P   ���#BCBEE0$��
Montserrat)�6w   �� 5x      -   5        $ textBlockTitle��5x   6   $��2��6   $��0��6&   $
��Left=�6N   $��23��6i   $
��Wrap=�6v   $��Title :��5y      $��Center=�6*   $��56��6E   $��24,0,0,0q�6P   ���#BCBEE0$��
Montserrat)�6x   �� 5z      -   5        $ textBlockRoomNumber��5z   6   $��3��6   $��0��6&   $
��Left=�6S   $��23��6n   $
��Wrap=�6{   $��City :��5{      $��Center=�6)   $��86��6D   $��24,0,0,0q�6O   ���#BCBEE0$��
Montserrat)�6w   �� 5|      -   5        $ textBlockNotes��5|   6   $��4��6   $��0��6&   $
��Left=�6N   $��23��6i   $
��Wrap=�6v   $��	Country :��5}      $��Center=�6,   $��56��6G   $��24,0,0,0q�6R   ���#BCBEE0$��
Montserrat)�6z   �� 5�      -   5        $ textBlockFirstName��5�   G   $��0��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6c   $��23��6~   $
��Wrap=�6�   $��First Name :��5�      $��Center=�62   $��64��6M   ���#BCBEE0$��
Montserrat)�6m   �� 5�      -   5        $ textBlockEmail��5�   G   $��1��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6_   $��23��6z   $
��Wrap=�6�   $��Email :��5�      $��Center=�6-   $��54��6H   ���#BCBEE0$��
Montserrat)�6h   �� 5�      -	   5        $ textBlockPhone��5�   G   $��2��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6_   $��23��6z   $
��Wrap=�6�   $��	Address :��5�      $��Center=�6,   $��64��6G   ���#BCBEE0$��
Montserrat)�6g   �� 5�      -
   5        $ textBlockState��5�   G   $��3��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6_   $��23��6z   $
��Wrap=�6�   $��State :��5�      $��Center=�6-   $��54��6H   ���#BCBEE0$��
Montserrat)�6h   �� 5�      -   5        $ textBlockPost��5�   G   $��4��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6^   $��23��6y   $
��Wrap=�6�   $��Post Code :��5�      $��Center=�6.   $��64��6I   ���#BCBEE0$��
Montserrat)�6i   �� 5�      -   5         ��Name$ textBoxLastName��5�   3   $��0��6   $��1��6#   $
��Left=�6L    �� TextWrapping$
 Wrap=�6h   $��Center=�6}   $	��220��6�   $��23��6�   ��6�   �� *Customer.Last_name+$ PropertyChanged=��� 5�      -   5        $ textBoxPhone��5�   4   $��1��6   $��1��6$   $
��Left=�6J   $
 Wrap=�6f   $��Center=�6{   $	��220��6�   $��23��6�   ��6�   �� *Customer.Phone+$ PropertyChanged=��� 5�      -   5        $ textBoxNumber��5�   4   $��2��6   $��1��6$   $
��Left=�6K   $
 Wrap=�6g   $��Center=�6|   $	��220��6�   $��23��6�   ��6�   �� *Customer.Title+$ PropertyChanged=��� 5�      -   5        $ textBoxCity��5�   4   $��3��6   $��1��6$   $
��Left=�6I   $
 Wrap=�6e   $��Center=�6z   $	��220��6�   $��23��6�   ��6�   �� *Customer.City+$ PropertyChanged=��� 5�      -   5        $ textBoxCountry��5�   4   $��4��6   $��1��6$   $
��Left=�6L   $
 Wrap=�6h   $��Center=�6}   $	��220��6�   $��23��6�   ��6�   �� *Customer.Country+$ PropertyChanged=��� 5�      -   5        $ textBoxFirstName��5�   3   $��0��6   $��3��6#   $
��Left=�6M   $
 Wrap=�6h   $��Center=�6}   $	��220��6�   $��23��6�   ��6�   �� *Customer.First_name+$ PropertyChanged=��� 5�      -   5        $ textBoxEmail��5�   3   $��1��6   $��3��6#   $
��Left=�6I   $
 Wrap=�6d   $��Center=�6y   $	��220��6�   $��23��6�   ��6�   �� *Customer.Email+$ PropertyChanged=��� 5�      -   5        $ textBoxAddress��5�   3   $��2��6   $��3��6#   $
��Left=�6K   $
 Wrap=�6g   $��Center=�6|   $	��220��6�   $��23��6�   ��6�   �� *Customer.Street+$ PropertyChanged=��� 5�      -   5        $ textBoxState��5�   3   $��3��6   $��3��6#   $
��Left=�6I   $
 Wrap=�6d   $��Center=�6y   $	��220��6�   $��23��6�   ��6�   �� *Customer.State+$ PropertyChanged=��� 5�      -   5        $ textBoxPost��5�   3   $��4��6   $��3��6#   $
��Left=�6H   $
 Wrap=�6d   $��Center=�6y   $	��220��6�   $��23��6�   ��6�   �� *Customer.Postal_code+$ PropertyChanged=��� 5�      -   5         ��Name$ btnAdd��5�   2   $��0��6   $��4��6"   $	��Add��6B   $
��Left=�6P   $��20,0,0,0q�6k   $��Center=�6~   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *AddCustomerCommand+6�   �� 5�      -   5        $ 	btnModify��5�   2   $��1��6   $��4��6"   $��Modify��6E   $
��Left=�6V   $��20,0,0,0q�6q   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *ModifyCustomerCommand+6�   �� 5�      -   5        $ 	btnDelete��5�   2   $��2��6   $��4��6"   $��Delete��6E   $��20,0,0,0q�6V   $
��Left=�6h   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *DeleteCustomerCommand+6�   �� 5�      -   5        $ btnClear��5�   2   $��3��6   $��4��6"   $��Clear��6D   $
��Left=�6T   $��20,0,0,0q�6o   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *ClearInputsCommand+6�   �� 5�      -   5        $ 	btnSearch��5�   2   $��4��6   $��4��6"   $��Credit Card��6E   $��20,0,0,0q�6[   $
��Left=�6m   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *OpenCreditCardWindowCommand+6�   5�      5�      5�      