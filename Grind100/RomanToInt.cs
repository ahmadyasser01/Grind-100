using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>(){
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50},
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 }
        };
            int result = 0;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                string substringOf2 = s.Substring(i, Math.Min(2, s.Length - i));
                if (dict.TryGetValue(substringOf2, out int value))
                {
                    i++;
                    result += value;
                }
                else result += dict[s[i].ToString()];

            }
            return result;

        }
    }
}
