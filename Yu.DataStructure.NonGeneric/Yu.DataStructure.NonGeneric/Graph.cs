using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu.DataStructure.NonGeneric
{
    /// <summary>
    /// Graph type
    /// Compose by a List of EdgeList
    /// </summary>
    public class Graph
    {
        private List<LinkedList<Edge>> _list;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Graph()
        {
            _list = new List<LinkedList<Edge>>();
        }

        /// <summary>
        /// COnstructor based on a file
        /// </summary>
        /// <param name="fileName"></param>
        public Graph(string fileName)
        {
            _list = new List<LinkedList<Edge>>();
            StreamReader file = new StreamReader(fileName);
            string buffer;
            string[] bufferArray;
            while((buffer = file.ReadLine())!=null){
                if (String.Compare(buffer.Substring(0, 1),"#") == 0)
                {
                    continue;
                }
                if (String.Compare(buffer.Substring(0, 4), "Node") == 0)
                {
                    AddNode(buffer.Substring(5, 1)[0]);
                    continue;
                }
                bufferArray = buffer.Split(' ');
                AddEdge(bufferArray[0][0], bufferArray[1][0], bufferArray[2][0]);
            }
            file.Close();
        }

        /// <summary>
        /// Property returns _list
        /// </summary>
        public List<LinkedList<Edge>> List
        {
            get
            {
                return _list;
            }
        }

        /// <summary>
        /// Return specific LinkedList of some key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public LinkedList<Edge> LList(char key)
        {
            return _list[_list.FindIndex(x => x.First.Value.Key == key)];
        }

        /// <summary>
        /// Return an edge
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public Edge GetEdge(char from, char to)
        {
            foreach (Edge edge in LList(from))
            {
                if (edge.Key == to) return edge;
            }
            return null;
        }

        /// <summary>
        /// Add a node.
        /// Add a new LinkedList with First item that key is key and distance is 0.
        /// </summary>
        /// <param name="key"></param>
        public void AddNode(char key)
        {
            if (ContainsNode(key))
            {
                Console.WriteLine("Error: Node {0} already existed. You cannot add duplicate node.", key);
                return;
            }
            var lList = new LinkedList<Edge>();
            lList.AddFirst(new Edge(key, 0));
            _list.Add(lList);
        }

        /// <summary>
        /// Check if the graph have this node already
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsNode(char key)
        {
            foreach (LinkedList<Edge> item in _list)
            {
                if (item.First.Value.Key == key) return true;
            }
            return false;
        }

        /// <summary>
        /// Check if the graph have such edge with same from and to
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool ContainsEdge(char from, char to)
        {
            foreach (Edge item in LList(from))
            {
                if (item.Key == to) return true;
            }
            return false;
        }

        /// <summary>
        /// Add an edge
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="distance"></param>
        public void AddEdge(char from, char to, int distance)
        {
            if (!ContainsNode(from) || !ContainsNode(to))
            {
                Console.WriteLine("Error: Node not existed. AddEdge() must be based on existed node.");
                return;
            }

            if (ContainsEdge(from, to))
            {
                Console.WriteLine("Error: Edge to {0} already existed in node {1}. You cannot add duplicate edge.", to, from);
                return;
            }

            LList(from).AddLast(new Edge(to, distance));
        }

        /// <summary>
        /// Print whole graph
        /// </summary>
        public void Print()
        {
            Console.WriteLine("===Print Whole Graph Adjacent List===");
            foreach (LinkedList<Edge> item in _list)
            {
                foreach (Edge edge in item)
                {
                    Console.Write("|" + edge.Key + "|" + edge.Distance + "|" + "->");
                }
                Console.Write("Null\n");
            }
            Console.WriteLine("===Print Finished===");
        }

        /// <summary>
        /// Print specific LinkedList
        /// </summary>
        /// <param name="key"></param>
        public void Print(char key)
        {
            Console.Write("Adjacent List of node " + key + ": ");
            foreach (Edge edge in LList(key))
            {
                Console.Write("|" + edge.Key + "|" + edge.Distance + "|" + "->");
            }
            Console.Write("Null\n");
        }
    }

    public class Edge
    {
        public char Key;
        public int Distance;

        public Edge(char key, int distance)
        {
            Key = key;
            Distance = distance;
        }
    }
}
