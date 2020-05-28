namespace CSProblems
{
    using CSProblems.GraphProblem;
    using CSProblems.Heap;
    using CSProblems.TreeProblem;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TreeTraversal.Run();
            CheckIfBinaryTreeBST.Run();
            BinaryTreeOperations.Run();
            TransformToBST.Run();
            LowestCommonAncestor.Run();
            BSTOperations.Run();

            Console.WriteLine();
            GraphTraversal graph = new GraphTraversal();
            graph.Run();

            Console.WriteLine();
            Console.WriteLine("Dijkstra Algo:");
            Dijkstra dj = new Dijkstra();
            dj.Run();

            SortingAlogrithm.Run();
            Console.WriteLine();
            Console.WriteLine("Heap : ");
            HeapProblem.Run();
            Console.ReadLine();
        }
    }
}
