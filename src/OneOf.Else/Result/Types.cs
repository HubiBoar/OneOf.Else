using OneOf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace OneOf.Else;

public sealed class Success
{
    public static Success Instance { get; } = new Success();

    private Success()
    {
    }
}

public record Error(string Message)
{
    public Error(Exception exception) : this("From Exception", exception)
    {
    }

    public Error(string prefix, Exception exception) : this($"{prefix} :: {exception}")
    {
    }

    public BadRequest<string> ToBadRequest()
    {
        return TypedResults.BadRequest<string>(Message);
    }
}