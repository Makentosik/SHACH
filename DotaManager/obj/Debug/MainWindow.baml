   M S B A M L   `   `   `  ����F  BDotaManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DotaManagerDotaManager  5   	       DotaManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DotaManager     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
�������.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��130 �6   �� 5      $	��400 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��Dota 2 Manger��6   $��3��6(   $��Center=�6<   $��Center=�6W   $��50(�6t   �� 5   
   $&�� Найти игрока по ID:��6   $��0��6.   $��1��6>   $��12(�6K   $��Center=�6Y   $��Center=�6v   �� 5   
   -   5         ��Name$ PlayerID_textBox��5      $��1��6,   $��1��69   $��30��6I   �� 5   
   -   5        $��Найти игрока��5      $��1��6(   $��2��65   6E   �� 5   
   $"��Найти матч по ID:��6   $��0��6,   $��2��6<   $��12(�6I   $��Center=�6W   $��Center=�6t   �� 5   
   -   5        $ MatchID_textBox��5      $��2��6+   $��1��68   $��30��6H   �� 5   
   -   5        $��Найти матч��5      $��2��6&   $��2��63   6C   5      5      