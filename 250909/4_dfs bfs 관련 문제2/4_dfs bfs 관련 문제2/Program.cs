using static System.Net.Mime.MediaTypeNames;

namespace _4_dfs_bfs_관련_문제2
{
    internal class Program
    {
        static bool[,] visited = new bool[50, 50]; // 방문 배열 (최대크기가 50이니까)
        static int[] deltaY = { -1, 0, 1, 0 };  // Y 축 좌표
        static int[] deltaX = { 0, -1, 0, 1 };  // X 축 좌표
        static int m, n, k;  // 가로 m, 세로 n, 배추 개수 k
        static int[,] adj = new int[50, 50];    // 맵 배열 (최대크기가 50이라 했음)

        static void DFS(int y, int x)
        {
            visited[y, x] = true;
            for (int i = 0; i < 4; i++)
            {
                int newY = y + deltaY[i];
                int newX = x + deltaX[i];

                if (newY < 0 || newY >= n || newX < 0 || newX >= m)
                    continue;
                if (adj[newY, newX] == 0)
                    continue;
                if (visited[newY, newX] == true)
                    continue;
                DFS(newY, newX);
            }
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()); // 회차
            while (t-- > 0) // 회차 돌때마다 1씩 후위감소연산 
            {
                int ret = 0;

                Array.Clear(adj); // 회차라는건 배열을 그대로 쓴다는거니까 배열 초기화
                Array.Clear(visited); // 회차라는건 배열을 그대로 쓴다는거니까 배열 초기화
                string[] input = Console.ReadLine().Split(); // 2번째 줄에 m, n, k 준다고 했으니까 한줄 받기
                m = int.Parse(input[0]); // 한줄 받아서 분리
                n = int.Parse(input[1]); // 한줄 받아서 분리
                k = int.Parse(input[2]); // 한줄 받아서 분리

                int x, y; // 그 밑에줄부터 배추에 대한 x, y 좌표 준다고 했으니까 

                for (int i = 0; i < k; i++) // 배추 준다고 한 k 개수만큼 포문 돌기
                {
                    string[] delta = Console.ReadLine().Split(); // 좌표 x y 주니까 한줄 받아서 띄어쓰기로 분리
                    x = int.Parse(delta[0]); // 한줄 받아서 분리
                    y = int.Parse(delta[1]); // 한줄 받아서 분리
                    adj[y, x] = 1; // 배추 있는 좌표 받았으니 배열에 해당 좌표에 배추 심기
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (adj[i, j] == 0)
                            continue;
                        if (visited[i, j] == true)
                            continue;
                        DFS(i, j);
                        ret++;
                    }
                }

                Console.WriteLine(ret);
            }
        }
    }
}