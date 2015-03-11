using StudyDemo.DAL;
using StudyDemo.Domain.Address;

namespace StudyDemo.Repository
{
    public class AddressRepository : Repository<AddressAggregate>, IAddressRepository
    {
        #region Constructor

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public AddressRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}
