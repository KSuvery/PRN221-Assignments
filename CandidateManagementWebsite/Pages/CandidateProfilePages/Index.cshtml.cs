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
    public class IndexModel : PageModel
    {
        private readonly ICandidateProfileService candidateProfileService;

        public IndexModel(ICandidateProfileService _candidateProfileService)
        {
            candidateProfileService = _candidateProfileService;
        }

        public IList<CandidateProfile> CandidateProfile { get;set; } = default!;

        public void OnGet()
        {
            CandidateProfile = candidateProfileService.GetCandidateProfiles();
        }
    }
}
