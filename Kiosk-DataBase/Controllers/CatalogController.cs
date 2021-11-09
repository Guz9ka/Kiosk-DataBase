using Kiosk_DataBase.Models;
using Kiosk_DataBase.PersistentLayer;
using Microsoft.AspNetCore.Mvc;

namespace Kiosk_DataBase.Controllers
{
    public class CatalogController : Controller
    {
        private DataBaseInteractionPostgreSQL _dbInteraction;

        public CatalogController(DataBaseInteractionPostgreSQL dataBaseInteraction)
        {
            _dbInteraction = dataBaseInteraction;
        }

        public IActionResult Show()
        {
            var products = _dbInteraction.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = _dbInteraction.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            _dbInteraction.UpdateProduct(product);
            return RedirectToAction("Show");
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            _dbInteraction.DeleteProduct(product.DataBaseId);
            return RedirectToAction("Show");
        }
    }
}