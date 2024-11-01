using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Candidate_BusinessObjects
{
    public partial class JobPosting
    {
        public JobPosting()
        {
            CandidateProfiles = new HashSet<CandidateProfile>();
        }

        [Required]
        [RegularExpression(@"^P\d{4}$", ErrorMessage = "PostingId must be in the format 'P' followed by 4 digits")]
        public string PostingId { get; set; }
        [Required]
        public string JobPostingTitle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime? PostedDate { get; set; }

        public virtual ICollection<CandidateProfile> CandidateProfiles { get; set; }
    }
}
