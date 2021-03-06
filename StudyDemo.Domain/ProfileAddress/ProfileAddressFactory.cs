﻿using StudyDemo.Domain.Address;
using StudyDemo.Domain.Profile;
using System;

namespace StudyDemo.Domain.ProfileAddress
{
    /// <summary>
    /// This is the factory for Phone creation
    /// </summary>
    public static class ProfileAddressFactory
    {
        public static ProfileAddressAggregate ProfileAddress(ProfileAggregate profile, AddressAggregate address, 
            AddressType addressType, string createdBy, DateTime created, string updatedBy, DateTime updated)
        {
            ProfileAddressAggregate objProfileAddress = new ProfileAddressAggregate();

            //Set values for Address
            objProfileAddress.Created = created;
            objProfileAddress.CreatedBy = createdBy;
            objProfileAddress.Updated = updated;
            objProfileAddress.UpdatedBy = updatedBy;

            //Associate Profile for this Profile Phone
            objProfileAddress.ProfileId = profile.ProfileId;

            //Associate Address for this Profile Phone
            objProfileAddress.AddressId = address.AddressId;

            //Associate AddressTye for this Profile Phone
            objProfileAddress.AddressTypeId = addressType.AddressTypeId;

            return objProfileAddress;
        }

    }
}
