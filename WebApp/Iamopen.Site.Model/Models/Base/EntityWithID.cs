using System;
using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models.Base
{
    public abstract class EntityWithID<TID> : EntityBase, IEquatable<EntityWithID<TID>> where TID:IEquatable<TID>
    {
        [Key]
        public TID ID { get; set; }

        public bool Equals(EntityWithID<TID> other)
        {
            return this.ID.Equals(other.ID);
        }

        public override bool Equals(object obj)
        {
            var typedObj = obj as EntityWithID<TID>;
            return typedObj != null && this.Equals(typedObj);
        }
    }
}