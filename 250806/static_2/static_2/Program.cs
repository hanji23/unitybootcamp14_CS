
namespace static_2
{
    class Knight
    {
        public static int count = 0;
        public int id;
        public int hp;

        public Knight() 
        {
            id = count;
            count++;
            hp = 100;
        }

        public void Info(Knight knight)
        {
            Console.WriteLine($"기사 ID: {knight.id}, 체력: {knight.hp}");
        }
    }
     

    internal class Program
    {
        public static void ResetCount()
        {
            Knight.count = 0;
            Console.WriteLine("Knight 수 초기화!");
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Knight knight2 = new Knight();

            knight.Info(knight);
            knight.Info(knight2);
            Console.WriteLine($"현재 Knight 수: {Knight.count}");
            ResetCount();
            Console.WriteLine($"현재 Knight 수: {Knight.count}");
        }
    }
}
