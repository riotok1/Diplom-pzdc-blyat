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
    
    public partial class Supply
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int WorkersID { get; set; }
        public int Count { get; set; }
        public double TotalSum { get; set; }
        public Nullable<System.DateTime> YesterdayDate { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Workers Workers { get; set; }
    }
}
