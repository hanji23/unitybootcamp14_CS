namespace _2_BFS
{
    //BFS = 너비 우선 탐색 (Breadth firsh Search)
    // 기억을 한다 => Queue를 통해서 값을 넣고 제일 오래기다린 놈부터 꺼내서 씀
    // BFS의 역할 : 경로를 탐색해서 정보를 기록, 다만 최단거리를 찾는 알고리즘이 아니다.

    // DFS의 역할 : 끊긴길 찾기

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
        int[] parant = new int[6];// parant[0] -> 0번의 부모가 누구야
        int[] distance = new int[6];//distance[0] -> 해당 정점까지 걸린 길이 몇개야

        public void BFS(int start)
        {
            //방문목록
            found = new bool[6];
        
            //예약목록
            Queue <int> queue = new Queue <int>();

            //예약목록에 예약하기
            queue.Enqueue(start);
            
            //방문 처리하기
            found[start] = true;

            while (queue.Count > 0)
            {
                //예약 목록에서 예약을 꺼내와서 
                int now = queue.Dequeue();
                Console.WriteLine($"방문 {now}");

                //아직 예약 안한 애들 전부 예약하기
                for (int next = 0; next < /*6*/adj.GetLength(0); next++)
                {
                    //연결이 안되어있으면 넘김
                    if (adj[now, next] == 0)
                    {
                        continue;
                    }

                    //연결이 되어있으면 이미 예약이 되어있는지 확인,
                    //예약이 됬으면 넘김
                    if (found[next] == true)
                    {
                        continue;
                    }

                    //예약하기
                    queue.Enqueue(next);
                    
                    //예약한놈 찾은놈으로 선정
                    found[next] = true;
                    //찾은놈의 부모는 now
                    parant[next] = now;
                    //찾은놈의 거리는 = 부모 + 1을 해주면 됨
                    distance[next] = distance[now] + 1;
                }
            }
        }

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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.BFS(0);
        }
    }
}
