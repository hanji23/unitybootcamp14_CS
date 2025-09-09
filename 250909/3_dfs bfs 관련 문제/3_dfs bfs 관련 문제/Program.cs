namespace _3_dfs_bfs_관련_문제
{
    class Pos
    {
        public Pos(int y, int x) { Y = y; X = x; }

        public int Y;
        public int X;
    }

    internal class Program
    {
        enum Dir
        {
            Up = 0,
            Left = 1,
            Down = 2,
            Right = 3,
        }

        int _dir = (int)Dir.Up;

        static void Main(string[] args)
        {
            int[] deltaY = new int[] { -1, 0, 1, 0 };
            int[] deltaX = new int[] { 0, -1, 0, 1 };

            int m, n;
            int[,] adj;
            int[,] visited;

            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);

            adj = new int[n, m];
            visited = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < m; j++) 
                {
                    adj[i, j] = line[j] - '0';
                }
            }

            //bool[,] found = new bool[n, m];
            //Pos[,] parant = new Pos[n, m];

            //int PosY = 0;
            //int PosX = 0;

            //found[PosY, PosX] = true;
            //parant[PosY, PosX] = new Pos(PosY, PosX);

            //Queue<Pos> queue = new Queue<Pos>();
            //queue.Enqueue(new Pos(PosY, PosX));



            //while (queue.Count > 0)
            //{
            //    Pos pos = queue.Dequeue();
            //    int nowY = pos.Y;
            //    int nowX = pos.X;

            //    for (int i = 0; i < 4; i++)
            //    {
            //        int nextY = nowY + deltaY[i];
            //        int nextX = nowX + deltaX[i];

            //        //범위를 초과하는지
            //        if (nextY < 0 || nextY >= n || nextX < 0 || nextX >= m)
            //            continue;

            //        //체크하려는 점이 갈수 있는 점인지
            //        if (adj[nextY, nextX] == 0)
            //            continue;

            //        //이미 찾은 점인지 확인
            //        if (found[nextY, nextX] == true)
            //            continue;

            //        queue.Enqueue(new Pos(nextY, nextX));
            //        found[nextY, nextX] = true;
            //        parant[nextY, nextX] = new Pos(nowY, nowX);

            //    }

            //}

            //List<Pos> _points = new List<Pos>();
            //int y = n - 1;
            //int x = m - 1;

            //while (parant[y, x].Y != y || parant[y, x].X != x)
            //{
            //    //_points.Push(new Pos(y, x));

            //    //[0] => 목적지
            //    //[1] => 목적지 부모
            //    // ...
            //    //[마지막인덱스] => 최초 지점

            //    _points.Add(new Pos(y, x));
            //    Pos pos = parant[y, x];
            //    y = pos.Y;
            //    x = pos.X;

            //}

            //_points.Add(new Pos(y, x)); // 최초지점 수동추가
            //_points.Reverse();
            ////[0] => 최초 지점
            ////[1] => 최초 지점 다음
            //// ...
            ////[마지막인덱스] => 목적지

            //Console.WriteLine(_points.Count);

            Queue<(int, int)> queue = new Queue<(int, int)> ();
            visited[0, 0] = 1;
            queue.Enqueue((0, 0));

            while (queue.Count > 0) 
            {
                (int y, int x) = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nY = y + deltaY[i];
                    int nX = x + deltaX[i];

                    //범위체크
                    if(nY < 0 || nY >= n || nX < 0 || nX >= m)
                        continue;

                    if (adj[nY,nX] == 0)
                        continue;

                    if (visited[nY, nX] > 0)
                        continue;

                    visited[nY, nX] = visited[y, x] + 1;

                    queue.Enqueue((nY, nX));
                }   
            }
            Console.WriteLine(visited[n - 1, m - 1]);
        }
    }
}
