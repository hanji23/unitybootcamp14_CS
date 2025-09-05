namespace c__0_클래스
{
    class Player
    {
        // 필드 : 멤버 변수 (속성) (클래스에 만들어진 변수)
        int hp;
        int str;
        int atk;
        int def;

        // 기능 : 멤버 함수
        void Attck()
        {

        }

        void Skill()
        {

        }
    }

    class HealingPotion()
    {
        int heal = 0;

        void Heal()
        {

        }
    }

    struct Monster
    {
        public int hp;
        public int str;

    }
    //구조체와 클래스는 메모리 형식이 다름
    struct Point
    {
        public int x;
        public int y;
    }
    //값형식 값 데이터

    class Point2
    {
        public int x;
        public int y;
    }

    class Knight
    {
        public int hp;
        public int str;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //절차지향(procedural Programming)
            // procedure프로시저 - 함수 중심으로 프로그램을 구조화해서 문제를 해결하는 방식
            // 프로그램이 커지거나 분할되면 이때부터 무리가 생김
            // 절차지향의 가장 큰 문제점은 순서
            // 함수 호출 순서로 문제 해결

            //객체지향(Object-Oriented Programming, OOP)
            // 캐릭터, 몬스터, 아이템, 보이는거에서부터 스킬, 사운드 안보이는것 까지
            // 전부다 하나의 객체로 각각만드는 것

            //절차지향은 '함수중심으로 흐름을 만들고 조립하는 방식'이라면
            //객체지향은 '객체에게 역할을 부여하고, 객체간 협력을 통해 문제를 해결하는 방식'

            int a; //지역변수

            Player player = new Player(); // 인스턴스화

            // 함수는 = 스텍 메모리
            // 클레스 = 힙 메모리

            // 사용자가 직접만든 클래스의 주소를 담을때 운영체제의 비트만큼 스택메모리에 공간을 잡음 / 64비트 운영체제 -> 64비트

            // 변수 player는 스텍메모리에 공간을 만듬 (main함수 -> 변수 -> 스택메모리)
            // 인스턴스화를 하면 힙메모리에 해당 클래스의 값들을 할당 그리고 해당 힙메모리 주소를 위에 스텍 메모리에 할당

            //구조체와 클래스는 메모리 형식이 다름
            /*구조체*/Point point = new Point();   // 값형식 -> 값전달 -> 값 복사 (값이 스택메모리에 )
            /*클래스*/Point2 point2 = new Point2();// 참조(주소)형식 -> 참조전달 -> 주소공유 (값이 힙메모리에)

            //구조체 ->   값형식 -> 메모리를 잡으면 그안에 값이 들어간다
            //클래스 -> 참조형식 -> 스텍메모리에 값이 담긴 주소가 들어간다. -> 힙메모리에 값이 들어간다

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 2;

            Point p2 = new Point();
            p2 = p1;
            p2.x = 3;
            p2.y = 4;

            Console.WriteLine($"p1 - x {p1.x} y {p1.y}");
            Console.WriteLine($"p2 - x {p2.x} y {p2.y}");

            Knight knight1 = new Knight();
            knight1.hp = 100;
            knight1.str = 50;

            Knight knight2 = new Knight();
            knight2 = knight1; //knight2가 참조하던 주소를 knight1주소로  
            //얕은 복사 : 스텍의 주소값만 복사하는 것을 얕은 복사라 함

            knight2.hp = 200;
            knight2.str = 100;

            Console.WriteLine($"knight1 - hp {knight1.hp} str {knight1.str}");
            Console.WriteLine($"knight2 - hp {knight2.hp} str {knight2.str}");

            Knight knight3 = new Knight();
            Knight knight4 = new Knight();

            knight3.hp = 100;
            knight4.hp = 50;

            knight3.hp = knight4.hp; // 50 150
            //knight3 = knight4; //150 150

            knight4.hp = 150;

            Console.WriteLine($"knight3 - hp {knight3.hp} str {knight3.str}");
            Console.WriteLine($"knight4 - hp {knight4.hp} str {knight4.str}");

            //깊은 복사 : 힙에 있는 데이터를 복사해 오는 것을 깊은 복사라 함


            //얕은 복사 : 스택의 주소를 복사하면 얕은복사
            //일단 객체하나 생성
            //Person[       ]
            //    int age = 객체의 값 복사
            //    string name = 객체가 현재 들고 잇는 주소를 복사해서 줌
            //    결과적으로 값형식의 필드는 서로 완전히 다른 애를 들고 있는거고
            //    참조형식의 필드는 서로 같은 객체를 보고 있다


            //깊은 복사 : 힙의 내용물을 복사하면 깊은복사
            //일단 객체하나 생성
            //Person[]
            //    int age = 객체의 값 복사
            //    string name = 객체의 새 객체를 만들어서 그 주소를 줌
            //    결과적으로 값형식의 필드는 서로 완전히 다른 애를 들고 있는거고
            //    참조형식의 필드는 서로 "다른" 객체를 보고 있다


            //메모리구조

            //      코드 영역(텍스트영역)
            //    데이터 영역

            //        힙 영역
            // 동적할당 하는 애들이 여기 올라감
            // 클래스로 객체를 생성하면 그 데이터(값)이 힙 영역에 올라갑니다


            //      스택 영역 - 임시적이고 불안전한 공간
            // 함수가 실행되면 그 함수의 매개변수, 그 함수의 내부에서 선언된 변수들이 스텍공간에 잠시 올라감
            // 함수가 종료되면 스택 공간에서 빠짐
            // 값 형식의 데이터 변수를 만들면 스택에 올라감
            // 클래스의 힙영역에 올라간 데이터의 주소 변수
        }
    }
}
