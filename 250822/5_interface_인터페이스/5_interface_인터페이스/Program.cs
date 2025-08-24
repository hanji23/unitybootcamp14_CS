namespace _5_interface_인터페이스
{
    abstract class Monster
    {
        public void Move()
        {
            Console.WriteLine("몬스터가 한 칸 이동합니다.");
        }
        abstract public void Attack();
    }

    abstract class Element : Monster
    {
        abstract public void ElementalAttack();
    }

    class Orc : Monster
    {
        public override void Attack()
        {
            Console.WriteLine("오크가 몽둥이로 공격!");
        }
    }

    //C# 다중상속 금지 _ 클래스는 2개 이상 상속받을수 없음 (죽음의 다이아몬드 상속 : 다중 상속중 각각의 부모에 같은 이름의 변수가 있을 경우 모호함 발생)
    //class FireOrc : Orc, Element
    //{

    //}

    //이런 경우는 인터페이스를 사용
    interface IElement
    {
        void ElementalAttack();
    }

    class FireOrc : Monster, IElement
    {
        public override void Attack()
        {
            
        }

        public void ElementalAttack()
        {
            
        }
    }

    class Skeleton : Monster
    {
        public override void Attack()
        {
            Console.WriteLine("스켈레톤이 화살을 발사!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
