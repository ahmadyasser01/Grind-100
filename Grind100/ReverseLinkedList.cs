using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode r = null;
            ListNode q = head;
            ListNode p = head;
            if (p is not null) p = p.next;
            while (p is not null)
            {

                q.next = r;
                r = q;
                q = p;
                if (p is not null)
                    p = p.next;
            }
            if (q is not null)
                q.next = r;
            return q;
        }
        }
    }
}
