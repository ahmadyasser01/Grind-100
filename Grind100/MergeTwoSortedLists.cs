using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        } }
        public partial class Program
        {

             static ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                ListNode head = null;
                ListNode tail = new ListNode(0,null);
                ListNode f = list1;
                ListNode s = list2;
                while(f!=null && s!=null)
                {

                    if (f.val < s.val)
                    {
                        tail.next = f;
                        f = f.next;
                    }
                    else
                    {
                        tail.next = s;
                        s = s.next;
                    }
                    if (head == null) head = tail.next;
                    tail = tail.next;
                }
                if (f != null) tail.next = f;
                else tail.next = s;
            if (head == null) head = tail.next;
                return head;
            }
        }
    }

