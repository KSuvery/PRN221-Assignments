using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Candidate_BusinessObjects;
using Candidate_Service;
using Microsoft.EntityFrameworkCore;

namespace CandidateManagementWebsite.Pages.CandidateProfilePages
{
    public class CreateModel : PageModel
    {
        private readonly ICandidateProfileService candidateProfileService;
        private readonly IJobPostingService jobPostingService;

        public CreateModel(ICandidateProfileService _candidateProfileService, IJobPostingService _jobPostingService)
        {
            candidateProfileService = _candidateProfileService;
            jobPostingService = _jobPostingService;
            JobPostingList = new SelectList(jobPostingService.GetJobPostings(), "PostingId", "JobPostingTitle");
        }

        public IActionResult OnGet()
        {
            PopulateJobPostingsDropDownList();
            return Page();
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;
        public SelectList JobPostingList { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public IActionResult OnPost()
        {
            if(candidateProfileService.GetCandidateProfiles().Any(c => c.CandidateId == CandidateProfile.CandidateId))
            {
                ModelState.AddModelError("CandidateProfile.CandidateId", "CandidateId already exists");
                PopulateJobPostingsDropDownList();
                return Page();
            }

            if (!ModelState.IsValid)
            {
                PopulateJobPostingsDropDownList();
                return Page();
            }

            candidateProfileService.AddCandidateProfile(CandidateProfile);

            return RedirectToPage("./Index");
        }

        private void PopulateJobPostingsDropDownList()
        {
            var jobPostingsQuery = from d in jobPostingService.GetJobPostings()
                                   orderby d.PostingId
                                   select new { d.PostingId, d.JobPostingTitle };
            JobPostingList = new SelectList(jobPostingsQuery, "PostingId", "JobPostingTitle");
        }
    }
}
