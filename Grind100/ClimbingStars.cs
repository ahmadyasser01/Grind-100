

namespace Grind100
{
    partial class Program
    {
        public int ClimbStairs(int n)
        {
            int a = 1;
            int b = 2;
            int c = n == 1 ? 1 : n == 2 ? 2 : 3;
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
