using System;

namespace Iamopen.Availability.Common.DB.DomainModels
{
    public/*internal*/ class Reservation
    {
        public/*internal*/ int ID { get; set; }

        public/*internal*/ DateTime ReservationTime { get; set; }
        public/*internal*/ DateTime CreationTime { get; set; }

        public/*internal*/ int StatusID { get; set; }
        public/*internal*/ virtual ReservationStatus Status { get; set; }

        public/*internal*/ int TableID { get; set; }
        public/*internal*/ virtual Table Table { get; set; }

        public/*internal*/ int CustomerID { get; set; }

        public string CancellationNote { get; set; }

        public/*internal*/ bool Public { get; set; }
    }
}
