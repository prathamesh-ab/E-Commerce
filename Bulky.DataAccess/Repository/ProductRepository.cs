using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using BulkyWeb.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        
        public void Update(Product obj)
        {
            //_db.Products.Update(obj);
            Product productFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (productFromDb != null) { 
                productFromDb.Title = obj.Title;
                productFromDb.Description = obj.Description;
                productFromDb.Category = obj.Category;
                productFromDb.ISBN = obj.ISBN;
                productFromDb.Author = obj.Author;
                productFromDb.ListPrice = obj.ListPrice;
                productFromDb.Price = obj.Price;
                productFromDb.Price50 = obj.Price50;
                productFromDb.Price100 = obj.Price100;
                if (obj.ImageUrl != null)  // ✅ This is correct
                {
                    productFromDb.ImageUrl = obj.ImageUrl;
                }

            }
        }
    
    }
}
