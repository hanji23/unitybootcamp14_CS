using System.Threading.Channels;

namespace _4_화살표_함수
{
    //화살표 함수 - 이름있는 메소드 짧게 쓰기
    internal class Program
    {
        public int hp;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int GethpArrow()
        {
            return hp;
        }
        //↓
        public int GethpArrow2() => hp;

        //프로퍼티에도 가능
        public string Status => hp > 0 ? "Alice" : "Dead";

        public void test() => Console.WriteLine(" ");
    }

    
}
