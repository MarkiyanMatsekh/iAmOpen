using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Abstractions;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock
{
    class MockUnitOfWork  : IUnitOfWork
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IGenericRepository<Institution> InstitutionRepository
        {
            get { return new MockINstitutionRepository(); }
        }

        public IGenericRepository<InstitutionType> InstitutionTypeRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<User> UserRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Chain> ChainRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<ExternalAccount> ExternalAccountRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<WorkTime> WorkTimeRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Vote> VoteRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Review> ReviewRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<UserExternalAccountToken> UserExtAccountRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Status> StatusRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<Role> RoleRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<State> StateRepository
        {
            get { throw new NotImplementedException(); }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
