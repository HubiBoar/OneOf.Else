namespace OneOf.Else;

public static class BoolExtensions
{
    public static TResult Match<TResult>(this bool value, Func<TResult> onTrue, Func<TResult> onFalse)
    {
        if (value)
        {
            return onTrue();
        }
        else
        {
            return onFalse();
        }
    }
    
    public static void Switch(this bool value, Action onTrue, Action onFalse)
    {
        if (value)
        {
            onTrue();
        }
        else
        {
            onFalse();
        }
    }
}