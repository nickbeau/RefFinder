using System;
using System.Collections.Generic;

namespace RefFinder.server2.Models
{
    public partial class Association
    {
        public Association()
        {
            this.Referees = new List<Referee>();
        }

        public System.Guid id { get; set; }
        public string Acronym { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Referee> Referees { get; set; }
    }
}
