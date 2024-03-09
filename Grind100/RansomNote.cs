using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            char[] arr = new char[26];
            foreach (var ch in magazine)
            {
                arr[ch - 'a']++;
            }
            foreach (var ch in ransomNote)
            {
                if (arr[ch - 'a'] <= 0) return false;
                arr[ch - 'a']--;

            }
            foreach (var ch in arr)
            {
                if (ch < 0) return false;
            }
            return true;
        }
    }
}
