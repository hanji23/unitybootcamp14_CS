
using System.Threading;
using System.Xml.Linq;

namespace static_
{
    //필드(멤버변수), 지역변수
    //     멤버함수 , 지역함수

    #region
    //class Knight
    //{
    //    //필드(= 멤버변수)
    //    //Knight에 포함된 데이터
    //    //클래스 내에서 존재하는 경우
    //    public int atk = 30;
    //    public string name = "아서";

    //    void Test()
    //    {
    //        //지역변수 (함수 내에서 존재하는 경우)
    //        int a = 0;
    //        { 
    //            //지역변수
    //            int b = 0;
    //        }
    //    }

    //    //멤버함수
    //    public void Attack(Knight k, Monster target)
    //    {
    //        int damege = atk;
    //        //지역함수
    //        void DamageLog(int damage) //접근 지정자를 붙일수 없음 : 퍼블릭, 프라이빗, 프로텍티드
    //        {
    //            target.hp -= damage;
    //            Console.WriteLine($"{k.name}가 {target.name}에게 {damage}의 피해를 입힘");
    //            Console.WriteLine($"{target.name}의 남은 체력 : {target.hp}");
    //        }

    //        DamageLog(damege);
    //    }
    //}

    //class Monster
    //{
    //    public int hp = 100;
    //    public string name = "고블린";
    //}
    #endregion

    class Knight
    {
        // Knight에서 공용으로 사용할 변수
        static int count = 0;
        // 객체에 속하지 않고 오직 Knight에서 공용으로 사용하는 변수, 정적변수 전역변수 느낌으로 사용함 
        // 정적변수는 클래스에 있어도 데이터 영역에 할당됨

        // Knight에서 공용으로 사용하고, 외부에서 객체 없이 접근 할수 있도록 하고 싶을때
        public static int a = 0;

        public int hp;
        public int id;

        public Knight()
        {
            this.id = count;
            count++;
        }
    }

    class Utill
    {
        static void add(int a, int b)
        {
            int sum = a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            ////지역변수
            //int a = 0;

            ////Knight knight = new Knight();
            ////Knight knight1 = new Knight();
            ////Knight knight2 = new Knight();
            ////Knight knight3 = new Knight();

            ////knight = knight1;
            ////knight1 = null;
            //////가비지컬랙터 -> 연결이 안되어있는 아무도 사용하지않는 객체를 삭제

            //Knight knight = new Knight();
            //Monster monster = new Monster();

            //knight.Attack(knight, monster);
#endregion

            Knight knight = new Knight();
            knight.hp = 100;
            //knight.count = 1; // <- 에러
            //Knight.count = 1; // 에러는 나지 않지만 추후에 public을 사용하지 않을 예정이므로 사용하지 않음

            Knight knight1 = new Knight();
            //id = 1
            Knight knight2 = new Knight();
            //id = 2
            Knight knight3 = new Knight();
            //id = 3
        }
    }
}
