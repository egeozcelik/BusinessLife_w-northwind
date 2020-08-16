using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLife.BLL
{
    public class FactoryBuilder
    {
        public IRepository createRepositoryInstance(Olusturucu olusturucu)
        {
            IRepository repo = null;
            switch (olusturucu)
            {
                case Olusturucu.Category:
                    repo = new CategoryRepository();
                    break;
                case Olusturucu.Supplier:
                    
                    break;
                case Olusturucu.Customer:
                    break;
                default:
                    repo = new ProductRepository();
                    break;
            }
            return repo;
        }
    }


   
    public enum Olusturucu
    {
        Category,
        Product,
        Supplier,
        Customer
    }
}
