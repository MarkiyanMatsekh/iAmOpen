#region

using System.Collections.Generic;
using System.Linq;
using IAmOpen.Model.Models;

#endregion

namespace IAmOpen.Model.DAL
{
    public class DBInstitutionRepository: IInstitutionRepository
    {
        private readonly InstitutionContext context;

        public DBInstitutionRepository(InstitutionContext institutionContext)
        {
            this.context = institutionContext;
        }

        public IEnumerable<Institution> GetInstitutions()
        {
            return context.Institutions.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}