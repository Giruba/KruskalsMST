using System;

namespace KruskalsAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kruskal's algorithm!");
            Console.WriteLine("--------------------");

            Graph graph = GetGraphFromInput();
            try
            {
                graph.KruskalMinimumSpanningTree();
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static Graph GetGraphFromInput() {
            Graph graph = null;

            Console.WriteLine("Enter the no of vertices in the graph");
            try
            {
                int noVertices = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the no of edges in the graph");
                int noEdges = int.Parse(Console.ReadLine());
                graph = new Graph(noVertices, noEdges);
                Console.WriteLine("Enter the edges with the weight sourceVertex " +
                    "endVertex in the order separated by space");
                for (int i = 0; i < noEdges; i++) {
                    String[] edgeElements = Console.ReadLine().Split(' ');
                    graph.addEdge(i, int.Parse(edgeElements[0]),
                        int.Parse(edgeElements[1]), int.Parse(edgeElements[2]));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return graph;
        }
    }
}
