//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dining_Room.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class DishBacket
    {
        public int ID { get; set; }
        public int DishID { get; set; }
        public int WorkerID { get; set; }
        public double TotalSum { get; set; }
        public System.DateTime YesterdayDate { get; set; }
        public int Count { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Workers Workers { get; set; }
    }
}