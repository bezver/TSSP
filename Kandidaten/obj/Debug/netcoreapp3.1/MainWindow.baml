   M S B A M L   `   `   `  ����E  AKandidaten, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Kandidaten
Kandidaten  5   	       Kandidaten.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Kandidaten     5   	   -   5          �Name$  InfoKandidatenForm��5   	    � Title$ 
Kandidaten��5   	   $	��450��6   $	��400��6)    � Icon$ 	/icon.png��6X   .��5	      � .+�5
   
   o� -   5        $��MainMenu��5
      $
��Left=�6   $	��Top=�6:   $	��800��6R   $��1q�6^   ��6r   Z� .@�5      m� $��Файл��6   .@�5      m� -   5        $��Завантажити��5      60   m� 5      -   5        $��Зберегти��5      6-   5      m� 5      $��Абітурієнти��6   .@�5      m� -   5        $��Додати��5      6+   m� 5      -   5        $��Видалити��5      6-   5      m� 5      $��
Пошук��6   .@�5      m� -   5        $L��FПошук абітурієнтів за прохідним балом��5      6J   m� 5      -   5        $X��RПошук абітурієнтів за заданим балом і школою��5      6Q   5      m� 5      -	   5        $��Авторизація��5      6,   5      &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ EntrantsListSet��5      $��Center=�6,   $��0,25,0,0q�6I   $	��Top=�5         AutoGenerateColumns$ False��6+      
IsReadOnly$
 True��6_   ��6G   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Прізвище��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6Z   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *
secondName+6Z     5      $ Ім'я��6%   $
 Auto 6U   	 65   �� *	firstName+6U     5      $ Середній бал��6%   $
 Auto 6_   	 6=   �� *averageMark+6_     5      $ Номер школи��6%   $
 Auto 6Y   	 6<   �� *school+6Y   5!      5"      5#      