namespace _1_캡슐화
{
    //캡슐화 (은닉성)
    // 은닉성 개년의 캡슐화
    // 기능 + 데이터를 묶는 개념의 캡술화 -> 중요하진 않음
    //  ㄴ 목적 : 관련된 데이터와 그 데이터를 다루는 메서드를 한클래스 안에 묶어서 하나의 "기능 단위"로 만들기

    // 보안레벨 == 은닉성

    //자동차
    // ㄴ> 헨들조작, 페달조작, 차문 조작
    //  ㄴ> 전기장치, 엔진, 연료분사장치 (외부에 보여주기엔 위험해 굳이 외부에 보여질 이유 없음)

    //접근 지정자(접근 제한자)
    // public, protected, private
    // public - 가장 개방적인 형태, 외부에서 누구나 접근 가능
    // protected - 상속받은 애들만 가능
    // private - 가장 비개방적인(안전한) 형태
    // ↓대신 아래처럼 접근 가능
    class Player
    {
        //외부접근불가
        private int hp;

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public int GetHp() { return hp; }
    }
    class Knight : Player
    {
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
