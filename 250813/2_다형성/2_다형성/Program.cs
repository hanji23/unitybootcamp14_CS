namespace _2_다형성
{
    //다형성(Polymorphism) - 여러가지 형태를 가지는 성질
    // OOP의 다형성 - 같은 이름의 메서드나 인터페이스를 통해 여러 다른 형태를 구현하는것

    //class Player
    //{
    //    public int hp;
    //    public int mp;

    //    public void Move()
    //    {
    //        Console.WriteLine("Move");
    //    }
    //}

    //class Knight : Player
    //{
    //    public new void Move()
    //    {
    //        Console.WriteLine("Knight Move");
    //    }
    //}

    //class Mage : Player
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Mage Move");
    //    }
    //}

    class Player
    {
        public int hp;
        public int mp;

        public virtual void Move()
        {
            Console.WriteLine("Move");
        }
    }

    class Knight : Player
    {
        public sealed override void Move()
        {
            Console.WriteLine("Knight Move");
        }
    }

    class Mage : Player
    {
        public override void Move()
        {
            Console.WriteLine("Mage Move");
        }
    }

    class SuperKnight : Knight
    {
        public /* override */ void Move() //부모클래스에서 함수에 sealed를 쓰면 상속받은 자식클래스에서 오버라이드(함수 재정의)를 못하지만 실제론 잘 쓰이진 않음
        {
            Console.WriteLine("SuperKnight Move");
        }
    }

    internal class Program
    {
        static void Test (Player p)
        {
            p.Move();
        }

        static void Main(string[] args)
        {
            //Knight knight = new Knight();
            //knight.Move();
            //Mage mage = new Mage();
            //mage.Move();

            /*********** 다형성 ***********/
            Player player = new Knight();
            Player player1 = new Mage();

            player.Move(); //virtual붙이면 재정의한 함수(오버라이드)도 찾아서 호출함
            player1.Move();
            /******************************/

            Test(player);
            Test(player1);
        }
    }
}
