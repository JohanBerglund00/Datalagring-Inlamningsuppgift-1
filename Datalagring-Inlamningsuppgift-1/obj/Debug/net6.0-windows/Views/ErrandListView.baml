   M S B A M L   `   `   `  ����Z  VDatalagring-Inlamningsuppgift-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Datalagring_Inlamningsuppgift_1.Views%Datalagring_Inlamningsuppgift_1.Views  5      :    4Datalagring_Inlamningsuppgift_1.Views.ErrandListView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Datalagring_Inlamningsuppgift_1.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��500 �6   �� 5      $
��1200 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��0��6%   $��1��62   �� 5   
   -   5        $��getErrandBtn��5      $��0��6%   $	��400��65   $	��100��6A   $
��Left=�6N   $	��Top=�6i   $��	50,10,0,0q�6�   $��45(�6�   
����İ�
���   �$��3q�6�   $��Hämta alla ärenden��6�   6   �� 5   
   -   5        $��getErrandSearchBtn��5      $��0��6+   $	��400��6;   $	��100��6G   $
��Left=�6T   $	��Top=�6o   $��
50,160,0,0q�6�   $��38(�6�   
����İ�
���   �$��3q�6�   $��Sök på ärendenummer��6�   6.  �� 5   
   -   5        $��getErrandSearchValue��5      $��0��6.   $	��400��6>   $	��100��6J   $
��Left=�6W   $	��Top=�6r   $��
50,275,0,0q�6�   $��Center=�6�   $��50(�6�   
�������6�   �� 5   
   -   5        $��	firstName��5      $��1��6%   $��0��62   $��Center=�6B   $��Center=�6]   $��30(�6z   6�   �� 5   
   -   5        $��lastName��5      $��2��6$   $��0��61   $��Center=�6A   $��Center=�6\   $��30(�6y   6�   �� 5    
   -   5        $��email��5       $��3��6!   $��0��6.   $��Center=�6>   $��Center=�6Y   $��30(�6v   6�   �� 5!   
   -   5        $��phone��5!      $��4��6!   $��0��6.   $��Center=�6>   $��Center=�6Y   $��30(�6v   6�   �� 5"   
   -   5        $��address��5"      $��5��6#   $��0��60   $��Center=�6@   $��Center=�6[   $��30(�6x   6�   &   System.Windows.Controls.DataGrid  5$   
   -	   5        $��errandListDataGrid��5$      $��1��6-   $
��1200��6=   $	��900��6J   $��25(�6W   
�������
�������$��25q�6�   $��6��6�   6�   5&      5'      