//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serveit.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceiptHistory
    {
        public int Rt_id { get; set; }
        public string Type { get; set; }
        public string Table_id { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> Due { get; set; }
    }
}
