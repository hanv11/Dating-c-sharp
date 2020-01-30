using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dating.Models
{
    public class CheckoutViewModel
    {
        public string OrderCategory { get; set; }
        public decimal Amount { get; set; }
        public string OrderDescription { get; set; }
        public string Bank { get; set; }
        public string Language { get; set; }
    }
}