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
            return View();
        }
    }
}