using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObjects;
using Candidate_Service;

namespace CandidateManagementWebsite.Pages.JobPostingPages
{
    public class IndexModel : PageModel
    {
        private readonly IJobPostingService jobPostingService;

        public IndexModel (IJobPostingService _jobPostingService)
        {
            jobPostingService = _jobPostingService;
        }

        public IList<JobPosting> JobPosting { get;set; } = default!;

        public void OnGet()
        {
            JobPosting = jobPostingService.GetJobPostings();
        }
    }
}
