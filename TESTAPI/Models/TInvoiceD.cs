using System;
using System.Collections.Generic;

#nullable disable

namespace TESTAPI.Models
{
    public partial class TInvoiceD
    {
        public Guid InvoiceDetailID { get; set; }
        public string InvoiceHID { get; set; }
        public string Name { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
