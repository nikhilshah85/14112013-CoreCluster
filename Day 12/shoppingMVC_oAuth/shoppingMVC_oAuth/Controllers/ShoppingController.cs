using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace shoppingMVC_oAuth.Controllers
{

    //[Authorize] //all the actions on this controller will need users to be logged in
    public class ShoppingController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }

        [Authorize] //this action will need user to be logged in
        public IActionResult MakePayment()
        {
            return View();
        }


        [Authorize]
        public IActionResult ViewCart()
        {
            return View();
        }
    }
}
