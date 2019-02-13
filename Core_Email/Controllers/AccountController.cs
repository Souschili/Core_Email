using Core_Email.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Core_Email.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet("")]
        public IActionResult Enter()
        {
            DataInputViewModel model = new DataInputViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Enter(DataInputViewModel model)
        {
            //todo add validation on server side 
            return Content($"This is post method {model.Login}--{model.Password}--{model.Title}");
        }


    }
}