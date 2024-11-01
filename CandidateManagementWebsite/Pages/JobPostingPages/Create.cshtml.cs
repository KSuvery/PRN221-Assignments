using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Candidate_BusinessObjects;
using Candidate_Service;

namespace CandidateManagementWebsite.Pages.JobPostingPages
{
    public class CreateModel : PageModel
    {
        private readonly IJobPostingService jobPostingService;

        public CreateModel(IJobPostingService _jobPostingService)
        {
            jobPostingService = _jobPostingService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobPosting JobPosting { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public IActionResult OnPost()
        {
            if(jobPostingService.GetJobPostings().Any(j => j.PostingId == JobPosting.PostingId))
            {
                ModelState.AddModelError("JobPosting.PostingId", "PostingId already exists");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            jobPostingService.AddJobPosting(JobPosting);

            return RedirectToPage("./Index");
        }
    }
}
