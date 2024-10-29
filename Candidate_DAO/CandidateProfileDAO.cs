using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext context;
        private static CandidateProfileDAO instance;

        public CandidateProfileDAO()
        {
            context = new CandidateManagementContext();
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

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return context.CandidateProfiles.SingleOrDefault(x => x.CandidateId.Equals(id));
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return context.CandidateProfiles.ToList();
        }

        public Boolean AddCandidateProfile(CandidateProfile profile)
        {
            bool isSuccess = false;
            CandidateProfile existingProfile = this.GetCandidateProfileById(profile.CandidateId);

            if (existingProfile == null)
            {
                context.ChangeTracker.Clear();
                profile.Posting = null;
                context.CandidateProfiles.Add(profile);
                context.SaveChanges();
                isSuccess = true;
            }

            return isSuccess;
        }

        public Boolean UpdateCandidateProfile(CandidateProfile profile)
        {
            bool isSuccess = false;
            CandidateProfile existingProfile = this.GetCandidateProfileById(profile.CandidateId);

            if (existingProfile != null)
            {
                context.ChangeTracker.Clear();
                profile.Posting = null;
                context.CandidateProfiles.Update(profile);
                context.SaveChanges();
                isSuccess = true;
            }

            return isSuccess;
        }

        public Boolean DeleteCandidateProfile(CandidateProfile profile)
        {
            bool isSuccess = false;
            CandidateProfile existingProfile = this.GetCandidateProfileById(profile.CandidateId);

            if (existingProfile != null)
            {
                context.ChangeTracker.Clear();
                profile.Posting = null;
                context.CandidateProfiles.Remove(profile);
                context.SaveChanges();
                isSuccess = true;
            }

            return isSuccess;
        }
    }
}
