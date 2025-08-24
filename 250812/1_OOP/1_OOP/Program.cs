namespace _1_OOP
{
    internal class Program
    {
        //OOP는 단지 기능이 많은 코드를 짜는 게 아니라, 변화에 강하고, 유지보수하기 쉽고, 협업하기 좋은 구조

        // 절차지향에서 불편했던 점	            ->  객체지향에서는 이렇게 해결됨
        // ------------------------------------------------------------------------------------------
        // 똑같은 코드를 여러 번 써야 함	    ->  공통 속성을 상위 클래스에 넣고, 상속으로 재사용 가능
        // 기능이 많아질수록 코드가 길어짐	    ->  객체 단위로 쪼개고, 각 객체가 자기 일만 처리하게 만듦
        // 수정할 때 모든 함수에 영향감	        ->  캡슐화 덕분에 클래스 내부만 바꾸면 됨
        // 코드를 읽기 어려워짐	                ->  객체 단위로 구조화되어 가독성 향상
        // 확장하거나 새로운 기능 넣기 어려움	->  기존 클래스 건드리지 않고 새 객체만 만들면 됨 (확장성)

        //OOP(객체지향 프로그래밍)
        //OOP의 4가지 특징은 서로 연결되어있고 클래스에서 이 4가지 특징이 녹아있음
        //OOP의 4가지 특징은 "클래스"안에서 돌아감
        //int a = 10; <- 단순한 변수는 객체가 아님

        //①추상화(Abstraction) : 설계의 시작점
        // -> 클래스는 현실을 코드로 모델링하는 도구
        // 1. 여러 설계도 간의 공통점을 추려냄
        // 2. 추려낸 공통점을 하나의 상위 개념으로 정리
        // 3. 추상 클래스나 인터페이스 표현
        #region 추상화 예시
        // ex) (knight, mage, Archer) -> player

        //class Knight 
        //{
        //    public int hp;
        //    public int atk;
        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //}
        //class Mage 
        //{   
        //    public int hp;
        //    public int atk;
        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //}
        //class Archer 
        //{    
        //    public int hp;
        //    public int atk;
        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //}

        // ↓

        //abstract class Player // <- 여러 설계도 간의 공통점을 추려내 추려낸 공통점을 하나의 상위 개념으로 정리
        //{
        //    public int hp;
        //    public int atk;

        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //}
        //class Knight : Player { }
        //class Mage : Player { }
        //class Archer : Player { }
        #endregion

        // 구분              | 일반 클래스(`class`)               | 추상 클래스(`abstract class`)           
        // ------------------|------------------------------------|------------------------------------ 
        // 인스턴스 생성     | 가능 (`new ClassName()`)           | 불가능(`new AbstractClass()`) 
        // 메서드 구현 여부  | 모든 메서드는 구현이 되어야 함     | 일부 메서드는 미구현(추상 메서드)로 둘 수 있음
        // 목적              | 실제 기능을 가진 구체적 설계도     | 공통 설계와 규칙만 정의하는 추상적 설계도  
        #region 추상 클래스의 핵심 -> 강제성을 위해 (abstract class)
        //abstract class Player
        //{
        //    abstract public void attack(); // abstract를 붙이면 하위 클래스들은 각자 abstract가 붙었던 함수를 고유의 함수로 구현해야함(강제성)
        //}
        //class Knight : Player
        //{
        //    public override void attack()
        //    {

        //    }
        //}
        //class Mage : Player
        //{
        //    public override void attack()
        //    {

        //    }
        //}
        //class Archer : Player
        //{
        //    public override void attack()
        //    {

        //    }
        //}
        #endregion

        // 추상의 핵심
        // 공통의 내용 추출, 강제성

        //②상속 : 공통된 구조를 재사용
        // 추상화로 정의된 베이스 클래스를 기반으로, 하위 클래스가 물려받아 사용
        // 부모의 속성과 기능을 그대로 물려받아 사용
        //자식클래스 생성자 호출전 부모 클래스 생성자가 먼저 호출됨 (메모리 상에서는 부모클래스가 먼저 생성되고 그뒤에 자식 클래스의 필드가 이어서 생성됨)

        //class 부모클래스 {}
        //class 자식클래스 : 상속받을 부모 클래스 {}
        //base : 부모, this : 나 자신
        #region 상속 예시
        //class Player //부모클래스 = 기반 클래스 = 베이스 클래스
        //{
        //    public int hp;
        //    public int atk;

        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //    public void defend()
        //    {
        //        Console.WriteLine("defend");
        //    } 
        //}

        //class 자식클래스 : 상속받을 부모 클래스
        //class Knight : Player { } //자식 클래스 = 하위 클래스 = 파생 클래스
        //class Mage : Player { }
        //class Archer : Player { }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    Knight k = new Knight();
        //    k.attack();
        //}
        #endregion

        #region 부모클래스 생성자에 매개변수가 있을 경우 자식 클래스 생성자에 : base(매개변수) 사용
        //class Player //부모클래스 = 기반 클래스 = 베이스 클래스
        //{
        //    public int hp;

        //    public Player(int hp)
        //    {

        //    }

        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //}
        //class Knight : Player
        //{
        //    public Knight(int hp) : base(hp)
        //    {
        //        Console.WriteLine("Knight attack");
        //    }
        //}
        #endregion

        #region 상속 virtual, override
        //class Player
        //{
        //    public virtual void attack() // 자식클래스에서 해당 함수를 변경하고 싶을때 virtual를 넣음
        //    {
        //        Console.WriteLine("attack");
        //    }
        //}
        //class Knight : Player
        //{
        //    public override void attack() //이어서 override를 넣음
        //    {
        //        base.attack(); // virtual, override 사용시 기존 부모 클래스 함수를 호출 하고 싶을 경우 base.을 사용
        //        Console.WriteLine("Knight attack");
        //    }

        //}
        //static void Main(string[] args)
        //{
        //    Player p = new Knight();
        //    p.attack();
        //    //자식클래스는 부모클래스를 가지고 있는게 아니라, 자식 클래스가 "부모클래스 이기도 한 존재"
        //}
        #endregion

        //   오버로딩 : 함수이름 재사용
        // 오버라이딩 : 상속 함수 재정의

        //상속은 2~3단계 정도가 적당
        //비슷한 종류의 클래스가 아니라면 상속X

        //③다형성 : 같은 이름 다른 행동
        // 상속을 받은 여러 클래스들이 같은 메서드를 각자 다르게 구현할 수 있음
        #region 다형성예시
        //class Player
        //{
        //    public int hp;
        //    public int atk;

        //    public void attack()
        //    {
        //        Console.WriteLine("attack");
        //    }
        //    public void defend()
        //    {
        //        Console.WriteLine("defend");
        //    }
        //}
        //class Knight : Player
        //{
        //    public void attack()
        //    {
        //        Console.WriteLine("knight attack");
        //    }
        //}
        //class Mage : Player
        //{
        //    public void attack()
        //    {
        //        Console.WriteLine("mage attack");
        //    }
        //}
        //class Archer : Player
        //{
        //    public void attack()
        //    {
        //        Console.WriteLine("Archer attack");
        //    }
        //}
        #endregion

        //④캡슐화 : 안전하고 통제된 사용, 보안레벨
        // 내부로직이나 데이터를 외부에는 숨김
        // 공개된 메서드를 통해서 접근할수 있게 함
        #region 캡슐화 예시
        //class Player
        //{
        //    protected int hp; // <-
        //    public int atk;
        //}
        #endregion


    }
}
