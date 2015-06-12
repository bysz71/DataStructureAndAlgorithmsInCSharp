using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.NonGeneric
{
    public class DijkstrasAlgorithm
    {
        public static void FindShortestPath(Graph graph, char start)
        {
            var d = new Dictionary<char, int>();
            var s = new Dictionary<char, bool>();

            char current = start;
            d[start] = 0;
            s[start] = true;
            foreach (LinkedList<Edge> entry in graph.List)
            {
                if (entry.First.Value.Key != start){
                    d[entry.First.Value.Key] = 1000000;
                    s[entry.First.Value.Key] = false;
                }
            }

            char bufferChar;
            int bufferInt;
            while (s.ContainsValue(false))
            {
                bufferChar = current;
                bufferInt = 10000000;
                foreach (Edge edge in graph.LList(current))
                {
                    if (edge.Key != current)
                    {
                        d[edge.Key] = Math.Min(d[edge.Key], d[current] + graph.GetEdge(current, edge.Key).Distance);
                    }
                }

                foreach (KeyValuePair<char, bool> entry in s)
                {
                    if (entry.Value == false)
                    {
                        if (d[entry.Key] < bufferInt)
                        {
                            bufferInt = d[entry.Key];
                            bufferChar = entry.Key;
                        }
                    }
                }
                current = bufferChar;
                s[current] = true;
            }

            foreach (KeyValuePair<char, int> entry in d)
            {
                Console.Write("(" + entry.Key + "," + s[entry.Key] + "," + entry.Value + ")  ");
            }
        }
    }
}
