namespace _2_문제2
{
    internal class Program
    {
        static void CountingStar()
        {
            int[] a = new int[26];
            string s = Console.ReadLine();

            foreach (int i in s)
            {
                a[i - 'a']++;
            }

            foreach (int i in a)
            {
                Console.Write(i);
            }
        }

        static void Main(string[] args)
        {

            int[] a = { 15, 3, 9, 27, -5, 8, 99 };

            int max = a[0], min = a[0];

            for (int i= 0; i < a.Length - 1; i++)
            {

                if (a[i + 1] > max)
                {
                    max = a[i + 1];
                    
                }
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] < min)
                {
                    min = a[i + 1];

                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);

            CountingStar();
        }
    }
}
