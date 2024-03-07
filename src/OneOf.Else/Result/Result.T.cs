using OneOf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace OneOf.Else;

public sealed class Result<TValue> : OneOfBase<TValue, Error>
{
    public TValue? SuccessValue { get; }
    public Error? Error { get; }
    public bool Successful { get; }

    public Result(TValue value) : base(value)
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
        return this.Is(out TValue _);
    }

    public OneOfElse<Error> IsSuccess(out TValue value)
    {
        return this.Is(out value);
    }

    public OneOfElse<TValue> IsError()
    {
        return this.Is(out Error _);
    }

    public OneOfElse<TValue> IsError(out Error error)
    {
        return this.Is(out error);
    }
    
    public static implicit operator Result<TValue>(TValue value)
    {
        return new Result<TValue>(value);
    }

    public static implicit operator Result<TValue>(Error error)
    {
        return new Result<TValue>(error);
    }

    public static implicit operator Result<TValue>(Exception exception)
    {
        return new Result<TValue>(new Error(exception));
    }

    public Results<Ok, BadRequest<string>> OkOrBadRequestEmpty()
    {
        return this.Match<Results<Ok, BadRequest<string>>>(ok => TypedResults.Ok(), error => TypedResults.BadRequest<string>(error.Message));
    }

    public Results<Ok<TValue>, BadRequest<string>> OkOrBadRequest()
    {
        return this.Match<Results<Ok<TValue>, BadRequest<string>>>(ok => TypedResults.Ok(ok), error => TypedResults.BadRequest<string>(error.Message));
    }
}
