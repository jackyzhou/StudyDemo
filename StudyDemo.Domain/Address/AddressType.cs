using StudyDemo.Domain.ProfileAddress;
using StudyDemo.Framework.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyDemo.Domain.Address
{
    public class AddressType : Entity
    {
        
        #region Constructor

        public AddressType()
        {
            this.ProfileAddresses = new HashSet<ProfileAddressAggregate>();
        }

        #endregion Constructor

        #region Property

        [Key]
        public int AddressTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProfileAddressAggregate> ProfileAddresses { get; set; }

        #endregion Property

    }
}
