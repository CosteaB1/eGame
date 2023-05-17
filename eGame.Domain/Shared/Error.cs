namespace eGame.Domain.Shared;

public class Error
{
    public string Message { get; set; }

    public Error(string message)
    {
        Message = message;
    }
    internal static Error None => new(string.Empty);
}