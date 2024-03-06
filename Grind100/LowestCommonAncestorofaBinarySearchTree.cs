using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while (root is not null)
            {
                if (p.val > root.val && q.val > root.val)
                    root = root.right;
                else if (p.val < root.val && q.val < root.val)
                    root = root.left;
                else
                    return root;
            }
            return root;
        }
    }
}
