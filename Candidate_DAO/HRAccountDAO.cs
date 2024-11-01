using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class HRAccountDAO
    {
        private CandidateManagementContext context;
        private static HRAccountDAO instance;

        public HRAccountDAO()
        {
            context = new CandidateManagementContext();
        }

        public static HRAccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            return context.Hraccounts.SingleOrDefault(x => x.Email.Equals(email));
        }

        public List<Hraccount> GetHraccounts()
        {
            return context.Hraccounts.ToList();
        }

        public void AddHraccount(Hraccount hraccount)
        {
            context.Hraccounts.Add(hraccount);
            context.SaveChanges();
        }

        public bool isAdmin(Hraccount hraccount)
        {
            try
            {
                if(hraccount.MemberRole == 1)
                {
                   return true;
                }
                else
                {
                   return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool isStaff(Hraccount hraccount)
        {
            try
            {
                if (hraccount.MemberRole == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
