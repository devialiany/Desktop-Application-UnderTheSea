   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5   	   :    4UnderTheSea.View.RideandAttarctionCreativeDepartment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UnderTheSea.View     5   	     � Title$=  7Under The Sea - Ride and Attraction Creative Department��5   	   $	��700��6I   $
��1200��6V   $��15(�6c   
��� � � � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�   .��5	      �� .+�5
   
   �� -   5        $��
btnSignOut��5
   C   $��	0,10,10,0q�6   $��5q�6$   $��Sign Out��60   $��Right=�6n   $	��127��6�   �� 5   
   $��10q�6   ._�5      �� $	��597��6   .@�5      �� -   5         ��Name$ RequestRide��5   0   $��Request Ride��6   .��5      �� $��10q�6!   .+�5      �  � ColumnDefinitions 5      �� 5   "   $��* �63   �� 5   "   $��* �63   .+�5      �� $��0��6)   $��10q�69   .+�5   "   �� $��List Ride Under The Sea��6(   $
��Bold"�6J   &   System.Windows.Controls.DataGrid  5   "   -   5          Name$ dataRideForRequest��5   +   $	��500��6G   6T   5      �� 5      $��1��6)   $��10q�69   .+�5   "   �� $��Ride ID��6(   �� 5   "    �� Orientation$ 
Horizontal=�6-   .+�5   &   �� -   5         ��Name$ tbRideId��5   .   $��70��6@   �� 5   &   -   5         ��Name$ btnSearchRide��5   -   $��Search��6D   $��50,0,0,0q�6q   $��	10,0,10,0q�6�   �� 5   &   -   5        $ btnSendConstruction��5   -   $��Request To Construction��6l   $��40 0 0 0q�6�   5    #   �� 5"   "   $��	Name Ride��6(   �� 5#   "   -   5        $ 
tbNameRide��5#   *   �� 5$   "   $��Description��6(   �� 5%   "   -   5        $ 
tbDescRide��5%   *   	 �� TextWrapping$
	 Wrap=�6>   "
 �� VerticalScrollBarVisibility$
 Visible=�6R   $��65��6x   �� 5&   "   $��How to work��6(   �� 5'   "   -	   5        $ tbHowWorkRide��5'   *   $
	 Wrap=�6A   $
 Visible=�6U   $��65��6{   �� 5(   "   $��Safety Information��6(   �� 5)   "   -
   5        $ tbSafetyRide��5)   *   $
	 Wrap=�6@   $
 Visible=�6T   $��65��6z   �� 5*   "   -   5         ��Name$ 
cbKindRide��5*   +   $	��200��6?   $��25��6K   $	��Top=�6W   $
��Left=�6o   $��0,7,0,7q�6�   .@�5+   &   �� $��Select Kind Of Ride��63    �� 
IsSelected . 6Q   �� 5,   &   $��Children Ride��63   �� 5-   &   $��Family Ride��63   �� 5.   &   $��
Water Ride��63   �� 5/   &   $��Thrill Ride��63   50   #   �� 51   "   -   5        $ btnRequestAddRide��51   )   $��Send Request To Add Ride��6D   $��5q�6�   �� 52   "   -   5        $ btnRequestUpdateRide��52   )   $!��Send Request To Update Ride��6G   $��5q�6m   6x   �� 53   "   -   5        $ btnRequestRemoveRide��53   )   $!��Send Request To Remove Ride��6G   $��5q�6m   6x   54      55      56      57      �� 5:      -   5        $ 
RequestAtt��5:   6   $��Request Attraction��6   .��5;      �� $��10q�6!   .+�5<      �  5=      �� 5>   "   $��* �63   �� 5?   "   $��* �63   .+�5A      �� $��0��6)   $��10q�69   .+�5B   "   �� $#��List Attraction Under The Sea��6(   $
��Bold"�6P     5C   "   -   5        $ dataAttractionForRequest��5C   +   $	��500��6M   6Z   5D      �� 5E      $��1��6)   $��10q�69   .+�5F   "   �� $��Attraction ID��6(   �� 5G   "   $ 
Horizontal=�6-   .+�5H   &   �� -   5        $ tbAttId��5H   .   $��70��6?   �� 5I   &   -   5        $ btnSearchAtt��5I   -   $��Search��6C   $��50,0,0,0q�6o   $��	10,0,10,0q�6�   5J   #   �� 5K   "   $��Name Attraction��6(   �� 5L   "   -   5        $ 	tbNameAtt��5L   *   $��31��6=   �� 5M   "   $��Description��6(   �� 5N   "   -   5        $ 	tbDescAtt��5N   *   $
	 Wrap=�6=   $
 Visible=�6Q   $��60��6w   �� 5O   "   $��How to work��6(   �� 5P   "   -   5        $ tbHowWorkRAtt��5P   *   $
	 Wrap=�6A   $
 Visible=�6U   $��60��6{   �� 5Q   "   $��who participant��6(   �� 5R   "   -   5        $ 	tbWhoPart��5R   *   $
	 Wrap=�6=   $
 Visible=�6Q   $��60��6w   �� 5S   "   $��Start Date Launch��6(   (  "System.Windows.Controls.DatePicker  5T   "   -   5          Name$ dpDateLaunch��5T   -   �� 5U   "   -   5        $ btnRequestAddAtt��5U   )   $$��Send Request To Add Attraction��6C   $��5q�6�   �� 5V   "   -   5        $ btnRequestUpdateAtt��5V   )   $'��!Send Request To Update Attraction��6F   $��5q�6r   6}   �� 5W   "   -   5        $ btnRequestRemoveAtt��5W   )   $'��!Send Request To Remove Attraction��6F   $��5q�6r   6}   5X      5Y      5Z      5[      �� 5^      -   5        $ DataRequestRide��5^   5   $��Data Request Ride��6   .��5_      �� $��10q�6!   .+�5`      �  5a      �� 5b   "   $��* �63   �� 5c   "   $��* �63   .+�5e      �� $��0��6)   $��10q�69   .+�5f   "   �� $%��List Request Ride Under The Sea��6(   $
��Bold"�6R     5g   "   -   5        $ dataRequestRide��5g   +   $	��315��6D   6Q   �� 5h   "   -   5        $ btnAddRideBase��5h   )   $��Add Ride��6A   $��70,10,70,10q�6T   6i   �� 5i   "   -   5        $ btnUpdRideBase��5i   )   $��Update Ride��6A   $��70,10,70,10q�6W   6l   �� 5j   "   -   5        $ btnDelRideBase��5j   )   $��Remove Ride��6A   $��70,10,70,10q�6W   6l   5k      �� 5l      $��1��6)   $��10q�69   .+�5m   "   �� $��Request Ride ID��6(   �� 5n   "   $ 
Horizontal=�6-   $��10q�6F   .+�5o   &   �� -    5        $ tbReqRideId��5o   .   $��70��6C   �� 5p   &   -!   5        $ btnSearchReRide��5p   -   $��Search��6F   $��50,0,0,0q�6u   $��	10,0,10,0q�6�   5q   #   �� 5r   "   $��	Name Ride��6(   �� 5s   "   -"   5        $ tbNameReRide��5s   *   �� 5t   "   $��Description��6(   �� 5u   "   -#   5        $ tbDescReRide��5u   *   $
	 Wrap=�6@   $
 Visible=�6T   $��65��6z   �� 5v   "   $��How to work��6(   �� 5w   "   -$   5        $ tbHowWorkReRide��5w   *   $
	 Wrap=�6C   $
 Visible=�6W   $��65��6}   �� 5x   "   $��Safety Information��6(   �� 5y   "   -%   5        $ tbSafetyReRide��5y   *   $
	 Wrap=�6B   $
 Visible=�6V   $��65��6|   �� 5z   "   -&   5        $ cbKindReRide��5z   +   $	��200��6A   $��25��6M   $	��Top=�6Y   $
��Left=�6q   $��0,7,0,7q�6�   .@�5{   &   �� $��Select Kind Of Ride��63    . 6Q   �� 5|   &   $��Children Ride��63   �� 5}   &   $��Family Ride��63   �� 5~   &   $��
Water Ride��63   �� 5   &   $��Thrill Ride��63   5�   #   �� 5�   "   -'   5        $ btnUpdateRequestRideData��5�   )   $��Update Request Ride��6K   $��70,10,70,10q�6i   6~   �� 5�   "   -(   5        $ btnCancelRequestRideData��5�   )   $��Cancel Request Ride��6K   $��70,10,70,10q�6i   6~   5�      5�      5�      5�      �� 5�      -)   5        $ DataRequestAtt��5�   ;   $��Data Request Attraction��6   .��5�      �� $��10q�6!   .+�5�      �  5�      �� 5�   "   $��* �63   �� 5�   "   $��* �63   .+�5�      �� $��0��6)   $��10q�69   .+�5�   "   �� $%��List Request Ride Under The Sea��6(   $
��Bold"�6R     5�   "   -*   5        $ dataRequestAtt��5�   +   $	��315��6C   6P   �� 5�   "   -+   5        $ btnAddAttBase��5�   )   $��Add Ride��6@   $��70,10,70,10q�6S   6h   �� 5�   "   -,   5        $ btnUpdAttBase��5�   )   $��Update Ride��6@   $��70,10,70,10q�6V   6k   �� 5�   "   --   5        $ btnDelAttBase��5�   )   $��Remove Ride��6@   $��70,10,70,10q�6V   6k   5�      �� 5�      $��1��6)   $��10q�69   .+�5�   "   �� $��Request Ride ID��6(   �� 5�   "   $ 
Horizontal=�6-   $��10q�6F   .+�5�   &   �� -.   5        $ 
tbReqAttId��5�   .   $��70��6B   �� 5�   &   -/   5        $ btnSearchReAtt��5�   -   $��Search��6E   $��50,0,0,0q�6s   $��	10,0,10,0q�6�   5�   #   �� 5�   "   $��	Name Ride��6(   �� 5�   "   -0   5        $ tbNameReAtt��5�   *   �� 5�   "   $��Description��6(   �� 5�   "   -1   5        $ tbDescReAtt��5�   *   $
	 Wrap=�6?   $
 Visible=�6S   $��65��6y   �� 5�   "   $��How to work��6(   �� 5�   "   -2   5        $ tbHowWorkReAtt��5�   *   $
	 Wrap=�6B   $
 Visible=�6V   $��65��6|   �� 5�   "   $��who participant��6(   �� 5�   "   -3   5        $ tbReWhoPart��5�   *   $
	 Wrap=�6?   $
 Visible=�6S   $��60��6y   �� 5�   "   $��Start Date Launch��6(     5�   "   -4   5        $ dpReDateLaunch��5�   -   �� 5�   "   -5   5        $ btnUpdateRequestAttData��5�   )   $��Update Request Ride��6J   $��70,10,70,10q�6h   6}   �� 5�   "   -6   5        $ btnCancelRequestAttData��5�   )   $��Cancel Request Ride��6J   $��70,10,70,10q�6h   6}   5�      5�      5�      5�      �� 5�      -7   5        $ requestPurchase��5�   4   $��Request Purchase��6   .��5�      � $��10q�6    5�      �� 5�      $
��574* �6/   �� 5�      $
��146* �6/   �� 5�      $
��429* �6/   .+�5�      �� $��0��6%   $��10q�65   .+�5�      �� $)��#List Request Purchase Under The Sea��6$   $
��Bold"�6R     5�      -8   5        $ dataRequestPurchase��5�   '   $	��315��6D   6Q   5�      �� 5�      $��1��6%   $��10q�65   $��2��6A   .+�5�      �� $��Request Purchase ID��6$   �� 5�      $ 
Horizontal=�6)   $��10q�6B   .+�5�   "   �� -9   5        $ tbPurId��5�   *   $��70��6;   �� 5�   "   -:   5        $ btnPurId��5�   )   $��Search��6;   $��50,0,0,0q�6c   $��	10,0,10,0q�6u   5�      �� 5�      $��Request Detail��6$   �� 5�      -;   5        $ tbReqDet��5�   &   $
	 Wrap=�68   $
 Visible=�6L   $��78��6r   �� 5�      $��Date to Need��6$     5�      -<   5        $ dpNeed��5�   )   �� 5�      $��Time to Need��6$   �� 5�      -=   5        $ 
tbTimeNeed��5�   &   �� 5�      ->   5        $ btnRequestPurchase��5�   %   $��Request Purchase��6A   $��70,10,70,10q�6\   6q   5�      5�      5�      �� 5�      -?   5        $ requestFund��5�   0   $��Request Fund��6   .��5�      � $��10q�6    5�      �� 5�      $��* �6/   �� 5�      $��* �6/   .+�5�      �� $��0��6%   $��10q�65   .+�5�      �� $)��#List Request Purchase Under The Sea��6$   $
��Bold"�6R     5�      -@   5        $ dataRequestFund��5�   '   $	��315��6@   6M   5�      �� 5�      $��1��6%   $��10q�65   .+�5�      �� $��Request Purchase ID��6$   �� 5�      $ 
Horizontal=�6)   $��10q�6B   .+�5�   "   �� -A   5        $ tbFundId��5�   *   $��70��6<   �� 5�   "   -B   5        $ 	btnFundId��5�   )   $��Search��6<   $��50,0,0,0q�6e   $��	10,0,10,0q�6w   5�      �� 5�      $��Request Detail��6$   �� 5�      -C   5        $ 	tbFundDet��5�   &   $
	 Wrap=�69   $
 Visible=�6M   $��45��6s   �� 5�      $��Amount of Price��6$   �� 5�      -D   5        $ tbFundAmount��5�   &   $��30��6<   �� 5�      -E   5        $ RequestFund��5�   %   $��Request Fund��6:   $��70,10,70,10q�6Q   6f   �� 5�      $��Reason��6$   �� 5�      -F   5        $ tbReasonNoAcc��5�   &   $
	 Wrap=�6=   $
 Visible=�6Q   $��84��6w   5�      5�      5�      5�      5�      5�      5�      