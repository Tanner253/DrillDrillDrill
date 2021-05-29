using System;
using System.Collections.Generic;

namespace LeafSumsOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree leftChild;
            public BinaryTree rightChild;
            public BinaryTree(int value)
            {
                this.value = value;
                this.leftChild = null;
                this.rightChild = null;
            }
        }
        public static void CalculateBranchSums(BinaryTree root, int runningSum, List<int> sums)
        {
            if (root == null) return;
            int newRunningSum = runningSum += root.value;
            if(root.leftChild == null && root.rightChild == null){
                sums.Add(newRunningSum);
                return;
            }
            CalculateBranchSums(root.leftChild, newRunningSum, sums);
            CalculateBranchSums(root.rightChild, newRunningSum, sums);

        }
    }
}
