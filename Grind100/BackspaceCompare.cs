

using System.Text;

namespace Grind100
{
    partial class Program
    {
        public bool BackspaceCompare(string s, string t)
        {
            StringBuilder sb_S = new StringBuilder();
            StringBuilder sb_T = new StringBuilder();

            foreach (var chr in s)
            {
                if (chr == '#')
                {
                    if (sb_S.Length > 0) sb_S.Remove(sb_S.Length - 1, 1);
                }
                else sb_S.Append(chr);
            }
            foreach (var chr in t)
            {
                if (chr == '#')
                {
                    if (sb_T.Length > 0) sb_T.Remove(sb_T.Length - 1, 1);
                }
                else sb_T.Append(chr);
            }
            return string.Compare(sb_S.ToString(), sb_T.ToString()) == 0 ? true : false;

        }
    }
}
