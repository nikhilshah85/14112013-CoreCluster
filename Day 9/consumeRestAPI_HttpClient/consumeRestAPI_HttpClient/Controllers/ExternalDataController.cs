using Microsoft.AspNetCore.Mvc;
using consumeRestAPI_HttpClient.Models;

namespace consumeRestAPI_HttpClient.Controllers
{
    public class ExternalDataController : Controller
    {

        PostModel postModel = new PostModel(); //this is crime, we should use Dependency injection instead
        public IActionResult PostDetails()
        {

            ViewBag.post = postModel.getPostModels();
            return View();
        }
    }
}
