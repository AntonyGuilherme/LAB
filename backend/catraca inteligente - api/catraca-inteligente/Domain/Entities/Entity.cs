namespace Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
        }

        public override bool Equals(object entity)
        {
            var objToCompare = entity as Entity;

            if (ReferenceEquals(this, objToCompare)) return true;
            if (ReferenceEquals(null, objToCompare)) return false;

            return Id.Equals(objToCompare.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode() + Id.GetHashCode();
        }
    }
}
