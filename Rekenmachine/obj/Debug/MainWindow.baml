   M S B A M L   `   `   `  ����G  CRekenmachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RekenmachineRekenmachine  5   	       Rekenmachine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Rekenmachine     5   	     � Title$  
Calculator��5   	   $	��430��6   $	��280��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ button7��5      $��2��6"   $��0��6/   .��6?   76B   �� 5   
   -   5        $ button8��5      $��2��6"   $��1��6/   .��6?   86B   �� 5   
   -   5        $ button9��5      $��2��6"   $��2��6/   .��6?   96B   �� 5   
   -   5        $ button4��5      $��3��6"   $��0��6/   .��6?   46B   �� 5   
   -   5        $ button5��5      $��3��6"   $��1��6/   .��6?   56B   �� 5    
   -   5        $ button6��5       $��3��6"   $��2��6/   .��6?   66B   �� 5!   
   -   5        $ button1��5!      $��4��6"   $��0��6/   .��6?   16B   �� 5"   
   -   5        $ button2��5"      $��4��6"   $��1��6/   .��6?   26B   �� 5#   
   -	   5        $ button3��5#      $��4��6"   $��2��6/   .��6?   36B   �� 5$   
   -
   5        $ button0��5$      $��5��6"   $��1��6/   .��6?   06B   �� 5'   
   -   5        $ 
buttonPlus��5'      $��1��6%   $��3��62   .��6B   +6E   �� 5(   
   -   5        $ buttonMinus��5(      $��2��6&   $��3��63   .��6C   -6F   �� 5)   
   -   5        $ buttonTimes��5)      $��3��6&   $��3��63   .��6C   *6F   �� 5*   
   -   5        $ buttonDivide��5*      $��4��6'   $��3��64   .��6D   /6G   �� 5+   
   -   5        $ buttonEquals��5+      $��5��6'   $��3��64   .��6_   =6b   �� 5.   
   -   5        $ buttonClearEntry��5.      $��1��6+   $��0��68   .��6g   CE6k   �� 5/   
   -   5        $ buttonClear��5/      $��1��6&   $��1��63   .��6]   C6`   �� 53   
   -   5        $ buttonPercentage��53      $��5��6+   $��2��68   .��6g   %6j   �� 56   
   -   5        $ buttonPositiveNegative��56      $��1��61   $��2��6>   .��6s   +-6w   �� 57   
   -   5        $ 	buttonDot��57      $��5��6$   $��0��61   $��1��6Y   $��0q�6m   .��6x   ,6{   �� 5:   
   -   5         ��Name$ textDisplay��5:       �� 
IsReadOnly .  �� TextAlignment$ Right=�69   $��Bottom=�6O   $��30(�6q   $��0q�6   $��0��6�   $��0��6�   $��4��6�   6�   5;      5<      