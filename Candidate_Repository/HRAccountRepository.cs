using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class HRAccountRepository : IHRAccountRepository
    {
        public Hraccount GetHraccountByEmail(string email) => HRAccountDAO.Instance.GetHraccountByEmail(email);

        public List<Hraccount> GetHraccounts() => HRAccountDAO.Instance.GetHraccounts();
        
        public void AddHraccount(Hraccount hraccount) => HRAccountDAO.Instance.AddHraccount(hraccount);
        
        public bool isAdmin(Hraccount hraccount) => HRAccountDAO.Instance.isAdmin(hraccount);

        public bool isStaff(Hraccount hraccount) => HRAccountDAO.Instance.isStaff(hraccount);
    }
}
