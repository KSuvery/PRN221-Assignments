using Candidate_BusinessObjects;
using Candidate_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagementWebsite.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IHRAccountService hRAccountService;

        public LoginModel(IHRAccountService _hRAccountService)
        {
            hRAccountService = _hRAccountService;
        }

        [BindProperty]
        public string email { get; set; } = default!;

        [BindProperty]
        public string password { get; set; } = default!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Hraccount hraccount = hRAccountService.GetHraccountByEmail(email);
            if (hraccount != null && hraccount.Password.Equals(password) && hraccount.MemberRole == 1)
            {
                HttpContext.Session.SetString("admin", email);
                return RedirectToPage("/JobPostingPages/Index");
            }
            else if(hraccount != null && hraccount.Password.Equals(password) && hraccount.MemberRole == 3)
            {
                    HttpContext.Session.SetString("staff", email);
                    return RedirectToPage("/CandidateProfilePages/Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return Page();
            }
        }
    }
}
