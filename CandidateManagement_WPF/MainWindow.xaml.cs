using Candidate_Service;
using Candidate_BusinessObjects;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidateManagement_WPF
{
    public partial class MainWindow : Window
    {
        private int? RoleID = 0;
        private IHRAccountService accountService;
        public MainWindow()
        {
            InitializeComponent();
            accountService = new HRAccountService();
            
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = accountService.GetHraccountByEmail(txt_Email.Text);
            if (hraccount != null && hraccount.Password.Equals(txt_Password.Password) && hraccount.MemberRole == 1)
            {
                JobPostingWindow job = new JobPostingWindow(hraccount.MemberRole);
                job.Show();
                this.Close();
            }
            else if (hraccount != null && hraccount.Password.Equals(txt_Password.Password) && hraccount.MemberRole == 3)
            {
                CandidateProfileManagement candidateprofilemanagement = new CandidateProfileManagement(hraccount.MemberRole);
                candidateprofilemanagement.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}