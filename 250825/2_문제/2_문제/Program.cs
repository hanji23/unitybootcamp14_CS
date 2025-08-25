namespace _2_문제
{
    //문제2
    //다음 조건을 만족하는 코드를 작성하세요.
    //1. Enemy 클래스 내부에 델리게이트 OnDie를 정의한다.
    // -> 시그니처: void(string killerName, int reward)
    //2.Enemy 클래스는 다음 멤버를 가진다.
    // -> string Name, int Hp, int Reward, OnDie dieCallback(private)
    //3.생성자 Enemy(string name, int hp, int reward, OnDie onDieCallback)에서 모든 필드를 초기화한다.
    //4. void TakeDamage(int amount, string attacker) 함수를 정의한다.
    // -> Hp에서 amount만큼 감소시키고 "[{Name}] HP: {Hp}"를 출력한다.
    // -> Hp가 0 이하가 되면 "[{Name}] 처치!"를 출력하고,
    // -> dieCallback이 null이 아니면 dieCallback(attacker, Reward)를 호출한다.
    //5. Program 클래스에 콜백 메서드 static void OnEnemyDie(string killerName, int reward)를 구현한다.
    // -> 함수 내부에 
    // -> "{killerName}이(가) +{reward} 점수를 획득"
    // -> "[효과음] 처치 사운드 재생"
    // -> 가 출력되도록 구현한다.
    //6. Main()에서 다음 순서로 호출 한다.
    // -> Enemy slime = new Enemy("Slime", 20, 100, OnEnemyDie);
    // -> slime.TakeDamage(5, "Knight"); 
    // -> slime.TakeDamage(20, "Knight");

    class Enemy
    {
        string Name;
        int Hp;
        int Reward;

        private OnDie dieCallback;

        public Enemy(string name, int hp, int reward, OnDie onDieCallback)
        {
            this.Name = name;
            this.Hp = hp;   
            this.Reward = reward;
            dieCallback = onDieCallback;
        }

        public delegate void OnDie(string killerName, int reward);

        public void TakeDamage(int amount, string attacker)
        {
            Hp -= amount;
            if (Hp <= 0)
            {
                Console.WriteLine($"[{Name}] 처치!");
                if (dieCallback != null)
                {
                    dieCallback(attacker, Reward);
                }

            }
            
        }

    }

    internal class Program
    {
        static void OnEnemyDie(string killerName, int reward)
        {
            Console.WriteLine($"{killerName}이(가) +{reward} 점수를 획득 \n [효과음] 처치 사운드 재생");
        }
        static void Main(string[] args)
        {
            Enemy slime = new Enemy("Slime", 20, 100, OnEnemyDie);
            slime.TakeDamage(5, "Knight"); 
            slime.TakeDamage(20, "Knight");
        }
    }
}
