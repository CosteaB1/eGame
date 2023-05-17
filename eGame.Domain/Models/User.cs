namespace eGame.Domain.Models
{
    public sealed class User : Entity
    {
        public User(Guid id,
                    string country,
                    string nickName,
                    DateTime createdAt) : base(id)
        {
            Country = country;
            NickName = nickName;
            CreatedAt = createdAt;
        }
        public string Country { get; private set; }
        public string NickName { get; private set; }
        public DateTime CreatedAt { get; private set; }

    }
}
