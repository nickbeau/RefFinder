using System;
using System.Collections.Generic;

namespace RefFinder.server2.Models
{
    public partial class Field
    {
        public System.Guid id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
