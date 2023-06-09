using eGame.Domain.Shared;

namespace eGame.Domain.Models
{
    public sealed class User : Entity
    {
        private User(Guid id,
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

        public static Result<User> Create(string country, string nickName)
        {
            var newUser = new User(new Guid(), country, nickName, DateTime.UtcNow);
            UserStats.Create(newUser.Id);

            return newUser;
        }
    }
}
