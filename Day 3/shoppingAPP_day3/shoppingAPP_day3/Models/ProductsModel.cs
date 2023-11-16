using System.Reflection;

namespace shoppingAPP_day3.Models
{
    public class ProductsModel
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        #endregion

        #region Collection Data - Model

        private static List<ProductsModel> _productsList = new List<ProductsModel>()
        {
            new ProductsModel { pId = 1, pName = "Iphone", pCategory = "Smart Phone", pIsInStock = true, pPrice = 150000 },
            new ProductsModel { pId = 2, pName = "AirPods", pCategory = "Accessory", pIsInStock = false, pPrice = 26000 },
            new ProductsModel { pId = 3, pName = "Nike Air", pCategory = "Shoes", pIsInStock = true, pPrice = 12000 },
            new ProductsModel { pId = 4, pName = "Pepsi", pCategory = "Cold-Drink", pIsInStock = true, pPrice = 80 },
            new ProductsModel { pId = 5, pName = "Maggie", pCategory = "FastFood", pIsInStock = true, pPrice = 120 },
            new ProductsModel { pId = 6, pName = "Super Dry", pCategory = "TShirt", pIsInStock = false, pPrice = 2800 },
            new ProductsModel { pId = 7, pName = "Jeep Compass", pCategory = "SUV", pIsInStock = true, pPrice = 2800000 },
        };

        #endregion

        #region Select / Get data
        public List<ProductsModel> GetAllProducts()
        {
            return _productsList;
        }

        public ProductsModel GetProductById(int id)
        {
            var p = _productsList.Find(p => p.pId == id);
            if (p == null)
            {
                throw new Exception("Product not found");
            }
            return p;
        }

        public List<ProductsModel> GetProductsByCategory(string category)
        {
            var p = _productsList.FindAll(p => p.pCategory == category);
            if (p == null)
            {
                throw new Exception("No product found");
            }
            return p;
        }

        #endregion

        #region Add, Update and Delete methods
        public string AddNewProduct(ProductsModel model)
        {
            //we can do data validation here before adding the model to collection/db 
            //eg. if(model.pName.Length < 3){ thrown new exception("message")}
            _productsList.Add(model);
            return "Product Added Successfully";
        }

        public string EditProduct(ProductsModel model)
        {
            var p = _productsList.Find(pr => pr.pId == model.pId);
            if (p != null)
            {
                p.pName = model.pName;
                p.pCategory = model.pCategory;
                p.pPrice = model.pPrice;
                p.pIsInStock = model.pIsInStock;
                return "Product Details moadified successfully";

            }
            throw new Exception("Product Not Found");
        }

        public string DeleteProduct(int id)
        {
            var p = _productsList.Find(pr => pr.pId == id);
            if (p == null)
            {
                throw new Exception("Product Not Found");
            }
            _productsList.Remove(p);
            return "Product Deleted Successfully";
        }
        #endregion
    }
}























