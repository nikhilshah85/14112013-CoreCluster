using Microsoft.AspNetCore.Mvc;

namespace consumeAPI_learn_CORS.Controllers
{
    public class APIDataController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
