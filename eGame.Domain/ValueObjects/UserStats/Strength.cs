using eGame.Domain.Errors;
using eGame.Domain.Shared;

namespace eGame.Domain.ValueObjects.UserStats;

public record Strength
{
    public int StrengthValue { get; }
    public DateTime? LastStrengthIncrement { get; }

    public Strength(int strengthValue, DateTime? lastStrengthIncrement)
    {
        StrengthValue = strengthValue;
        LastStrengthIncrement = lastStrengthIncrement;
    }

    public static Result<Strength> Create(int value)
    {
        return value < 0 ? Result<Strength>.Failure(DomainErrors.UserStats.StrengthIsNegative) : new Strength(value, null);
    }

    public static Result<Strength> Increment(Strength currentStrength, int incrementValue, DateTime lastStrengthIncrement)
    {
        var todayDay = DateTime.UtcNow;
        if (lastStrengthIncrement < todayDay)
        {
            return new Strength(currentStrength.StrengthValue + incrementValue, todayDay);
        }
        return Result<Strength>.Failure(DomainErrors.UserStats.StrengthAlreadyWorked);
    }
}