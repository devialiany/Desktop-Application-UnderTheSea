   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5   	   +    %UnderTheSea.View.RestaurantDepartment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UnderTheSea.View     5   	     � Title$+  %Under The Sea - Restaurant Department��5   	   $	��500��67   $	��770��6D   $��15(�6P   
������� � WindowStartupLocation$ CenterScreen=�6p    � 
ResizeMode$ NoResize=�6�   .��5	      �� .+�5
   
   �� -   5        $��
btnSignOut��5
   C   $��	0,10,10,0q�6   $��5q�6$   $��Sign Out��60   $��Right=�6n   $	��127��6�   �� 5   
   $��10q�6   ._�5      �� $	��396��6   .@�5      �� -   5         ��Name$ CheckTicket��5   3   $��Checking Ticket��6   .��5      �� $��30q�6!   .+�5      �� $��Checking Validy Ticket��6    $��Center=�6A   $
��Bold"�6^   � 5      $��0 5 0 0q�6   $	��252��60    � ColumnDefinitions 5      �� 5   "   $��* �63   �� 5   "   $��* �63   .+�5      �� -   5        $��btnScan��5   a   $��0��6%   $��10,23,10,182q�6K   $
��Scan��6p   �� 5      -   5         ��Name$ 	imgQRCode��5   $   $��1��67   $
��Left=�6G   $	��232��6b   $��	68,10,0,0q�6o   $	��Top=�6�   $	��235��6�   �� 5      -   5         ��Name$ tbQrCode��5   &   $��Center=�68   $��35��6U   $��30,91,27,126q�6a    �� TextWrapping$
 Wrap=�6w   $��Center=�6�   $	��296��6�   $��Center=�6�   $��Center=�6�   6�   �� 5      -   5         ��Name$ 	lbMessage��5   $   $��Scan Ticket....��67   $
��Left=�6Q   $��
10,141,0,0q�6l   $	��Top=�6�   $	��333��6�   $	��103��6�   $��Center=�6�   $��Center=�6�   5      5      5      �� 5      -   5        $ a��5   .   $��
List Table��6   .��5       �� .+�5!      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 dataListTable��5!   #   $	��500��6:   6G   5"      5#      5$      5%      5&      5'      