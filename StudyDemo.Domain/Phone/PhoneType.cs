using StudyDemo.Domain.ProfilePhone;
using StudyDemo.Framework.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyDemo.Domain.Phone
{
    public class PhoneType : Entity
    {
        #region Constructor

        public PhoneType()
        {
            this.ProfilePhones = new HashSet<ProfilePhoneAggregate>();
        }

        #endregion Constructor

        #region Property

        [Key]
        public int PhoneTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProfilePhoneAggregate> ProfilePhones { get; set; }

        #endregion Property

    }
}
