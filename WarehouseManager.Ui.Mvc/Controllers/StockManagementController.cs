using Microsoft.AspNetCore.Mvc;
using WarehouseManager.Services;

namespace WarehouseManager.Ui.Mvc.Controllers
{
    public class StockManagementController(ArticleService articleService) : Controller
    {
        public IActionResult Index()
        {
            var article = articleService.Find();
            return View(article);
        }
    }
}
