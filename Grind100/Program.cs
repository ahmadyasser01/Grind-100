namespace Grind100
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var answer = TwoSum([2, 7, 11, 15], 9);
            //var answer = MaxProfit([7, 6, 4, 3, 1]);
            //var answer = IsValid("(])");
            var list1_3 = new ListNode(4, null);
            var list1_2 = new ListNode(2,list1_3);
            var list1 = new ListNode(1, list1_2);

            var list2_3 = new ListNode(4, null);
            var list2_2 = new ListNode(3, list2_3);
            var list2 = new ListNode(1, list2_2);


            MergeTwoLists(null,new ListNode(0,null));

        }
       

    }
}
