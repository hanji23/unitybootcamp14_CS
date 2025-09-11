namespace _1_문제1
{
    internal class Program
    {

        static void Swap(ref int x, ref int y) 
        {
            int a = x;
            x = y; 
            y = a;   
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 10;
            int y = 20;

            Swap(ref x, ref y);

            Console.WriteLine($"{x} {y}");
        }
    }
}
