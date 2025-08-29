namespace _2_graph
{
    //graph - 개념적으로는 현실세계의 사물이나 추상적인 개념간의 연결관계를 표현한다
    // 정점 - vertex, 노드
    //  ㄴ 데이터를 표현(위치, 사람, 물건)
    // 간선 - 엣지
    //  ㄴ 정점을 잇는 선(관계, 경로)
    internal class Program
    {
        //class Vertex
        //{

        //    public List<Vertex> edges = new List<Vertex>();

        //}

        //class Edge
        //{
        //    public int vertex;
        //    public int weight;
        //    public Edge(int v, int w)
        //    {
        //        vertex = v;
        //        weight = w;
        //    }
        //}

        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello, World!");
            //    List<Vertex> Vertex = new List<Vertex>();

            //    Vertex.Add(new Vertex());
            //    Vertex.Add(new Vertex());
            //    Vertex.Add(new Vertex());
            //    Vertex.Add(new Vertex());
            //    Vertex.Add(new Vertex());

            //    Vertex[0].edges.Add(Vertex[1]);
            //    Vertex[0].edges.Add(Vertex[2]);

            //    Vertex[1].edges.Add(Vertex[2]);
            //    Vertex[1].edges.Add(Vertex[3]);

            //    Vertex[2].edges.Add(Vertex[0]);
            //    Vertex[2].edges.Add(Vertex[2]);
            //    Vertex[2].edges.Add(Vertex[3]);

            //    Vertex[3].edges.Add(Vertex[4]);

            //List<int>[] adj = new List<int>[5]
            //{
            //    new List<int> { 1, 2, },
            //    new List<int> { 2, 3, },
            //    new List<int> { 0, 2, 3 },
            //    new List<int> { 4 },
            //    new List<int> {  },
            //};

            //List<Edge>[] adj = new List<Edge>[4]
            //{ 
            //    //            (1번 버텍스↖  ↗가중치 2)
            //    new List<Edge> { new Edge(1, 2), new Edge(2, 1) },
            //    new List<Edge> { new Edge(1, 2), new Edge(2, 1) },
            //    new List<Edge> { new Edge(1, 2), new Edge(2, 1) },
            //    new List<Edge> { new Edge(1, 2), new Edge(2, 1) }
            //};

            int[,] adj = new int[5, 5]
            {
                { 0, 1, 1, 0, 0 }, // 0번점 표시 (2번점과 3번점 연결)
                { 1, 0, 1, 1, 0 }, // 1번점 표시
                { 1, 1, 0, 1, 0 }, // 2번점 표시
                { 0, 1, 1, 0, 1 }, // 3번점 표시
                { 0, 0, 0, 1, 0 }  // 4번점 표시
                //연결 되어 있으면 1 아니면 0으로 표기
            };

            if (adj[0, 3] == 1)
            {
                //인덱스 접근 방법
            }

            int[,] adj2 = new int[5, 5]
            {
                //가중치가 있다면?
                { -1, 02, 03, -1, -1 }, // 0번점 표시 (2번점과 3번점 연결)
                { 02, -1, 07, 26, -1 }, // 1번점 표시
                { 03, 07, -1, 12, -1 }, // 2번점 표시
                { -1, 26, 12, -1, 09 }, // 3번점 표시
                { -1, -1, -1, 09, -1 }  // 4번점 표시
                //이땐 연결 되어 있지 않다는 것을 -1 로 표기
            };

            if (adj[0, 3] == 1)
            {
                //인덱스 접근 방법
            }

            //bool[,] adj = new bool[5, 5]
            //{
            //    { false, true, true, false, false }, // 0번점 표시 (2번점과 3번점 연결)
            //    { 1, 0, 1, 1, 0 }, // 1번점 표시
            //    { 1, 1, 0, 1, 0 }, // 2번점 표시
            //    { 0, 1, 1, 0, 1 }, // 3번점 표시
            //    { 0, 0, 0, 1, 0 }  // 4번점 표시
            //};
        }
    }
}
