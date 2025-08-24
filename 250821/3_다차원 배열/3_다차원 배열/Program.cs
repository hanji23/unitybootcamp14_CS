namespace _3_다차원_배열
{
    internal class Program
    {
        static public int[,] board =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };
        static void Main(string[] args)
        {
            //데이터타입[,] 배열이름 = new 타입[행, 열]

            int[,] map = new int[10, 10];
            // 배열이름[행, 열] = 값;

            map[0, 0] = 1;
            map[0, 1] = 2;  
            map[1, 2] = 3;  
            map[2, 3] = 4;

            //축약형
            Render();

            //↓자주 사용하지않음
            int[][] jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[1] = new int[4];
            jagged[2] = new int[2];
            //[  [][][]    ]
            //[  [][][][]  ]
            //[  [][]      ]
        }

        static public void Render()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
            
                for(int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
        }
    }
}
