   M S B A M L   `   `   `  ����Z  VDatalagring-Inlamningsuppgift-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Datalagring_Inlamningsuppgift_1.Views%Datalagring_Inlamningsuppgift_1.Views  5      >    8Datalagring_Inlamningsuppgift_1.Views.RegisterErrandView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Datalagring_Inlamningsuppgift_1.Views     5      -   5        .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��275 �6   �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Center=�61   $��50,0,0,0q�6L   $��30(�6^   Kundnummer:6y   �� 5   
   -   5         ��Name$ customerText��5      $��0��6(   $��1��65   $	��700��6E   $��50��6Q   $��10,3,0,0q�6]   $��30(�6p   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $��50,0,0,0q�6L   $��30(�6^   	Rubrik:6u   �� 5   
   -   5        $ errandNameText��5      $��1��6*   $��1��67   $	��700��6G   $��50��6S   $��10,3,0,0q�6_   $��30(�6r   �� 5   
   $��2��6   $��0��6!   $��Center=�61   $��50,0,0,0q�6L   $��30(�6^   Beskrivning:6z   �� 5    
   -   5        $ descriptionText��5       $��2��6+   $��1��68   $	��700��6H   $��50��6T   $��10,3,0,0q�6`   $��30(�6s   �� 5"   
   $��3��6   $��0��6   $��Center=�6-   $��50,0,0,0q�6H   $��30(�6Z   $��Skapande av 
ärende:��6h   6�   �� 5#   
   -   5        $��errandDateCreated��5#      $��3��6)   $��1��66   $��Center=�6F   $��30(�6a   $�� ��6o   6|   �� 5%   
   $��4��6   $��0��6   $��Center=�6-   $��50,0,0,0q�6H   $��30(�6Z   $��Ändring av 
ärende:��6h   6�   �� 5&   
   -   5        $��errandDateUpdated��5&      $��4��6)   $��1��66   $��Center=�6F   $��30(�6a   $�� ��6o   6|   �� 5(   
   $��5��6   $��0��6   $��Center=�6-   $��50,0,0,0q�6H   $��30(�6Z   .��6h   	Status:6q   �� 5)   
   -   5        $��statusComboBox��5)      $��5��6)   $��1��66   $��Center=�6F   $��Center=�6a   $	��700��6~   $��50��6�   $��30(�6�   6�   �� 5+   
   -   5        $��errandIdText��5+      $��6��6$   $��0��61   $��Center=�6A   $��50,0,0,0q�6\   $��30(�6n   $��Ärendenummer��6|   6�   �� 5,   
   -	   5        $��errandIdValue��5,      $��6��6%   $��1��62   $��Center=�6B   $��50,0,0,0q�6]   $��30(�6o   $�� ��6}   6�   �� 5.   
   -
   5         ��Name$ submitButton��5.      $��7��6'   $��1��64   $	��400��6D   $	��100��6P   $��Center=�6]   $��50(�6x   $��Spara��6�   6�   50      51      