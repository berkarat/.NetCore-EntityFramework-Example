using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkExample.Repository.Abstract
{
    public interface IProductRepository
    {
        void AddProduct(Product prd);
        void DeleteProduct(Product prd);
        void EditProduct(Product prd);
        IEnumerable<Product> GetAllProduct();
        Product GetSelectedProduct(int productid);
    }
}
