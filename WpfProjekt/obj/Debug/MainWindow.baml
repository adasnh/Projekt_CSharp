   M S B A M L   `   `   `  ����E  AWpfProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfProjekt
WpfProjekt  5   	       WpfProjekt.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfProjekt     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Jlocal19http://schemas.microsoft.com/netfx/2009/xaml/presentation    6R     � Title$  Magazyn Dna��5	   	   $��732.777��6   $
��1080��6.   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��165* �6   �� 5      $
��104* �6   ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.2,1&�65   .��5      �  � Color$ DarkGoldenrod��6    � Offset$	 0.9Q�65   � 5      $ Black��6   $ 0Q�6-   5      .+�5   
   �� -   5        $	��600��5      $	��Top=�6    �� CornerRadius$ 0 180 0 180��66   ���#000000$��2��6�   $��0,0,-0.445,0q�6�   �� 5   
   -   5         $   MaterialDesignFlatAccentBgButton#��[  5      $��Dodaj/Usuń pracownika��6L   $
��Left=�6l   $	��Top=�6�   $	��300��6�   ���	#FF9E871C���	#FFE8E4DB$��40��6�   $��1q�6�   $��24(�6�   $��206,165,0,0q�6  6  �� 5   
   -   5        #��[  5      $��Dodaj artykuł��6L   $
��Left=�6d   $	��Top=�6�   $	��300��6�   ���	#FF8C8C8C���	#FFE8E4DB$��40��6�   $��1q�6�   $��24(�6�   $��642,165,0,0q�6   $��2��6%  �� 5   
   -   5        #��[  5      $��Wydaj artykuł��6L   $
��Left=�6d   $	��Top=�6�   $	��300��6�   ���	#FF8C8C8C���	#FFE8E4DB$��40��6�   $��1q�6�   $��24(�6�   $��206,401,0,0q�6   6  �� 5   
   $��	10,10,0,0q�6   $��Assets/Dna_logo_male.png��6#   $	��200��6E   $	��100��6Q   $	��Top=�6^   $
��Left=�6v   $
��Fill=�6�   �� 5   
   -   5        #��[  5      $��O mnie��6L   $
��Left=�6]   $	��Top=�6y   $	��300��6�   
�������
���   �$��40��6�   $��1q�6�   $��24(�6�   $��642,401,0,0q�6�   $��2��6  �� 5   
   -   5         ��Name$ btnExit��5    %   $��353.406,10,9.555,626.889q�5       & "MaterialDesignFloatingActionButton#��[ 64    � ToolTip$ Close��5       	 J� RenderTransformOrigin$	 7.003,0.218&�6L   $
��Auto��6p   $��1��6}   ��5   p   Z� .��5!      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Close=�6&   
�������$��30��6F   $��30��6Q   5#      �� 5$   
   -   5        $ btnExit_Copy��5%      $��353.406,10,9.555,626.889q�5$      #��[ 64   $ Close��5%      $	 7.003,0.218&�6I   $
��Auto��6m   $��1��6z   ��5$   p   Z� .��5&        $
 Close=�6&   
�������$��30��6F   $��30��6Q   5(      5*      5,      