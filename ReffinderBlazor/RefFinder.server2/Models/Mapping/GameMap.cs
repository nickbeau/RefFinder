using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RefFinder.server2.Models.Mapping
{
    public class GameMap : EntityTypeConfiguration<Game>
    {
        public GameMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HomeTeam)
                .HasMaxLength(50);

            this.Property(t => t.AwayTeam)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Games");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.HomeTeam).HasColumnName("HomeTeam");
            this.Property(t => t.AwayTeam).HasColumnName("AwayTeam");
            this.Property(t => t.Referee).HasColumnName("Referee");
            this.Property(t => t.Field).HasColumnName("Field");
        }
    }
}
