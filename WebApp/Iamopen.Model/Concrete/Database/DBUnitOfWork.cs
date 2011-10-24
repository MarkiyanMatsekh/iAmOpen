using System;
using IAmOpen.Model.Abstractions;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Database
{
    public class DBUnitOfWork : IUnitOfWork
    {
        private readonly InstitutionContext context = new InstitutionContext();

        private DBGenericRepository<Institution> institutionRepository;
        private DBGenericRepository<InstitutionType> institutionTypeRepository;
        private DBGenericRepository<User> userRepository;
        private DBGenericRepository<Chain> chainRepository;
        private DBGenericRepository<ExternalAccount> externalAccountRepository;
        private DBGenericRepository<WorkTime> workTimeRepository;
        private DBGenericRepository<Vote> voteRepository;
        private DBGenericRepository<Review> reviewRepository;
        private DBGenericRepository<UserExternalAccountToken> userExtAccountRepository;
        private DBGenericRepository<Status> statusRepository;
        private DBGenericRepository<Role> roleRepository;
        private DBGenericRepository<State> stateRepository;

        public IGenericRepository<Institution> InstitutionRepository
        {
            get { return CreateIfDoesntExist(ref institutionRepository); }
        }

        public IGenericRepository<InstitutionType> InstitutionTypeRepository
        {
            get { return CreateIfDoesntExist(ref institutionTypeRepository); }
        }

        public IGenericRepository<User> UserRepository
        {
            get { return CreateIfDoesntExist(ref userRepository); }
        }

        public IGenericRepository<Chain> ChainRepository
        {
            get { return CreateIfDoesntExist(ref chainRepository); }
        }

        public IGenericRepository<ExternalAccount> ExternalAccountRepository
        {
            get { return CreateIfDoesntExist(ref externalAccountRepository); }
        }

        public IGenericRepository<WorkTime> WorkTimeRepository
        {
            get { return CreateIfDoesntExist(ref workTimeRepository); }
        }

        public IGenericRepository<Vote> VoteRepository
        {
            get { return CreateIfDoesntExist(ref voteRepository); }
        }

        public IGenericRepository<Review> ReviewRepository
        {
            get { return CreateIfDoesntExist(ref reviewRepository); }
        }

        public IGenericRepository<UserExternalAccountToken> UserExtAccountRepository
        {
            get { return CreateIfDoesntExist(ref userExtAccountRepository); }
        }

        public IGenericRepository<Status> StatusRepository
        {
            get { return CreateIfDoesntExist(ref statusRepository); }
        }

        public IGenericRepository<Role> RoleRepository
        {
            get { return CreateIfDoesntExist(ref roleRepository); }
        }

        public IGenericRepository<State> StateRepository
        {
            get { return CreateIfDoesntExist(ref stateRepository); }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private IGenericRepository<TEntity> CreateIfDoesntExist<TEntity>(ref DBGenericRepository<TEntity> field) where TEntity : class
        {
            return field ?? (field = new DBGenericRepository<TEntity>(context));
        }
    }
}
