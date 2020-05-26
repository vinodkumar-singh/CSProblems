using CSProblems.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.TreeProblem
{
    public class BinaryTreeOperations
    {
        public static void Run()
        {
            var initNode = TreeInitializer.Initialize();
            Console.WriteLine($"Height of Tree : {Height(initNode.treeNode)}");
            Node<int> newNodeToAdd = new Node<int>()
            {
                Value = 25
            };
            AddNewNodeAndTranformToBST(initNode.treeNode, newNodeToAdd);
            Console.WriteLine($"AddNewNodeAndTranformToBST - IsBST : {CheckIfBinaryTreeBST.IsBinarySearchTree(initNode.treeNode)} ");
        }

        public static int Height(Node<int> root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var lh = Height(root.Left);
                var rh = Height(root.Right);

                if (lh > rh)
                {
                    return lh + 1;
                }
                else
                {
                    return rh + 1;
                }
            }
        }

        public static void AddNewNodeAndTranformToBST(Node<int> root, Node<int> newNode)
        {
            if (root == null || newNode == null)
                return;
            AddNewNode(root, newNode);
            TransformToBST.ConvertToBinaryTree(root, 8);
        }
        private static void AddNewNode(Node<int> root, Node<int> newNode)
        {
            if (root == null)
                return;

            if (root.Value > newNode.Value)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    AddNewNode(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    AddNewNode(root.Right, newNode);
            }
        }
    }
}
