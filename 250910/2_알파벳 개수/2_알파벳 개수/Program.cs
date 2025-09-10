namespace _2_알파벳_개수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            
            for (int i = 97; i < 123; i++)
            {
                
                keyValuePairs.Add((char)i, 0);
            }

            foreach (char c in s)
            {
                keyValuePairs[c] = keyValuePairs[c] + 1;
            }

            for (int i = 97; i < 123; i++)
            {
                Console.Write($"{keyValuePairs[(char)i]} ");
            }
            
            Console.WriteLine();

            int[] count = new int[26];

            foreach(int a in s)
            {
                count[a - 'a']++;
            }
            foreach(int a in count)
            {
                Console.Write($"{a} ");
            }
        }
        
    }
}
