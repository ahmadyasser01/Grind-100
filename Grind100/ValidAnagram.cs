using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public bool IsAnagram_SpaceOptimized(string s, string t)
        {
            s = String.Concat(s.OrderBy(c => c));
            t = String.Concat(t.OrderBy(c => c));
            return String.Compare(s, t) == 0;
        }

        public bool IsAnagram_TimeOptimized(string s, string t)
        {
            int[] arr = new int[26];

            for(int i=0;i<s.Length;i++)
            {
                arr[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            { 
                arr[t[i] - 'a']--;
            }
            foreach (int i in arr)
            {
                if (i != 0) return false;
                
            }
            return true;
        }
    }
}
