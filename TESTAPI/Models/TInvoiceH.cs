using System;
using System.Collections.Generic;

#nullable disable

namespace TESTAPI.Models
{
    public partial class TInvoiceH
    {
        public string InvoiceHID { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string Fr { get; set; }
        public string ToID { get; set; }
        public DateTime Date { get; set; }
        public DateTime InvoiceDue { get; set; }
        public string Pono { get; set; }
        public string Discount { get; set; }
        public string Percent { get; set; }
    }
}
