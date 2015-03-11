using StudyDemo.Domain.Profile;
using System.Data.Entity.ModelConfiguration;

namespace StudyDemo.DAL.EntityConfiguration
{
    class ProfileConfiguration : EntityTypeConfiguration<ProfileAggregate>
    {
        public ProfileConfiguration()
        {
            this.HasKey(p => p.ProfileId);
            this.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            this.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            this.Property(p => p.Email).HasMaxLength(50).IsRequired();

            //configure table map
            this.ToTable("Profile");
        }
    }
}
