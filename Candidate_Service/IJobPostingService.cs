using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface IJobPostingService
    {
        public JobPosting GetJobPostingById(string id);

        public List<JobPosting> GetJobPostings();

        public void AddJobPosting(JobPosting jobPosting);

        public void UpdateJobPosting(JobPosting jobPosting);

        public void RemoveJobPosting(string id);
    }
}
