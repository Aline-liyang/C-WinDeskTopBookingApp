   M S B A M L   `   `   `  ����G  CBooking Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Booking_Test.ViewBooking_Test.View  5      ?$clr-namespace:Booking_Test.ViewModelBooking_Test.ViewModel  5      .    (Booking_Test.View.AllReservationListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Booking_Test.View     5      :	viewModel$clr-namespace:Booking_Test.ViewModel     5      X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5	      .��5      �   � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��180 �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�5      $��0��5      .+�5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Search=�6   $��20��6-   $��20��69      plainTextColor3   
Foreground# [  6D   �� 5      $��13(�5      $��24��5      $	��300��5      
������ $��Medium"�5!      $��
Montserrat)�5"      #��[  5#       �� 
CaretBrush# [  5$      #��[  5%      $��0,0,0,1q�5&      $��Center=�5'      $��5,5,0,0q�5(      ��5      �� *	Firstname+ �� UpdateSourceTrigger$ PropertyChanged=�.��5)       5*      5,      �� 5-      $��1��6   $��Search Reservation��5/      $��12(�50      $��
Montserrat)�51       � Cursor$
 Hand��52      $��0q�53      $	��Top=�54        reservationButton#��[ 55      ��5.      �� *ShowAllCustomerCommand+56      57      �� 58   
   $��1��6   ���#200F53 �� CornerRadius$ 10��5:      	 �� Padding$	 10q�5;      ._�5<      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 reservationListDataGrid��5<         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5=      $��0��5>      ���#200F53$��0q�5@         AutoGenerateColumns .  ��5A      �� *Reservations+ �� Mode$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5C      �� *SelectedItem+$ TwoWay=�   ColumnHeaderStyle 5E      �� 5F       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5G      ��  �� Property � �� �� Value
 ���� 67   �� 5H       � �� �#BCBEE067   �� 5I       � ��$ 	10,0,0,10q�64   �� 5J       � ��$ 
Montserrat)�67   �� 5K       � ��$ 15(�65   5L         Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ Occupant��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
Occupant+6F     5P      $ 	Mr. / Ms.��6C    6)   �� *Title+6C     5Q      $ RoomNumber Id��6L    6)   �� *RoomNumber_id+6L     5R      $ CheckIn��6j    6)   �� *Checkin_date+ �� StringFormat$ {0:dd/MM/yyyy}��6j     5S      $ CheckOut��6k    6)   �� *Checkout_date+$ {0:dd/MM/yyyy}��6k     5T      $
 Time��6C    6)   �� *Time+6C     5U      $ Adults��6I    6)   �� *
Num_adults+6I     5V      $ Children��6K    6)   �� *Num_children+6K     5W      $ Others��6E    6)   �� *Others+6E     5X      $ Agency��6D    6)   �� *Agency+6D     5Y      $ Vehicle��6F    6)   �� *	Vehicle+6F     5Z      $ Id��6A    6)   �� *Id+6A   5\      5^      � 5_   
   $��2��6   $��0, 20, 0, 0q�6     5a      �� 5b      $��* �6!   �� 5c      $��* �6!   �� 5d      $��* �6!   �� 5e      $��* �6!   �� 5f      $��* �6!   �� 5g      $��* �6!    5j      �� 5k      $��* �6#   �� 5l      $��2* �6#   �� 5m      $��* �6#   �� 5n      $��2* �6#   �� 5o      $��2* �6#   .+�5s      �� -   5         ��Name$ textBlockOccupant��5s   7   $��0��6   $��0��6&   $
��Left=�6R   $��23��6m   $
��Wrap=�6y   $��
Occupant :��5t      $��Center=�6,   $	��120��6G   $��24,0,0,0q�6S   ���#BCBEE0$��
Montserrat)�6{   �� 5u      -   5        $ textBlockRoomNumberId��5u   6   $��1��6   $��0��6&   $
��Left=�6U   $��23��6p   $
��Wrap=�6}   $��RoomNumber Id :��5v      $��Center=�62   $	��120��6M   $��24,0,0,0q�6Y   ���#BCBEE0$��
Montserrat)�6�   �� 5w      -   5        $ textBlockCheckoutDate��5w   6   $��2��6   $��0��6&   $
��Left=�6U   $��23��6p   $
��Wrap=�6}   $��Checkout Date :��5x      $��Center=�62   $	��120��6M   $��24,0,0,0q�6Y   ���#BCBEE0$��
Montserrat)�6�   �� 5y      -   5        $ textBlockAdults��5y   6   $��3��6   $��0��6&   $
��Left=�6O   $��23��6j   $
��Wrap=�6w   $��Adults :��5z      $��Center=�6+   $	��120��6F   $��24,0,0,0q�6R   ���#BCBEE0$��
Montserrat)�6z   �� 5{      -   5        $ textBlockAnimals��5{   6   $��4��6   $��0��6&   $
��Left=�6P   $��23��6k   $
��Wrap=�6x   $��	Animals :��5|      $��Center=�6,   $	��120��6G   $��24,0,0,0q�6S   ���#BCBEE0$��
Montserrat)�6{   �� 5}      -   5        $ textBlockVehicle��5}   6   $��5��6   $��0��6&   $
��Left=�6P   $��23��6k   $
��Wrap=�6x   $��	Vehicle :��5~      $��Center=�6,   $	��120��6G   $��24,0,0,0q�6S   ���#BCBEE0$��
Montserrat)�6{   �� 5�      -   5        $ textBlockTitle��5�   G   $��0��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6_   $��23��6z   $
��Wrap=�6�   $��Title :��5�      $��Center=�6-   $	��120��6H   ���#BCBEE0$��
Montserrat)�6i   �� 5�      -	   5        $ textBlockCheckinDate��5�   G   $��1��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6e   $��23��6�   $
��Wrap=�6�   $��Checkin Date :��5�      $��Center=�64   $	��120��6O   ���#BCBEE0$��
Montserrat)�6p   �� 5�      -
   5        $ textBlockTime��5�   G   $��2��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6^   $��23��6y   $
��Wrap=�6�   $��Time :��5�      $��Center=�6)   $	��120��6D   ���#BCBEE0$��
Montserrat)�6e   �� 5�      -   5        $ textBlockChildren��5�   G   $��3��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6b   $��23��6}   $
��Wrap=�6�   $��
Children :��5�      $��Center=�60   $	��120��6K   ���#BCBEE0$��
Montserrat)�6l   �� 5�      -   5        $ textBlockAgency��5�   G   $��4��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6`   $��23��6{   $
��Wrap=�6�   $��Agency :��5�      $��Center=�6+   $	��120��6F   ���#BCBEE0$��
Montserrat)�6g   �� 5�      -   5        $ textBlockId��5�   G   $��5��6   $��2��6%   $��24,0,0,0q�65   $
��Left=�6\   $��23��6w   $
��Wrap=�6�   $
��Id :��5�      $��Center=�6'   $	��120��6B   ���#BCBEE0$��
Montserrat)�6c   �� 5�      -   5         ��Name$ textBoxOccupant��5�   3   $��0��6   $��1��6#   $
��Left=�6L    �� TextWrapping$
 Wrap=�6h   $��Center=�6}   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Occupant+$ PropertyChanged=��� 5�      -   5        $ textBoxRoomNumberId��5�   4   $��1��6   $��1��6$   $
��Left=�6Q   $
 Wrap=�6m   $��Center=�6�   $	��220��6�   $��23��6�   ��6�   �� *" CurrentReservation.RoomNumber_id+$ PropertyChanged=��� 5�      -   5        $ textBoxCheckoutDate��5�   4   $��2��6   $��1��6$   $
��Left=�6Q   $
 Wrap=�6m   $��Center=�6�   $	��220��6�   $��23��6�   ��6�   �� *" CurrentReservation.Checkout_date+$ {0:dd/MM/yyyy}��$ PropertyChanged=��� 5�      -   5        $ textBoxAdults��5�   4   $��3��6   $��1��6$   $
��Left=�6K   $
 Wrap=�6g   $��Center=�6|   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Num_adults+$ PropertyChanged=��� 5�      -   5        $ textBoxAnimals��5�   4   $��4��6   $��1��6$   $
��Left=�6L   $
 Wrap=�6h   $��Center=�6}   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Others+$ PropertyChanged=��� 5�      -   5        $ textBoxVehicle��5�   4   $��5��6   $��1��6$   $
��Left=�6L   $
 Wrap=�6h   $��Center=�6}   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Vehicle+$ PropertyChanged=��� 5�      -   5        $ textBoxTitle��5�   3   $��0��6   $��3��6#   $
��Left=�6I   $
 Wrap=�6d   $��Center=�6y   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Title+$ PropertyChanged=��� 5�      -   5        $ textBoxCheckinDate��5�   3   $��1��6   $��3��6#   $
��Left=�6O   $
 Wrap=�6j   $��Center=�6   $	��220��6�   $��23��6�   ��6�   �� *!CurrentReservation.Checkin_date+$ {0:dd/MM/yyyy}��$ PropertyChanged=��� 5�      -   5        $ textBoxTime��5�   3   $��2��6   $��3��6#   $
��Left=�6H   $
 Wrap=�6d   $��Center=�6y   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Time+$ PropertyChanged=��� 5�      -   5        $ textBoxChildren��5�   3   $��3��6   $��3��6#   $
��Left=�6L   $
 Wrap=�6g   $��Center=�6|   $	��220��6�   $��23��6�   ��6�   �� *!CurrentReservation.Num_children+$ PropertyChanged=��� 5�      -   5        $ textBoxAgency��5�   3   $��4��6   $��3��6#   $
��Left=�6J   $
 Wrap=�6f   $��Center=�6{   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Agency+$ PropertyChanged=��� 5�      -   5        $ 	textBoxId��5�   3   $��5��6   $��3��6#   $
��Left=�6F   $
 Wrap=�6b   $��Center=�6w   $	��220��6�   $��23��6�   ��6�   �� *CurrentReservation.Id+$ PropertyChanged=��� 5�      -   5         ��Name$ btnAdd��5�   2   $��0��6   $��4��6"   $	��Add��6B   $
��Left=�6P   $��20,0,0,0q�6k   $��Center=�6~   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *AddReservationCommand+6�   �� 5�      -   5        $ 	btnModify��5�   2   $��1��6   $��4��6"   $��Modify��6E   $
��Left=�6V   $��20,0,0,0q�6q   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *ModifyReservationCommand+6�   �� 5�      -   5        $ 	btnDelete��5�   2   $��2��6   $��4��6"   $��Delete��6E   $��20,0,0,0q�6V   $
��Left=�6h   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *DeleteReservationCommand+6�   �� 5�      -   5        $ btnClear��5�   2   $��3��6   $��4��6"   $��Clear��6D   $
��Left=�6T   $��20,0,0,0q�6o   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *ClearInputsCommand+6�   �� 5�      -   5        $ 	btnSearch��5�   2   $��4��6   $��4��6"   $��Credit Card��6E   $��20,0,0,0q�6[   $
��Left=�6m   $��Center=�6�   $	��100��6�   $��30��6�   #��[ 6�   ��6�   �� *OpenCreditCardWindowCommand+6�   5�      5�      5�      