using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface ICandidateProfileRepository
    {
        public CandidateProfile GetCandidateProfileById(string id);

        public List<CandidateProfile> GetCandidateProfiles();

        public void AddCandidateProfile(CandidateProfile profile);

        public void UpdateCandidateProfile(CandidateProfile profile);

        public void DeleteCandidateProfile(string id);
    }
}
