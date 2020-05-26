namespace CSProblems.TreeProblem
{
    using System;
    using Model;
    class LowestCommonAncestor
    {
        public static void Run()
        {
            var node = Initialize();
            Node<int> node1 = new Node<int>()
            {
                Value = 12
            };
            Node<int> node2 = new Node<int>()
            {
                Value = 19
            };
            Node<int> lcaNode = LCA(node.intRootNode, node1, node2);
            Console.WriteLine($"LCA for {node1.Value} and {node2.Value} is {lcaNode.Value}");
            Console.WriteLine();

            Node<string> nodea = new Node<string>()
            {
                Value = "r"
            };
            Node<string> nodeb = new Node<string>()
            {
                Value = "f"
            };
            Node<string> lcaNodeS = LCA(node.stringRootNode, nodea, nodeb);
            Console.WriteLine($"LCA for {nodea.Value} and {nodeb.Value} is {lcaNodeS.Value}");

        }

        static Node<int> LCA(Node<int> root, Node<int> node1, Node<int> node2)
        {
            if (root == null)
                return null;
            
            if (root.Value == node1.Value || root.Value == node2.Value)
                return root;

            Node<int> leftSearch = LCA(root.Left, node1, node2);
            Node<int> rightSearch = LCA(root.Right, node1, node2);

            //if (leftSearch == null && rightSearch == null)
            //    return null;

            //if (leftSearch != null && rightSearch != null)
            //    return root;

            if (leftSearch == null)
                return rightSearch;

            if (rightSearch == null)
                return leftSearch;

            return root;
        }

        static Node<string> LCA(Node<string> root, Node<string> node1, Node<string> node2)
        {
            if (root == null)
                return null;

            if (root.Value == node1.Value || root.Value == node2.Value)
                return root;

            Node<string> leftSearch = LCA(root.Left, node1, node2);
            Node<string> rightSearch = LCA(root.Right, node1, node2);

            //if (leftSearch == null && rightSearch == null)
            //    return null;

            //if (leftSearch != null && rightSearch != null)
            //    return root;

            if (leftSearch == null)
                return rightSearch;

            if (rightSearch == null)
                return leftSearch;

            return root;
        }


        static (Node<int> intRootNode, Node<string> stringRootNode) Initialize()
        {
            Node<int> rootNode = new Node<int>()
            {
                Value = 10,
                Left = new Node<int>()
                {
                    Value = 8,
                    Left = new Node<int>()
                    {
                        Value = 6
                    },
                    Right = new Node<int>()
                    {
                        Value = 5
                    }
                },
                Right = new Node<int>()
                {
                    Value = 19,
                    Left = new Node<int>()
                    {
                        Value = 12
                    },
                    Right = new Node<int>()
                    {
                        Value = 20
                    }
                }
            };

            Node<string> root1 = new Node<string>()
            {
                Value = "a",
                Left = new Node<string>()
                {
                    Value = "b",
                    Left = new Node<string>()
                    {
                        Value = "d",
                        Left = new Node<string>()
                        {
                            Value = "h"
                        },
                        Right = new Node<string>()
                        {
                            Value = "i",
                            Left = new Node<string>()
                            {
                                Value = "m"
                            },
                            Right = new Node<string>()
                            {
                                Value = "n"
                            }
                        }
                    },
                    Right = new Node<string>()
                    {
                        Value = "e",
                        Left = new Node<string>()
                        {
                            Value = "r"
                        },
                        Right = new Node<string>()
                        {
                            Value = "s"
                        }
                    }
                },
                Right = new Node<string>()
                {
                    Value = "c",
                    Left = new Node<string>()
                    {
                        Value = "f",
                        Left = new Node<string>()
                        {
                            Value = "j"
                        },
                        Right = new Node<string>()
                        {
                            Value = "k"
                        }
                    },
                    Right = new Node<string>()
                    {
                        Value = "g",
                        Right = new Node<string>()
                        {
                            Value = "l",
                            Left = new Node<string>()
                            {
                                Value = "p"
                            },
                            Right = new Node<string>()
                            {
                                Value = "q"
                            }
                        }
                    }
                }
            };

            return (rootNode, root1);
        }
    }
}
