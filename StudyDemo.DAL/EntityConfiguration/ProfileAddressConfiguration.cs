﻿using StudyDemo.Domain.ProfileAddress;
using System.Data.Entity.ModelConfiguration;

namespace StudyDemo.DAL.EntityConfiguration
{
    class ProfileAddressConfiguration : EntityTypeConfiguration<ProfileAddressAggregate>
    {
        public ProfileAddressConfiguration()
        {
            this.HasKey(pa => pa.ProfileAddressId);
            // 1..*
            this.HasRequired(pa => pa.Address)
                .WithMany(pa => pa.ProfileAddresses)
                .HasForeignKey(pa => pa.AddressId)
                .WillCascadeOnDelete(false);

            // 1..*
            this.HasRequired(pa => pa.AddressType)
                .WithMany(pa => pa.ProfileAddresses)
                .HasForeignKey(pa => pa.AddressTypeId)
                .WillCascadeOnDelete(false);

            // 1..*
            this.HasRequired(pa => pa.Profile)
                .WithMany(pa => pa.ProfileAddresses)
                .HasForeignKey(pa => pa.ProfileId)
                .WillCascadeOnDelete(true);

            //configure table map
            this.ToTable("ProfileAddress");
        }
    }
}
