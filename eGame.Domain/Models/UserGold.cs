namespace eGame.Domain.Models;

public class UserGold : Entity
{
    public UserGold(Guid id, int goldAmount, Guid userId) : base(id)
    {
        GoldAmount = goldAmount;
        UserId = userId;
    }
    public int GoldAmount { get; private set; }
    public Guid UserId { get; private set; }
}