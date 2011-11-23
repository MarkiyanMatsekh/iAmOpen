using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Abstractions
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Institution> InstitutionRepository { get; }

        IGenericRepository<InstitutionType> InstitutionTypeRepository { get; }

        IGenericRepository<User> UserRepository{ get; }

        IGenericRepository<Chain> ChainRepository{ get; }

        IGenericRepository<ExternalAccount> ExternalAccountRepository{ get; }

        IGenericRepository<WorkTime> WorkTimeRepository{ get; }

        IGenericRepository<Vote> VoteRepository{ get; }

        IGenericRepository<Review> ReviewRepository{ get; }

        IGenericRepository<UserExternalAccountToken> UserExtAccountRepository{ get; }

        IGenericRepository<Status> StatusRepository{ get; }

        IGenericRepository<Role> RoleRepository{ get; }

        IGenericRepository<State> StateRepository{ get; }

        void Save();
    }
}
