   M S B A M L   `   `   `  ����P  LHealthNotificationWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HealthNotificationWpfHealthNotificationWpf  5   	   ,    &HealthNotificationWpf.NotificationForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	   /local#clr-namespace:HealthNotificationWpf  5   	   -   5          � Title$  NotificationForm��5	   	   $	��200��6"   $	��500��6/    � AllowsTransparency$
 True��6Q    � WindowStyle$
 None=�6k   ��6;   Z� .��5
      � $	��200��6   $	��500��6   .+�5   
   �� -   5         ��Name$ txtNotificationForm��5   P    �� Padding$ 18,18,18,40q�6,    J� Opacity$	 100Q�6B   $��Bottom=�6m   $��Right=�6�   $
��Wrap=�6�    �� TextAlignment$
 Left=�6�   $��14(�6�   
���   �$��
0,0,194,38q�6�   $	��152��6  $	��296��6  $��	TextBlock��6  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FF003EFF��6#   � 5      $	 White��6#   � 5      $	 	#FF171717��6#   � 5      $	 	#FFFFD0A8��6#   � 5      $	 	#FFFFE3CB��6#   
 � Offset$
 0.984Q�65   5      5   &   �� 5   
   -   5        $ txtNotificationFormUrl��5      $y�Hidden=�64   $
��Left=�6H   $��16��6c   $��	0,154,0,0q�6o   $ Center=�6�   $
��Wrap=�6�   $��	TextBlock��6�   $	��Top=�6�   $	��138��6�   
�������6�   �� 5   
   -   5         ��Name$ 	VixieFace��5   *   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ /Resources/Vixie_3.gif��6=      RepeatBehavior$ Forever��6w   $��Center=�6�   $��0��6�   $��
311,15,0,0q�6�   $��Center=�6�   $��0��6�   �� 5   
   -   5        $
 Exit��5   J   $
��Left=�6y   $��20��6�   $��
474,15,0,0q�6�   $	��Top=�6�   $��20��6�   $��/Resources/ExitIcon.ico��6�   �� 5   
   -   5        $ 0Q�5   (   $��20,121,307,51q�6L   
���   ���6c   Z� ��6�   Z� .��6�   Click for more Information...5      �� 5   
   -   5        $��Vixie Health App��5   &   $ 0Q�6A   $
��Left=�6M   $��10,9,0,0q�6h   $	��Top=�6z   $��10(�6�   5      5      