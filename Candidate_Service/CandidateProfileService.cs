using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private ICandidateProfileRepository candidateProfileRepository;

        public CandidateProfileService()
        {
            candidateProfileRepository = new CandidateProfileRepository();
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return candidateProfileRepository.GetCandidateProfileById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return candidateProfileRepository.GetCandidateProfiles();
        }

        public Boolean AddCandidateProfile(CandidateProfile candidate) => candidateProfileRepository.AddCandidateProfile(candidate);
        public Boolean UpdateCandidateProfile(CandidateProfile candidate) => candidateProfileRepository.UpdateCandidateProfile(candidate);
        public Boolean DeleteCandidateProfile(CandidateProfile candidate) => candidateProfileRepository.DeleteCandidateProfile(candidate);
    }
}
