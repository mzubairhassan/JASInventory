//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JASDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.Receipt_Purchase = new HashSet<Receipt_Purchase>();
        }
    
        public byte[] ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
    
        public virtual ICollection<Receipt_Purchase> Receipt_Purchase { get; set; }
    }
}
