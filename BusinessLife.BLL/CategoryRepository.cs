using BusinessLife.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLife.BLL
{
    public class CategoryRepository : IRepository
    {
        NorthwindEntities1 db = SingleObject.getInstance();
        public List<Category> GetCategoryList()
        {
            return db.Categories.ToList();
        }

        public bool InsertCategory(Category c)
        {
            bool result = true;
            try

            {
                db.Categories.Add(c);
                db.SaveChanges();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool UpdateCategory(Category c)
        {
            bool result = true;
            try
            {
                //Category updateCategory =
                //    (from x in db.Categories
                //     where x.CategoryID == c.CategoryID
                //     select x).FirstOrDefault();

                //Category updateCategory = db.Categories.
                //    Where(z => z.CategoryID == c.CategoryID).FirstOrDefault();

                Category updateCategory = db.Categories.
                  FirstOrDefault(z => z.CategoryID == c.CategoryID);

                updateCategory.CategoryName = c.CategoryName;
                updateCategory.Description = c.Description;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool DeleteCategory(int Id)
        {
            bool result = true
;
            try
            {
                Category c = db.Categories.FirstOrDefault(z => z.CategoryID == Id);
                db.Categories.Remove(c);
                db.SaveChanges();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public Category SelectById(int Id)
        {
            return db.Categories.FirstOrDefault(z => z.CategoryID == Id);
        }

    }
}
