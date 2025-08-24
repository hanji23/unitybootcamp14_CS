namespace _250729_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i;
            int j;

            string s = "*";

            for (i = 2; i < 10; i++) 
            {
                for (j = 1; j < 10; j++ )
                {
                    Console.WriteLine($"{i} X {j} = {i*j}");
                }
            }

            for (i = 0; i < 5; i++)
            {
                //for (j = 5; j > 0; j--)
                //{

                //    if (i == j)
                //        break;
                //    Console.Write($"{s}");
                //}
                for (j = 5; j > i; j--)
                {
                    Console.Write($"{s}");
                }
                Console.WriteLine("");
            }
            for (i = 5; i > 0; i--)
            {
                //for (j = 6; j > 0; j--)
                //{
                    
                //    if ( i == j )
                //        break;
                //    Console.Write($"{s}");
                //}
                for (j = 6; j > i; j--)
                {
                    Console.Write($"{s}");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            int a = 1;
            int b = 12;

            for(i = 1; i <= 11; i++)
            {
                if (i <= 5)
                {
                    for (j = 1; j <= 11; j++)
                    {
                        if (j >= a && j < b)
                            Console.Write($"{s}");
                        else
                            Console.Write(" ");
                    }
                    a++;
                    b--;
                    Console.WriteLine("");
                }
                else
                {
                    for (j = 1; j <= 11; j++)
                    {
                        if (j >= a && j < b)
                            Console.Write($"{s}");
                        else
                            Console.Write(" ");
                    }
                    a--;
                    b++;
                    Console.WriteLine("");
                }
            }
        }
    }
}