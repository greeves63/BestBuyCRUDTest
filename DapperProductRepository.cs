using System;
using System.Collections.Generic;

namespace BestBuyCRUDTest
{
    public class DapperProductRepository : IProductRepository
    {
        public DapperProductRepository()
        {
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(string newProductName)
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(string newProductName)
        {
            throw new NotImplementedException();
        }
    }
}
