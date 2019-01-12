using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RefFinder.server2.Models.Mapping
{
    public class FieldMap : EntityTypeConfiguration<Field>
    {
        public FieldMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(50);

            this.Property(t => t.Suburb)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.PostalCode)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Fields");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Suburb).HasColumnName("Suburb");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
        }
    }
}
