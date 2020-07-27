using System;
using System.Collections.Generic;
using System.Text;


namespace BestBuyCRUDTest
{
    public interface IProductRepository
    {

        public IEnumerable<Products> GetAllProducts();

        public Products GetProduct(int ProductID);

        public void InsertProduct(string name, double price, int categoryID);
        
    }

    
}
