using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                while (!Char.IsLetterOrDigit(s[i]) && i < j)
                {
                    i++;
                }
                while (!Char.IsLetterOrDigit(s[j]) && i <j)
                {
                    j--;
                }

                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))

                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
