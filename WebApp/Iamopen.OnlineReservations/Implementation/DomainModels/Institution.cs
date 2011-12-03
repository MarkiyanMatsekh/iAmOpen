using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Iamopen.OnlineAvailability.Implementation.DomainModels
{
    public/*internal*/ class Institution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public/*internal*/ int ID {get; set;}

        public/*internal*/ int ServiceTypeID { get; set; }
        public/*internal*/ virtual InstitutionServiceType ServiceType { get; set; }

        public/*internal*/ virtual ICollection<Table> Tables { get; set; }
        public/*internal*/ virtual ICollection<Hall> Halls { get; set; }

    }
}
