using OneOf.Types;

namespace OneOf.Else;

public static class Example
{
    private static void ExampleMethod()
    {
        if (TestMethod().Is(out Success success))
        {
            //Do something with success
            var _ = success.ToString();
        }
        
        if (TestMethod().Is(out success).Else(out var error))
        {
            //Do something with success
            var _ = success.ToString();
        }
        else
        {
            //Do something with error
            var _ = error.ToString();
        }
    }

    private static OneOf<Success, Error> TestMethod()
    {
        return new Success();
    }
}