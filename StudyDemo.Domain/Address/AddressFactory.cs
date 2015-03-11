﻿using System;

namespace StudyDemo.Domain.Address
{
    /// <summary>
    /// This is the factory for Address creation
    /// </summary>
    public static class AddressFactory
    {
        /// <summary>
        /// Create a New Address
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="createdBy"></param>
        /// <param name="created"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updated"></param>
        /// <returns></returns>
        public static AddressAggregate CreateAddress(string line1, string line2, string city, string state, string country, string zipCode, string createdBy, DateTime created, string updatedBy, DateTime updated)
        {
            AddressAggregate objAddress = new AddressAggregate();

            //Set values for Address
            objAddress.AddressLine1 = line1;
            objAddress.AddressLine2 = line2;
            objAddress.Country = country;
            objAddress.State = state;
            objAddress.City = city;
            objAddress.ZipCode = zipCode;
            objAddress.Created = created;
            objAddress.CreatedBy = createdBy;
            objAddress.Updated = updated;
            objAddress.UpdatedBy = updatedBy;
            
            return objAddress;
        }
    }
}