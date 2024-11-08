using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class JobPostingService : IJobPostingService
    {
        private IJobPostingRepository jobPostingRepository;

        public JobPostingService()
        {
            jobPostingRepository = new JobPostingRepository();
        }

        public JobPosting GetJobPostingById(string id)
        {
            return jobPostingRepository.GetJobPostingById(id);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jobPostingRepository.GetJobPostings();
        }

        public void AddJobPosting(JobPosting jobPosting)
        {
            jobPostingRepository.AddJobPosting(jobPosting);
        }

        public void UpdateJobPosting(JobPosting jobPosting)
        {
            jobPostingRepository.UpdateJobPosting(jobPosting);
        }

        public void RemoveJobPosting(string id)
        {
            jobPostingRepository.RemoveJobPosting(id);
        }
    }
}
