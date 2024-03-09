using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root is null) return true;
            int l = geth(root.left);
            int r = geth(root.right);
            if (Math.Abs(l - r) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        public int geth(TreeNode root)
        {
            if (root is null) return 0;
            return 1 + Math.Max(geth(root.left), geth(root.right));
        }
    }
}
