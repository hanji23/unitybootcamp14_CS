using static System.Net.Mime.MediaTypeNames;

namespace _3_dfs_bfs
{
    class Graph
    {
        int[,] adj = new int[6, 6] //인접행렬방식
        {
            { 0, 1, 0, 1, 0, 0, },
            { 1, 0, 1, 1, 0, 0, },
            { 0, 1, 0, 0, 0, 0, },
            { 1, 1, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 0, 1, },
            { 0, 0, 0, 0, 1, 0, }

            //{ 0, 1, 0, 1, 0, 0, },
            //{ 1, 0, 1, 1, 0, 0, },
            //{ 0, 1, 0, 0, 0, 0, },
            //{ 1, 1, 0, 0, 1, 0, },
            //{ 0, 0, 0, 1, 0, 1, },
            //{ 0, 0, 0, 0, 1, 0, }
        };

        bool[] visited = new bool[6];

        public void DFS(int now)
        {
            //1. now 부터 방문 후 방문 체크
            Console.WriteLine($"방문 : {now}");
            visited[now] = true;

            //2. now와 연결된 정점들을 하나씩 확인해서 아직 방문하지 않은 정점을 방문
            for (int next= 0;next < adj.GetLength(0); next++)
            {
                //배열을 초과하는지 확인

                //연결되어있는지 확인
                if (adj[now, next] == 0)
                    continue;

                //이미 방문 했는지 확인
                if (visited[next] == true)
                    continue;

                DFS(next);
            }
        }

        public void SearchAll()
        {
            visited = new bool[6];
            for(int now = 0; now < adj.GetLength(0); now++)
            {
                if (visited[now] == false)
                    DFS(now);
            }
        }
    }


    internal class Program
    {
        static int[,] adj = new int[50, 50];
        static bool[,] visited = new bool[50, 50];
        static int[] dy = { -1, 0, 1, 0 };
        static int[] dx = { 0, -1, 0, 1 };

        static int m, n, k;
        static int ret = 0;

        static void DFS(int y, int x)
        {
            // 방문 처리
            visited[y, x] = true;

            //연결되어있는 노드 확인해서 아직 방문안한녀석 방문
            for (int i = 0; i < dy.Length; i++)
            {
                int newY = y + dy[i];
                int newX = x + dx[i];

                if (newY < 0 || newX < 0 || newY >= n || newX >= m)
                    continue;

                //배추가 있는지 확인
                if (adj[newY, newX] == 0)
                    continue;

                //이미 방문 했는지 확인
                if (visited[newY, newX] == true)
                    continue;

                DFS(newY, newX);

            }
        }

        static void Main(string[] args)
        {
            Graph g = new Graph();
            g.DFS(2);

            g.SearchAll();

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0) 
            {
                ret = 0;
                string[] s = Console.ReadLine().Split();

                m = int.Parse(s[0]); 
                n = int.Parse(s[1]);
                k = int.Parse(s[2]);

                Array.Clear(adj);
                Array.Clear(visited);
                //adj = new int[50, 50];

                int x, y;
                for (int i = 0; i < k; i++)
                {
                    s = Console.ReadLine().Split();
                    x = int.Parse(s[0]);
                    y = int.Parse(s[1]);
                    adj[y, x] = 1;
                }

                for (int now = 0; now < n; now++)
                {
                    for (int next = 0; next < m; next++)
                    {            
                        //배추가 있는지 확인
                        if (adj[now, next] == 0)
                            continue;

                        //이미 방문 했는지 확인
                        if (visited[now, next] == true)
                            continue;

                        DFS(now, next);
                        ret++;
                    }
                    
                }

                Console.WriteLine(ret);
                //t--;
            }
        }
    }
}
