using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public class MyQueue
        {
            Stack<int> stk1;
            Stack<int> stk2;

            public MyQueue()
            {
                stk1 = new Stack<int>();
                stk2 = new Stack<int>();
            }

            public void Push(int x)
            {
                stk1.Push(x);
            }

            public int Pop()
            {
                if (stk2.Count == 0)
                {
                    while (stk1.Count > 0)
                    {
                        stk2.Push(stk1.Pop());
                    }
                }
                return stk2.Pop();
            }

            public int Peek()
            {
                if (stk2.Count == 0)
                {
                    while (stk1.Count > 0)
                    {
                        stk2.Push(stk1.Pop());
                    }
                }
                return stk2.Peek();
            }

            public bool Empty()
            {
                return stk1.Count == 0 && stk2.Count == 0;
            }
        }
    }
}
