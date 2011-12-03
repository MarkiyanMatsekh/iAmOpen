using System;

namespace Iamopen.Availability.OnlineAvailability.Implementation.DomainModels
{
    public/*internal*/ class Table
    {
        public/*internal*/ int TableID { get; set; }
        public/*internal*/ short No { get; set; }

        public/*internal*/ int HallID { get; set; }
        public/*internal*/ virtual Hall Hall { get; set; }

        public/*internal*/ int InstitutionID { get; set; }// From Iamopen site
        public/*internal*/ virtual Institution Institution { get; set; }

        public/*internal*/ int StatusID { get; set; }
        public/*internal*/ virtual TableStatus Status { get; set; }

        public/*internal*/ DateTime LastUpdateTime { get; set; }

        public/*internal*/ double Left { get; set; }
        public/*internal*/ double Top { get; set; }
        public/*internal*/ double Width { get; set; }
        public/*internal*/ double Height { get; set; }

        public/*internal*/ int AreaTypeID { get; set; }
        public/*internal*/ virtual AreaType AreaType { get; set; }
    }
}
