using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLife.DAL
{
    public class SingleObject
    {
        private static NorthwindEntities1 _instance;
        public static NorthwindEntities1 getInstance()
        {
            if (_instance == null)
            {
                _instance = new NorthwindEntities1();
            }
            return _instance;
        }
    }
}
