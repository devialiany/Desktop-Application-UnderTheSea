   M S B A M L   `   `   `  ����F  BUnderTheSea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UnderTheSea.ViewUnderTheSea.View  5      $    UnderTheSea.View.RequestPermit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:UnderTheSea.View     5        N� Title$  RequestPermit��5	       N� 
Background
 ����� N� FontSize$ 15(�63   .��5      �� $��5q�6   .+�5   
   �� $��Request Permit��6   $
��Bold"�6)   �� 5   
   $��From Date *(required)��6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 from��5      �� 5   
   $��To Date *(required)��6     5   
   -   5        $ to��5      �� 5   
   -   5         ��Name$ cbCategoryPermit��5      $	��200��6-   $��25��69   $	��Top=�6E   $
��Left=�6]   $��0,7,0,7q�6x   .@�5      �� $��select category��6    �� 
IsSelected . 65   �� 5      $��Personal��6   �� 5      $
��Sick��6   �� 5      $��Family Event��6   �� 5      $��Other��6   5      �� 5   
   $��Reason *(required)��6   �� 5   
   -   5         ��Name$ 
reasonDesc��5       �� TextWrapping$
 Wrap=�6&   " �� VerticalScrollBarVisibility$ Visible=�6:   $��76��6`   �� 5   
   -   5        	 ��Name$	 sendPermitToManager��5      $��Send Request��6)   $��10q�6@   6L   5      5      