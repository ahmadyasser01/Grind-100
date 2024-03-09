using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{


    partial class Program
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast is not null && fast.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow) return true;

            }
            return false;
        }
    }
}
