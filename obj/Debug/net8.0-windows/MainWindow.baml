   M S B A M L   `   `   `  ����  CustomerFinderApp"    CustomerFinderApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Customer Finder��5   	   $	��350��6!   $	��400��6.   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   � $��0��6   $��0,0,0,10q�6   .+�5      �� -   5         ��Name$ 
IdsTextBox��5      $	��350��6*   $��30��66   �� 5      -   5         ��Name$ PlaceholderTextBlock��5      $G��AВъведете ID-та (разделени с интервал)��66   
������� J� IsHitTestVisible$ False��5   *   $��Center=�5      $
��Left=�63   $��5,0,0,0q�5      5      �� 5   
   -   5        $��Търсене��5      $	��100��6#   $��30��6/   $��1��5      $	��Top=�6   $
��Left=�66   5      �� 5   
   -   5         ��Name$ ResultsListBox��5      $��2��6*   5      5      