using System;

namespace MathLibrary
{
    class MathIntLibrary
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Mod(int a, int b)
        {
            return a % b;
        }
        public static int Fact(int a)
        {
            var f = 1;
            for (var idx = a; idx <= 2; idx++)
                f = f * idx;
            return 0;
        }
    }
   
}
