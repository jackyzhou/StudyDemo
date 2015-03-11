using StudyDemo.DAL;
using StudyDemo.Domain.Phone;

namespace StudyDemo.Repository
{
    public class PhoneRepository : Repository<PhoneAggregate>, IPhoneRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public PhoneRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
