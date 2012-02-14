using System;
using Iamopen.Availability.Common.DB.DomainModels;
using Iamopen.Common.Exceptions;
using TableStatus = Iamopen.Common.ServiceModels.TableStatus;
using ReservationStatus = Iamopen.Common.ServiceModels.ReservationStatus;

namespace Iamopen.Availability.Common.DB
{
    public static class EntitiesMapping
    {
        public static TableStatus MapTableStatus(DomainModels.TableStatus domainModelTableStatus)
        {
            return MapFromDbToCode<DomainModels.TableStatus, TableStatus>(domainModelTableStatus);
        }

        public static  DomainModels.TableStatus MapTableStatus(TableStatus serviceModelTableStatus)
        {
            return MapFromCodeToDb<DomainModels.TableStatus>((int)serviceModelTableStatus);
        }

        public static ReservationStatus MapReservationStatus(DomainModels.ReservationStatus serviceModelResStatus)
        {
            return MapFromDbToCode<DomainModels.ReservationStatus, ReservationStatus>(serviceModelResStatus);
        }

        public static DomainModels.ReservationStatus MapReservationStatus(ReservationStatus serviceModelResStatus)
        {
            return MapFromCodeToDb<DomainModels.ReservationStatus>((int)serviceModelResStatus);
        }

        private static TOut MapFromDbToCode<TIn, TOut>(TIn dbEnum)
            where TIn : Enumeration
        {
            var enumID = dbEnum.ID;
            if (!Enum.IsDefined(typeof(TOut), enumID))
                throw new DBIncompatibilityException(
                    String.Format("Cannot cast Domain model table status to Service model table status. Value {0} is not supported", enumID));
            return (TOut)Enum.ToObject(typeof(TOut), enumID);
        }

        private static TOut MapFromCodeToDb<TOut>(int enumID) where TOut : Enumeration, new()
        {
            return new TOut { ID = enumID };
        }

    }
}
