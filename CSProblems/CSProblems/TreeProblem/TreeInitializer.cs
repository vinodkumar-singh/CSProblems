namespace CSProblems.TreeProblem
{
    using Model;
    public static class TreeInitializer
    {
        public static (Node<int> treeNode, Node<int> bstNode) Initialize()
        {
            Node<int> treeNode = new Node<int>()
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

            Node<int> bstNode = new Node<int>()
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
                        Value = 9
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
            return (treeNode, bstNode);
        }
    }
}
