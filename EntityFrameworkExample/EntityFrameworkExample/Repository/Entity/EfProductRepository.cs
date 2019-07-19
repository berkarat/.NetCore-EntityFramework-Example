using EntityFrameworkExample.Models;
using EntityFrameworkExample.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkExample.Repository.Entity
{
    public class EfProductRepository : IProductRepository
    {
        private AppDbContext context;
        public EfProductRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void AddProduct(Product prd)
        {
            context.Add(prd);
        }

        public void DeleteProduct(Product prd)
        {
            context.Remove(prd);
        }

        public void EditProduct(Product prd)
        {
            context.Entry(prd).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return context.Products.ToList();
        }

        public Product GetSelectedProduct(int productid)
        {
           return context.Products.Find(productid);
        }
    }
}
