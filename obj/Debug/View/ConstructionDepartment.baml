   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5   	   -    'UnderTheSea.View.ConstructionDepartment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UnderTheSea.View     5   	     � Title$-  'Under The Sea - Construction Department��5   	   $	��700��69   $
��1200��6F   $��15(�6S   
����·� � WindowStartupLocation$ CenterScreen=�6v    � 
ResizeMode$ NoResize=�6�   .��5	      �� .+�5
   
   �� -   5        $��
btnSignOut��5
   C   $��	0,10,10,0q�6   $��5q�6$   $��Sign Out��60   $��Right=�6n   $	��127��6�   �� 5   
   $��10q�6   ._�5      �� $	��600��6   .@�5      �� -   5         ��Name$ DataconstructRide��5   5   $��Data Constructing��6   .��5      �� $��10q�6!   .+�5      �  � ColumnDefinitions 5      �� 5   "   $��* �63   �� 5   "   $��* �63   .+�5      �� $��0��6)   $��10q�69   .+�5   "   �� $*��$List Ride Constructing Under The Sea��6(   $
��Bold"�6W   &   System.Windows.Controls.DataGrid  5   "   -   5          Name$ dataConsRide��5   +   $	��315��6A   6N   5      �� 5      $��1��6)   $��10q�69   .+�5   "   �� $��Request Ride ID��6(   �� 5   "    �� Orientation$ 
Horizontal=�6-   $��10q�6F   .+�5   &   �� -   5         ��Name$ tbReqRideId��5   .   $��70��6C   �� 5   &   -   5         ��Name$ btnSearchRide��5   -   $��Search��6D   $��50,0,0,0q�6q   $��	10,0,10,0q�6�   5   #   �� 5    "   $��	Name Ride��6(   �� 5!   "   -   5        $ tbNameReRide��5!   *   �� 5"   "   -   5        $ btnStartCons��5"   )   $��Start Construct��6?   $��70,10,70,10q�6Y   6n   �� 5#   "   -   5        $ btnfinishCons��5#   )   $��Finish Construct��6@   $��70,10,70,10q�6[   6p   5$      5%      5&      5'      �� 5)      -	   5        $ RequestRide��5)   0   $��Request Ride��6   $
��Left=�6E   $	��102��6`   .��5*      �� $��10q�6!   .+�5+      �  5,      �� 5-   "   $��* �63   �� 5.   "   $��* �63   .+�50      �� $��0��6)   $��10q�69   .+�51   "   �� $��List Ride Under The Sea��6(   $
��Bold"�6J     52   "   -
   5        $ dataRide��52   +   $	��500��6=   6J   53      �� 54      $��1��6)   $��10q�69   .+�55   "   �� $��Ride ID��6(   �� 56   "   $ 
Horizontal=�6-   .+�57   &   �� -   5        $ tbRideId��57   .   $��70��6@   �� 58   &   -   5        $ btnLookRide��58   -   $��Search��6B   $��50,0,0,0q�6m   $��	10,0,10,0q�6   59   #   �� 5;   "   $��	Name Ride��6(   �� 5<   "   -   5        $ 
tbNameRide��5<   *   �� 5=   "   $��Description��6(   �� 5>   "   -   5        $ 
tbDescRide��5>   *   	 �� TextWrapping$
	 Wrap=�6>   "
 �� VerticalScrollBarVisibility$
 Visible=�6R   $��65��6x   �� 5?   "   $��How to work��6(   �� 5@   "   -   5        $ tbHowWorkRide��5@   *   $
	 Wrap=�6A   $
 Visible=�6U   $��65��6{   �� 5A   "   $��Safety Information��6(   �� 5B   "   -   5        $ tbSafetyRide��5B   *   $
	 Wrap=�6@   $
 Visible=�6T   $��65��6z   �� 5C   "   -   5         ��Name$ 
cbKindRide��5C   +   $	��200��6?   $��25��6K   $	��Top=�6W   $
��Left=�6o   $��0,7,0,7q�6�   .@�5D   &   �� $��Select Kind Of Ride��63    �� 
IsSelected . 6Q   �� 5E   &   $��Children Ride��63   �� 5F   &   $��Family Ride��63   �� 5G   &   $��
Water Ride��63   �� 5H   &   $��Thrill Ride��63   5I   #   5J      5K      5L      5M      5N      5O      5P      5Q      