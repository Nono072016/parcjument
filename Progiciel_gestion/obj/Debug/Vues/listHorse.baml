   M S B A M L   `   `   `  ����  Progiciel_gestion&     Progiciel_gestion.Vues.listHorse   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	listHorse��5   	   $��614.752��6   $��580.827��6,   ���	#FFF9CD05.��5      � -   5         �Name$ dateNaissance��5      $	��583��6"   $	��Top=�6/    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5
   
   �� $
��Left=�6   $	��100��6+   $��	241,0,0,0q�68   $	��Top=�6K   $	��100��6c   $4��./Progiciel_gestion;component/Images/jument.png��6o   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
listJument��5      $
��Left=�6'   $��
20,100,0,0q�6B   $	��Top=�6V   $	��272��6n   $	��530��6{   $��1��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 20* 6B      Header$ Id��6N      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
IdJument+6Z     5      $	 40* 6C   $	 Nom��6O    .  6%   �� *	NomJument+6\     5      $	 40* 6D   $
 Race��6P    .  6%   �� *
RaceJument+6^     5      $	 30* 6v   $ Date de naissance��6�    .  6%   �� *DateNaissance+	 �� StringFormat$	 
dd/MM/yyyy��
 �� ConverterCulture$
 fr-FR��6�     5      $	 30* 6E   $ 	Poids(kg)��6Q    .  6%   �� *PoidsJument+6d   5      �� 5   
   -   5         ��Name$ lbJument��5      $��Label��6"   $
��Left=�62   $��267,392,0,0q�6M   $	��Top=�6b    J� RenderTransformOrigin$ -0.857,-0.562&�6z   $��1��6�   $��16��6�   $��28��6�   �� 5   
   -   5        $ lbNom��5      $��2��6   $	��Nom��63   $
��Left=�6A   $��
20,436,0,0q�6\   $	��Top=�6p   �� 5   
   -   5         ��Name$ txtNom��5      $��2��6"   $
��Left=�66   $��23��6Q   $��
78,436,0,0q�6]    �� TextWrapping$
 Wrap=�6q   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ lbRace��5      $��2��6    $
��Race��64   $
��Left=�6C   $��346,439,0,0q�6^   $	��Top=�6s   �� 5   
   -   5        $ txtRace��5      $��2��6#   $
��Left=�67   $��23��6R   $��405,436,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ lbPoids��5      $��2��6!   $��Poids��65   $
��Left=�6E   $��
20,497,0,0q�6`   $	��Top=�6t   �� 5   
   -	   5        $ txtPoids��5      $��2��6$   $
��Left=�68   $��23��6S   $��
78,498,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   $��2��6   $
��Left=�6)   $��401,497,0,0q�6D   $	��Top=�6Y   �� 5   
   -
   5        $ lbDate��5      $��2��6    $��Date de naissance��64   $
��Left=�6P   $��276,498,0,0q�6k   $	��Top=�6�   $ 0.607,-0.312&�6�   �� 5   
   -   5         ��Name$ btnModifier��5      $��2��6&   $��Modifier��6:   $
��Left=�6M   $��241,555,0,0q�6h   $	��Top=�6}   $��75��6�   6�   5       5!      