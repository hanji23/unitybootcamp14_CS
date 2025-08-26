namespace _2_Nullable
{

    //nullable - null 이 가능한
    //게임쪽은 상대적으로 덜사용하나 DB 같은 곳에서 사용함

    class Monster 
    {
        public int id;

        public Monster(int Id)
        {
            this.id = Id;
        }

        public Monster MatchId(int id) 
        {
            if (this.id == id)
            {
                return this;
            }
            return null;
        }

        public int? Search(int id)
        {
            if (this.id == id)
            {
                return this.id;
            }else
                return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int number = null; 값형식이라 null 사용불가
            //{
            int? number = null;
            //int b = number;
            //int b = number.Value; //number의 값을 가져오나 null 경우 에러발생
            int b;
            if (number.HasValue == true)//number에 값이 있다면
            {
                b = number.Value;
               
            }
            else
            {
                b = 5;
            }
            Console.WriteLine(b);
            //}
            //↓
            int c = number ?? 5; //DB에서 많이 사용하는 문법
            Console.WriteLine(c);


            Monster monster = new Monster(30);
            Monster found = monster.MatchId(30);
            Console.WriteLine($"{monster.Search(30)}  !");
        }
    }
}
