   M S B A M L   `   `   `  ����L  HACT7CoursLevriers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ACT7CoursLevriersACT7CoursLevriers  5   	   "    ACT7CoursLevriers.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ACT7CoursLevriers     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��850��6)   .��5	      � -   5        $��gridMain��5	       � RowDefinitions 5
   
   �� 5      $	��271 �6   6+   �� 5      $	��431 �6   6+   .+�5   
   �� -   5         ��Name$ piste��5      $��0��6    $	��850��6.   $	��271��6:   .+�5      �� $��/assets/racetrack.png��6   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#    5      �� 5      $��2* �6    �� 5      $��1* �6    .+�5   
   �� $��Salle des paris��6   
���   �$��18(�6>   �� 5   
   $��0��6   .+�5      �� $��Pari minimum : 5 écus��6   
���   �$
��Bold"�6L   $��24(�6^    �� Padding$ 20q�6l   	� 5      -   5         	�Name$ radioButtonParieur1��5       	� 	GroupName$ parieurActuel��6;   $��Joe possède 50 écus��6U   $��20(�6s   $��8q�6�   	� 5       -   5        $ radioButtonParieur2��5       $ parieurActuel��6;   $��Bob possède 50 écus��6U   $��20(�6s   $��8q�6�   	� 5!      -   5        $ radioButtonParieur3��5!      $ parieurActuel��6;   $��Bill possède 50 écus��6U   $��20(�6t   $��8q�6�   5"      �� 5#      $��1��6   .+�5$      �� $�� ��6   
���   �$��18(�67   �� 5%      $��Paris��6   
���   �$
��Bold"�6<   $��24(�5&      �� 5(      -   5         ��Name$ textBlockParieur1��5(      $��Joe n'a pas encore parié��68   $��20(�6X   $��10q�6f   �� 5)      -   5        $ textBlockParieur2��5)      $��Bob n'a pas encore parié��67   $��20(�6W   $��10q�6e   �� 5*      -   5        $ textBlockParieur3��5*      $ ��Bill n'a pas encore parié��67   $��20(�6X   $��10q�6f   5+      �� 5,      $��2��6   $��2��6&   .+�5-      ��  �� Orientation$ 
Horizontal=�6   .+�5.      �� -	   5        $ textBlockParieurActuel��5.       $��20(�6@   $��ParieurX��6N   $��30��6_   $��10q�6k   �� 5/      -
   5        	 ��Name$	 btnParie��5/      $��Parier��6/   $��20(�6@   $��30��6N   $��10q�6Z   6f   �� 50      -   5        
 ��Name$
 textBoxEcusPari��50      $��30��67    �� TextAlignment$ Center=�6E   $��5��6\   $��20(�6e   $
��Bold"�6s   
���   �$��30��6�   $��10q�6�   �� 51      $ ��écus sur le chien numéro��6    $��20(�6@   $��30��6N   $��10q�6Z   �� 52      -   5        $
 textBoxNumeroChienPari��52      $��30��6>   $ Center=�6L   $�� ��6c   $��20(�6k   $
��Bold"�6y   
���   �$��30��6�   $��10q�6�   �� 53      -   5        $	 buttonLancerCourse��53      $��Lancer la course !��69   $��5,0,5,0q�6V   $��20(�6h   $��10,0,0,0q�6v   54      �� 55      $��2��6   $��2��6+   .+�56      �� -   5        $	 buttonReset��56      $��10,10,10,10q�62   $��Remettre à zéro��6G   $��20(�6a   57      58      59      5:      5;      