using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        bool IsBadVersion(int version)
        {
            return true;
            // this is not implemented
        }
        public int FirstBadVersion(int n)
        {
            int low = 0;
            int high = n;
            int mid = low + (high - low) / 2;
            while (low < high)
            {
                mid = low + (high - low) / 2; // 3 + (5-3)/2
                if (IsBadVersion(mid) == false)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return high;
        }
    }
}
