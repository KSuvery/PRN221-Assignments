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
        //private CandidateManagementContext context;
        private static CandidateProfileDAO instance;
        private List<CandidateProfile> candidateProfiles;

        public CandidateProfileDAO()
        {
            //context = new CandidateManagementContext();
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

        //public CandidateProfile GetCandidateProfileById(string id)
        //{
        //    return context.CandidateProfiles.SingleOrDefault(x => x.CandidateId.Equals(id));
        //}

        //public List<CandidateProfile> GetCandidateProfiles()
        //{
        //    return context.CandidateProfiles.ToList();
        //}

        //public Boolean AddCandidateProfile(CandidateProfile profile)
        //{
        //    bool isSuccess = false;
        //    CandidateProfile existingProfile = this.GetCandidateProfileById(profile.CandidateId);

        //    if (existingProfile == null)
        //    {
        //        context.ChangeTracker.Clear();
        //        profile.Posting = null;
        //        context.CandidateProfiles.Add(profile);
        //        context.SaveChanges();
        //        isSuccess = true;
        //    }

        //    return isSuccess;
        //}

        //public Boolean UpdateCandidateProfile(CandidateProfile profile)
        //{
        //    bool isSuccess = false;
        //    CandidateProfile existingProfile = this.GetCandidateProfileById(profile.CandidateId);

        //    if (existingProfile != null)
        //    {
        //        context.ChangeTracker.Clear();
        //        profile.Posting = null;
        //        context.CandidateProfiles.Update(profile);
        //        context.SaveChanges();
        //        isSuccess = true;
        //    }

        //    return isSuccess;
        //}

        //public Boolean DeleteCandidateProfile(CandidateProfile profile)
        //{
        //    bool isSuccess = false;
        //    CandidateProfile existingProfile = this.GetCandidateProfileById(profile.CandidateId);

        //    if (existingProfile != null)
        //    {
        //        context.ChangeTracker.Clear();
        //        profile.Posting = null;
        //        context.CandidateProfiles.Remove(profile);
        //        context.SaveChanges();
        //        isSuccess = true;
        //    }

        //    return isSuccess;
        //}

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
        }

        public void DeleteCandidateProfile(string id)
        {
            candidateProfiles.Remove(GetCandidateProfileById(id));
        }
            
    }
}
