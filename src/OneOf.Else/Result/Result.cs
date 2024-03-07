using OneOf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace OneOf.Else;

public sealed class Result : OneOfBase<Success, Error>
{
    public static Result Success { get; } = new Result(OneOf.Else.Success.Instance); 

    public Success? SuccessValue { get; }
    public Error? Error { get; }
    public bool Successful { get; }

    public Result(Success value) : base(value)
    {
        SuccessValue = value;
        Successful = true;
    }

    public Result(Error error) : base(error)
    {
        Error = error;
        Successful = false;
    }

    public OneOfElse<Error> IsSuccess()
    {
        return this.Is(out Success _);
    }

    public OneOfElse<Error> IsSuccess(out Success success)
    {
        return this.Is(out success);
    }

    public OneOfElse<Success> IsError()
    {
        return this.Is(out Error _);
    }

    public OneOfElse<Success> IsError(out Error error)
    {
        return this.Is(out error);
    }

    public static implicit operator Result(Error error)
    {
        return new Result(error);
    }

    public static implicit operator Result(Exception exception)
    {
        return new Result(new Error(exception));
    }

    public Results<Ok, BadRequest<string>> OkOrBadRequest()
    {
        return this.Match<Results<Ok, BadRequest<string>>>(success => TypedResults.Ok(), error => TypedResults.BadRequest<string>(error.Message));
    }
}
