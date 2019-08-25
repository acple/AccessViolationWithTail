namespace TailCallTestAssembly
{
    public class Class1
    {
        public static string TestFunction<T>(T value)
            => value.ToString();
    }
}
