//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanetFormsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class sales
    {
        public int id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> plant_id { get; set; }
        public Nullable<int> location_id { get; set; }
        public Nullable<int> farmer_id { get; set; }
        public Nullable<int> sales_price { get; set; }
        public Nullable<bool> isBuy { get; set; }
    
        public virtual customers customers { get; set; }
        public virtual farmers farmers { get; set; }
        public virtual locations locations { get; set; }
        public virtual plants plants { get; set; }
    }
}
