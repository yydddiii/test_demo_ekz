//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo_ekz.DataApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int id { get; set; }
        public string article { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public decimal price { get; set; }
        public decimal max_sale { get; set; }
        public string manufacturer { get; set; }
        public int provider_id { get; set; }
        public int categoty_id { get; set; }
        public decimal real_sale { get; set; }
        public int count { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    
        public virtual Categoty Categoty { get; set; }
        public virtual Provider Provider { get; set; }
    }
}