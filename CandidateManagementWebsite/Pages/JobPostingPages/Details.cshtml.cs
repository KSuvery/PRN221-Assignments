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
    public class DetailsModel : PageModel
    {
        private readonly IJobPostingService jobPostingService;

        public DetailsModel(IJobPostingService _jobPostingService)
        {
            jobPostingService = _jobPostingService;
        }

        public JobPosting JobPosting { get; set; } = default!; 

        public IActionResult OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobPosting = jobPostingService.GetJobPostingById(id);

            if (JobPosting == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
