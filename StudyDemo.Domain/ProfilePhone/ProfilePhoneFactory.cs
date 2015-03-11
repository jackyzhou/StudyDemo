using StudyDemo.Domain.Phone;
using StudyDemo.Domain.Profile;
using System;

namespace StudyDemo.Domain.ProfilePhone
{
    /// <summary>
    /// This is the factory for Profile Phone association 
    /// </summary>
    public static class ProfilePhoneFactory
    {
        /// <summary>
        /// Create a New ProfilePhone
        /// </summary>
        /// <param name="profile"></param>
        /// <param name="phone"></param>
        /// <param name="phoneType"></param>
        /// <param name="createdBy"></param>
        /// <param name="created"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updated"></param>
        /// <returns></returns>
        public static ProfilePhoneAggregate CreateProfilePhone(ProfileAggregate profile, PhoneAggregate phone, 
            PhoneType phoneType, string createdBy, DateTime created, string updatedBy, DateTime updated)
        {
            ProfilePhoneAggregate objProfilePhone = new ProfilePhoneAggregate();

            //Set values for Address
            objProfilePhone.Created = created;
            objProfilePhone.CreatedBy = createdBy;
            objProfilePhone.Updated = updated;
            objProfilePhone.UpdatedBy = updatedBy;

            //Associate Profile for this Profile Phone
            objProfilePhone.ProfileId = profile.ProfileId;
            //Associate Phone for this Profile Phone
            objProfilePhone.PhoneId = phone.PhoneId;
            //Associate PhoneTye for this Profile Phone
            objProfilePhone.PhoneTypeId = phoneType.PhoneTypeId;
            return objProfilePhone;
        }

    }
}
