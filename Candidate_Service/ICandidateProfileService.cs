using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface ICandidateProfileService
    {
        public CandidateProfile GetCandidateProfileById(string id);

        public List<CandidateProfile> GetCandidateProfiles();

        public Boolean AddCandidateProfile(CandidateProfile profile);

        public Boolean UpdateCandidateProfile(CandidateProfile profile);

        public Boolean DeleteCandidateProfile(CandidateProfile profile);
    }
}
