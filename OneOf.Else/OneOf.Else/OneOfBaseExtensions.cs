namespace OneOf.Else;

public static class OneOfBaseExtensions
{
    public static OneOfElse<T1> Is<T0, T1>(this OneOfBase<T0, T1> oneOf, out T0 value)
    {
        return new OneOfElse<T1>(oneOf.TryPickT0(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<T0> Is<T0, T1>(this OneOfBase<T0, T1> oneOf, out T1 value)
    {
        return new OneOfElse<T0>(oneOf.TryPickT1(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T1, T2>> Is<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, out T0 value)
    {
        return new OneOfElse<OneOf<T1, T2>>(oneOf.TryPickT0(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T0, T2>> Is<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, out T1 value)
    {
        return new OneOfElse<OneOf<T0, T2>>(oneOf.TryPickT1(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T0, T1>> Is<T0, T1, T2>(this OneOfBase<T0, T1, T2> oneOf, out T2 value)
    {
        return new OneOfElse<OneOf<T0, T1>>(oneOf.TryPickT2(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T1, T2, T3>> Is<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, out T0 value)
    {
        return new OneOfElse<OneOf<T1, T2, T3>>(oneOf.TryPickT0(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T0, T2, T3>> Is<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, out T1 value)
    {
        return new OneOfElse<OneOf<T0, T2, T3>>(oneOf.TryPickT1(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T0, T1, T3>> Is<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, out T2 value)
    {
        return new OneOfElse<OneOf<T0, T1, T3>>(oneOf.TryPickT2(out value, out var remainder), remainder);
    }
    
    public static OneOfElse<OneOf<T0, T1, T2>> Is<T0, T1, T2, T3>(this OneOfBase<T0, T1, T2, T3> oneOf, out T3 value)
    {
        return new OneOfElse<OneOf<T0, T1, T2>>(oneOf.TryPickT3(out value, out var remainder), remainder);
    }
}