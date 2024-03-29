﻿using System;
using IAmOpen.Site.Model.Abstractions;
using IAmOpen.Site.Model.Models;
using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Concrete.Database
{
    // TODO LP(from MM): consider why this class is not Disposable, but has Dispose method
    public class DBUnitOfWork : IUnitOfWork
    {
        private readonly InstitutionContext context = new InstitutionContext();

        private GenericDBRepository<Institution> institutionRepository;
        private GenericDBRepository<InstitutionType> institutionTypeRepository;
        private GenericDBRepository<User> userRepository;
        private GenericDBRepository<Chain> chainRepository;
        private GenericDBRepository<ExternalAccount> externalAccountRepository;
        private GenericDBRepository<WorkTime> workTimeRepository;
        private GenericDBRepository<Vote> voteRepository;
        private GenericDBRepository<Review> reviewRepository;
        private GenericDBRepository<UserExternalAccountToken> userExtAccountRepository;
        private GenericDBRepository<Status> statusRepository;
        private GenericDBRepository<Role> roleRepository;
        private GenericDBRepository<State> stateRepository;

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

        private IGenericRepository<TEntity> CreateIfDoesntExist<TEntity>(ref GenericDBRepository<TEntity> field) where TEntity : EntityBase
        {
            return field ?? (field = new GenericDBRepository<TEntity>(context));
        }
    }
}
