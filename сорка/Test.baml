   M S B A M L   `   `   `  ���� B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3      WpfApp3.Test   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp3       � Icon$  	/icon.png�� � Title$* $ТЕСТ ПО ИНФОРМАТИКЕ��$	��800��$
��1000�� � WindowStartupLocation$ CenterScreen=� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Triggers P� Property P� Value �� 
TargetName��%7  '��       �� " ��.���  � �� �� " ��.R��� ._�� .+�� .+��� $ border��$	 3,3,0,0�����#ffeced�� $��Header��#��z��#��z��
 P�  �@J�IsMouseOver . . ��� $ border�� � �� �#f1b4b4P�  �@��
IsSelected . . ��� $ border�� � �� �#f1b4b4.��� .+��� ����  �� ImageSource$ 	/fon2.PNG�� j� Stretch$ UniformToFill=� j� TileMode$ FlipXY=�.+��� -    ��Name$ Counter��$��30(�$��Center=����	#FFBDBDBD$
��Bold"�����  �� Color$ 	#FFBDBDBD�� �� Opacity$	 0.3Q��� -    ��Name$ QuestionTest��$	��300��$��15q�$��30(� �� TextWrapping$
 Wrap=����	#FF283742$
��Bold"�.������ $ 	#FFC0D6E5��$	 0.9Q�.���� $��Ваш ответ��$��30(�$��Center=����	#FFBDBDBD$
��Bold"��� -   $ 
AnswerText��$��30(�$	��210��$
��15,0q�$
 Wrap=����	#FF283742$
��Bold"�.������ $ 	#FFC0D6E5��$	 0.9Q�.���� -    ��Name$ ManyAnswers�� �� Orientation$ Vertical=�$
��Left=�$��
0,-200,0,0q�$	��200��$	��900��$y�Hidden=����� $ 	#FFC0D6E5��$	 0.9Q�.+��� -    ��Name$	 ch1��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"����� $ 	#FFC0D6E5��$	 0.9Q� � LayoutTransform ��  �� ScaleX$	 2.5Q� �� ScaleY$	 2.5Q��� -   $	 ch2��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"����� $ 	#FFC0D6E5��$	 0.9Q� �� $	 2.5Q�$	 2.5Q��� -   $	 ch3��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"����� $ 	#FFC0D6E5��$	 0.9Q� �� $	 2.5Q�$	 2.5Q��� -   $	 ch4��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"����� $ 	#FFC0D6E5��$	 0.9Q� �� $	 2.5Q�$	 2.5Q��� -	   $ 	OneAnswer��$ Vertical=�$
��Left=�$��
0,-200,0,0q�$	��200��$	��900��$y�Hidden=����� $ 	#FFC0D6E5��$	 0.9Q�.+�	� -
    	�Name$	 rb1��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"� �� $	 2.5Q�$	 2.5Q�	� -   $	 rb2��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"� �� $	 2.5Q�$	 2.5Q�	� -   $	 rb3��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"� �� $	 2.5Q�$	 2.5Q�	� -   $	 rb4��$��10(�$�� ��$
��20,5q�$	��350�����	#FF283742$
��Bold"� �� $	 2.5Q�$	 2.5Q��� -    ��Name$
 next�����	#FF8D595B$	��200��$��60��$��0, 20, 15, 0q�$��30(����	#FF583939$��4q�$��Right=����	#FFCCC0C0$
��Bold"�