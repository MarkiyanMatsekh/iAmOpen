using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models.Base
{
    // note MM: base class could be generic, to identify the type of ID(usually its int), but it's too big price in design as for development convenience
    // we can implement this a bit later, when the hierarchy of types will be more obvious
    // todo MM,LP: consider making base class generic and mapping ID property from it
    public abstract class EntityBase
    {
        [NotMapped]
        // this property is used mostly in mock repositories to generalize the concept of element's ID
            public abstract object EntityID { get; set; }
    }
}