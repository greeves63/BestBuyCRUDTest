using System;
using System.Collections.Generic;

namespace BestBuyCRUDTest
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts();

        void InsertProduct(string newProductName);

        public void CreateProduct(string name, int price, int categoryID);
        
    }

    
}
