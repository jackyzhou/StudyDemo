﻿using StudyDemo.Domain.Address;
using System.Data.Entity.ModelConfiguration;

namespace StudyDemo.DAL.EntityConfiguration
{
    class AddressConfiguration : EntityTypeConfiguration<AddressAggregate>
    {
        public AddressConfiguration()
        {
            this.HasKey(a => a.AddressId);
            this.Property(a => a.AddressLine1).HasMaxLength(100).IsRequired();
            this.Property(a => a.AddressLine2).HasMaxLength(100).IsRequired();
            this.Property(a => a.Country).HasMaxLength(50).IsRequired();
            this.Property(a => a.State).HasMaxLength(50).IsRequired();
            this.Property(a => a.City).HasMaxLength(50).IsRequired();
            this.Property(a => a.ZipCode).HasMaxLength(15).IsRequired();
            //configure table map
            this.ToTable("Address");
        }
    }
}
