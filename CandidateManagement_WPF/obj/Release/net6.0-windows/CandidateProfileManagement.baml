   M S B A M L   `   `   `  ���� R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  8    2CandidateManagement_WPF.CandidateProfileManagement   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:CandidateManagement_WPF     -     � WindowStartupLocation$  CenterScreen=� � Title$  CandidateProfileManagement��$	��708��$	��800��.��� -    �Name$ CandidateGrid��$	��624��$	��Top=�$��0,37,0,0q� � ColumnDefinitions �� �� .+��� $"��CANDIDATE PROFILE MANAGEMENT��$��26(�$
��Left=�$��188,-13,0,0q�$	��Top=�$��42��$	��462�� J� RenderTransformOrigin$ 1.024,-0.151&�$
��Bold"�$��2���� $��Candidate ID��$
��Left=�$��	30,37,0,0q�$	��Top=�$��16(�$��32��$	��107���� $��FullName��$
��Left=�$��	30,83,0,0q�$	��Top=�$��16(�$��32��$��92���� $��	Birthdate��$
��Left=�$��
30,166,0,0q�$	��Top=�$��16(�$��30��$��88���� -    ��Name$ txt_CandidateID��$
��Left=�$��
137,41,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��250��$��24���� -   $ txt_fullName��$
��Left=�$��
137,87,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��250��$��24��(  "System.Windows.Controls.DatePicker  -     Name$ date_Birthdate��$
��Left=�$��137,169,0,0q�$	��Top=�$	��250��$��24���� $��Description��$
��Left=�$��	39,89,0,0q�$	��Top=�$��16(�$��1��$��31��$��90��&   System.Windows.Controls.DataGrid  -     Name$ dgv_CandidateProfile��$��29,218,23,205q�$��2���� $
��Left=�$��0��$��-245,443,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��120���� -   	 ��Name$	 AddBtn��$	��Add��$
��Left=�$��49��$��
50,547,0,0q�$	��Top=�$	��144�����	#FF16DF1B$��16(��� -   $	 CloseBtn��$��Close��$
��Left=�$��49��$��228,547,0,0q�$	��Top=�$	��144�����	#FFCF631B$��16(�$
��Bold"�$��1���� -	   $	 	RemoveBtn��$��Remove��$
��Left=�$��49��$��
39,547,0,0q�$	��Top=�$	��144�����	#FF3F62D2$��16(�$��1���� -
   $	 	UpdateBtn��$��Update��$
��Left=�$��49��$��243,547,0,0q�$	��Top=�$	��144�����	#FFD1CD1D$��16(��� -   $ txt_Description��$��1��$
��Left=�$��
39,124,0,0q�$
 Wrap=�$	��Top=�$	��333��$��72���� $��
JobPosting��$
��Left=�$��	39,37,0,0q�$	��Top=�$��16(�$��1��$��31��$��90���� -   
 ��Name$
 cmb_JobPosting��$��1��$
��Left=�$��
134,37,0,0q�$	��Top=�$	��238��$��28���� $��ImageURL��$
��Left=�$��
30,128,0,0q�$	��Top=�$��16(�$��32��$��92���� -   $ txt_ImageURL��$
��Left=�$��137,128,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��250��$��24��