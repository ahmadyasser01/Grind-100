using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public int MajorityElement(int[] nums)
        {
            // return nums
            //     .GroupBy(i => i)
            //     .OrderByDescending(g => g.Count())
            //     .Take(1)
            //     .Select(g => g.Key).First();

            int freq = 0, majElement = 0;
            foreach (var num in nums)
            {
                if (freq == 0) majElement = num;
                freq += num == majElement ? 1 : -1;
            }
            return majElement;
        }
    }
}
