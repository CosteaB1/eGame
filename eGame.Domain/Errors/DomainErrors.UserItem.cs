using eGame.Domain.Shared;

namespace eGame.Domain.Errors;

public static partial class DomainErrors
{
    public static class UserItem
    {
        public static readonly Error QuantityIsZero = new Error("Quantity can't be zero");
    }
}