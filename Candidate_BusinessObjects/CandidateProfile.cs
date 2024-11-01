using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Candidate_BusinessObjects
{
    public partial class CandidateProfile
    {
        [Required]
        [RegularExpression(@"^CANDIDATE\d{4}$", ErrorMessage = "CandidateId must be in the format 'CANDIDATE' followed by 4 digits")]
        public string CandidateId { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public DateTime? Birthday { get; set; }
        [Required]
        public string ProfileShortDescription { get; set; }
        [Required]
        public string ProfileUrl { get; set; }
        public string PostingId { get; set; }
        public virtual JobPosting Posting { get; set; }
    }
}
