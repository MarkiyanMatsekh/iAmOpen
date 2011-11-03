using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Abstractions;
using IAmOpen.Model.Concrete.Mock.MockRepositories;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock
{
    public class MockUnitOfWork  : IUnitOfWork
    {
        private InstitutionMockRepository institutionRepository;
        //private DBGenericRepository<InstitutionType> institutionTypeRepository;
        private UserMockRepository userRepository;
        private ChainMockRepository chainRepository;
        //private DBGenericRepository<ExternalAccount> externalAccountRepository;
        //private DBGenericRepository<WorkTime> workTimeRepository;
        //private DBGenericRepository<Vote> voteRepository;
        //private DBGenericRepository<Review> reviewRepository;
        //private DBGenericRepository<UserExternalAccountToken> userExtAccountRepository;
        private StatusMockRepository statusRepository;
        //private DBGenericRepository<Role> roleRepository;
        private StateMockRepository stateRepository;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IGenericRepository<Institution> InstitutionRepository
        {
            get { return institutionRepository ?? (institutionRepository = new InstitutionMockRepository()); }
        }

        public IGenericRepository<InstitutionType> InstitutionTypeRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<User> UserRepository
        {
            get { return userRepository ?? (userRepository = new UserMockRepository()); }
        }

        public IGenericRepository<Chain> ChainRepository
        {
            get { return chainRepository ?? (chainRepository = new ChainMockRepository()); }
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
            get { return statusRepository ?? (statusRepository = new StatusMockRepository()); }
        }

        public IGenericRepository<Role> RoleRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IGenericRepository<State> StateRepository
        {
            get { return stateRepository ?? (stateRepository = new StateMockRepository()); }
        }

        public void Save()
        {
            //throw new NotImplementedException();
        }
    }
}
