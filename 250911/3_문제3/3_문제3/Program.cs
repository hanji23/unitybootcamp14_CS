namespace _3_문제3
{
    internal class Program
    {

        static void Add(int Y, int X)
        {
            int[,] map =
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            if (Y + 1 < map.GetLength(0))
            {
                map[Y + 1, X]++;
            }

            if (Y - 1 >= 0)
            {
                map[Y - 1, X]++;
            }

            if (X + 1 < map.GetLength(0))
            {
                map[Y, X + 1]++;
            }

            if (X - 1 >= 0)
            {
                map[Y , X - 1]++;
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    Console.Write($"{map[i, j]}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr =
            {
                {1 , 2, 3 },
                { 4 , 5 , 6 },
                { 7 , 8 , 9 }
            };

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        Console.Write($"{ arr[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write($"{arr[j, i]}");
                }
                Console.WriteLine();
            }

            Add(2, 2);
        }
    }
}
