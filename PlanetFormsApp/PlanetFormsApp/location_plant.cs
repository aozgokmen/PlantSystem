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
    
    public partial class location_plant
    {
        public int id { get; set; }
        public Nullable<int> location_id { get; set; }
        public Nullable<int> plant_id { get; set; }
    
        public virtual locations locations { get; set; }
        public virtual plants plants { get; set; }
    }
}
