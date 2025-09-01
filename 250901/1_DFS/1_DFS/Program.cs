namespace _1_DFS
{
    //DFS = 깊이 우선 탐색 (Depth first Search)
    // DFS는 그래프를 탐색할 때 쓰는 알고리즘
    // 어떤 버텍스부터 시작해서 인접한 버텍스들을 재귀적으로 방문
    // 방문한 정점은 다시 방문하지 않습니다
    // 각 분기마다 가능한 가장 멀~리 있는 버텍스까지 탐색
    // 핵심 : 내가 했던일을 내 다음에게 떠넘긴다
    // DFS의 역할 : 끊긴길 찾기

    //BFS = 너비 우선 탐색 (Breadth firsh Search)

    class Graph
    {
        int[,] adj = new int[6, 6] //인접행렬방식
        {
            { 0, 1, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0, 1 },
            { 0, 0, 0, 0, 1, 0 }
        };

        bool[] found = new bool[6];

        public void DFS(int now)
        {
            // 1. now 부터 방문후 방문 체크
            Console.WriteLine($"방문 : {now}");
            found[now] = true;

            // 2. now와 연결된 정점들을 하나씩 확인, 아직 방문하지않은 정점을 방문
            for (int next = 0; next < adj.GetLength(0); next++)
            {
                if (adj[now, next] == 0) // 연결된 정점들을 확인
                {
                    continue;
                }

                if (found[next] == true) //아직 방문하지않은 정점인지 확인
                {
                    continue;
                }
                DFS(next);
            }
        }

        public void SearchAll(int now)
        {
            Console.WriteLine($"SearchAll 방문 : {now}");
            found[now] = true;

            //for (int next = 0; next < adj.GetLength(0); next++)
            //{

            //    if (visited[next] == true) //아직 방문하지않은 정점인지 확인
            //    {
            //        continue;
            //    }
            //    SearchAll(next);
            //}

            for (int next = 0; next < adj.GetLength(0); next++)
            {

                if (found[next] == false)
                {
                    DFS(next);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Graph graph = new Graph();
            //graph.DFS(0);
            graph.SearchAll(0);
        }
    }
}
