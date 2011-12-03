using System;
using Iamopen.Common.Exceptions;
using Iamopen.OnlineAvailability.Implementation.DomainModels;
using TableStatus = Iamopen.Common.ServiceModels.TableStatus;

namespace Iamopen.OnlineAvailability.Implementation
{
    public static class EntitiesMapping
    {
        public static TableStatus MapTableStatus(DomainModels.TableStatus domainModelTableStatus)
        {
            return Map<DomainModels.TableStatus, TableStatus>(domainModelTableStatus);
        }

        public static TOut Map<TIn, TOut>(TIn dbEnum)
            where TIn : Enumeration
        {
            var enumID = dbEnum.ID;
            if (!Enum.IsDefined(typeof(TOut), enumID))
                throw new DBIncompatibilityException(
                    String.Format("Cannot cast Domain model table status to Service model table status. Value {0} is not supported", enumID));
            return (TOut)Enum.ToObject(typeof(TOut), enumID);
        }
    }
}
