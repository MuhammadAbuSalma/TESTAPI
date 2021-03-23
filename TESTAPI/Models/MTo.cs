using System;
using System.Collections.Generic;

#nullable disable

namespace TESTAPI.Models
{
    public partial class MTo
    {
        public Guid ToID { get; set; }
        public string To { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
    }
}
