using StudyDemo.Domain.Phone;
using System.Data.Entity.ModelConfiguration;

namespace StudyDemo.DAL.EntityConfiguration
{
    class PhoneConfiguration : EntityTypeConfiguration<PhoneAggregate>
    {
        public PhoneConfiguration()
        {
            this.HasKey(p => p.PhoneId);
            this.Property(p => p.Number).HasMaxLength(25).IsRequired();

            //configure table map
            this.ToTable("Phone");
        }
    }
}
