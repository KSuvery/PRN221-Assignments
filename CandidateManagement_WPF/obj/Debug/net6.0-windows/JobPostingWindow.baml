   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5   	   .    (CandidateManagement_WPF.JobPostingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CandidateManagement_WPF     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ JobPostingWindow��5	   	   $	��708��6"   $	��800��6/   .��5
      � -   5         �Name$ JobPostingGrid��5
      $	��624��6#   $	��Top=�60   $��0,37,0,0q�6H    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��JOB POSTING MANAGEMENT��6   $��26(�61   $
��Left=�6?   $��
210,-6,0,0q�6Z   $	��Top=�6n   $��42��6�   $	��380��6�    J� RenderTransformOrigin$ 1.024,-0.151&�6�   $
��Bold"�6�   $��2��6�   �� 5   
   $��Post ID��6   $
��Left=�6"   $��	30,65,0,0q�6=   $	��Top=�6P   $��16(�6h   $��32��6v   $��60��6�   �� 5   
   $��Title��6   $
��Left=�6    $��
30,101,0,0q�6;   $	��Top=�6O   $��16(�6g   $��32��6u   $��40��6�   �� 5   
   $��	Post Date��6   $
��Left=�6$   $��
30,143,0,0q�6?   $	��Top=�6S   $��16(�6k   $��30��6y   $��77��6�   �� 5   
   -   5         ��Name$ 
txt_PostID��5      $
��Left=�6&   $��
123,69,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��264��6�   $��24��6�   �� 5   
   -   5        $ txt_JobTitle��5      $
��Left=�6(   $��123,105,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��264��6�   $��24��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txt_PostDate��5      $
��Left=�6+   $��123,145,0,0q�6F   $	��Top=�6[   $	��264��6s   $��24��6   �� 5   
   $��Description��6   $
��Left=�6&   $��	39,65,0,0q�6A   $	��Top=�6T   $��16(�6l   $��1��6z   $��31��6�   $��90��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgv_JobPosting��5      $��29,218,23,205q�6G   $��2��6^   6�   �� 5   
   $
��Left=�6   $��0��6-   $��-245,443,0,0q�68   $
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        	 ��Name$	 AddBtn��5      $	��Add��6!   $
��Left=�6/   $��49��6J   $��
50,547,0,0q�6V   $	��Top=�6j   $	��144��6�   ���	#FF16DF1B$��16(�6�   �� 5   
   -   5        $	 CloseBtn��5      $��Close��6#   $
��Left=�63   $��49��6N   $��228,547,0,0q�6Z   $	��Top=�6o   $	��144��6�   ���	#FFCF631B$��16(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   -   5        $	 	RemoveBtn��5      $��Remove��6$   $
��Left=�65   $��49��6P   $��
39,547,0,0q�6\   $	��Top=�6p   $	��144��6�   ���	#FF3F62D2$��16(�6�   $��1��6�   �� 5   
   -	   5        $	 	UpdateBtn��5      $��Update��6$   $
��Left=�65   $��49��6P   $��243,547,0,0q�6\   $	��Top=�6q   $	��144��6�   ���	#FFD1CD1D$��16(�6�   �� 5   
   -
   5        $ txt_Description��5      $��1��6+   $
��Left=�6;   $��
39,101,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��333��6�   $��72��6�   �� 5   
   -   5        $	 ClearBtn��5      $��Clear��6#   $
��Left=�63   $��
257,65,0,0q�6N   $	��Top=�6b   $��1��6z   $	��115��6�   6�   5      5       