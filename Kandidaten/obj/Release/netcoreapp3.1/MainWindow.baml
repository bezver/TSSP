   M S B A M L   `   `   `  ���� E  AKandidaten, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Kandidaten
Kandidaten      Kandidaten.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Kandidaten     -     �Name$  InfoKandidatenForm�� � Title$ 
Kandidaten��$	��450��$	��400�� � Icon$ 	/icon.png��.��� .+�o� -   $��MainMenu��$
��Left=�$	��Top=�$	��800��$��1q���Z� .@�m� $��Файл��.@�m� -   $��Завантажити��m� -   $��Зберегти��m� $��Абітурієнти��.@�m� -   $��Додати��m� -   $��Видалити��m� $��
Пошук��.@�m� -   $L��FПошук абітурієнтів за прохідним балом��m� -   $X��RПошук абітурієнтів за заданим балом і школою��m� -	   $��Авторизація��&   System.Windows.Controls.DataGrid  -
     Name$ EntrantsListSet��$��Center=�$��0,25,0,0q�$	��Top=�   AutoGenerateColumns$ False��   
IsReadOnly$
 True������    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Прізвище��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *
secondName+  $ Ім'я��$
 Auto 	 �� *	firstName+  $ Середній бал��$
 Auto 	 �� *averageMark+  $ Номер школи��$
 Auto 	 �� *school+