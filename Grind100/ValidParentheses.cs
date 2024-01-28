using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        static bool IsValid(string input)
        {
            Stack<char> stk = new Stack<char>();

            foreach(var ch in input)
            {
                if(ch =='(' ||  ch =='[' || ch == '{')
                {
                    stk.Push(ch);
                }
                else
                {
                    
                    if (!stk.TryPeek(out char result)) return false;
                    if ((ch == ')' && result == '(') || (ch == '}' && result == '{') || (ch == ']' && result == '['))
                    {
                        stk.Pop();
                    }
                    else return false;
                }
            }
            if(stk.Count == 0 ) return true;
            return false;
        }
    }
}
