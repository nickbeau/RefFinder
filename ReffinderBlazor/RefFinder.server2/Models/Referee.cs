using System;
using System.Collections.Generic;

namespace RefFinder.server2.Models
{
    public partial class Referee
    {
        public System.Guid id { get; set; }
        public string Referee_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.Guid> AssociationID { get; set; }
        public virtual Association Association { get; set; }
    }
}
