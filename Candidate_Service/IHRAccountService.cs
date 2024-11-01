using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface IHRAccountService
    {
        public Hraccount GetHraccountByEmail(string email);

        public List<Hraccount> GetHraccounts();

        public void AddHraccount(Hraccount hraccount);

        public bool isAdmin(Hraccount hraccount);

        public bool isStaff(Hraccount hraccount);
    }
}
