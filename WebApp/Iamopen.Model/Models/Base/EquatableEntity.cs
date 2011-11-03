using System;

namespace IAmOpen.Model.Models.Base
{
    public abstract class EquatableEntity : EntityBase, IEquatable<EquatableEntity>
    {
        public bool Equals(EquatableEntity other)
        {
            return this.EntityID.Equals(other.EntityID);
        }

        public override bool Equals(object obj)
        {
            var typedObj = obj as EquatableEntity;
            return typedObj != null && this.Equals(typedObj);
        }
    }
}