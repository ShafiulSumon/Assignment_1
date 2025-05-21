using System.Threading.Tasks;
using Assignment_1.DTOs;
using Assignment_1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class SignupController : Controller
    {
        private readonly ISignupService _signupService;
        public SignupController(ISignupService signupService)
        {
            _signupService = signupService;
        }

        public ActionResult SignupPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignupPage(SignupDTO data)
        {
            if (data == null)
            {
                return BadRequest("Invalid signup data.");
            }
            await _signupService.SignupAsync(data);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<ActionResult> GetSignupList()
        {
            var signupList = await _signupService.GetSignupList();
            return Ok(signupList);
        }
    }
}
