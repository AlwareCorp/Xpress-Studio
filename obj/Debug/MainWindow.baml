   M S B A M L   `   `   `  ����@  <uxdev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Xpress.Core.UltimateXpress.Core.Ultimate  5   	   %    Xpress.Core.Ultimate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Xpress.Core.Ultimate     5   	   -   5          � Title$  ALSD Xpress Studio��5   	   $	��650��6$   $
��1150��61    � WindowStartupLocation$ CenterOwner=�6|    � AllowsTransparency .  � WindowStyle$
 None=�6�   $
��1150��6�   $	��650��6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CaptionHeight$ 34Q�6    � 	Resources 5         CaptionButtonStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType �Name ��Name �� ClearTypeHint&   System.Windows.Media.TextOptions   TextRenderingMode   TextFormattingMode �� Triggers P� Property P� Value �� 
TargetName  CaptionStyleButtonAll  MinimizeButtonStyle �� BasedOn  MaximizeButtonStyle  RestoreButtonStyle  CloseButtonStyle  
AllButtons�� 5   
   %�  &	        &	 ?    &	     7   &	 U    7   &	 �    7   &	 �    7   &	 ?    7  �� 5      " ��6/   .�5      ��  � ��	 5      �� 5      "
 ��6*   .R�5      � $ 
LayoutRoot��6#   
������ $��44��6P   $��30��6[   .+�5   "   �� $	 txt��6,   #��z��69   $��Segoe MDL2 Assets)�6Z   $��10(�6y   
�������$��Center=�5   7   $��Center=�6T   $
 Auto=�5   $   $ Aliased=�6G   $ Display=�6p   5       5      P� 5   "    �@J�IsMouseOver . . �5   &   �� $ 
LayoutRoot��6-    � ��
	 ��iA�6[   �� 5   &   $	 txt��6-    � ��
	 �����6T   5   #   5!      5#      5$      �� 5&      " ��62   .�5'      ��  � ��	 5(      �� 5)      "
 ��6*   .R�5*      � $ 
LayoutRoot��6#   
������ $	��250��6P   $��35��6\   .+�5+   "   �� $	 txt��6,   #��z��69   $��Segoe UI)�6Z   $��14(�6p   
�������$��Center=�5,   7   $��Center=�6T   5-       5.      P� 5/   "    �@J�IsMouseOver . . �50   &   �� $ 
LayoutRoot��6-    � ��
	 ��iA�6[   51   #   53      55      56      �� 59      " ��60   8   .�5:      ��  � ��$		 ��6,   5;      �� 5>      " ��60   8   .�5?      ��  � ��$		 ��6,   5@      �� 5C      " ��6/   8   .�5D      ��  � ��$		 ��6,   5E      �� 5H      " ��6-   8   .�5I      ��  � ��$		 ��6,   5J      �� 5M      " ��6'   8   .�5N      ��  � ��$	 Segoe UI)�6/   5O      5Q       J� CommandBindings 5U      )  #System.Windows.Input.CommandBinding  5V   
   -   5        #  System.Windows.SystemCommands   CloseWindowCommand   Command# Z 5V      6w     5W   
   -   5           MaximizeWindowCommand# Z 5W      6z     5X   
   -   5           MinimizeWindowCommand# Z 5X      6z     5Y   
   -   5           RestoreWindowCommand# Z 5Y      6y   .��5\      �� -   5         ��Name$ MainWindowBorder��5\      
����iA�$��1q�6?   ._�5]   
   � -   5        $ parentContainer��5]      ���	#FF181818 � RowDefinitions 5_      �� 5`      $
��Auto �6    �� 5a      $��* �6    .+�5e      � $��0��6   $��30��6    .+�5f      ��  �� Orientation$ 
Horizontal=�6   $��center=�66   $��Center=�6S   .+�5h      �� -   5        $ 
WindowName��5h       $��ALSD Xpress Studio��64   $��Arial)�6N   
�������$��4 3 0 0q�6t   5i      �� 5l      $ 
Horizontal=�6   $��Right=�66   .+�5m      �� #��[ 6      IsHitTestVisibleInChrome .  � ToolTip$ Minimize��6w   #��Z 5n      ��.  6W   �� 5o      -	   5          ��Name$  RestoreButton��5o      $y�	Collapsed=�64   #��[ 6K   #��Z 5p       . $ Restore��6�   ��.  6�   �� 5q      -
   5        $  MaximizeButton��5q      $y�Visible=�65   #��[ 6J   #��Z 5r       . $ Maximize��6�   �� 5s      -   5        $  CloseButton��5s      $y�Visible=�62   #��[ 6G    . $ Close��6�   #��Z 5t      
���������.  6g   5u      5v      � 5y      -   5        $ ToolsBar��5y      $��30��6%   $��1��61   $	��Top=�6>   .+�5z      �� -   5        ! ��Name$! Settings��5z      $��Right=�6/   $��30��6K   $��
1108,0,0,0q�6W   $��1��6k   $	��Top=�6x   $��40��6�   .+�5{      �� $
��Wrap=�6    $��Segoe MDL2 Assets)�64   $��22(�6S   
�������$��Center=�6t   $��22��6�   $	��9,4q�6�   �� 6�   $	���6�   6�   5|      5}      � 5~      -   5        $ AppArea��5~       $��1��6   $��	40,30,0,0q�61   .+�5       � -   5        "  �Name$" NavPage��5      #  � NavigationUIVisibility$# Hidden=�6)   
������ $��0,0,0,0q�6b   $  � Source$'$ !/uxdev;component/StartupPage.xaml?�6s   $�� ��6�   �� 5�      -   5        $! settingsPanel��5�      ���	#FF181818$��Right=�6K   $	��Top=�6g   $	��471��6   $	��250��6�   $��0,-1,0,0q�6�   $y�Hidden=�6�   .+�5�      �� -   5        $  NewWin��5�      #��[ 6-   $��
New Window��6Q   ���	#00DDDDDD���	#00000000
�������$��35��6�   $��0q�6�   �� 5�      
���iii�$��1��66   $	��250��6A   �� 5�      -   5        $  NewProj��5�      #��[ 6.   $��New Project��6R   ���	#00DDDDDD���	#00000000
�������$��35��6�   $��0q�6�   �� 5�      -   5        $  OpenProj��5�      #��[ 6/   $��Open Project��6S   ���	#00DDDDDD���	#00000000
�������$��35��6�   $��0q�6�   5�      5�      � 5�      -   5        $ HorizontalTabs��5�      $
��Left=�6+   $��1��6F   $��Stretch=�6S   $��40��6o   .+�5�      �� -   5        $! TabPage0��5�      $
��Left=�6/   $��30��6J   $��4,35,0,0q�6V   $	��Top=�6h   $��30��6�   ���	#00000000.+�5�      �� $��30��6   $
��Left=�6)   $	��Top=�6D   5�      5�      5�      5�      5�      