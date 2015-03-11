using StudyDemo.DAL;
using StudyDemo.Domain.ProfileAddress;

namespace StudyDemo.Repository
{
    public class ProfileAddressRepository : Repository<ProfileAddressAggregate>, IProfileAddressRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public ProfileAddressRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
