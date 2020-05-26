namespace CSProblems.TreeProblem
{
    using CSProblems.Model;
    using System;

    public class BSTOperations
    {
        public static void Run()
        {
            var initNode = TreeInitializer.Initialize();
            Node<int> newNodeForBST = new Node<int>()
            {
                Value = 4
            };

            AddNewNodeToBST(initNode.bstNode, newNodeForBST);
            Console.WriteLine($"AddNewNodeToBST - IsBST : {CheckIfBinaryTreeBST.IsBinarySearchTree(initNode.bstNode)} ");
            Console.WriteLine($"InOrder for BST : ");
            TreeTraversal.InOrderTraversal(initNode.bstNode);
        }
        private static void AddNewNodeToBST(Node<int> root, Node<int> newNode)
        {
            if (root == null || newNode == null)
                return;
            if (root.Value > newNode.Value)
            {
                if (root.Left != null)
                {
                    AddNewNodeToBST(root.Left, newNode);
                }
                else
                {
                    root.Left = newNode;
                }
            }
            else
            {
                if (root.Right != null)
                {
                    AddNewNodeToBST(root.Right, newNode);
                }
                else
                {
                    root.Right = newNode;
                }
            }
        }

        private static void DeleteNodeFromBST(Node<int> root, Node<int> deleteNode)
        {

        }
    }
}
