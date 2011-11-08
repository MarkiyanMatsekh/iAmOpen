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
        private InstitutionMockRepository _institutionRepository;
        private InstitutionTypeMockRepository _institutionTypeRepository;
        private UserMockRepository _userRepository;
        private ChainMockRepository _chainRepository;
        private ExternalAccountMockRepository _externalAccountRepository;
        private WorkTimeMockRepository _workTimeRepository;
        private VoteMockRepository _voteRepository;
        private ReviewMockRepository _reviewRepository;
        private UserExternalAccountTokenMockRepository _userExtAccountRepository;
        private StatusMockRepository _statusRepository;
        private RoleMockRepository _roleRepository;
        private StateMockRepository _stateRepository;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IGenericRepository<Institution> InstitutionRepository
        {
            get { return _institutionRepository ?? (_institutionRepository = new InstitutionMockRepository()); }
        }

        public IGenericRepository<InstitutionType> InstitutionTypeRepository
        {
            get { return _institutionTypeRepository ?? (_institutionTypeRepository = new InstitutionTypeMockRepository()); }
        }

        public IGenericRepository<User> UserRepository
        {
            get { return _userRepository ?? (_userRepository = new UserMockRepository()); }
        }

        public IGenericRepository<Chain> ChainRepository
        {
            get { return _chainRepository ?? (_chainRepository = new ChainMockRepository()); }
        }

        public IGenericRepository<ExternalAccount> ExternalAccountRepository
        {
            get { return _externalAccountRepository ?? (_externalAccountRepository = new ExternalAccountMockRepository()); }
        }

        public IGenericRepository<WorkTime> WorkTimeRepository
        {
            get { return _workTimeRepository ?? (_workTimeRepository = new WorkTimeMockRepository()); }
        }

        public IGenericRepository<Vote> VoteRepository
        {
            get { return _voteRepository ?? (_voteRepository = new VoteMockRepository()); }
        }

        public IGenericRepository<Review> ReviewRepository
        {
            get { return _reviewRepository ?? (_reviewRepository = new ReviewMockRepository()); }
        }

        public IGenericRepository<UserExternalAccountToken> UserExtAccountRepository
        {
            get { return _userExtAccountRepository ?? (_userExtAccountRepository = new UserExternalAccountTokenMockRepository()); }
        }

        public IGenericRepository<Status> StatusRepository
        {
            get { return _statusRepository ?? (_statusRepository = new StatusMockRepository()); }
        }

        public IGenericRepository<Role> RoleRepository
        {
            get { return _roleRepository ?? (_roleRepository = new RoleMockRepository()); }
        }

        public IGenericRepository<State> StateRepository
        {
            get { return _stateRepository ?? (_stateRepository = new StateMockRepository()); }
        }

        public void Save()
        {
            //throw new NotImplementedException();
        }
    }
}
