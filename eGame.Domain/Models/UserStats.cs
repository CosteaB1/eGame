using eGame.Domain.Shared;
using eGame.Domain.ValueObjects.UserStats;

namespace eGame.Domain.Models;

public sealed class UserStats : Entity  // should be value object 
{
    private UserStats(Guid id,
        Guid userId,
        Strength strength,
        Level level,
        Power power,
        int experience)
        : base(id)
    {
        UserId = userId;
        Strength = strength;
        Level = level;
        Power = power;
        Experience = experience;
    }

    public Guid UserId { get; private set; }
    public Strength Strength { get; private set; }
    public Level Level { get; private set; }
    public Power Power { get; private set; }
    public int Experience { get; set; }

    public static Result<UserStats> Create(Guid userGuid)
    {
        var level = Level.Create(0);
        var strength = Strength.Create(0);
        var power = new Power(0);

        return new UserStats(Guid.NewGuid(), userGuid, strength.Data, level.Data, power, 0);
    }

    private void UpdateLevel()
    {
        Level = Level.FromExperience(Experience).Data;
    }

    public void IncrementStrength(Guid userGuid)
    {
        Strength = Strength.Increment(Strength, 25, DateTime.Today).Data;
        Experience += 10;
        UpdateLevel();
    }

}