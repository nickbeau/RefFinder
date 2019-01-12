using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RefFinder.server2.Models.Mapping
{
    public class RefereeMap : EntityTypeConfiguration<Referee>
    {
        public RefereeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Referee_ID)
                .HasMaxLength(50);

            this.Property(t => t.FirstName)
                .HasMaxLength(128);

            this.Property(t => t.LastName)
                .HasMaxLength(128);

            this.Property(t => t.Email)
                .HasMaxLength(255);

            this.Property(t => t.Phone)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Referees");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Referee_ID).HasColumnName("Referee ID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.AssociationID).HasColumnName("AssociationID");

            // Relationships
            this.HasOptional(t => t.Association)
                .WithMany(t => t.Referees)
                .HasForeignKey(d => d.AssociationID);

        }
    }
}
