   M S B A M L   `   `   `  ����P  LUAA14WPF_Entrainement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UAA14WPF_EntrainementUAA14WPF_Entrainement  5   	   &     UAA14WPF_Entrainement.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:UAA14WPF_Entrainement     5   	   -   5          �Name$  grdMain��5   4    � Title$ 
MainWindow��5   	   $
��1000��6   $
��1200��6*   .��5	      � -   5         �Name$ grdMainn��5	      ���#EBD9B4 � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��8* �6   �� 5      .+�5   
   �� $*��$VERIFIONS VOS CONNAISSANCES EN WPF !��6   $
��Bold"�6@   $��34(�6R   ���#638889$��0��6u   $��0��6�   $��2��6�   6�   �� 5   
   $��2��6   $��1��6%   ���#9DBC98.+�5      �� $��	10,0,10,0q�6   $��Paramétrage��6*   $��22(�6?   $
��Bold"�6M   .��5      �� .+�5      �� $��
10,10,10,0q�6   $��Choix de la disposition��63   $��22(�6T   $
��Bold"�6b   .��5      �� $��
10,10,10,0q�6%   .+�5      	� -   5         	�Name$ rdbtnSolitaire��5   *   $��	Solitaire��6B   	� 5      -   5        $ rdbtnMarelle��5   *   $��Marelle��6@   	� 5      -   5        $ rdbtnBandeLaterale��5   *   $��Une Bande Latérale��6F   5      5      �� 5      $��10,10,10,10q�6   $��Taille du plateau��64   .��5      �� .+�5       ��  �� Orientation$ 
Horizontal=�6)   .+�5!   "   �� $��Nbre de Lignes��6,   $��22(�6B   �� 5"   "   -   5         ��Name$ nbLignesBox��5"   *   $��30��6?   5#      �� 5$      $ 
Horizontal=�6)   .+�5%   "   �� $��Nbre de Clonnes��6,   �� 5&   "   -   5        $ nbColonnesBox��5&   *   $��30��6A   5'      5(      5)      5*      5+      �� 5,      -   5         ��Name$ 
btnValider��5,      $��Valider��6)   $��20(�6;   $
��Bold"�6I   $
��0,50q�6[   $	��400��6i   $��50��6u   5-      �� 5.   
   $��Text WPF 6T 2024��6   $
��Bold"�6,   
���  ��	 �� TextAlignment$	 Center=�6O   $
��0,20q�6f   $��30(�6t   $��2��6�   $��0��6�   $��2��6�   5/      50      