   M S B A M L   `   `   `  ����E  AWpfProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProjekt
WpfProjekt  5   	       WpfProjekt.GiveItem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfProjekt     5   	     � Title$  	AddWorker��5	   	   $	��450��6   $	��800��6(    � 	Resources 5
      ��%    5      .��5      � ��5   
   �� 5       �� 
StartPoint$	 1,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ DarkGoldenrod��6    � Offset$	 0.1Q�65   � 5      $ Black��6   $ 6Q�6-   5      .+�5   
   � -   5         �Name$ grid1��5      $
��Left=�6   $��	50,35,0,0q�69   $	��Top=�6L    J� Opacity$	 0.9Q�6d   $	��240��6r   $	��149��6~   #��� ��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	 � ColumnDefinitions	 5      �� 5      $
��Auto �6#   �� 5      
 � RowDefinitions
 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5#      �� $��Id artykułu:��6   $��0��6+   $
��Left=�6;   $��3,8.556,0,35.778q�6V   $��1��6p   $��Center=�6}   $��16(�6�   $��2��6�   �� 5$      -   5         ��Name$ idartykuluTextBox��5$      $��1��61   $
��Left=�6A   $��28��6\   $��2.556,5.556,0,36.222q�6h   $��1��6�   $��Center=�6�   $	��120��6  $��15(�6  $��2��6,  ��6�   �� *id_artykulu+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6,  �� 5%      $��id pracownika:��6   $��0��6-   $
��Left=�6=   $��3,8.556,0,35.778q�6X   $��2��6r   $��Center=�6   $��16(�6�   $��2��6�   �� 5&      -   5        $ idpracownikaTextBox��5&      $��1��63   $
��Left=�6C   $��28��6^   $��2.556,5.556,0,36.222q�6j   $��2��6�   $��Center=�6�   $	��120��6  $��15(�6"  $��2��60  ��6�   �� *id_pracownika+$ TwoWay=� .  . 60  �� 5'      $��Ilosc sztuk:��6   $
��Left=�6+   $��10,7.889,0,1.778q�6F   $��3��6`   $��Center=�6m   $��16(�6�   �� 5(      -   5        $ iloscTextBox��5(      $��1��6,   $
��Left=�6<   $��30��6W   $��2.556,6.222,0,0.222q�6c   $��3��6�   $��Center=�6�   $	��120��6  $��14(�6  $��2��6&  ��6�   �� *ilosc_sztuk+$ TwoWay=� .  . 6&  �� 5)      $��data wydania:��6   $��0��6,   $
��Left=�6<   $��10,43.889,0,-26.111q�6W   $��3��6t   $��Center=�6�   $��16(�6�   (  "System.Windows.Controls.DatePicker  5*      -   5          Name$ data_wydaniaDatePicker��5*      $��1��69   $
��Left=�6I   $��0.111,44.889,0,-25.444q�6d   $��3��6�   $��Center=�6�      SelectedDate 6�   �� *data_wydania+$ TwoWay=� .  . 6�   5+      �� 5,   
   -   5        $��Wydaj��5,      $
��Left=�6!   $��
50,202,0,0q�6<   $	��Top=�6P   $��40��6h   $	��240��6t   $��14(�6�   $	 0.9Q�6�   ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $ Black��6#   $ 0Q�61   � 50      $ White��6#   $ 1Q�61   51      53      �� 54   
   -   5        $��Edytuj��54      $
��Left=�6"   $��
50,265,0,0q�6=   $	��Top=�6Q   $��40��6i   $	��240��6u   $��14(�6�   $	 0.9Q�6�   ��55      �� 56      $ 0.5,1&�6&   $ 0.5,0&�67   .��57      � $ Black��6#   $ 0Q�61   � 58      $ White��6#   $ 1Q�61   59      5;      �� 5<   
   -   5        $��Usuń��5<      $
��Left=�6    $��
50,328,0,0q�6;   $	��Top=�6O   $��40��6g   $	��240��6s   $��14(�6�   $	 0.9Q�6�   ��5=      �� 5>      $ 0.5,1&�6&   $ 0.5,0&�67   .��5?      � $ Black��6#   $ 0Q�61   � 5@      $ White��6#   $ 1Q�61   5A      5C      &   System.Windows.Controls.DataGrid  5D   
   -	   5          Name$ gridGiveItems��5D         AutoGenerateColumns .  $
��Left=�6F   $	��237��6a   $��
412,26,0,0q�6n   $	��Top=�6�   $	��350��6�   #��� ��6�      Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5G      -
   5        id_zamowieniaColumn��,  &System.Windows.Controls.DataGridColumn   Header$ id zamowienia��5G   d      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6{   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *id_zamowienia+6{     5H      -   5        id_artykuluColumn��$ id artykulu��5H   `   $ SizeToHeader 6u    6@   �� *id_artykulu+6u     5I      -   5        id_pracownikaColumn��$ id racownika��5I   d   $ SizeToHeader 6z    6B   �� *id_pracownika+6z     5J      -   5        riloscColumn��$ ilosc��5J   [   $ 50 6j    6;   �� *ilosc_sztuk+6j   4  .System.Windows.Controls.DataGridTemplateColumn  5K      -   5        data_wydaniaColumn��$ data wydania��5K   E   $	 100 6[      CellTemplate 5L      �� 5M      .R�5N         6)   �� *data_wydania+$ TwoWay=� .  . 5O      5Q      5T      5V      5W      