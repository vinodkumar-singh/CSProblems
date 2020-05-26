namespace CSProblems.TreeProblem
{
    using CSProblems.Model;
    using System;

    public class CheckIfBinaryTreeBST
    {
        public static void Run()
        {
            var initNode = TreeInitializer.Initialize();
            Console.WriteLine($"IsBST : {IsBinarySearchTree(initNode.treeNode)} ");
            Console.WriteLine($"IsBST : {IsBinarySearchTree(initNode.bstNode)} ");
        }
        public static bool IsBinarySearchTree(Node<int> root)
        {
            if (root == null)
                return true;
            if (IsBinarySearchTree(root.Left) && IsBinarySearchTree(root.Right) &&
                IsSubTreeLesser(root.Left, root.Value) && IsSubTreeGreater(root.Right, root.Value))
            {
                return true;
            }
            else
                return false;
        }

        private static bool IsSubTreeLesser(Node<int> root, int value)
        {
            if (root == null)
                return true;
            if (root.Value <= value && IsSubTreeLesser(root.Left, value) && IsSubTreeLesser(root.Right, value))
                return true;
            else
                return false;
        }

        private static bool IsSubTreeGreater(Node<int> root, int value)
        {
            if (root == null)
                return true;
            if (root.Value > value && IsSubTreeGreater(root.Left, value) && IsSubTreeGreater(root.Right, value))
                return true;
            else
                return false;
        }
    }
}
