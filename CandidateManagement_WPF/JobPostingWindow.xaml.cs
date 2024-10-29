using Candidate_BusinessObjects;
using Candidate_Service;
using Microsoft.VisualBasic;
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
    /// <summary>
    /// Interaction logic for JobPostingWindow.xaml
    /// </summary>
    public partial class JobPostingWindow : Window
    {
        private int? RoleID = 0;
        private IJobPostingService jobPostingService;
        public JobPostingWindow(int? roleID)
        {
            InitializeComponent();
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
                    AddBtn.IsEnabled = false;
                    UpdateBtn.IsEnabled = false;
                    RemoveBtn.IsEnabled = false;
                    break;
            }
        }

        private void Clear()
        {
            txt_PostID.Text = string.Empty;
            txt_JobTitle.Text = string.Empty;
            txt_Description.Text = string.Empty;
            txt_PostDate.Text = string.Empty;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            JobPosting job = new JobPosting();
            job.PostingId = txt_PostID.Text;
            job.JobPostingTitle = txt_JobTitle.Text;
            job.Description = txt_Description.Text;
            job.PostedDate = DateTime.Parse(txt_PostDate.Text);
            JobPosting result = job;

            if (!Regex.Match(txt_PostID.Text, @"P[0-9][0-9][0-9][0-9]", RegexOptions.IgnoreCase).Success)
            {
                MessageBox.Show("Posting ID must start with 'P' followed by 4 digits");
                result = null;
            }

            if (result != null)
            {
                jobPostingService.AddJobPosting(result);
                dgv_JobPosting.ItemsSource = jobPostingService.GetJobPostings();
                MessageBox.Show("Add Successful!");
            }
            else
            {
                MessageBox.Show("Chiu");
            }
        }

        private void dgv_JobPosting_Loaded(object sender, RoutedEventArgs e)
        {
            dgv_JobPosting.ItemsSource = jobPostingService.GetJobPostings();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            JobPosting job = new JobPosting();
            job.PostingId = txt_PostID.Text;
            job.JobPostingTitle = txt_JobTitle.Text;
            job.Description = txt_Description.Text;
            job.PostedDate = DateTime.Parse(txt_PostDate.Text);
            JobPosting result = job;
            
            if (result != null)
            {
                jobPostingService.UpdateJobPosting(result);
                dgv_JobPosting.ItemsSource = jobPostingService.GetJobPostings();
                MessageBox.Show("Update Successful!");
            }
            else
            {
                MessageBox.Show("Chiu");
            }
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            JobPosting jobPosting = (JobPosting)dgv_JobPosting.SelectedItem;
            jobPostingService.RemoveJobPosting(jobPosting);
            dgv_JobPosting.ItemsSource = jobPostingService.GetJobPostings();
        }

        private void dgv_JobPosting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            JobPosting jobPosting = dgv_JobPosting.SelectedItem as JobPosting;
            if (jobPosting != null)
            {
                txt_PostID.Text = jobPosting.PostingId;
                txt_JobTitle.Text = jobPosting.JobPostingTitle;
                txt_Description.Text = jobPosting.Description;
                txt_PostDate.Text = jobPosting.PostedDate.ToString();
            }
            txt_PostID.IsEnabled = false;
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            txt_PostID.IsEnabled = true;
        }
    }
}
