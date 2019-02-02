using System;
using System.Collections.Generic;
using System.Text;

namespace KruskalsAlgorithm
{
    class Edge : IComparable
    {
        int weight;
        int sourceVertex;
        int endVertex;

        public int CompareTo(Object edge){
            if (edge == null) return -1;
            Edge compared = edge as Edge;
            return weight.CompareTo(compared.weight) ;
        }

        public Edge() { }

        public Edge(int weight, int sourceVertex, int endVertex) {
            this.weight = weight;
            this.sourceVertex = sourceVertex;
            this.endVertex = endVertex;
        }

        public void SetWeight(int weight) {
            this.weight = weight;
        }

        public void SetSourceVertex(int sourceVertex) {
            this.sourceVertex = sourceVertex;
        }

        public void SetEndVertex(int endVertex) {
            this.endVertex = endVertex;
        }

        public int GetWeight() {
            return weight;
        }

        public int GetSourceVertex() {
            return sourceVertex;
        }

        public int GetEndVertex() {
            return endVertex;
        }

    }
}
