using Candidate_BusinessObjects;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepository accountRepository;

        public HRAccountService()
        {
            accountRepository = new HRAccountRepository();
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            return accountRepository.GetHraccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return accountRepository.GetHraccounts();
        }

        public void AddHraccount(Hraccount hraccount)
        {
            accountRepository.AddHraccount(hraccount);
        }

        public bool isAdmin(Hraccount hraccount)
        {
            return accountRepository.isAdmin(hraccount);
        }

        public bool isStaff(Hraccount hraccount)
        {
            return accountRepository.isStaff(hraccount);
        }
    }
}
