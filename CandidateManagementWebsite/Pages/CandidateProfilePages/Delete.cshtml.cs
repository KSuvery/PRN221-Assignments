using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObjects;
using Candidate_Service;

namespace CandidateManagementWebsite.Pages.CandidateProfilePages
{
    public class DeleteModel : PageModel
    {
        private readonly ICandidateProfileService candidateProfileService;

        public DeleteModel(ICandidateProfileService _candidateProfileService)
        {
            candidateProfileService = _candidateProfileService;
        }

        [BindProperty]
      public CandidateProfile CandidateProfile { get; set; } = default!;

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
            return Page();
        }

        public IActionResult OnPost(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var candidateProfile = candidateProfileService.GetCandidateProfileById(id);

            if (candidateProfile != null)
            {
                candidateProfileService.DeleteCandidateProfile(candidateProfile);
            }

            return RedirectToPage("./Index");
        }
    }
}
