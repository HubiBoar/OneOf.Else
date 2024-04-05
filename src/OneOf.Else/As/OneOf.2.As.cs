using OneOf;

namespace OneOf.Else;

public static class OneOf_2_AsExtensions
{
    public static OneOf<T1, T0> As<T0, T1>(this OneOf<T0, T1> oneOf) => oneOf.Match<OneOf<T1, T0>>(t => t, t => t);
    public static OneOf<T1, T0> As<T0, T1>(this OneOf<T1, T0> oneOf) => oneOf.Match<OneOf<T1, T0>>(t => t, t => t);

    public static OneOf<T0, T1, T2> As<T0, T1, T2>(this OneOf<T0, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2>>(t => t, t => t);
    public static OneOf<T0, T1, T2> As<T0, T1, T2>(this OneOf<T0, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2>>(t => t, t => t);
    public static OneOf<T0, T1, T2> As<T0, T1, T2>(this OneOf<T1, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2>>(t => t, t => t);
    public static OneOf<T0, T1, T2> As<T0, T1, T2>(this OneOf<T1, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2>>(t => t, t => t);
    public static OneOf<T0, T1, T2> As<T0, T1, T2>(this OneOf<T2, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2>>(t => t, t => t);
    public static OneOf<T0, T1, T2> As<T0, T1, T2>(this OneOf<T2, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2>>(t => t, t => t);

    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T0, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T0, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T0, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T1, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T1, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T1, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T2, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T2, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T2, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T3, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T3, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3> As<T0, T1, T2, T3>(this OneOf<T3, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3>>(t => t, t => t);

    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T0, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T0, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T0, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T0, T4> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T1, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T1, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T1, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T1, T4> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T2, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T2, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T2, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T2, T4> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T3, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T3, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T3, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T3, T4> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T4, T0> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T4, T1> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T4, T2> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
    public static OneOf<T0, T1, T2, T3, T4> As<T0, T1, T2, T3, T4>(this OneOf<T4, T3> oneOf) => oneOf.Match<OneOf<T0, T1, T2, T3, T4>>(t => t, t => t);
}