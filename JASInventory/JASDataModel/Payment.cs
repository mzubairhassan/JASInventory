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
    
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public string Status { get; set; }
        public System.DateTime TimeLimit { get; set; }
        public double Amount { get; set; }
        public string PayementType { get; set; }
    
        public virtual Receipt_Purchase Receipt_Purchase { get; set; }
        public virtual Receipt_Sale Receipt_Sale { get; set; }
    }
}
