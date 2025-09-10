namespace _3_트럭_문제
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // int a = 0, b = 0, c = 0;
            // string[] input = Console.ReadLine().Split();

            // int[] t1 = new int[0], t2 = new int[0], t3 = new int[0];

            // int result = 0;

            //for (int i = 0; i < 3; i++)
            //{

            //    switch (i)
            //    {
            //        case 0:
            //            a = int.Parse(input[i]);
            //            break;
            //        case 1:
            //            b = int.Parse(input[i]);
            //            break;
            //        case 2:
            //            c = int.Parse(input[i]);
            //            break;
            //    }
            //}
            //if (c > 0 && c <= b && b >= c && b <= a && a >= b && a <= 100)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {

            //        input = Console.ReadLine().Split();

            //        switch (i)
            //        {
            //            case 0:
            //                t1 = new int[int.Parse(input[1])];

            //                for (int j = 0; j < t1.Length - 1; j++)
            //                {
            //                    if (j >= int.Parse(input[0]) - 1)
            //                    {
            //                        t1[j] = 1;
            //                    }
            //                }

            //                break;
            //            case 1:
            //                t2 = new int[int.Parse(input[1])];

            //                for (int j = 0; j < t2.Length - 1; j++)
            //                {
            //                    if (j >= int.Parse(input[0]) - 1)
            //                    {
            //                        t2[j] = 1;
            //                    }
            //                }
            //                break;
            //            case 2:
            //                t3 = new int[int.Parse(input[1])];

            //                for (int j = 0; j < t3.Length - 1; j++)
            //                {
            //                    if (j >= int.Parse(input[0]) - 1)
            //                    {
            //                        t3[j] = 1;
            //                    }
            //                }
            //                break;
            //        }
            //    }

            //    int MaxLength;

            //    MaxLength = Math.Max(t1.Length, t2.Length);
            //    MaxLength = Math.Max(t2.Length, t3.Length);

            //    Console.WriteLine();

            //    int[] copy = new int[MaxLength];

            //    for (int i = 0; i < t1.Length; i++)
            //    {
            //        copy[i] = t1[i];
            //    }

            //    t1 = copy;

            //    copy = new int[MaxLength];

            //    for (int i = 0; i < t2.Length; i++)
            //    {
            //        copy[i] = t2[i];
            //    }

            //    t2 = copy;

            //    copy = new int[MaxLength];

            //    for (int i = 0; i < t3.Length; i++)
            //    {
            //        copy[i] = t3[i];
            //    }

            //    t3 = copy;



            //    foreach (int i in t1)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //    Console.WriteLine();
            //    foreach (int i in t2)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //    Console.WriteLine();
            //    foreach (int i in t3)
            //    {
            //        Console.Write($"{i}, ");
            //    }



            //    for (int i = 0; i < MaxLength; i++)
            //    {

            //        if (t1[i] == 1 && t2[i] == 1 && t3[i] == 1)
            //        {
            //            result += (3 * c);
            //            //Console.WriteLine("c");
            //        }
            //        else if ((t1[i] == 1 && t2[i] == 1 && t3[i] != 1) || (t1[i] == 1 && t2[i] != 1 && t3[i] == 1) || (t1[i] != 1 && t2[i] == 1 && t3[i] == 1))
            //        {
            //            result += (2 * b);
            //            //Console.WriteLine("b");
            //        }
            //        else if ((t1[i] == 1 && t2[i] != 1 && t3[i] != 1) || (t1[i] != 1 && t2[i] != 1 && t3[i] == 1) || (t1[i] != 1 && t2[i] == 1 && t3[i] != 1))
            //        {
            //            result += a;
            //            //Console.WriteLine("a");
            //        }
            //    }

                
            //}

            //Console.WriteLine(result);

            int A, B, C, start, end;
            int ret = 0;
            int[] count = new int[101];

            string[] input = Console.ReadLine().Split();
            A = int.Parse(input[0]);
            B = int.Parse(input[1]);
            C = int.Parse(input[2]);

            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine().Split();
                start = int.Parse(input[0]);
                end = int.Parse(input[1]);

                for (int j = start; j < end; j++)
                {
                    count[j]++;
                }
            }

            for (int j = 1; j <= 100; j++)
            {
                if (count[j] > 0)
                {
                    if (count[j] == 1)
                        ret += A;
                    else if (count[j] == 2)
                        ret += B * 2;
                    else if (count[j] == 3)
                        ret += C * 3;
                }
            }
            Console.WriteLine(ret);
        }
    }
}
