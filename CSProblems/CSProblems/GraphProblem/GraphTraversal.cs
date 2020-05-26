namespace CSProblems.GraphProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GraphTraversal
    {
        public void Run()
        {
            int verticesCount = 6;
            Graph graph = new Graph(verticesCount);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 5);
            graph.AddEdge(1, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 6);
            graph.AddEdge(5, 4);

            Console.WriteLine("Graph Traversal DFS Recursive : ");
            graph.DFSRecursive(1, new Dictionary<int, bool>());
            Console.WriteLine();
            
            Console.WriteLine("Graph Traversal DFS Using Stack : ");
            graph.DFSUsingStack(1, new Dictionary<int, bool>());
            Console.WriteLine();
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("Graph Traversal BFS Recursive : ");
            graph.BFSRecursive(queue, new Dictionary<int, bool>());
            Console.WriteLine();
            
            queue.Enqueue(1);
            Console.WriteLine("Graph Traversal BFS Using Queue : ");
            graph.BFSUsingQueue(queue, new Dictionary<int, bool>());
        }

        public class Graph
        {
            int Vertices;
            List<int>[] adjacentVertices;

            public Graph(int verticesCount)
            {
                this.Vertices = verticesCount;

                adjacentVertices = new List<int>[this.Vertices+1];

                for (int i = 1; i <= this.Vertices; i++)
                {
                    this.adjacentVertices[i] = new List<int>();
                }
            }

            public class Edge
            {
                public int Source;
                public int Destination;
                public int Weight;

                public Edge(int source, int destination, int weight)
                {
                    Source = source;
                    Destination = destination;
                    Weight = weight;
                }
            }

            public void AddEdge(int source, int destination, bool unDirected = false)
            {
                adjacentVertices[source].Add(destination);
                if (unDirected)
                {
                    adjacentVertices[destination].Add(source);
                }
            }

            public void DFSRecursive(int startingVertex, Dictionary<int, bool> visitedVertex)
            {
                Console.Write($"{startingVertex} -> ");
                visitedVertex[startingVertex] = false;
                
                foreach(var adjancentVertex in adjacentVertices[startingVertex])
                {
                    if (!visitedVertex.ContainsKey(adjancentVertex) || (visitedVertex.ContainsKey(adjancentVertex) && !visitedVertex[adjancentVertex]))
                    {                        
                        DFSRecursive(adjancentVertex, visitedVertex);
                    }
                    visitedVertex[adjancentVertex] = true;
                }
                visitedVertex[startingVertex] = true;
            }

            public void DFSUsingStack(int startingVertex, Dictionary<int,bool> visitedVertex)
            {
                visitedVertex[startingVertex] = false;
                Stack<int> stack = new Stack<int>();
                stack.Push(startingVertex);                
                while(stack.Count != 0)
                {
                    startingVertex = stack.Pop();
                    visitedVertex[startingVertex] = true;
                    Console.Write($"{startingVertex} -> ");
                    foreach (var adjacentvertex in adjacentVertices[startingVertex])
                    {
                        if (!visitedVertex.ContainsKey(adjacentvertex) || (visitedVertex.ContainsKey(adjacentvertex) && !visitedVertex[adjacentvertex]))
                            stack.Push(adjacentvertex);
                    }
                }
            }

            public void BFSRecursive(Queue<int> queue, Dictionary<int, bool> visitedVertex)
            {
                if (queue.Count > 0)
                {
                    int startingVertex = queue.Dequeue();
                    Console.Write($"{startingVertex} -> ");
                    visitedVertex[startingVertex] = true;
                    foreach (var adjacentvertex in adjacentVertices[startingVertex])
                    {
                        if (!visitedVertex.ContainsKey(adjacentvertex) || (visitedVertex.ContainsKey(adjacentvertex) && !visitedVertex[adjacentvertex]))
                        {
                            visitedVertex[adjacentvertex] = false;
                            queue.Enqueue(adjacentvertex);
                        }
                    }
                    BFSRecursive(queue, visitedVertex);
                }
            }

            public void BFSUsingQueue(Queue<int> queue, Dictionary<int, bool> visitedVertex)
            {
                visitedVertex[queue.Peek()] = false;
                while (queue.Count != 0)
                {
                    int startingVertex = queue.Dequeue();
                    if (!visitedVertex[startingVertex])
                        Console.Write($"{startingVertex} -> ");
                    visitedVertex[startingVertex] = true;
                    foreach (var adjacentvertex in adjacentVertices[startingVertex])
                    {
                        if (!visitedVertex.ContainsKey(adjacentvertex) || (visitedVertex.ContainsKey(adjacentvertex) && !visitedVertex[adjacentvertex]))
                        {
                            visitedVertex[adjacentvertex] = false;
                            queue.Enqueue(adjacentvertex);
                        }
                    }
                }
            }
        }
    }
}
