   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5   	   )    #UnderTheSea.View.PurchaseDepartment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UnderTheSea.View     5   	     � Title$)  #Purchase Department - Under The Sea��5   	   $	��700��65   $
��1200��6B   $��15(�6O   
���P�� � WindowStartupLocation$ CenterScreen=�6p    � 
ResizeMode$ NoResize=�6�   .��5	      �� .+�5
   
   �� -   5         ��Name$ 
btnSignOut��5
   C   $��	0,10,10,0q�6   $��5q�6$   $��Sign Out��60   $��Right=�6p   $	��127��6�   �� 5   
   $��10q�6   ._�5      �� $	��595��6   .@�5      �� -   5         ��Name$ ManageAdvertisement��5   4   $��Request Purchase��6   .��5      �  � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $��* �6/   .+�5      �� $��0��6%   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dataReqPur��5   '   $	��500��6;   6H   5      �� 5      $��1��6%   5      5      5      �� 5      -   5        $ requestFund��5   0   $��Request Fund��6   .��5      � $��10q�6    5      �� 5      $��* �6/   �� 5       $��* �6/   .+�5"      �� $��0��6%   $��10q�65   .+�5#      �� $)��#List Request Purchase Under The Sea��6$   $
��Bold"�6R     5$      -   5        $ dataRequestFund��5$   '   $	��315��6@   6M   5%      �� 5&      $��1��6%   $��10q�65   .+�5'      �� $��Request Purchase ID��6$   �� 5(       �� Orientation$ 
Horizontal=�6)   $��10q�6B   .+�5)   "   �� -   5         ��Name$ tbFundId��5)   *   $��70��6<   �� 5*   "   -   5        $ 	btnFundId��5*   )   $��Search��6<   $��50,0,0,0q�6e   $��	10,0,10,0q�6w   5+      �� 5,      $��Request Detail��6$   �� 5-      -   5        $ 	tbFundDet��5-   &   	 �� TextWrapping$
	 Wrap=�69   "
 �� VerticalScrollBarVisibility$
 Visible=�6M   $��45��6s   �� 5.      $��Amount of Price��6$   �� 5/      -	   5        $ tbFundAmount��5/   &   $��30��6<   �� 50      -
   5        $ RequestFund��50   %   $��Request Fund��6:   $��70,10,70,10q�6Q   6f   �� 51      $��Reason��6$   �� 52      -   5        $ tbReasonNoAcc��52   &   $
	 Wrap=�6=   $
 Visible=�6Q   $��84��6w   53      54      55      56      57      58      59      