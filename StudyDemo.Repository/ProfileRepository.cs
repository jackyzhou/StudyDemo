using StudyDemo.DAL;
using StudyDemo.Domain.Profile;

namespace StudyDemo.Repository
{
    public class ProfileRepository : Repository<ProfileAggregate>, IProfileRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public ProfileRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
