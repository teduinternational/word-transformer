namespace Dictionary.Entities
{
    public class Edge
    {
        public Edge(Vertex vertex1,Vertex vertex2,int cost)
        {
            this.Vertex1 = vertex1;
            this.Vertex2 = vertex2;
            this.Cost = cost;
        }
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }

        public int Cost { set; get; }
    }
}