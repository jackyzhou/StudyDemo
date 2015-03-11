using StudyDemo.Domain.ProfileAddress;
using StudyDemo.Domain.ProfilePhone;
using StudyDemo.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StudyDemo.Framework.Core;

namespace StudyDemo.Domain.Profile
{
    public partial class ProfileAggregate  : Entity, IValidatableObject
    {
       #region Constructor

        public ProfileAggregate()
        {
            this.ProfileAddresses = new HashSet<ProfileAddressAggregate>();
            this.ProfilePhones = new HashSet<ProfilePhoneAggregate>();
        }

        #endregion Constructor

        #region Properties
        [Key]
        public int ProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<ProfileAddressAggregate> ProfileAddresses { get; set; }
        public virtual ICollection<ProfilePhoneAggregate> ProfilePhones { get; set; }

        #endregion Properties

        #region IValidatableObject Members

        /// <summary>
        /// This will validate entity for all  the conditions
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();

            //-->Check FirstName property
            if (String.IsNullOrWhiteSpace(this.FirstName))
            {
                validationResults.Add(new ValidationResult(Messages.validation_ProfileFirstNameCannotBeNull,
                                                           new string[] { "AddressLine1" }));
            }

            //-->Check LastName property
            if (String.IsNullOrWhiteSpace(this.LastName))
            {
                validationResults.Add(new ValidationResult(Messages.validation_ProfileLastNameCannotBeBull,
                                                           new string[] { "AddressLine2" }));
            }

            //-->Check Email property
            if (String.IsNullOrWhiteSpace(this.Email))
            {
                validationResults.Add(new ValidationResult(Messages.validation_ProfileEmailCannotBeBull,
                                                           new string[] { "ZipCode" }));
            }

            return validationResults;
        }

        #endregion

    }
}
