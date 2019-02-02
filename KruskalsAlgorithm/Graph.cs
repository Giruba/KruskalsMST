using System;
using System.Collections.Generic;
using System.Text;

namespace KruskalsAlgorithm
{
    class Graph
    {
        int noVertices;
        int noEdges;
        Edge []_Edges;

        public Graph() { }

        public Graph(int vertices, int edges) {
            noVertices = vertices;
            noEdges = edges;
            _Edges = new Edge[noEdges];
            for (int i = 0; i < noEdges; i++) {
                _Edges[i] = new Edge();
            }
        }

        public void addEdge(int index, int weight, int sourceVertex, int endVertex) {
            _Edges[index].SetSourceVertex(sourceVertex);
            _Edges[index].SetEndVertex(endVertex);
            _Edges[index].SetWeight(weight);
        }

        public void KruskalMinimumSpanningTree() {
            Edge[] resultantMST = new Edge[noVertices];

            int resultIndex = 0;
            int originalEdgeIndex = 0;

            Subset[] subsets = new Subset[noVertices];
            for (int i = 0; i < noVertices; i++) {
                subsets[i] = new Subset();
                subsets[i].SetParent(i);
                subsets[i].SetRank(0);
            }

            Array.Sort(_Edges);

            while (resultIndex < (noVertices - 1)) {
                Edge considered = new Edge();
                considered = _Edges[originalEdgeIndex++];

                int x = find(subsets, considered.GetSourceVertex());
                int y = find(subsets, considered.GetEndVertex());

                if (x != y) {
                    resultantMST[resultIndex++] = considered;
                    Union(subsets, x, y);
                }
            }

            Console.WriteLine("----- Kruskal's MST -------");
            for (int i = 0; i < resultantMST.Length-1; i++) {
                Console.WriteLine(resultantMST[i].GetSourceVertex()+"->"
                    +resultantMST[i].GetEndVertex()+"("+
                    resultantMST[i].GetWeight()+")");
            }
        }

        private int find(Subset[] subsets, int value) {
            if (subsets[value].GetParent() != value) {
                return find(subsets, subsets[value].GetParent());
            }
            return subsets[value].GetParent();
        }

        private void Union(Subset []subsets, int x, int y) {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            if (subsets[xroot].GetRank() < subsets[yroot].GetRank())
            {
                subsets[xroot].SetParent(yroot);
            }
            else if (subsets[xroot].GetRank() > subsets[yroot].GetRank())
            {
                subsets[yroot].SetParent(xroot);
            }
            else {
                subsets[yroot].SetParent(xroot);
                subsets[xroot].SetRank(subsets[xroot].GetRank() + 1);
            }
        }

    }
}
