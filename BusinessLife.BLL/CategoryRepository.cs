using BusinessLife.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLife.BLL
{
    public class CategoryRepository
    {
        NorthwindEntities db = new NorthwindEntities();
        public List<Category> GetCategoryList()
        {
            return db.Categories.ToList();
        }

    }
}
