using Microsoft.EntityFrameworkCore;
using WarehouseManager.Models;
using WarehouseManager.Repository;

namespace WarehouseManager.Services
{
    public class ArticleService(WarehouseManagerDbContext dbContext)
    {
        public IList<Article> Find()
        {
            return dbContext.Articles
                .ToList();
        }
    }
}
