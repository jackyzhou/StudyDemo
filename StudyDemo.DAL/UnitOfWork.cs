using StudyDemo.DAL.Contract;
using StudyDemo.DAL.EntityConfiguration;
using StudyDemo.Domain.Address;
using StudyDemo.Domain.Phone;
using StudyDemo.Domain.Profile;
using StudyDemo.Domain.ProfileAddress;
using StudyDemo.Domain.ProfilePhone;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace StudyDemo.DAL
{
    public class UnitOfWork : DbContext, IQueryableUnitOfWork
    {
        #region Constructor

        public UnitOfWork()
            : base("name=StudyDemo.DAL.UnitOfWork")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        #endregion Constructor

        #region IDbSet Members

        IDbSet<AddressAggregate> _address;
        public IDbSet<AddressAggregate> Address
        {
            get
            {
                if (_address == null)
                    _address = base.Set<AddressAggregate>();

                return _address;
            }
        }

        IDbSet<AddressType> _addressType;
        public IDbSet<AddressType> AddressType
        {
            get
            {
                if (_addressType == null)
                    _addressType = base.Set<AddressType>();

                return _addressType;
            }
        }

        IDbSet<PhoneAggregate> _phone;
        public IDbSet<PhoneAggregate> Countries
        {
            get
            {
                if (_phone == null)
                    _phone = base.Set<PhoneAggregate>();

                return _phone;
            }
        }

        IDbSet<PhoneType> _phoneType;
        public IDbSet<PhoneType> PhoneType
        {
            get
            {
                if (_phoneType == null)
                    _phoneType = base.Set<PhoneType>();

                return _phoneType;
            }
        }

        IDbSet<ProfileAddressAggregate> _profileAddress;
        public IDbSet<ProfileAddressAggregate> ProfileAddress
        {
            get
            {
                if (_profileAddress == null)
                    _profileAddress = base.Set<ProfileAddressAggregate>();

                return _profileAddress;
            }
        }

        IDbSet<ProfileAggregate> _profile;
        public IDbSet<ProfileAggregate> Profile
        {
            get
            {
                if (_profile == null)
                    _profile = base.Set<ProfileAggregate>();

                return _profile;
            }
        }

        IDbSet<ProfilePhoneAggregate> _profilePhone;
        public IDbSet<ProfilePhoneAggregate> ProfilePhone
        {
            get
            {
                if (_profilePhone == null)
                    _profilePhone = base.Set<ProfilePhoneAggregate>();

                return _profilePhone;
            }
        }

        #endregion

        #region IQueryableUnitOfWork Members

        public DbSet<T> CreateSet<T>()
            where T : class
        {
            return base.Set<T>();
        }

        public void Attach<T>(T item)
            where T : class
        {
            //attach and set as unchanged
            base.Entry<T>(item).State = EntityState.Unchanged;
        }

        public void SetModified<T>(T item)
            where T : class
        {
            //this operation also attach item in object state manager
            base.Entry<T>(item).State = EntityState.Modified;
        }
        public void ApplyCurrentValues<T>(T original, T current)
            where T : class
        {
            //if it is not attached, attach original and set current values
            base.Entry<T>(original).CurrentValues.SetValues(current);
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();

                    saveFailed = false;

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.ToList()
                              .ForEach(entry =>
                              {
                                  entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                              });

                }
            } while (saveFailed);

        }

        public void RollbackChanges()
        {
            // set all entities in change tracker 
            // as 'unchanged state'
            base.ChangeTracker.Entries()
                              .ToList()
                              .ForEach(entry => entry.State = EntityState.Unchanged);
        }

        public IEnumerable<T> ExecuteQuery<T>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<T>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        #endregion

        #region DbContext Overrides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove unused conventions
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Add entity configurations in a structured way using 'TypeConfiguration’ classes
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new AddressTypeConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
            modelBuilder.Configurations.Add(new PhoneTypeConfiguration());
            modelBuilder.Configurations.Add(new ProfileAddressConfiguration());
            modelBuilder.Configurations.Add(new ProfileConfiguration());
            modelBuilder.Configurations.Add(new ProfilePhoneConfiguration());
        }
        #endregion

    }
}
