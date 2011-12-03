using System.Collections.Generic;

namespace Iamopen.OnlineAvailability.Implementation.DomainModels
{
    public/*internal*/ class Hall
    {
        public/*internal*/ int ID { get; set; }
        public/*internal*/ int No { get; set; }

        public/*internal*/ int InstitutionID { get; set; }
        public/*internal*/ virtual Institution Institution { get; set; }

        public/*internal*/ string Name { get; set; }

        public/*internal*/ bool IsSmokingHall { get; set; }

        public/*internal*/ double EntranceLeft { get; set; }
        public/*internal*/ double EntranceTop { get; set; }
        public/*internal*/ double EntranceWidth { get; set; }
        public/*internal*/ double EntranceHeight { get; set; }

        public/*internal*/ virtual ICollection<Table> Tables { get; set; }
    }
}
