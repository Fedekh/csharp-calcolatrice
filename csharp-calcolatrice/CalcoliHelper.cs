using System.Numerics;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static T Sum<T>(T x, T y) where T : INumber<T>
        {
            return x + y;
        }
        public static T Minus<T>(T x, T y) where T : INumber<T>
        {
            return x - y;

        }
        public static T Molti<T>(T x, T y) where T : INumber<T>
        {
            return x * y;
        }
        public static T Absolute<T>(T x) where T : INumber<T>
        {
            return x < default(T) ? -x : x;
        }

        public static T Minor<T>(T x, T y) where T : INumber<T>
        {
            if (x > y) return y;
            return x;
          
        }

        public static T Maxim<T>(T x, T y) where T : INumber<T>
        {
            if (x > y) return x;
            return y;
        }


    }
}
