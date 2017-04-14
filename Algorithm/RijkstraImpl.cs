using System.Collections.Generic;
using System.Diagnostics;

namespace Dictionary.Algorithm
{
    public class RijkstraImpl
    {
        public static Dictionary<string, int> FindShortestPath(Dictionary<string, Dictionary<string, int>> vertices, string start, string finish)
        {
            var previous = new Dictionary<string, string>();
            var distances = new Dictionary<string, int>();
            var nodes = new List<string>();

           Dictionary<string,int> path = new Dictionary<string, int>();

            foreach (var vertex in vertices)
            {
                if (vertex.Key == start)
                {
                    distances[vertex.Key] = 0;
                }
                else
                {
                    distances[vertex.Key] = int.MaxValue;
                }

                nodes.Add(vertex.Key);
            }
            while (nodes.Count != 0)
            {
                nodes.Sort((x, y) => distances[x] - distances[y]);

                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest == finish)
                {
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest, distances[smallest]);
                        smallest = previous[smallest];
                    }

                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in vertices[smallest])
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if (alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
                Trace.WriteLine("Node: " + nodes.Count);
            }

            return path;
        }
    }
}