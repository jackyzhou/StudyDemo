using StudyDemo.DAL;
using StudyDemo.Domain.ProfilePhone;

namespace StudyDemo.Repository
{
    public class ProfilePhoneRepository : Repository<ProfilePhoneAggregate>, IProfilePhoneRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public ProfilePhoneRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion
    }
}
