   M S B A M L   `   `   `  ����J  FAmateurFootball, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AmateurFootballAmateurFootball  5   	        AmateurFootball.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AmateurFootball     5   	     � Title$  Footbal��5   	   $��474.074��6   $��1368.5��6*    � 	Resources 5	      2  ,System.Windows.Controls.AlternationConverter   AlternationConverter��%   &	          5
   
   6   5      .��5      � $��10,0,-316,0q�6   $	��440��6    $	��Top=�6-   $
��Left=�6E   $
��1666��6`    � ColumnDefinitions 5   
   �� 5      $
��461* �6   �� 5      $
��181* �6   �� 5      $	��86* �6   �� 5      $	��37* �6   �� 5      $
��343* �6   .+�5   
   �� -   5        $��
cmbStadium��5      $
��Left=�6V   $��	48,86,0,0q�6q   $	��Top=�6�   $	��168��6�   $��37��6�   �� 5   
   $��Stadiums��6   $
��Left=�6#   $��	48,49,0,0q�6>   $	��Top=�6Q    J� RenderTransformOrigin$ 0.632,1.096&�6i   $��32��6�   $	��101��6�   �� 5   
   -   5        $��txtCostumers��5      $
��Left=�6&   $��23��6A   $��
272,86,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   $��	Costumers��6   $
��Left=�6$   $��
272,49,0,0q�6?   $	��Top=�6S   $ -0.171,0.577&�6k   �� 5   
   $��EndTime��6   $
��Left=�6"   $��
48,257,0,0q�6=   $	��Top=�6Q   $ -0.171,0.577&�6i   �� 5   
   $��	StartTime��6   $
��Left=�6$   $��
44,145,0,0q�6?   $	��Top=�6S   $ -0.171,0.577&�6k   �� 5   
   $
��Left=�6   $��282,124,0,0q�6/   $
��Wrap=�6D   $��Phone��6X   $	��Top=�6e   $ 0.602,-0.844&�6}   �� 5   
   -   5        $��txtPhone��5      $
��Left=�6"   $��23��6=   $��272,145,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $��Booking��5      $��20(�6#   $
��Left=�61   $��
78,375,0,0q�6L   $	��Top=�6`   $	��138��6x   $ 1.333,0.025&�6�   $��44��6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgReserv��5         AutoGenerateColumns .  $
��Left=�6d   $	��239��6   $��
461,76,0,0q�6�   $	��Top=�6�   $	��761��6�   $��5��6�   ��6?   �� *ReservedView+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6A      
Visibility$ Hidden=�6M   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 
 �� Path$
 Id�6M     5!      $ Stadium��6F   	 6%   �� $
 Stadium�6F     5"      $ 	StartTime��6E   	 6&   �� $
 Stime�6E     5#      $ EndTime��6E   	 6&   �� $
 Etime�6E     5$      $ 
ReservTime��6P   	 6&   �� $
 ReservAcsesstime�6P     5%      $ Price��6E   	 6&   �� $
 Price�6E     5&      $ Costumer��6H   	 6&   �� $
 Costumer�6H     5'      $ Phone��6E   	 6&   �� $
 Phone�6E     5(      $ 
Match Date��6I   	 6&   �� $
 	MatchDate�6I   4  .System.Windows.Controls.DataGridTemplateColumn  5)         CellTemplate 5*      �� 5+      .R�5,      �� -   5        .��5,   <   Delete6D   5-      5/        50       51      �� 52      .R�53      �� -   5        .��53   <   Update6D   54      56      58      �� 5:   
   -   5        $��lblRooms��5:      $�� ��6    $
��Left=�6+   $��
48,278,0,0q�6F   $	��Top=�6Z   ���	#FF91230A$��20(�6�   $
��Bold"�6�   �� 5;   
   -	   5        $��lblError��5;      $
��Left=�6$   $��430,362,0,0q�6?   $
��Wrap=�6T   $�� ��6h   $	��Top=�6p   $ 0.602,-0.844&�6�   ���	#FFC50E0E$��20(�6�   $
��Bold"�6�   �� 5<   
   -
   5        $��tbPrice��5<      $
��Left=�6#   $��282,201,0,0q�6>   $
��Wrap=�6S   $�� ��6g   $	��Top=�6o   ���	#FF2414C3$
��Bold"�6�   $��20(�6�   �� 5=   
   -   5         ��Name$ cmbTest��5=      $
��Left=�6%   $��
48,176,0,0q�6@   $	��Top=�6T   $	��168��6l   $��37��6x   6�   �� 5>   
   -   5        $ cmbETimeTest��5>      $
��Left=�6)   $��
48,288,0,0q�6D   $	��Top=�6X   $	��168��6p   $��37��6|   6�   (  "System.Windows.Controls.DatePicker  5?   
   -   5        $��dpMatchDate��5?         SelectedDateFormat$ Short=�6*   $
��Left=�6F   $��282,298,0,0q�6a   $	��Top=�6v   $��27��6�   $	��110��6�      FirstDayOfWeek$ Monday=�6�   �� 5@   
   $
��Left=�6   $��282,267,0,0q�6/   $
��Wrap=�6D   $��
Match Date��6X   $	��Top=�6j   $ 0.602,-0.844&�6�     5A   
   -   5        $��dpSearch��5A      $
��Left=�6%   $��	0,388,0,0q�6@   $	��Top=�6S   $	��142��6k   $ 1.035,0.625&�6w   $��3��6�   $��2��6�     5B   
   -   5        $��dgSearch��5B      $
��Left=�6#   $	��100��6d   $��461,330,0,0q�6q   $	��Top=�6�   $	��565��6�   $��3��6�   ��6?   �� *ReservedView+ 5C        5D      $ ID��6A   $ Hidden=�6M   	 6%   �� $
 Id�6M     5E      $ Stadium��6F   	 6%   �� $
 Stadium�6F     5F      $ 	StartTime��6E   	 6&   �� $
 Stime�6E     5G      $ EndTime��6E   	 6&   �� $
 Etime�6E     5H      $ 
ReservTime��6P   	 6&   �� $
 ReservAcsesstime�6P     5I      $ Price��6E   	 6&   �� $
 Price�6E     5J      $ Costumer��6H   	 6&   �� $
 Costumer�6H     5K      $ Phone��6E   	 6&   �� $
 Phone�6E     5L      $ 
Match Date��6I   	 6&   �� $
 	MatchDate�6I   5N      �� 5O   
   -   5        $��Search��5O      $��20(�6"   $
��Left=�60   $��	0,330,0,0q�6K   $	��Top=�6^   $��88��6v   $ 1.333,0.025&�6�   $��44��6�   $
��Bold"�6�   $��3��6�   $��2��6�   5P      5Q      