   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5   	   8    2CandidateManagement_WPF.CandidateProfileManagement   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CandidateManagement_WPF     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$  CandidateProfileManagement��5	   	   $	��708��6,   $	��800��69   .��5
      � -   5         �Name$ CandidateGrid��5
      $	��624��6"   $	��Top=�6/   $��0,37,0,0q�6G    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $"��CANDIDATE PROFILE MANAGEMENT��6   $��26(�67   $
��Left=�6E   $��188,-13,0,0q�6`   $	��Top=�6u   $��42��6�   $	��462��6�    J� RenderTransformOrigin$ 1.024,-0.151&�6�   $
��Bold"�6�   $��2��6�   �� 5   
   $��Candidate ID��6   $
��Left=�6'   $��	30,37,0,0q�6B   $	��Top=�6U   $��16(�6m   $��32��6{   $	��107��6�   �� 5   
   $��FullName��6   $
��Left=�6#   $��	30,83,0,0q�6>   $	��Top=�6Q   $��16(�6i   $��32��6w   $��92��6�   �� 5   
   $��	Birthdate��6   $
��Left=�6$   $��
30,166,0,0q�6?   $	��Top=�6S   $��16(�6k   $��30��6y   $��88��6�   �� 5   
   -   5         ��Name$ txt_CandidateID��5      $
��Left=�6+   $��
137,41,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��250��6�   $��24��6�   �� 5   
   -   5        $ txt_fullName��5      $
��Left=�6(   $��
137,87,0,0q�6C   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��250��6�   $��24��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ date_Birthdate��5      $
��Left=�6-   $��137,169,0,0q�6H   $	��Top=�6]   $	��250��6u   $��24��6�   �� 5   
   $��Description��6   $
��Left=�6&   $��	39,89,0,0q�6A   $	��Top=�6T   $��16(�6l   $��1��6z   $��31��6�   $��90��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgv_CandidateProfile��5      $��29,218,23,205q�6S   $��2��6j   6�   �� 5   
   $
��Left=�6   $��0��6-   $��-245,443,0,0q�68   $
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        	 ��Name$	 AddBtn��5      $	��Add��6!   $
��Left=�6/   $��49��6J   $��
50,547,0,0q�6V   $	��Top=�6j   $	��144��6�   ���	#FF16DF1B$��16(�6�   �� 5   
   -   5        $	 CloseBtn��5      $��Close��6#   $
��Left=�63   $��49��6N   $��228,547,0,0q�6Z   $	��Top=�6o   $	��144��6�   ���	#FFCF631B$��16(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   -	   5        $	 	RemoveBtn��5      $��Remove��6$   $
��Left=�65   $��49��6P   $��
39,547,0,0q�6\   $	��Top=�6p   $	��144��6�   ���	#FF3F62D2$��16(�6�   $��1��6�   �� 5   
   -
   5        $	 	UpdateBtn��5      $��Update��6$   $
��Left=�65   $��49��6P   $��243,547,0,0q�6\   $	��Top=�6q   $	��144��6�   ���	#FFD1CD1D$��16(�6�   �� 5   
   -   5        $ txt_Description��5      $��1��6+   $
��Left=�6;   $��
39,124,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��333��6�   $��72��6�   �� 5   
   $��
JobPosting��6   $
��Left=�6%   $��	39,37,0,0q�6@   $	��Top=�6S   $��16(�6k   $��1��6y   $��31��6�   $��90��6�   �� 5   
   -   5        
 ��Name$
 cmb_JobPosting��5      $��1��6+   $
��Left=�6;   $��
134,37,0,0q�6V   $	��Top=�6j   $	��238��6�   $��28��6�   �� 5    
   $��ImageURL��6   $
��Left=�6#   $��
30,128,0,0q�6>   $	��Top=�6R   $��16(�6j   $��32��6x   $��92��6�   �� 5!   
   -   5        $ txt_ImageURL��5!      $
��Left=�6(   $��137,128,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��250��6�   $��24��6�   �� 5"   
   -   5        $	 ClearBtn��5"      $��Clear��6#   $
��Left=�63   $��
257,85,0,0q�6N   $	��Top=�6b   $��1��6z   $	��115��6�   6�   5#      5$      