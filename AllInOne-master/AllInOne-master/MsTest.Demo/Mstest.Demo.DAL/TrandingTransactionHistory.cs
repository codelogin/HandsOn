//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mstest.Demo.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrandingTransactionHistory
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public string UserId { get; set; }
        public string TransactionType { get; set; }
        public string StatusType { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int Quantity { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
