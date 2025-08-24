namespace 생성자
{
    class Knight
    {
        public int hp;
        public int atk;

        // 기본생성자
        //public Knight ()
        //{
        //    Knight 타입의 객체를 힙에 생성
        //    힙 메모리
        //    [0000 0000 0000 0000 0000 0000 0000 0000][0000 0000 0000 0000 0000 0000 0000 0000]
        //    hp = 0;
        //    atk = 0;
        //    return Knight 타입의 객체
        //}

        // 기본생성자
        public Knight()
        {
            Console.WriteLine("응애 나 기본생성자");
        }

        public Knight(int hp, int atk) : this(10) // 함수 이름 재사용
        {
            this.hp = hp;
            this.atk = atk;
        }

        public Knight(int hp) : this() // 함수 이름 재사용
        {
            Console.WriteLine("응애 나 커스텀 생성자");
        }
    }
    class Wizard
    {
        public int mp;
        public int intelligence;

        public Wizard()
        {
            mp = 50;
            intelligence = 20;
        }
    }

    class Archer
    {
        public int hp;
        public int dexterity;

        public Archer()
        {
            hp = 70;
            dexterity = 30;
        }

        public Archer(int hp , int dexterity)
        {
            this.hp = hp;
            this.dexterity = dexterity;
        }
    }

    class Paladin
    {
        public int hp;
        public int atk;
        public int def;

        public Paladin()
        {
            Console.WriteLine("기본생성자 호출");
            def = 5;
        }

        public Paladin(int hp, int atk) : this()
        {
            Console.WriteLine("커스텀 생성자 호출");
            this.hp = hp;
            this.atk = atk;
        }
    }

    //구조체 생성자
    struct Point
    {
        public int x;
        public int y;

        public Point()
        {
            Console.WriteLine("구조체 생성자!");
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("새로운 구조체 생성자!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본생성자 호출
            Knight Knight = new Knight();
            // 매개변수가 있는 생성자 호출
            Knight strongKnight = new Knight(200, 10);

            Console.WriteLine($"강한 기사: HP {strongKnight.hp}, ATK {strongKnight.atk}");

            Wizard wizard = new Wizard();
            Console.WriteLine($" Wizard mp : {wizard.mp}, Wizard intelligence :  {wizard.intelligence}");

            Archer archer = new Archer();
            Console.WriteLine($" 기본 궁수 HP : {archer.hp}, 민첩성  :  {archer.dexterity}");

            Archer archer2 = new Archer(90, 45);
            Console.WriteLine($" 커스텀 궁수 HP : {archer2.hp}, 민첩성  :  {archer2.dexterity}");

            Paladin paladin = new Paladin(150, 30);
            Console.WriteLine($" 성기사  HP : {paladin.hp}, ATK  :  {paladin.atk}, DEF  :  {paladin.def}");

            Point p = new Point();
            Point p2 = new Point(10, 20);
        }
    }
}
