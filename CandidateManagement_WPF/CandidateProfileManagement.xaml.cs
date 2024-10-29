using Candidate_BusinessObjects;
using Candidate_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CandidateManagement_WPF
{
    public partial class CandidateProfileManagement : Window
    {
        private int? RoleID = 0;
        private ICandidateProfileService candidateProfileService;
        private IJobPostingService jobPostingService;
        
        public CandidateProfileManagement(int? roleID)
        {
            InitializeComponent();
            candidateProfileService = new CandidateProfileService();
            jobPostingService = new JobPostingService();
            this.RoleID = roleID;
            switch (RoleID)
            {
                case 1:
                    break;
                case 2:
                    this.AddBtn.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private void dgv_CandidateProfile_Loaded(object sender, RoutedEventArgs e)
        {
            dgv_CandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile profile = new CandidateProfile();
            profile.CandidateId = txt_CandidateID.Text;
            profile.Fullname = txt_fullName.Text;
            profile.ProfileUrl = txt_ImageURL.Text;
            profile.Birthday = DateTime.Parse(date_Birthdate.Text);
            profile.PostingId = cmb_JobPosting.SelectedValue.ToString();
            profile.ProfileShortDescription = txt_Description.Text;
            CandidateProfile result = profile;

            if (!Regex.Match(txt_CandidateID.Text, @"CANDIDATE[0-9][0-9][0-9][0-9]", RegexOptions.IgnoreCase).Success)
            {
                MessageBox.Show("Candidate ID must start with 'CANDIDATE' followed by 4 digits");
                result = null;
            }
            
            if (result != null)
            {
                candidateProfileService.AddCandidateProfile(profile);
                dgv_CandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
                MessageBox.Show("Add Successful!");
            }
            else
            {
                MessageBox.Show("Chiu");
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CandidateProfileManagementWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.loadInitData();
        }

        private void loadInitData()
        {
            this.cmb_JobPosting.ItemsSource = jobPostingService.GetJobPostings();
            this.cmb_JobPosting.DisplayMemberPath = "JobPostingTitle";
            this.cmb_JobPosting.SelectedValuePath = "PostingId";
        }

        private void dgv_CandidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CandidateProfile profile = dgv_CandidateProfile.SelectedItem as CandidateProfile;
            if (profile != null)
            {
                txt_CandidateID.Text = profile.CandidateId;
                txt_fullName.Text = profile.Fullname;
                txt_ImageURL.Text = profile.ProfileUrl;
                txt_Description.Text = profile.ProfileShortDescription;
                date_Birthdate.Text = profile.Birthday.ToString();
                cmb_JobPosting.SelectedValue = profile.PostingId;
            }
            txt_CandidateID.IsEnabled = false;
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile profile = (CandidateProfile)dgv_CandidateProfile.SelectedItem;
            candidateProfileService.DeleteCandidateProfile(profile);
            dgv_CandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile profile = new CandidateProfile();
            profile.CandidateId = txt_CandidateID.Text;
            profile.Fullname = txt_fullName.Text;
            profile.ProfileUrl = txt_ImageURL.Text;
            profile.Birthday = DateTime.Parse(date_Birthdate.Text);
            profile.PostingId = cmb_JobPosting.SelectedValue.ToString();
            profile.ProfileShortDescription = txt_Description.Text;
            CandidateProfile result = profile;
            
            if (result != null)
            {
                candidateProfileService.UpdateCandidateProfile(profile);
                dgv_CandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
                MessageBox.Show("Update Successful!");
            }
            else
            {
                MessageBox.Show("Chiu");
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            txt_CandidateID.IsEnabled = true;
        }

        private void Clear()
        {
            txt_CandidateID.Text = string.Empty;
            txt_fullName.Text = string.Empty;
            txt_ImageURL.Text = string.Empty;
            txt_Description.Text = string.Empty;
            date_Birthdate.Text = string.Empty;
            cmb_JobPosting.SelectedIndex = 0;
        }
    }
}
