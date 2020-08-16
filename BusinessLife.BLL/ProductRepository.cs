using BusinessLife.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLife.BLL
{
    public class ProductRepository : IRepository
    {
        NorthwindEntities1 db = SingleObject.getInstance();
        public List<Product> GetProductList()
        {
            return db.Products.ToList();
        }

        public bool InsertProduct(Product p)
        {
            bool result = true;
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool UpdateProduct(Product p)
        {
            bool result = true;
            try
            {
                Product updateProduct = db.Products.
                  FirstOrDefault(z => z.ProductID == p.ProductID);

                updateProduct.ProductName = p.ProductName;
                updateProduct.UnitsInStock = p.UnitsInStock;
                updateProduct.UnitPrice = p.UnitPrice;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool DeleteProduct(int Id)
        {
            bool result = true;
            try
            {
                Product p = db.Products.FirstOrDefault(z => z.ProductID == Id);
                db.Products.Remove(p);
                db.SaveChanges();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public Product SelectById(int Id)
        {
            return db.Products.FirstOrDefault(z => z.ProductID == Id);
        }
    }
}
