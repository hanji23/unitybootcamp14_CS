using static System.Net.Mime.MediaTypeNames;

namespace _4_BFS
{
    class Graph
    {
        int[,] adj = new int[6, 6] //인접행렬방식
        {
            //{ 0, 1, 0, 1, 0, 0, },
            //{ 1, 0, 1, 1, 0, 0, },
            //{ 0, 1, 0, 0, 0, 0, },
            //{ 1, 1, 0, 0, 0, 0, },
            //{ 0, 0, 0, 0, 0, 1, },
            //{ 0, 0, 0, 0, 1, 0, }

            { 0, 1, 0, 1, 0, 0, },
            { 1, 0, 1, 1, 0, 0, },
            { 0, 1, 0, 0, 0, 0, },
            { 1, 1, 0, 0, 1, 0, },
            { 0, 0, 0, 1, 0, 1, },
            { 0, 0, 0, 0, 1, 0, }
        };


        public int[] distance = new int[6];

        //방문 목록 만들기
        public bool[] visited = new bool[6];

        public void BFS(int start)
        {
            //예약목록
            Queue<int> queue = new Queue<int>();

            //예약목록에 예약하기
            queue.Enqueue(start);
            visited[start] = true;

            distance[start] = 0;

            //예약목록에서 예약을 꺼내서 아직 예약하지 않았고 연결되어있으며 방문 안한 애들을 예약하기
            while (queue.Count > 0) 
            {
                //예약 목록에서 꺼내옴
                int now = queue.Dequeue();
                Console.WriteLine($"방문 : {now}, 단계 : {distance[now]}");

                for (int next = 0; next < adj.GetLength(0); next++) 
                {
                    //연결이 되어있는지
                    if (adj[now, next] == 0)
                        continue;
                    //방문이 되어있는지
                    if (visited[next] == true)
                        continue;
                    
                    //에약하기
                    queue.Enqueue(next);
                    visited[next] = true;

                    distance[next] = distance[now] + 1;
                }
            }
            Console.WriteLine(distance[adj.GetLength(0) - 1]);
        }
    }

    internal class Program
    {
        static void BFS()
        {

        }

        static void Main(string[] args)
        {
            Graph g = new Graph();
            g.BFS(0);

            //int[,] map = new int[100, 100];

            string[] s = Console.ReadLine().Split();

            int n = int.Parse(s[0]); // y
            int m = int.Parse(s[1]); // x

            int[,] map = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string s2 = Console.ReadLine();

                for (int j = 0; j < m; j++)
                {
                    map[i, j] = s2[j] - '0';
                }
            }

            bool[,] visited = new bool[n, m];

            int[,] distance = new int[n, m];

            Queue<(int, int)> queue = new Queue<(int, int)>();

            queue.Enqueue((0, 0));
            distance[0, 0] = 1;

            while (queue.Count > 0)
            {
                (int y, int x) = queue.Dequeue();
                visited[y, x] = true;

                for (int i = 0; i < 4; i++)
                {
                    int[] dy = { -1, 0, 1, 0 };
                    int[] dx = { 0, -1, 0, 1 };

                    int nextY = y + dy[i];
                    int nextX = x + dx[i];

                    if (nextY < 0 || nextX < 0 || nextY >= n || nextX >= m)
                        continue;
                    if (visited[nextY, nextX] == true)
                        continue;
                    if (map[nextY, nextX] == 0)
                        continue;

                    queue.Enqueue((nextY, nextX));
                    distance[nextY, nextX] = distance[y, x] + 1;

                }
            }

            Console.WriteLine(distance[n - 1, m - 1]);

            //map = new int[n, m];
        }
    }
}
