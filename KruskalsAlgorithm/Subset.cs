using System;
using System.Collections.Generic;
using System.Text;

namespace KruskalsAlgorithm
{
    class Subset
    {
        int parent;
        int rank;

        public Subset() { }

        public Subset(int parent, int rank) {
            this.parent = parent;
            this.rank = rank;
        }

        public void SetParent(int value) {
            parent = value;
        }

        public void SetRank(int value) {
            rank = value;
        }

        public int GetParent() {
            return parent;
        }

        public int GetRank() {
            return rank;
        }
    }
}
