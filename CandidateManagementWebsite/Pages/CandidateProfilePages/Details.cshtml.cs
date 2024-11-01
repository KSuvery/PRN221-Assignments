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
    public class DetailsModel : PageModel
    {
        private readonly ICandidateProfileService candidateProfileService;

        public DetailsModel(ICandidateProfileService _candidateProfileService)
        {
            candidateProfileService = _candidateProfileService;
        }

        public CandidateProfile CandidateProfile { get; set; } = default!; 

        public IActionResult OnGetAsync(string id)
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
    }
}
