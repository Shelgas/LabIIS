using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaSecond
{
    class GraphNumerator : IIterator
    {

        Dictionary<int, HashSet<int>> Graph { get; set; }
        private int vertex;
        private HashSet<int> visited = new HashSet<int>();
        private Queue<int> q = new Queue<int>();

        public GraphNumerator(Dictionary<int, HashSet<int>> graph)
        {
            vertex = 1; 
            Graph = graph;

            q.Enqueue(vertex);
        }


        public int Next()
        {
            var current = q.Dequeue();
        

            if (Graph.ContainsKey(current))
            {
                
                foreach (int neighbour in Graph[current].Where(a => !visited.Contains(a)))
                {
                    visited.Add(neighbour);
                    q.Enqueue(neighbour);
                }
            }

            return current;
        }

        public bool HasMoveNext()
        {
            return q.Count > 0;
        }
    }
}
