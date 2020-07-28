namespace UnitTests
{
    public class Calculator
    {
        public static string Multiply(float arg1, float arg2)
        {
            return (arg1 * arg2).ToString();
        }

        public static string Divide(float arg1, float arg2)
        {
            return (arg1 % arg2).ToString();
        }

        public static string Adding(float arg1, float arg2)
        {
            return (arg1 + arg2).ToString();
        }

        public static string Substract(float arg1, float arg2)
        {
            return (arg1 - arg2).ToString();
        }
    }
}
