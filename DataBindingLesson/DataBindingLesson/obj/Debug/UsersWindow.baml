   M S B A M L   `   `   `  ����L  HDataBindingLesson, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DataBindingLessonDataBindingLesson  5   	   #    DataBindingLesson.UsersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DataBindingLesson     5   	     � Title$  UsersWindow��5   	   $	��300��6   $	��300��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��	usersGrid��5
         AutoGenerateColumns .  $
��Left=�6@   $	��220��6[   $	��Top=�6h   $	��292��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Id�6Z     5      $ 
Логин��6D   $	 50* 6S    6%   �� $ Login�6a     5      $ Пароль��6G   $	 50* 6W    6%   �� $ Password�6e   5      �� 5   
   $��Login��6   $
��Left=�6    $��
10,229,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $��loginTextBox��5      $
��Left=�6&   $��23��6A   $��
60,233,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   �� *SelectedItem.Name+ �� ElementName$ 	usersGrid��6�   �� 5   
   -   5        $��changeButton��5      $��Изменить��6@   $
��Left=�6S   $��200,233,0,0q�6n   $	��Top=�6�   $��75��6�   $��22��6�   5      5      