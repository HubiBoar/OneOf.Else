namespace OneOf.Else;

public sealed class OneOfElse<TOut>
{
    private readonly bool _returnValue;
    private readonly TOut _remainder;

    public OneOfElse(bool returnValue, TOut remainder)
    {
        _returnValue = returnValue;
        _remainder = remainder;
    }

    public bool Else(out TOut remainder)
    {
        remainder = _remainder;
        return _returnValue == false;
    }

    public static explicit operator bool(OneOfElse<TOut> valid)
    {
        return valid._returnValue;
    }
}