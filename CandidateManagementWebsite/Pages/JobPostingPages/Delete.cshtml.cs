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
    public class DeleteModel : PageModel
    {
        private readonly IJobPostingService jobPostingService;

        public DeleteModel(IJobPostingService _jobPostingService)
        {
            jobPostingService = _jobPostingService;
        }

        [BindProperty]
      public JobPosting JobPosting { get; set; } = default!;

        public IActionResult OnGet(string id)
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

        public IActionResult OnPost(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var jobposting = jobPostingService.GetJobPostingById(id);

            if (jobposting != null)
            {
                jobPostingService.RemoveJobPosting(jobposting);
            }

            return RedirectToPage("./Index");
        }
    }
}
