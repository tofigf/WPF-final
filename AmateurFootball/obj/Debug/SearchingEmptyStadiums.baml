   M S B A M L   `   `   `  ����J  FAmateurFootball, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AmateurFootballAmateurFootball  5      ,    &AmateurFootball.SearchingEmptyStadiums   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:AmateurFootball     5      .��5	      � #��� ��6   $��	0,0,-98,0q�6W   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dgSearchResult��5
      $
��Left=�6O   $	��306��6j   $��
288,10,0,0q�6w   $	��Top=�6�   $	��504��6�   ��6*   �� *ReservedView+    Columns  5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Id�6M     5      $ Stadium��6F    6%   �� $ Stadium�6F     5      $ 	StartTime��6E    6&   �� $ Stime�6E     5      $ EndTime��6E    6&   �� $ Etime�6E     5      $ 
ReservTime��6P    6&   �� $ ReservAcsesstime�6P     5      $ Price��6E    6&   �� $ Price�6E     5      $ Costumer��6H    6&   �� $ Costumer�6H     5      $ Phone��6E    6&   �� $ Phone�6E   5      �� 5   
   -   5        $��txtHours��5      $
��Left=�6E   $��23��6`   $��
47,152,0,0q�6l    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��	49,59,0,0q�6/   $
��Wrap=�6B   $��Search Date��6V   $	��Top=�6i   �� 5   
   $
��Left=�6   $��
47,131,0,0q�6/   $
��Wrap=�6C   $��Search Hour��6W   $	��Top=�6j   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dpSeach��5      $
��Left=�6T   $��	36,80,0,0q�6o   $	��Top=�6�   �� 5   
   -   5        $��	btnSearch��5   "   $��Search��6   $
��Left=�6K   $��
63,247,0,0q�6f   $	��Top=�6z   $��75��6�   5      5      