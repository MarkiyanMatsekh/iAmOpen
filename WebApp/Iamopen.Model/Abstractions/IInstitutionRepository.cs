#region

using System.Collections.Generic;
using IAmOpen.Model.Models;

#endregion

namespace IAmOpen.Model.DAL
{
    public interface IInstitutionRepository
    {
        IEnumerable<Institution> GetInstitutions();
        //Institution GetInstitutionByID(int institutionId);
        //void InsertInstitution(Institution institution);
        //void DeleteInstitution(int institutionID);
        //void UpdateInstitution(Institution institution);
        void Save();
    }
}