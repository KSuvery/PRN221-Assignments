using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObjects;
using Candidate_Service;

namespace CandidateManagementWebsite.Pages.CandidateProfilePages
{
    public class EditModel : PageModel
    {
        private readonly ICandidateProfileService candidateProfileService;
        private readonly IJobPostingService jobPostingService;

        public EditModel(ICandidateProfileService _candidateProfileService, IJobPostingService _jobPostingService)
        {
            candidateProfileService = _candidateProfileService;
            jobPostingService = _jobPostingService;
            JobPostingList = new SelectList(jobPostingService.GetJobPostings(), "PostingId", "JobPostingTitle");
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;
        public SelectList JobPostingList { get; set; }

        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CandidateProfile = candidateProfileService.GetCandidateProfileById(id);

            if (CandidateProfile == null)
            {
                return NotFound();
            }

            PopulateJobPostingsDropDownList();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                PopulateJobPostingsDropDownList();
                return Page();
            }

            try
            {
                PopulateJobPostingsDropDownList();
                candidateProfileService.UpdateCandidateProfile(CandidateProfile);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateProfileExists(CandidateProfile.CandidateId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            PopulateJobPostingsDropDownList();
            return RedirectToPage("./Index");
        }

        private bool CandidateProfileExists(string id)
        {
            return candidateProfileService.GetCandidateProfileById(id) != null;
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
