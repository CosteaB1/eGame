namespace eGame.Domain.Shared;

public class Result<TValue>
{
    public bool IsSuccess { get; set; }
    public TValue Data { get; set; } // to check
    public Error? Error { get; set; }

    public static Result<TValue> Success(TValue data) // Result<Quantity>.Success(new Quantity(value))
    {
        return new Result<TValue>
        {
            IsSuccess = true,
            Data = data,
            Error = Error.None
        };
    }

    public static implicit operator Result<TValue>(TValue value) => Success(value); // new Quantity(value)

    public static Result<TValue> Failure(string errorMessage) // maybe will remove
    {
        return new Result<TValue>
        {
            IsSuccess = false,
            Error = new Error(errorMessage)
        };
    }

    public static Result<TValue> Failure(Error error)
    {
        return new Result<TValue>
        {
            IsSuccess = false,
            Error = error
        };
    }
}