   M S B A M L   `   `   `  ����G  CFileCombiner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FileCombinerFileCombiner  5   	   =#clr-namespace:FileCombiner.ControlsFileCombiner.Controls  5   	       FileCombiner.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FileCombiner     5   	   1c#clr-namespace:FileCombiner.Controls     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��5* �6   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��10* �6   �� 5      $��* �6   .+�5   
   �� $
��Name��6   $��Normal$�6    
���   �$��16(�6F   $��1��6T   $��Center=�6d   $
��Left=�6   �� 5   
   $��Date Modified��6   $��Normal$�6)   
���   �$��16(�6O   $��2��6]   $��Center=�6m   $
��Left=�6�   �� 5   
   $
��Size��6   $��Normal$�6    
���   �$��16(�6F   $��3��6T   $��Center=�6d   $
��Left=�6   �� 5   
   -   5         ��Name$ dropArea��5      
�������$��1��66   $��3��6F   $��1��6Z   $
��Auto��6g   $
��Auto��6u    J� 	AllowDrop . ._�5      �� -   5         ��Name$ listView��5      $��Stretch=�6G   $��Disabled=�6l   ��6)   �� *Files+��5      �� 5       �� 
TargetType" ��6   .�5       ��  �� Property �@J�	AllowDrop �� Value . 66   -   5        5#      ��5%      �� 5&      .R�5'      +   %FileCombiner.Controls.ListItemControl  5(      53      54      55      56      