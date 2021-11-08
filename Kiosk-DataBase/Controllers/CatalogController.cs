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

        [HttpGet]
        public IActionResult Show()
        {
            var products = _dbInteraction.GetAllProducts();
            return View(products);
        }

        [HttpPost]
        public IActionResult Show(Product[] product)
        {
            return View();
        }
    }
}