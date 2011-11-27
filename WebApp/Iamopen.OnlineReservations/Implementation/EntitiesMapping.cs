using System;
using System.Collections.Generic;
using System.Linq;
using Iamopen.Common.Exceptions;
using Iamopen.OnlineReservations.Implementation.DomainModels;
using DomainModelTableStatus = Iamopen.OnlineReservations.Implementation.DomainModels.TableStatus;
using ServiceModelTableStatus = Iamopen.Common.ServiceModels.TableStatus;

namespace Iamopen.OnlineReservations.Implementation
{
    public static class EntitiesMapping
    {
        public static ServiceModelTableStatus MapTableStatus(DomainModelTableStatus domainModelTableStatus)
        {
            return Map<DomainModelTableStatus, ServiceModelTableStatus>(domainModelTableStatus);
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
