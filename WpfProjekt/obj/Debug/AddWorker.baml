   M S B A M L   `   `   `  ����E  AWpfProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProjekt
WpfProjekt  5   	       WpfProjekt.AddWorker   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfProjekt     5   	     � Title$  	AddWorker��5   	   $	��450��6   $	��800��6(   .��5
      � ��5   
   �� 5       �� 
StartPoint$	 1,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ DarkGoldenrod��6    � Offset$	 0.1Q�65   � 5      $ Black��6   $ 6Q�6-   5      .+�5   
   � -   5         �Name$ grid1��5      $
��Left=�6   $��	50,35,0,0q�69   $	��Top=�6L    J� Opacity$	 0.9Q�6d   $	��230��6r   $��83��6~   #��� ��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      	 � RowDefinitions	 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Imie:��6   $��0��6$   $
��Left=�64   $��3,8.556,0,35.778q�6O   $��1��6i   $��Center=�6v   $��16(�6�   $��2��6�   �� 5       -   5        
 ��Name$
 imieTextBox��5       $��1��6+   $
��Left=�6;   $��28��6V   $��2.556,5.556,0,36.222q�6b   $��1��6�   $��Center=�6�   $	��120��6  $��15(�6  $��2��6  ��6�   �� *imie+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  �� 5!      $��	Nazwisko:��6   $��0��6(   $
��Left=�68   $��3,6.556,0,0.889q�6S   $��2��6l   $��Center=�6y   $��16(�6�   �� 5"      -   5        $
 nazwiskoTextBox��5"      $��1��6/   $
��Left=�6?   $��30��6Z   $��2.556,6.222,0,0.222q�6f   $��2��6�   $��Center=�6�   $	��120��6  $��14(�6  $��2��6&  ��6�   �� *
nazwisko+$ TwoWay=� .  . 6&  5$      �� 5%   
   -   5        $��Dodaj��5%      $
��Left=�6!   $��
50,181,0,0q�6<   $	��Top=�6P   $��40��6h   $	��240��6t   $��14(�6�   $	 0.9Q�6�   ��5&      �� 5'      $ 0.5,1&�6&   $ 0.5,0&�67   .��5(      � $ Black��6#   $ 0Q�61   � 5)      $ White��6#   $ 1Q�61   5*      5,      �� 5-   
   -   5        $��Edytuj��5-      $
��Left=�6"   $��
50,241,0,0q�6=   $	��Top=�6Q   $��40��6i   $	��240��6u   $��14(�6�   $	 0.9Q�6�   ��5.      �� 5/      $ 0.5,1&�6&   $ 0.5,0&�67   .��50      � $ Black��6#   $ 0Q�61   � 51      $ White��6#   $ 1Q�61   52      54      �� 55   
   -   5        $��Usuń��55      $
��Left=�6    $��
50,301,0,0q�6;   $	��Top=�6O   $��40��6g   $	��240��6s   $��14(�6�   $	 0.9Q�6�   ��56      �� 57      $ 0.5,1&�6&   $ 0.5,0&�67   .��58      � $ Black��6#   $ 0Q�61   � 59      $ White��6#   $ 1Q�61   5:      5<      &   System.Windows.Controls.DataGrid  5=   
   -   5          Name$ gridWorkers��5=         AutoGenerateColumns .  $
��Left=�6t   $	��237��6�   $��
412,26,0,0q�6�   $	��Top=�6�   $	��350��6�   #��� ��6�      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      -   5        id_pracownikaColumn��,  &System.Windows.Controls.DataGridColumn   Header$ id��5?   Y      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6w   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Id+6w     5@      -	   5        
imieColumn��$
 imie��5@   R    . $ 80 6r    69   �� *imie+6r     5A      -
   5        nazwiskoColumn��$ nazwisko��5A   Z    . $	 100 6~    6=   �� *
nazwisko+6~   5D      5F      5G      