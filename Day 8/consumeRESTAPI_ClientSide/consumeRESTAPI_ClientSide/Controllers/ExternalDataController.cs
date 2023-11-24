using Microsoft.AspNetCore.Mvc;

namespace consumeRESTAPI_ClientSide.Controllers
{
    public class ExternalDataController : Controller
    {
        public IActionResult PostData()
        {
            return View();
        }
    }
}
