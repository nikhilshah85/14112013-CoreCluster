using Microsoft.AspNetCore.Mvc;
using shoppingAPP_day3.Models;
namespace shoppingAPP_day3.Controllers
{
    public class ProductsController : Controller
    {
        
        ProductsModel _productsModel = new ProductsModel(); //this is a crime, we should use DI instead, which we will study later


        public IActionResult ViewAllProducts()
        {
            ViewBag.Products = _productsModel.GetAllProducts();
            return View();
        }


        [HttpGet]
        public IActionResult ViewProductById() 
        {
            ViewBag.ProductById = null;
            return View();
        }

        [HttpPost]
        public IActionResult ViewProductById(int id) 
        {

            try
            {
                ViewBag.ProductById = _productsModel.GetProductById(id);
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }




        public IActionResult ViewProductByCategory()
        {
            ViewBag.Category = null;
            return View();
        }


       [HttpPost]
        public IActionResult ViewProductByCategory(string category)
        {
            try
            {
                ViewBag.Category = _productsModel.GetProductsByCategory(category);
                return View();
            } catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }













    }
}
