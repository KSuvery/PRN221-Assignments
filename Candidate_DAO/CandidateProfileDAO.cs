using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class CandidateProfileDAO
    {
        private static CandidateProfileDAO instance;
        private List<CandidateProfile> candidateProfiles;

        public CandidateProfileDAO()
        {
            candidateProfiles = GetCandidateProfiles();
        }

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            string strData = File.ReadAllText("CandidateProfile.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            List<CandidateProfile> candidateProfiles = JsonSerializer.Deserialize<List<CandidateProfile>>(strData, options);

            return candidateProfiles;
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
           return candidateProfiles.SingleOrDefault(x => x.CandidateId.Equals(id));
        }

        public void AddCandidateProfile(CandidateProfile profile)
        {
            candidateProfiles.Add(profile);
            string strData = JsonSerializer.Serialize(candidateProfiles);
            File.WriteAllText("CandidateProfile.json", strData);
        }

        public void UpdateCandidateProfile(CandidateProfile profile)
        {
            for(int i = 0; i < candidateProfiles.Count; i++)
            {
                if (candidateProfiles[i].CandidateId == profile.CandidateId)
                {
                    candidateProfiles[i].Fullname = profile.Fullname;
                    candidateProfiles[i].Birthday = profile.Birthday;
                    candidateProfiles[i].ProfileShortDescription = profile.ProfileShortDescription;
                    candidateProfiles[i].ProfileUrl = profile.ProfileUrl;
                    candidateProfiles[i].PostingId = profile.PostingId;
                }
            }
            string strData = JsonSerializer.Serialize(candidateProfiles);
            File.WriteAllText("CandidateProfile.json", strData);
        }

        public void DeleteCandidateProfile(string id)
        {
            candidateProfiles.Remove(GetCandidateProfileById(id));
            string strData = JsonSerializer.Serialize(candidateProfiles);
            File.WriteAllText("CandidateProfile.json", strData);
        }
            
    }
}
