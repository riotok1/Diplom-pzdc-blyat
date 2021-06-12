using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dining_Room.DB
{
    partial class Products
    {
        public string fullProduct
        {
            get
            {
                return ProductName + ", цена: " + Price; 
            }
        }
    }
}
