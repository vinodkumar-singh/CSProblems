namespace CSProblems.TreeProblem
{
    using Model;
    using System;

    static class TreeTraversal
    {
        public static void Run()
        {
            var initNode = TreeInitializer.Initialize();
            Console.Write("InOrder Traversal :");
            InOrderTraversal(initNode.treeNode);
            Console.WriteLine();

            Console.Write("PreOrder Traversal :");
            PreOrderTraversal(initNode.treeNode);
            Console.WriteLine();

            Console.Write("PostOrder Traversal :");
            PostOrderTraversal(initNode.treeNode);
            Console.WriteLine();
        }

        public static void InOrderTraversal(Node<int> root)
        {
            if (root == null)
                return;
            InOrderTraversal(root.Left);
            Console.Write($"{root.Value}, ");
            InOrderTraversal(root.Right);
        }

        public static void PreOrderTraversal(Node<int> root)
        {
            if (root == null)
                return;
            Console.Write($"{root.Value}, ");
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        public static void PostOrderTraversal(Node<int> root)
        {
            if (root == null)
                return;

            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.Write($"{root.Value}, ");
        }
    }
}
