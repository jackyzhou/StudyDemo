﻿using StudyDemo.Domain.Phone;
using System.Data.Entity.ModelConfiguration;

namespace StudyDemo.DAL.EntityConfiguration
{
    class PhoneTypeConfiguration: EntityTypeConfiguration<PhoneType>
    {
        public PhoneTypeConfiguration()
        {
            this.HasKey(pt => pt.PhoneTypeId);
            this.Property(pt => pt.Name).HasMaxLength(50).IsRequired();

            //configure table map
            this.ToTable("PhoneType");
        }
    }
}
