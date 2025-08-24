namespace _4_문제
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-10×10 맵을 2차원 배열로 정의하라.
            //- 1은 벽, 0은 빈칸으로 간주하고, 벽은 '■', 빈칸은 '·' 문자로 출력하라.
            //- 각 행은 줄바꿈으로 구분한다.

            //[출력결과]
            //■ ■ ■ ■ ■ ■ ■ ■ ■ ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ · · · · · · · · ■
            //■ ■ ■ ■ ■ ■ ■ ■ ■ ■

            //int[,] map = new int[10,10];
            int[,] map =
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };

            for (int x = 0; x < map.GetLength(0); x++)
            {

                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if (map[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("■");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("·");
                    }
                        
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            //========================
            //문제 3) 전치(Transpose) 출력
            //========================
            //- 3×3 배열을 전치하여 출력하라.
            //- 전치란 a[r,c]를 aT[c,r]로 바꾸는 것이다.

            int[,] a = new int[3, 3]
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    };

            //[출력결과]
            //1 4 7
            //2 5 8
            //3 6 9

            int[,] aT = new int[3, 3];

            for (int x = 0; x < a.GetLength(0); x++)
            {

                for (int y = 0; y < a.GetLength(1); y++)
                {
                    aT[y, x] = a[x, y];
                    Console.Write(aT[y, x]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] t = new int[n, m];
            for (int r = 0; r < a.GetLength(0); r++)
            {

                for (int c = 0; c < a.GetLength(1); c++)
                {
                    t[c, r] = a[r, c];
                    
                }
                
            }

            for (int r = 0; r < a.GetLength(0); r++)
            {

                for (int c = 0; c < a.GetLength(1); c++)
                {
                   
                    Console.Write(t[c, r]);
                }
                Console.WriteLine();
            }
        }
    }
}
