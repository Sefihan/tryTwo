   M S B A M L   `   `   `  ����J  FPracticLachinov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PracticLachinov.PagesPracticLachinov.Pages  5      #    PracticLachinov.Pages.PageAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:PracticLachinov.Pages     5        N� Title$  PageAdd��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5      �� $��Название��6      	MainLabel#��[  6'   �� 5      -   5        $��tbTitle��5      5      �� 5   
   $��0��6   $��1��6"   $ 
Horizontal=�62   .+�5       �� $��Тип��6   #��[  6"   �� 5!      -   5        $��cbType��5!       �� DisplayMemberPath$ Title��6%   5"      �� 5$   
   $��1��6   $��0��6"   $ 
Horizontal=�62   .+�5%      �� $��Артикул��6   #��[  6&   �� 5&      -   5        $��	tbArticle��5&      5'      �� 5)   
   $��1��6   $��1��6"   $ 
Horizontal=�62   .+�5*      �� $��Описание��6   #��[  6'   �� 5+      -   5        $��tbDescription��5+      5,      �� 5.   
   $��2��6   $��0��6"   $ 
Horizontal=�62   .+�5/      �� $��Чел-к на пр-во��6   #��[  6-   �� 50      -   5        $��tbPersonCount��50      51      �� 53   
   $��2��6   $��1��6"   $ 
Horizontal=�62   .+�54      �� $��Раб номер��6   #��[  6(   �� 55      -   5        $��tbWorkNumber��55      56      �� 58   
   $��3��6   $��0��6"   $ 
Horizontal=�62   .+�59      �� $��Мин стоимость��6   #��[  6,   �� 5:      -   5        $��	tbMinCost��5:      5;      �� 5=   
   $��4��6   $��0��6"   $ 
Horizontal=�62   .+�5>      �� -   5        $��
btnBackAdd��5>   %   $��
Назад��6   $��5q�67   6B   5?      �� 5A   
   $��4��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   .+�5B      �� -	   5        $��btnBackSave��5B   )   $��Сохранить��6   $��5q�6<   6G   5C      5D      5E      