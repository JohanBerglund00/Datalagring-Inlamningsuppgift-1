   M S B A M L   `   `   `  ����Z  VDatalagring-Inlamningsuppgift-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Datalagring_Inlamningsuppgift_1.Views%Datalagring_Inlamningsuppgift_1.Views  5      <    6Datalagring_Inlamningsuppgift_1.Views.CustomerListView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Datalagring_Inlamningsuppgift_1.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��500 �6   �� 5       � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��customerList��5      $��1��6'   $
��1200��67   $	��900��6D   $��25(�6Q   
�������
�������$��25q�6�   6�   �� 5   
   -   5        $��customerSearchValue��5      $��0��6-   $	��400��6=   $	��100��6I   $
��Left=�6V   $	��Top=�6q   $��
50,325,0,0q�6�   $��Center=�6�   $��50(�6�   
�������6�   �� 5   
   -   5        $��customerAllBtn��5      $��0��6'   $	��400��67   $	��100��6C   $
��Left=�6P   $	��Top=�6k   $��	50,25,0,0q�6�   $��45(�6�   
����İ�
���   �$��3q�6�   $��Hämta alla kunder��6�   6  �� 5   
   -   5        $��customerSearchBtn��5      $��0��6*   $	��400��6:   $	��100��6F   $
��Left=�6S   $	��Top=�6n   $��
50,200,0,0q�6�   $��50(�6�   
����İ�
���   �$��3q�6�   $��Sök efter kund��6�   6  5      5      