using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grind100
{
    partial class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var y = target - nums[i];
                if (dict.ContainsKey(y)) return new int[] { i, dict[y] };
                else
                {
                    dict[nums[i]] = i;
                }
            }
            return new int[] { -1, -1 };
        }

    }
}
