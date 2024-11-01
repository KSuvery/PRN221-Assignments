using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class JobPostingDAO
    {
        private CandidateManagementContext context;
        private static JobPostingDAO instance;

        public JobPostingDAO()
        {
            context = new CandidateManagementContext();
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
        
        public JobPosting GetJobPostingById(string id)
        {
            return context.JobPostings.SingleOrDefault(x => x.PostingId.Equals(id));
        }

        public List<JobPosting> GetJobPostings()
        {
            return context.JobPostings.ToList();
        }

        public List<string> GetPostingIds()
        {
            List<JobPosting> jobPostings = context.JobPostings.ToList();

            List<string> formattedIds = new List<string>();

            foreach (var jobPosting in jobPostings)
            {
                formattedIds.Add($"{jobPosting.PostingId} ({jobPosting.JobPostingTitle})");
            }

            return formattedIds;
        }

        public void AddJobPosting(JobPosting jobPosting)
        {
            context.JobPostings.Add(jobPosting);
            context.SaveChanges();
        }
            
        public void UpdateJobPosting(JobPosting jobPosting)
        {
            context.ChangeTracker.Clear();
            context.JobPostings.Update(jobPosting);
            context.SaveChanges();
        }

        public void RemoveJobPosting(JobPosting jobPosting)
        {
            context.ChangeTracker.Clear();
            context.JobPostings.Remove(jobPosting);
            context.SaveChanges();
        }
    }
}
