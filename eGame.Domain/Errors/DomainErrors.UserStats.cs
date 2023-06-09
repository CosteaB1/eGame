using eGame.Domain.Shared;

namespace eGame.Domain.Errors;

public partial class DomainErrors
{
    public static class UserStats
    {
        public static readonly Error LevelIsNegative = new("Level can't be negative");
        public static readonly Error ExperienceIsNegative = new("Experience can't be negative");
        public static readonly Error StrengthIsNegative = new("Strength can't be negative");
        public static readonly Error StrengthAlreadyWorked = new("Strength can't be worked twice a day");

    }
}