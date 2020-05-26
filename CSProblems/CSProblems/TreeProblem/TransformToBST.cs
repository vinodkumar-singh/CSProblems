using CSProblems.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.TreeProblem
{
    public class TransformToBST
    {
        public static void Run()
        {
            var initNode = TreeInitializer.Initialize();
            ConvertToBinaryTree(initNode.treeNode, 7);
            Console.WriteLine($"ConvertToBinaryTree - IsBST : {CheckIfBinaryTreeBST.IsBinarySearchTree(initNode.treeNode)} ");
        }

        public static void ConvertToBinaryTree(Node<int> root, int arraySize = 0)
        {
            if (root == null)
                return;
            int[] array = new int[arraySize];
            int count = 0;
            InOrderTraversalInToArray(root, ref array, ref count);
            Array.Sort(array);
            Console.WriteLine();
            foreach (var a in array)
            {
                Console.Write($"{a} ");
            }
            count = 0;
            Console.WriteLine();
            TransformTreeToBST(root, array, ref count);
            Console.WriteLine();
        }

        private static void TransformTreeToBST(Node<int> root, int[] array, ref int count)
        {
            if (root == null)
                return;
            TransformTreeToBST(root.Left, array, ref count);
            root.Value = array[count];
            count++;
            Console.Write($"{root.Value} ");
            TransformTreeToBST(root.Right, array, ref count);
        }

        private static void InOrderTraversalInToArray(Node<int> root, ref int[] array, ref int count)
        {
            if (root == null)
                return;
            InOrderTraversalInToArray(root.Left, ref array, ref count);
            array[count] = root.Value;
            count++;
            InOrderTraversalInToArray(root.Right, ref array, ref count);
        }
    }
}
