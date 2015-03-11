using StudyDemo.Framework.Core.Specification;
using StudyDemo.Framework.Core.Specification.Implementation;
using StudyDemo.Domain.Profile;


namespace StudyDemo.Domain.ProfileAddress
{
    /// <summary>
    /// A list of Profile specification
    /// </summary>
    public static class ProfileSpecification
    {

        /// <summary>
        /// Profile with firstName or LastName or Email equal to
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <returns>Associated specification for this creterion</returns>
        public static Specification<ProfileAggregate> GetProfileByFilter(string firstName, string lastName, string email)
        {
            Specification<ProfileAggregate> specProfile = new TrueSpecification<ProfileAggregate>();

            if ( !string.IsNullOrEmpty(firstName))
                specProfile &= new DirectSpecification<ProfileAggregate>(p => p.FirstName.Contains(firstName));

            if (!string.IsNullOrEmpty(lastName))
                specProfile &= new DirectSpecification<ProfileAggregate>(p => p.LastName.Contains(lastName));

            if (!string.IsNullOrEmpty(email))
                specProfile &= new DirectSpecification<ProfileAggregate>(p => p.Email.Contains(email));

            return specProfile;
        }

    }
}
