using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class HRAccountDAO
    {
        private static HRAccountDAO instance;
        private List<Hraccount> hraccounts;

        public HRAccountDAO()
        {
            hraccounts = GetHraccounts();
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

        public List<Hraccount> GetHraccounts()
        {
            string strData = File.ReadAllText("HRAccount.json");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            List<Hraccount> hraccounts = JsonSerializer.Deserialize<List<Hraccount>>(strData, options);

            return hraccounts;
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            return hraccounts.SingleOrDefault(x => x.Email.Equals(email));
        }

        public void AddHraccount(Hraccount hraccount)
        {
            hraccounts.Add(hraccount);
            string data = JsonSerializer.Serialize(hraccounts);
            File.WriteAllText("HRAccount.json", data);
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
