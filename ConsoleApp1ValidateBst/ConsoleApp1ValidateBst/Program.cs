using System;

namespace ConsoleApp1ValidateBst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool ValidateBst(BST tree)
        {
            return ValidateBst(tree, Int32.MinValue, Int32.MaxValue);
        }
        public static bool ValidateBst(BST tree, int Min, int Max)
        {
            if(tree.value < Min || tree.value >= Max)
            {
                return false;
            }
            if(tree.left != null && !ValidateBst(tree.left, Min, tree.value))
            {
                return false;
            }
            if(tree.right != null && !ValidateBst(tree.right, tree.value, Max)){
                return false;
            }
            return true;
        }
        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}
