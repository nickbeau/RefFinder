using System;
using System.Collections.Generic;

namespace RefFinder.server2.Models
{
    public partial class Game
    {
        public System.Guid id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public Nullable<System.Guid> Referee { get; set; }
        public Nullable<System.Guid> Field { get; set; }
    }
}
