   M S B A M L   `   `   `  ����M  IScoresheetsLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulliGclr-namespace:ScoresheetsLibrary.ViewModels;assembly=ScoresheetsLibraryScoresheetsLibrary.ViewModels  5   	    ArcheryScoresheetsUI%   ArcheryScoresheetsUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^
viewModelsGclr-namespace:ScoresheetsLibrary.ViewModels;assembly=ScoresheetsLibrary     5   	     � Title$  
MainWindow��5	   	   $	��568��6   $	��800��6)   $
��11pt(�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��200 �6   .+�5   
   �� $��0��6   $��0��6   $��2��5      $
��Menu��5      $��Center=�5      
�������5      � 5   
   $��1��6   $��1��6   
����·� 5!      �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    .+�52      �� $��0��6   $��Center=�53      $��Config Menu��54      $��0,0,0,5q�55      �� 58      $��1��6   $
��Left=�59      $��Distance in metres��5:      �� 5<      -   5        $��DistanceBox��5=      $��2��5<      $��0,0,0,5q�5>      5?      �� 5B      $��3��6   $
��Left=�5C      $��Number of arrows per end��5D      �� 5F      -   5        $��ArrowsPerEndBox��5G      $��4��5F      $��0,0,0,5q�5H      5I      �� 5L      $��5��6   $
��Left=�5M      $��Number of ends��5N      �� 5P      -   5        $��NumberOfEndsBox��5Q      $��6��5P      $��0,0,0,5q�5R      5S      �� 5V      $��7��6   $
��Left=�5W      $��Scoring System��5X      �� 5Z      -   5        $��ScoringSystemListBox��5Z   #   $��8��6    �� SelectionMode$ Single=�5\      $��0,0,0,5q�5]      .@�5^      �� .��6   
Imperial6(   �� 5_      .��6   Metric6&   5`      �� 5c      $��9��6   $
��Left=�5d      $��	Face Size��5e      �� 5g      -   5        $��FaceSizeListBox��5g   $   $��10��6   $ Single=�5i      $��0,0,0,5q�5j      .@�5k      �� .��6   40cm6$   �� 5l      .��6   60cm6$   �� 5m      .��6   80cm6$   �� 5n      .��6   122cm6%   5o      �� 5r      $��11��6   $
��Left=�5s      $��Place��5t      �� 5v      -   5        $��PlaceListBox��5v   $   $��12��6   $ Single=�5x      .@�5y      �� .��6   	Indoors6'   �� 5z      .��6   
Outdoors6(   5{      5}      � 5�   
   $��1��6   $��0��6   
����ح� 5�      �� 5�      $
��Auto �6    �� 5�      $��* �6    �� 5�      $
��Auto �6    .+�5�      �� -   5        $��CurrentEntry��5�      $��0��5�      $��Title��5�      $��Center=�5�      
�������5�      &   System.Windows.Controls.DataGrid  5�      -   5        $��EntriesDataGrid��5�   $   $��1��6      AutoGenerateColumns .     HeadersVisibility$ Column=�5�         SelectionMode$ Single=�5�      ��5�      �� *CurrentEntries+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 5�   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   )   �� *	EntryName+ �� Mode$ OneWay=�5�   )     5�      $ Total��6)   	 . $

 Auto 5�   )    5�   )   �� *Total+$ OneWay=�5�   )     5�      $ Golds��6)   	 . $

 Auto 5�   )    5�   )   �� *
TotalGolds+$ OneWay=�5�   )   5�      � 5�      $��2��6   
������� 5�      �� 5�      $��* �6'   �� 5�      $��* �6'   .+�5�      �� $��0��6   $
��Left=�5�      ��5�      �� *CurrentEntry.EntryName+5�      � 5�      $��1��6   $��Right=�5�       5�      �� 5�      $��* �6+   �� 5�      $��* �6+   �� 5�      $��* �6+   .+�5�      �� -	   5        $��0��5�      $	��Add��5�      $��10,0,5,0q�5�      �� 5�      -
   5        $��1��5�      $
��Edit��5�      $��5,0,5,0q�5�      �� 5�      -   5        $��2��5�      $��Delete��5�      $��5,0,10,0q�5�      5�      5�      5�      5�      5�      