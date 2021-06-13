using Dining_Room.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dining_Room.DB
{
    partial class Dish
    {
        public string fullDish
        {
            get
            {
                return NameOfDish + ", стоимость: " + Price;
            }
        }

        public string CountDish
        {
            get
            {
                var CurrenDish = ConnectClass.db.Dish.FirstOrDefault(item => item.ID == this.ID);
                var CountDish = CurrenDish.Count;
                int Count = ConnectClass.db.YesterdayMenu.Where(item => item.DishID == this.ID).Count();
                return (CountDish - Count).ToString();
            }
        }
    }
}
