   M S B A M L   `   `   `  ����L  HDataBindingLesson, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DataBindingLessonDataBindingLesson  5   	   "    DataBindingLesson.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DataBindingLesson     5   	     � Title$  
UserWindow��5   	   $	��300��6   $	��300��6)   .��5	      � .+�5
   
   �� -   5        $��
loginLabel��5
      $��Login��6"   $
��Left=�62   $��10,7,0,0q�6M   $	��Top=�6_    J� RenderTransformOrigin$ -0.152,-0.359&�6w   �� 5   
   -   5        $��passwordLabel��5      $��Password��6%   $
��Left=�68   $��	10,38,0,0q�6S   $	��Top=�6f   �� 5   
   $
��Left=�6   $	��169��6/   $��0q�6<   $	��Top=�6G   $	��292��6_   $ 0.499,0.273&�6k   �� 5   
   -   5        $��loginTextBox��5      $
��Left=�6&   $��23��6A   $��	10,95,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   ��  �� ElementName$ 
loginLabel�� �� Path$ Content� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $��passwordTextBox��5      $
��Left=�6)   $��23��6D   $��
10,131,0,0q�6P   $
 Wrap=�6d   $	��Top=�6�   $	��120��6�   ��6x   �� $ passwordLabel��$ Content�$ PropertyChanged=�6�   5      5      