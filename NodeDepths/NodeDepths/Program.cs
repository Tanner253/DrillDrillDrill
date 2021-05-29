using System;

namespace NodeDepths
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int NodeDepths(BinaryTree root)
        {
            return NodeDepthsHelper(root, 0);
        }

        public static int NodeDepthsHelper(BinaryTree root, int depth)
        {
            if (root == null) return 0;
            return depth + NodeDepthsHelper(root.lChild, depth + 1) + NodeDepthsHelper(root.rChild, depth + 1);

        }

        public class BinaryTree
        {
            public int value;
            BinaryTree lChild;
            BinaryTree rChild;
            public BinaryTree(int value)
            {
                this.value = value;
                lChild = null;
                rChild = null;
            }
        }
    }
}
