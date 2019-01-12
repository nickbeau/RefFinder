using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RefFinder.server2.Models.Mapping;

namespace RefFinder.server2.Models
{
    public partial class RefFinderContext : DbContext
    {
        static RefFinderContext()
        {
            Database.SetInitializer<RefFinderContext>(null);
        }

        public RefFinderContext()
            : base("Name=RefFinderContext")
        {
        }

        public DbSet<Association> Associations { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AssociationMap());
            modelBuilder.Configurations.Add(new FieldMap());
            modelBuilder.Configurations.Add(new GameMap());
            modelBuilder.Configurations.Add(new RefereeMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
