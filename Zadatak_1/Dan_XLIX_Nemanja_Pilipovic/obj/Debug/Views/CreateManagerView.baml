   M S B A M L   `   `   `  ����U  QDan_XLIX_Nemanja_Pilipovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Dan_XLIX_Nemanja_Pilipovic.Views Dan_XLIX_Nemanja_Pilipovic.Views  5   	   8    2Dan_XLIX_Nemanja_Pilipovic.Views.CreateManagerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Dan_XLIX_Nemanja_Pilipovic.Views     5   	     � Title$  Create Manager��5   	   $	��550��6    $	��300��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      $
��auto �6   �� 5'      $��20 �6   .+�5*   
   �� $��1��6   $��1��6$   $��Name:��61   �� 5+   
   -   5        $��1��5+      $��2��6"    �� 	MaxLength$ 20��5,   =   ��5+   /   �� *Manager.Name+ �� UpdateSourceTrigger$ PropertyChanged=�5,   =   �� 5.   
   $��1��6   $��3��6$   $��Surname:��61   $��0,10,0,0q�6A   �� 5/   
   -   5        $��1��5/      $��4��6"   $ 50��50   =   ��5/   /   �� *Manager.Surname+$ PropertyChanged=�50   =   �� 52   
   $��1��6   $��5��6$   $��Date of Birth:��61   $��0,10,0,0q�6G   (  "System.Windows.Controls.DatePicker  53   
   $��1��6   $��6��6%      SelectedDate 62   �� *Manager.DateOfBirth+�� 55   
   $��1��6   $��7��6$   $��Mail:��61   $��0,10,0,0q�6>   �� 56   
   -   5        $��1��56      $��8��6"   $ 30��57   4   ��56   /   �� *Manager.Mail+$ PropertyChanged=�57   4   �� 59   
   $��1��6   $��9��6$   $��Usrname:��61   $��0,10,0,0q�6A   �� 5:   
   -   5        $��1��5:      $��10��6"   $ 20��5;   =   ��5:   0   �� *Manager.Username+$ PropertyChanged=�5;   =   �� 5=   
   $��1��6   $��11��6$   $��	Password:��62   $��0,10,0,0q�6C   �� 5>   
   -   5        $��1��5>      $��12��6"   $	 100��5?   F   ��5>   0   �� *Manager.HashedPassword+$ PropertyChanged=�5?   F   �� 5B   
   $��1��6   $��13��6$   $��Hotel Level:��62   $��0,10,0,0q�6F   �� 5C   
   -   5        $��1��5C      $��14��6"   ��60   �� *Manager.HotelLevel+$ PropertyChanged=�5D      �� 5F   
   $��1��6   $��15��6$   $��Working Experience:��62   $��0,10,0,0q�6M   �� 5G   
   -   5        $��1��5G      $��16��6"   ��60   �� *Manager.YearsOfExperience+$ PropertyChanged=�5H      �� 5J   
   $��1��6   $��17��6$   $��Qualification Level:��62   $��0,10,0,0q�6N   �� 5K   
   -   5        $��1��5K      $��18��6"   $ 1��5L   >   ��5K   0   �� *Manager.QualificationLevel+$ PropertyChanged=�5L   >   �� 5O   
   -	   5        $��btnSave��5O   /   $��1��6   $��19��6!   $��Add Manager��6>   $��20��6T   $	��100��6`   $
��Left=�6l   $��0,10,0,0q�5P   O   ��6   �� *Save+$ PropertyChanged=�6O   �� 5S   
   -
   5        $��btnClose��5S   /   $��2��6   $��19��6!   $��Close��6?   $��20��6O   $	��100��6[   $��Right=�6g   $��0,10,0,0q�5T   P   ��6   �� *Close+$ PropertyChanged=�6P   5V      5W      