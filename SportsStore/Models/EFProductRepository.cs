using System.Linq;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository{
        private MyDbContext context;

        public EFProductRepository(MyDbContext ctxt){
            context = ctxt;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
