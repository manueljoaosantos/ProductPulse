using ProductPulse.Core.Interfaces;
using ProductPulse.Core.Models;

namespace ProductPulse.Infra.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
