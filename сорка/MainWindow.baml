   M S B A M L   `   `   `  ���� B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3      WpfApp3.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp3       � Icon$  	/icon.ico�� � Title$, &ТЕСТЫ ПО ИНФОРМАТИКЕ��$	��800��$
��1000�� � WindowStartupLocation$ CenterScreen=�
���   � � 
ResizeMode$ NoResize=� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName��%7  '��       �� " ��.���  � �� �� " ��.R��� ._�� .+�� .+��� $	 border��$
 3,3,0,0�����#ffeced�� $��Header��#��z��#��z�� P�  �@J�IsMouseOver . . ��� $ border�� � �� �#f1b4b4P�  �@��
IsSelected . . ��� $ border�� � �� �#f1b4b4.���  � ColumnDefinitions �� $	��73* ��� $��0* ��� $��0* ��� $	��18* ��� $	��16* ��� $��6* ��� $
��887* �.+��� $��7��$
��Left=�$
��1000��4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ 	Offscreen=�   IsColumnHeader .    IsRequiredForForm .    IsRowHeader .  +� FocusedElement ��  �� ElementName$ StName������  �� ImageSource$ 	/fon2.PNG�� j� TileMode$
 Tile=� j� Stretch$ UniformToFill=�.+��� $,��&Фамилия Имя Отчество��$��15q�$
��Left=�$��30(�$
��Bold"����	#FFA8BFCF���	#FF283742�� -    ��Name$ StName��$��15,0, 100, 0q�$��30(� J� RenderTransformOrigin$ 0.367,0.519&�$��50���� $(��"Выберите ваш класс��$��15q�$
��Left=�$��30(�$
��Bold"����	#FFA5BFCF���	#FF283743�� -    ��Name$ Grade��$	��320��$
��Left=�$��15q�$��30(�$��50������  �� EndPoint$	 0,1&�.���  � Color$ 	#FFF0F0F0��� $ 	#FF273744�� � Offset$ 1Q�.@��� 5 класс�� 6 класс�� 7 класс�� 8 класс�� 9 класс�� $I��CВведите количество заданий (от 1 до 30)��$��15q�$
��Left=�$��30(�$
��Bold"����	#FFA5BFCF���	#FF283743$	��700��$��60���� -   $ Amount��$��15,0, 100, 0q�$	��130��$
��Left=� �� 	MaxLength$ 2��$��30(����	#FFDFDADA$��50���� -   $	��454��$	��140��$	��100q�$��
СТАРТ��$��50(�$��4q�$
��Bold"�
����������	#FF8D595B���� $ 0.5,1&�  �� 
StartPoint$  0.5,0&�.��� $ 	#FF717172��� $ 	#FF7A82CF��$ 1Q�