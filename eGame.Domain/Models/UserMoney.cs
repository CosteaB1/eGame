namespace eGame.Domain.Models
{
    public sealed class UserMoney : Entity
    {
        public UserMoney(Guid id, string name, double amount) : base(id)
        {
            Name = name;
            Amount = amount;
        }
        public Guid UserGuid { get; private set; }
        public string Name { get; private set; }
        public double Amount { get; private set; }

    }
}
