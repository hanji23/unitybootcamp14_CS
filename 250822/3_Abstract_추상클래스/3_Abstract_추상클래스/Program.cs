namespace _3_Abstract_추상클래스
{
    //추상클래스 : 상속구조에서 특정 기능을 반드시 구현하도록 강제할수 있음
    //하나이상의 추상함수를 가지고 있는 클래스
    //추상클래스는 미완성 클래스 이기에 객체를 생성할수 없음
    internal class Program
    {
        //abstract class 클래스 이름

        abstract class Monster
        {
            //public virtual void attack()
            //{

            //}
            // 상속받은 클래스에서 반드시 구현해야할 함수에 abstract
            //↓자식 클래스에서 무조건 구현해야함
            abstract public void attack();

            //↓강제성 없음
            public void Test()
            {

            }
        }

        class Orc : Monster
        {
            //추상 클래스를 구현할 때도 override가 있어야함
            public override void attack()
            {
                Console.WriteLine("오크의 공격");
            }
        }
        class Slime : Monster
        {
            public override void attack()
            {
                Console.WriteLine("슬라임의 공격");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //추상클래스는 미완성 클래스 이기에 객체를 생성할수 없음
            //Monster monster = new Monster();

            Orc orc = new Orc();
            Slime slime = new Slime();

            orc.attack();
        }
    }
}
