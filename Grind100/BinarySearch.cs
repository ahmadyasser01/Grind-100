using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{ 
    partial class Program
    {
        public int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            int mid = (r - l) / 2 + l;
            while (l <= r)
            {
                mid = (r - l) / 2 + l;
                if (nums[mid] == target) { return mid; }
                if (nums[mid] > target) r = mid - 1;
                else
                    l = mid + 1;
            }
            return -1;
        }
    }
}
