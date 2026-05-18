using Microsoft.AspNetCore.Mvc;

namespace WarehouseManager.Ui.Mvc.Controllers
{
    public class StockManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
