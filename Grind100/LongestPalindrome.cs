using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public static int LongestPalindrome(string s)
        {
            int count = 0;
            int mxOdd = 0;
            int mxLen = 0;
            string sortedString = String.Concat(s.OrderBy(c => c));
            char currChar = sortedString[0];
            for (int i = 0; i <= sortedString.Length; i++)
            {
                char ch = i==sortedString.Length? '_': sortedString[i];
                if (currChar == ch)
                {
                    count++;
                }
                else
                {
                    if (count % 2 == 0)
                    {
                        mxLen += count;

                    }
                    else
                    {
                        if (count > mxOdd)
                        {
                            mxOdd = count;
                        }
                            mxLen += (count - 1);
                    }
                    count = 1;
                    currChar = ch;
                    
                }
               
            }
            if (mxOdd > 0) mxLen++;
            return mxLen;
        }
    }
}
