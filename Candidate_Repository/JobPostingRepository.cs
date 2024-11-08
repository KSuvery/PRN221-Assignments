using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class JobPostingRepository : IJobPostingRepository
    { 
        public JobPosting GetJobPostingById(string id) => JobPostingDAO.Instance.GetJobPostingById(id);

        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();

        public void AddJobPosting(JobPosting jobPosting) => JobPostingDAO.Instance.AddJobPosting(jobPosting);

        public void UpdateJobPosting(JobPosting jobPosting) => JobPostingDAO.Instance.UpdateJobPosting(jobPosting);

        public void RemoveJobPosting(string id) => JobPostingDAO.Instance.RemoveJobPosting(id);

    }
}
