using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models {
    class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "Fotball", Price = 25},
            new Product { Name = "Surf board", Price = 179},
            new Product { Name = "Ruuning shoes", Price = 95}
        }.AsQueryable<Product>();
    }
}