using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IJobPostingRepository
    {
        public JobPosting GetJobPostingById(string id);

        public List<JobPosting> GetJobPostings();

        public List<string> GetPostingIds();

        public void AddJobPosting(JobPosting jobPosting);

        public void UpdateJobPosting(JobPosting jobPosting);

        public void RemoveJobPosting(JobPosting jobPosting);
    }
}
