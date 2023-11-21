//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gemini.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PosCategory
    {
        public PosCategory()
        {
            this.PosProduces = new HashSet<PosProduce>();
        }
    
        public System.Guid Guid { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
        public Nullable<System.Guid> ParentGuid { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public string SeoFriendUrl { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
    
        public virtual ICollection<PosProduce> PosProduces { get; set; }
    }
}