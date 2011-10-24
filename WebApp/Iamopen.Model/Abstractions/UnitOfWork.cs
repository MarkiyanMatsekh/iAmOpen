using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.DAL;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Abstractions
{
    public class UnitOfWork: IDisposable
    {
        private InstitutionContext context = new InstitutionContext();

        private GenericRepository<Institution> institutionRepository;
        private GenericRepository<InstitutionType> institutionTypeRepository;
        private GenericRepository<User> userRepository;
        private GenericRepository<Chain> chainRepository;
        private GenericRepository<ExternalAccount> externalAccountRepository;
        private GenericRepository<WorkTime> workTimeRepository;
        private GenericRepository<Vote> voteRepository;
        private GenericRepository<Review> reviewRepository;
        private GenericRepository<UserExternalAccountToken> userExtAccountRepository;
        private GenericRepository<Status> statusRepository;
        private GenericRepository<Role> roleRepository;
        private GenericRepository<State> stateRepository;


        public GenericRepository<Institution> InstitutionRepository
        {
            get
            {

                if (this.institutionRepository == null)
                {
                    this.institutionRepository = new GenericRepository<Institution>(context);
                }
                return institutionRepository;
            }
        }

        public GenericRepository<InstitutionType> InstitutionTypeRepository
        {
            get
            {

                if (this.institutionTypeRepository == null)
                {
                    this.institutionTypeRepository = new GenericRepository<InstitutionType>(context);
                }
                return institutionTypeRepository;
            }
        }

        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }

        public GenericRepository<Chain> ChainRepository
        {
            get
            {

                if (this.chainRepository == null)
                {
                    this.chainRepository = new GenericRepository<Chain>(context);
                }
                return chainRepository;
            }
        }

        public GenericRepository<ExternalAccount> ExternalAccountRepository
        {
            get
            {

                if (this.externalAccountRepository == null)
                {
                    this.externalAccountRepository = new GenericRepository<ExternalAccount>(context);
                }
                return externalAccountRepository;
            }
        }

        public GenericRepository<WorkTime> WorkTimeRepository
        {
            get
            {

                if (this.workTimeRepository == null)
                {
                    this.workTimeRepository = new GenericRepository<WorkTime>(context);
                }
                return workTimeRepository;
            }
        }

        public GenericRepository<Vote> VoteRepository
        {
            get
            {

                if (this.voteRepository == null)
                {
                    this.voteRepository = new GenericRepository<Vote>(context);
                }
                return voteRepository;
            }
        }

        public GenericRepository<Review> ReviewRepository
        {
            get
            {

                if (this.reviewRepository == null)
                {
                    this.reviewRepository = new GenericRepository<Review>(context);
                }
                return reviewRepository;
            }
        }

        public GenericRepository<UserExternalAccountToken> UserExtAccountRepository
        {
            get
            {

                if (this.userExtAccountRepository == null)
                {
                    this.userExtAccountRepository = new GenericRepository<UserExternalAccountToken>(context);
                }
                return userExtAccountRepository;
            }
        }

        public GenericRepository<Status> StatusRepository
        {
            get
            {

                if (this.statusRepository == null)
                {
                    this.statusRepository = new GenericRepository<Status>(context);
                }
                return statusRepository;
            }
        }

        public GenericRepository<Role> RoleRepository
        {
            get
            {

                if (this.roleRepository == null)
                {
                    this.roleRepository = new GenericRepository<Role>(context);
                }
                return roleRepository;
            }
        }

        public GenericRepository<State> StateRepository
        {
            get
            {

                if (this.stateRepository == null)
                {
                    this.stateRepository = new GenericRepository<State>(context);
                }
                return stateRepository;
            }
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
    }
}
