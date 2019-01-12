using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RefFinder.server2.Models.Mapping
{
    public class AssociationMap : EntityTypeConfiguration<Association>
    {
        public AssociationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Acronym)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Associations");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Acronym).HasColumnName("Acronym");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
