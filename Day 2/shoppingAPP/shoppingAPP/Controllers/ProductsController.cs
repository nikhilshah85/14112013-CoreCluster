using Microsoft.AspNetCore.Mvc;

namespace shoppingAPP.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult ProductList()
        {
            //collect data from Models


            List<string> productsCategory = new List<string>()
            {
                "TShirts","Shoes","Accessories","Ëlectronics","Jeans","Mobiles"
            };

            List<string> products = new List<string>()
            {
                "Nike","Apple","Adidas","Samsung Galaxy","Flying Machine","Super Dry"
            };

            ViewBag.ProductsCategory = productsCategory;
            ViewBag.Products = products;



            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult HotSellingProducts()
        {
            return View();
        }

        public IActionResult Offers()
        {
            return View();
        }




      
    }
}
