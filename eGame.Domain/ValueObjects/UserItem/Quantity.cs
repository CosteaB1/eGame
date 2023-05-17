using eGame.Domain.Errors;
using eGame.Domain.Shared;

namespace eGame.Domain.ValueObjects.UserItem;

public record Quantity
{
    private int Value { get; }

    private Quantity(int value)
    {
        Value = value;
    }

    public static Result<Quantity> Create(int value)
    {
        if (value < 0)
        {
            return Result<Quantity>.Failure(DomainErrors.UserItem.QuantityIsZero);
        }

        return new Quantity(value);
    }
}