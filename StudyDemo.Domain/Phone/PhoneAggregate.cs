using StudyDemo.Domain.ProfilePhone;
using StudyDemo.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StudyDemo.Framework.Core;

namespace StudyDemo.Domain.Phone
{
    public partial class PhoneAggregate : Entity, IValidatableObject
    {
        #region Constructor

        public PhoneAggregate()
        {
            this.ProfilePhones = new HashSet<ProfilePhoneAggregate>();
        }

        #endregion Constructor

        #region Property

        [Key]
        public int PhoneId { get; set; }
        public string Number { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<ProfilePhoneAggregate> ProfilePhones { get; set; }

        #endregion Property

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
            if (String.IsNullOrWhiteSpace(this.Number))
            {
                validationResults.Add(new ValidationResult(Messages.validation_PhoneNumberCannotBeNull,
                                                           new string[] { "Number" }));
            }

            return validationResults;
        }

        #endregion

    }
}
