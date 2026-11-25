using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class GymUserConfiguration<T>: IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(u => u.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(u => u.PhoneNumber).HasColumnType("varchar").HasMaxLength(11);
            builder.ComplexProperty(u => u.Address);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.PhoneNumber).IsUnique();

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("GymUser_EmailCheck", "Email LIKE '_%@_%._%'");
                t.HasCheckConstraint("GymUser_PhoneNumberCheck", "LEN(PhoneNumber) = 11 AND (PhoneNumber LIKE '010%' OR PhoneNumber LIKE '011%' OR PhoneNumber LIKE '012%' OR PhoneNumber LIKE '015%')");
            });
        }
    }
}
