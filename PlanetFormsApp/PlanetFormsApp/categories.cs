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
    
    public partial class categories
    {
        public categories()
        {
            this.plants = new HashSet<plants>();
        }
    
        public int id { get; set; }
        public string category_name { get; set; }
    
        public virtual ICollection<plants> plants { get; set; }
    }
}
