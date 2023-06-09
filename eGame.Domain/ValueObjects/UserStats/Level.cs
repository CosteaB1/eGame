using eGame.Domain.Errors;
using eGame.Domain.Shared;

namespace eGame.Domain.ValueObjects.UserStats;

public record Level
{
    public int Value { get; }

    public Level(int value)
    {
        Value = value;
    }

    public static Result<Level> Create(int value)
    {
        return value < 0 ? Result<Level>.Failure(DomainErrors.UserStats.LevelIsNegative) : new Level(value);
    }

    public static Result<Level> FromExperience(int experience)
    {
        if (experience < 0)
        {
            return Result<Level>.Failure(DomainErrors.UserStats.ExperienceIsNegative);
        }

        if (experience == 0)
        {
            return new Level(0);
        }

        return new Level(experience / 5000);
    }
}