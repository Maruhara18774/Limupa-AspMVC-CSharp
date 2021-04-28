//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER
    {
        public string ORDER_ID { get; set; }
        public string ACCOUNT_ID { get; set; }
        public string SHIP_ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string CREATE_DATE { get; set; }
        public string PAYMENT_ID { get; set; }
        public string STATUS_ID { get; set; }
        public Nullable<double> DISCOUNT { get; set; }
        public Nullable<double> TOTAL { get; set; }
        public string CART_ID { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual CART CART { get; set; }
        public virtual PAYMENT PAYMENT { get; set; }
        public virtual ORDERSTATU ORDERSTATU { get; set; }
    }
}