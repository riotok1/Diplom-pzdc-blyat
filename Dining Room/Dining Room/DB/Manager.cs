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
    
    public partial class Manager
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int SignID { get; set; }
    
        public virtual SignIn SignIn { get; set; }
    }
}
