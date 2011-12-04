using System;
using System.Collections.Generic;
using Iamopen.Availability.Common.DB.DomainModels;

namespace Iamopen.Availability.Common.DB
{
    public static class InitialData
    {
        private static List<InstitutionResponseType> responseTypes = new List<InstitutionResponseType>
        {
            new InstitutionResponseType {ID = 1, Name="Instant"},
            new InstitutionResponseType {ID = 2, Name="Delayed"}
        };

        private static List<InstitutionServiceType> serviceTypes = new List<InstitutionServiceType>
        {
            new InstitutionServiceType {ID = 1, Name="FirstPayThenEat"},
            new InstitutionServiceType {ID = 2, Name="FirstEatThenPay"}
        };

        private static List<ReservationStatus> reservationStatuses = new List<ReservationStatus>
        {
            new ReservationStatus {ID = 1, Name="ReservedByInstitution"},
            new ReservationStatus {ID = 2, Name="RequestSentByIAmOpenUser"},
            new ReservationStatus {ID = 3, Name="RequestConfirmedByInstitution"},
            new ReservationStatus {ID = 4, Name="ReservationCanceledByUser"}
        };

        private static List<TableStatus> tableStatuses = new List<TableStatus>
        {
            new TableStatus {ID = 1, Name="Free"},
            new TableStatus {ID = 2, Name="Busy"},
            new TableStatus {ID = 3, Name="Reserved"}
        };

        private static List<AreaType> areaTypes = new List<AreaType>
        {
            new AreaType {ID = 1, Name="Rectangle"},
            new AreaType {ID = 2, Name="Circle"}
        };

        private static List<Institution> institutions = new List<Institution>
        {
            new Institution {ID = 1, ServiceTypeID = 1},
            new Institution {ID = 2, ServiceTypeID = 2},
            new Institution {ID = 3, ServiceTypeID = 1},
            new Institution {ID = 6, ServiceTypeID = 1}
        };

        private static List<Hall> halls = new List<Hall>
        {
            new Hall {InstitutionID = 1, No = 1, Name="Entrance"},
            new Hall {InstitutionID = 1, No = 2, Name="2nd floor"},
            new Hall {InstitutionID = 1, No = 3, Name="3rd floor"},
            new Hall {InstitutionID = 1, No = 4, Name="Basement"},
            new Hall {InstitutionID = 2, No = 1, Name="Fun hall"},
            new Hall {InstitutionID = 2, No = 2, Name="Smoking hall"},
            new Hall {InstitutionID = 2, No = 3, Name="Killer hall"},
            new Hall {InstitutionID = 3, No = 1, Name="Lviv hall"},
            new Hall {InstitutionID = 3, No = 2, Name="Amsterdam"},
            new Hall {InstitutionID = 3, No = 3, Name="eleventeen"},
            new Hall {InstitutionID = 3, No = 4, Name="Stage"},
            new Hall {InstitutionID = 3, No = 5, Name="Scene"},
            new Hall {InstitutionID = 3, No = 6, Name="Sub-scene"},
            new Hall {InstitutionID = 6, No = 1, Name="1st hall"},
            new Hall {InstitutionID = 6, No = 2, Name="2nd hall"}
        };

        private static List<Table> tables = new List<Table>
        {
            new Table {TableID = 1, InstitutionID = 1, HallID = 1, No = 1, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 2, InstitutionID = 1, HallID = 1, No = 2, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 3, InstitutionID = 1, HallID = 1, No = 3, StatusID = 2, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 4, InstitutionID = 1, HallID = 1, No = 4, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 5, InstitutionID = 1, HallID = 1, No = 5, StatusID = 3, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
                       
            new Table {TableID = 6, InstitutionID = 1, HallID = 2, No = 1, StatusID = 2, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 7, InstitutionID = 1, HallID = 2, No = 2, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 8, InstitutionID = 1, HallID = 2, No = 3, StatusID = 1, AreaTypeID = 2, LastUpdateTime = DateTime.Now},
            new Table {TableID = 9, InstitutionID = 1, HallID = 2, No = 4, StatusID = 2, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 10, InstitutionID = 1, HallID = 2, No = 5, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
                       
            new Table {TableID = 11, InstitutionID = 1, HallID = 3, No = 1, StatusID = 3, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 12, InstitutionID = 1, HallID = 3, No = 2, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 13, InstitutionID = 1, HallID = 3, No = 3, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 14, InstitutionID = 1, HallID = 3, No = 4, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 15, InstitutionID = 1, HallID = 3, No = 5, StatusID = 2, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
                      
            new Table {TableID = 16, InstitutionID = 1, HallID = 4, No = 1, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 17, InstitutionID = 1, HallID = 4, No = 2, StatusID = 2, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 18, InstitutionID = 1, HallID = 4, No = 3, StatusID = 2, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 19, InstitutionID = 1, HallID = 4, No = 4, StatusID = 2, AreaTypeID = 2, LastUpdateTime = DateTime.Now},
            new Table {TableID = 20, InstitutionID = 1, HallID = 4, No = 5, StatusID = 3, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
            new Table {TableID = 21, InstitutionID = 1, HallID = 4, No = 6, StatusID = 1, AreaTypeID = 1, LastUpdateTime = DateTime.Now},
        };

        private static List<Reservation> reservations = new List<Reservation>
        {
            new Reservation {TableID = 1,  ReservationTime = DateTime.Now,CreationTime = DateTime.Now.AddHours(-1), StatusID = 1, CustomerID = 1, Public = true},
            new Reservation {TableID = 2,  ReservationTime = DateTime.Now,CreationTime = DateTime.Now.AddHours(-1), StatusID = 3, CustomerID = 10, Public = false},
            new Reservation {TableID = 3,  ReservationTime = DateTime.Now,CreationTime = DateTime.Now.AddHours(-2), StatusID = 1, CustomerID = 45, Public = true},
            new Reservation {TableID = 7,  ReservationTime = DateTime.Now,CreationTime = DateTime.Now.AddHours(-1), StatusID = 2, CustomerID = 7, Public = false},
            new Reservation {TableID = 10, ReservationTime = DateTime.Now,CreationTime = DateTime.Now.AddHours(-3), StatusID = 2, CustomerID = 97, Public = false}
        };

        public static List<InstitutionResponseType> ResponseTypes { get { return responseTypes; } }

        public static List<InstitutionServiceType> InstitutionServiceTypes { get { return serviceTypes; } }

        public static List<ReservationStatus> ReservationStatuses { get { return reservationStatuses; } }

        public static List<TableStatus> TableStatuses { get { return tableStatuses; } }

        public static List<AreaType> AreaTypes { get { return areaTypes; } }

        public static List<Institution> Institutions { get { return institutions; } }

        public static List<Hall> Halls { get { return halls; } }

        public static List<Table> Tables { get { return tables; } }

        public static List<Reservation> Reservations { get { return reservations; } }

    }
}
