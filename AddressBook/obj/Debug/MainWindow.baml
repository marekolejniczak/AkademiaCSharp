   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AddressBookAddressBook  5   	       AddressBook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AddressBook     5   	     � Title$  Ksiazka Tele/Net��5   	   $
��auto��6"   $
��auto��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��5* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0��6<   .+�5      �� $��	PhoneBook��6   �� 5      -   5        $��AddressBookList��5      
 � Tag$ Telebook��6.   $��5q�6=   $��0��6H   $��0��6X   ��6e   �� *TeleBookCollection+ �� View 5      �� 5      .P�5      �� $��Surname��6%    �� DisplayMemberBinding 66   �� *	Surname+�� 5      $
��Name��6%    63   �� *Name+�� 5      $��Telephone Number��6%    6?   �� *PhoneNumber+5      5      5      �� 5   
   $ Vertical=�6   $��0��6,   $��1��6<   .+�5       �� $��NetBook��6   �� 5!      -   5        $��NetBookList��5!      $��5q�6*   $
��auto��65   $
��auto��6B   ��6Q   �� *NetBookCollection+ 5"      �� 5#      .P�5$      �� $��Surname��6)    6:   �� *	Surname+�� 5%      $
��Name��6)    67   �� *Name+�� 5&      $��E-mail��6)    69   �� *Email+5'      5)      5*      �� 5,   
   $��1��6   $��2��6%   $��5q�66   .+�5-      �� $
��Dane��6   $��25(�6#   $��Center=�61   �� 5.      .+�5/      �� $��Surname��6   �� 50      -   5        $��SurnameTextBox��50      51      �� 52      .+�53      �� $
��Name��6   �� 54      -   5        $��NameBox��54      55      �� 56      .+�57      �� -   5        $��Email_Telephone��57      $��Email��6/   �� 58      -   5        $��	NumberBox��58      59      �� 5:      .+�5;      �� $��Kind of book��6   �� 5<      -   5        $��KindOfBookComboBox��5<      65   5=      �� 5>      .+�5?      �� $��Actions��6   5@      � 5A       � Orientation$ 
Horizontal=�6   .+�5B      �� -   5         ��Name$	 Add��5B      $	��Add��6&   $��Center=�64   $��0,0,0,0q�6Q   $	��Top=�6b   $
��auto��6z   $
��auto��6�   $��1��6�   �� 5C      -	   5        $ Delete��5C      $��Delete��6)   $��Center=�6:   $��0,0,0,0q�6W   $	��Top=�6h   $
��auto��6�   $
��auto��6�   $��1��6�   �� 5D      -
   5        $ SaveTele��5D      $��Save Telebook��6+   $��Center=�6C   $��0,0,0,0q�6`   $	��Top=�6q   $
��auto��6�   $
��auto��6�   $��1��6�   �� 5E      -   5        $ SaveNet��5E      $��Save Netbook��6*   $��Center=�6A   $��0,0,0,0q�6^   $	��Top=�6o   $
��auto��6�   $
��auto��6�   $��1��6�   5F      5G      5H      5I      