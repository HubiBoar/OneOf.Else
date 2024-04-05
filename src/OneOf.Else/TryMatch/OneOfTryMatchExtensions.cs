using OneOf;

namespace OneOf.Else;

public static class OneOfTryMatchExtensions
{
    public static T TryMatch<T0, T1, T>(
        this OneOf<T0, T1> oneOf,
        Func<T0, T> t0,
        Func<T1, T> t1,
        Func<Exception, T> onException)
    {
        try
        {
            return oneOf.Match(t0, t1);
        }
        catch (Exception exception)
        {
            return onException(exception);
        }
    }

    public static T TryMatch<T0, T1, T2, T>(
        this OneOf<T0, T1, T2> oneOf,
        Func<T0, T> t0,
        Func<T1, T> t1,
        Func<T2, T> t2,
        Func<Exception, T> onException)
    {
        try
        {
            return oneOf.Match(t0, t1, t2);
        }
        catch (Exception exception)
        {
            return onException(exception);
        }
    }

    public static T TryMatch<T0, T1, T2, T3, T>(
        this OneOf<T0, T1, T2, T3> oneOf,
        Func<T0, T> t0,
        Func<T1, T> t1,
        Func<T2, T> t2,
        Func<T3, T> t3,
        Func<Exception, T> onException)
    {
        try
        {
            return oneOf.Match(t0, t1, t2, t3);
        }
        catch (Exception exception)
        {
            return onException(exception);
        }
    }

    public static T TryMatch<T0, T1, T>(
        this OneOfBase<T0, T1> oneOf,
        Func<T0, T> t0,
        Func<T1, T> t1,
        Func<Exception, T> onException)
    {
        try
        {
            return oneOf.Match(t0, t1);
        }
        catch (Exception exception)
        {
            return onException(exception);
        }
    }

    public static T TryMatch<T0, T1, T2, T>(
        this OneOfBase<T0, T1, T2> oneOf,
        Func<T0, T> t0,
        Func<T1, T> t1,
        Func<T2, T> t2,
        Func<Exception, T> onException)
    {
        try
        {
            return oneOf.Match(t0, t1, t2);
        }
        catch (Exception exception)
        {
            return onException(exception);
        }
    }

    public static T TryMatch<T0, T1, T2, T3, T>(
        this OneOfBase<T0, T1, T2, T3> oneOf,
        Func<T0, T> t0,
        Func<T1, T> t1,
        Func<T2, T> t2,
        Func<T3, T> t3,
        Func<Exception, T> onException)
    {
        try
        {
            return oneOf.Match(t0, t1, t2, t3);
        }
        catch (Exception exception)
        {
            return onException(exception);
        }
    }
}