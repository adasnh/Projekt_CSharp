   M S B A M L   `   `   `  ����E  AWpfProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProjekt
WpfProjekt  5   	       WpfProjekt.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfProjekt     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Magazyn Dna��5	   	   $	��600��6   $	��400��6*    � WindowStartupLocation$ CenterScreen=�66   .��5
      � -   5         � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   �� 5      $��0* �6   ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ DarkGoldenrod��6    � Offset$	 0.7Q�65   � 5      $ Black��6   $ 0Q�6-   5      .+�5   
   �� -   5        $	��540��5      $	��Top=�6    �� CornerRadius$ 0 180 0 180��66   ���#0000006f   �� 5   
    �� Orientation$ Vertical=�6   .+�5      �� $	��350��6   .+�5      �� $��Assets/Dna_logo_male.png��6   $	��200��6:   $	��150��6F   $��Uniform=�6S   5      �� 5      $��20 40q�6   .+�5      �� $��Zaloguj się ��6   $��20q�60   
�������$��20(�6O   $��Comic Sans MS)�6]   	 �� TextAlignment$	 Center=�6x   6�   �� 5      $ 
Horizontal=�6   $��10q�66   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$

 User=�6.   $��25��6:   $��25��6E   
�������6Q   �� 5      -   5         ��Name$ txtUserName��5      $
��10 0q�63   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Podaj nazwe użytkownika��6A   
�������$	��250��6�   
������� �� 
CaretBrush
 ���� �� SelectionBrush
 ����6�   5       �� 5!      $ 
Horizontal=�6   $��10q�66   .+�5"        $

 Lock=�6.   $��25��6:   $��25��6E   
�������6Q   G� 5#      -   5         G�Name$ txtPassword��5#   "   $
��10 0q�67   $ Podaj hasło��6E   
�������$	��250��6�   
������� G� 
CaretBrush
 ���� G� SelectionBrush
 ����6�   5$      �� 5%      $��10q�6   $��Center=�6)   .+�5&      �� -   5         ��Name$ btnLogin��5(   �   $	��100��5&      $��40��6)      MaterialDesignRaisedButton#��[  65   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5(      $��2q�6G   
�������
������
������� � ToolTip$ Zaloguj��6�   $��Zaloguj��6�   5*      5,      5.      �� 5/      $	��100��6   .+�50      �� -   5        $ btnExit��51   %   $��10 20q�50       & "MaterialDesignFloatingActionButton#��[ 6(   $ Close��51      ��50   d   Z� .��52        $
 Close=�6.   
�������$��30��6N   $��30��6Y   54      55      56      57      58      