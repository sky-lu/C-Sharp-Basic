//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hi_Tech_Order_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public string OrderId { get; set; }
        public string OrderType { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime RequiredDate { get; set; }
        public System.DateTime ShippingDate { get; set; }
        public string OrderStatus { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
    }
}
