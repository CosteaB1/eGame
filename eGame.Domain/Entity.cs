namespace eGame.Domain
{
    public abstract class Entity : IEquatable<Entity>
    {
        /// <summary>
        /// Creates a new instance of the Entity
        /// </summary>
        /// <param name="id"></param>
        protected Entity(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        public Guid Id { get; private init; }

        /// <summary>
        /// Returns a boolean value indication the two objects have the same id.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(Entity left, Entity right)
        {
            return left.Id == right.Id;
        }

        /// <summary>
        /// Returns a boolean value indicating the two objects have a different id. (true or false)
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Returns a boolean value indicating the two objects have the same id.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Entity? other)
        {
            if (other is null)
                return false;
            if (other.GetType() != GetType())
                return false;

            return other.Id == Id;
        }

        /// <summary>
        /// Returns a boolean value indicating the two objects have the same id.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            if (obj is not Entity entity)
                return false;
            return entity.Id == Id;
        }

        // this can be useful when we are creating a collection of entity types
        public override int GetHashCode()
        {
            return Id.GetHashCode() * 41;
        }

    }
}
