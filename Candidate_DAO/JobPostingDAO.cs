using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class JobPostingDAO
    {
        private static JobPostingDAO instance;
        private List<JobPosting> jobPostings;

        public JobPostingDAO()
        {
            jobPostings = GetJobPostings();
        }

        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }
        }

        public List<JobPosting> GetJobPostings()
        {
            string strData = File.ReadAllText("JobPosting.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            List<JobPosting> jobPostings = JsonSerializer.Deserialize<List<JobPosting>>(strData, options);

            return jobPostings;
        }

        public JobPosting GetJobPostingById(string id)
        {
            return jobPostings.SingleOrDefault(x => x.PostingId.Equals(id));
        }

        public void AddJobPosting(JobPosting jobPosting)
        {
            jobPostings.Add(jobPosting);
            string strData = JsonSerializer.Serialize(jobPostings);
            File.WriteAllText("JobPosting.json", strData);
        }

        public void UpdateJobPosting(JobPosting jobPosting)
        {
            for (int i = 0; i < jobPostings.Count; i++)
            {
                if (jobPostings[i].PostingId == jobPosting.PostingId)
                {
                    jobPostings[i].JobPostingTitle = jobPosting.JobPostingTitle;
                    jobPostings[i].Description = jobPosting.Description;
                    jobPostings[i].PostedDate = jobPosting.PostedDate;
                }
            }
            string strData = JsonSerializer.Serialize(jobPostings);
            File.WriteAllText("JobPosting.json", strData);
        }

        public void RemoveJobPosting(string id)
        {
            jobPostings.Remove(GetJobPostingById(id));
            string strData = JsonSerializer.Serialize(jobPostings);
            File.WriteAllText("JobPosting.json", strData);
        }
    }
}
