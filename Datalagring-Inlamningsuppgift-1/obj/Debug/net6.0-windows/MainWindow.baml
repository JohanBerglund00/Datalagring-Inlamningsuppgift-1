   M S B A M L   `   `   `  ����Z  VDatalagring-Inlamningsuppgift-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Datalagring_Inlamningsuppgift_1Datalagring_Inlamningsuppgift_1  5   	   g8clr-namespace:Datalagring_Inlamningsuppgift_1.ViewModels*Datalagring_Inlamningsuppgift_1.ViewModels  5   	   ]3clr-namespace:Datalagring_Inlamningsuppgift_1.Views%Datalagring_Inlamningsuppgift_1.Views  5   	   0    *Datalagring_Inlamningsuppgift_1.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Datalagring_Inlamningsuppgift_1     5   	   O
viewmodels8clr-namespace:Datalagring_Inlamningsuppgift_1.ViewModels     5   	   Eviews3clr-namespace:Datalagring_Inlamningsuppgift_1.Views     5   	     � Title$  Inlämningsuppgift 1��5
   	   $	��900��6%   $
��1200��62    � 	Resources 5       �� DataTypeF  @Datalagring_Inlamningsuppgift_1.ViewModels.RegisterCustomerModel@   :Datalagring_Inlamningsuppgift_1.Views.RegisterCustomerView � DataContextD  >Datalagring_Inlamningsuppgift_1.ViewModels.RegisterErrandModel>   8Datalagring_Inlamningsuppgift_1.Views.RegisterErrandViewB  <Datalagring_Inlamningsuppgift_1.ViewModels.CustomerListModel<   6Datalagring_Inlamningsuppgift_1.Views.CustomerListView@  :Datalagring_Inlamningsuppgift_1.ViewModels.ErrandListModel:   4Datalagring_Inlamningsuppgift_1.Views.ErrandListView��%�  (��       5   9   *, +)(�� ]     5   7   *, +)(�� �     5   5   *, +)(��     5   3   *, +)�� 5   
   registerCustomerTemplate��"  69   .R�5         6)   �� 5      �� 5   
   registerErrandTemplate��"  67   .R�5         6'   �� 5      �� 5   
   customerListTemplate��"  65   .R�5         6%   �� 5      �� 5   
   errandListTemplate��"  63   .R�5         6#   �� 5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       .+�5#   
   ]� 
�������$��0��6&   $��0��63   $��8��6C   .+�5$      �� .+�5%      �� -   5         ��Name$ registerCustomerButton��5%      $��0��69   $��0��6F   $	��125��6V   $��10,10q�6c   $��Center=�6r   $��30(�6�   
����İ�
���   �$��3q�6�   $��Registrera
 ny kund��6�   6
  �� 5&      -   5        $ registerErrandButton��5&      $��1��67   $��0��6D   $	��125��6T   $��10,10q�6a   $��Center=�6p   $��30(�6�   
����İ�
���   �$��3q�6�   $��Registrera
nytt ärende��6�   6  �� 5'      -   5        $ customerListButton��5'      $��2��65   $��0��6B   $	��125��6R   $��10,10q�6_   $��Center=�6n   $��30(�6�   
����İ�
���   �$��3q�6�   $��	Kundlista��6�   6�   �� 5(      -   5        $ errandListButton��5(      $��3��63   $��0��6@   $	��125��6P   $��10,10q�6]   $��Center=�6l   $��30(�6�   
����İ�
���   �$��3q�6�   $��Ärendelista��6�   6�   5)      5*      ]� 5+   
   
�������$��1��6+   $��8��6;   6N   �� 5-   
   $��0��6   $��1��6&   $��4��66   $��5��6J   ��6[   �� 5.      5/      