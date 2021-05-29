using System;
namespace ClosestValueInBst
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int FindClosestValueInBst(BST tree, int target)
        {
            return FindClosestValueInBst(tree, target, tree.value);
        }

        private static int FindClosestValueInBst(BST tree, int target, int closest)
        {
            BST current = tree;
            while(current != null)
            {
                if(Math.Abs(target - closest) > Math.Abs(target - current.value))
                {
                    closest = current.value;
                }
                if(target < current.value)
                {
                    current = current.left;
                }else if(target > current.value)
                {
                    current = current.right;
                }
                else
                {
                    break;
                }
            }
            return closest;
        }

    }
}
