namespace _4_실습
{
    using System;
    using System.ComponentModel.Design.Serialization;
    using System.Diagnostics;
    using System.Threading;
    using System.Xml.Linq;

    class Character
    {
        // TODO: 이름, 체력, 공격력 필드 만들기

        public string name;
        public int hp;
        public int atk;

        // TODO: 생성자 만들기 (이름, 체력, 공격력 초기화)

        public Character(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }
        // TODO: Attack(Character target) 함수 만들기
        public void Attack(Character target)
        {
            if (target is Monster)
            {
                Console.WriteLine($" {name} 공격 →  {target.name} HP : {target.hp} -> {target.hp} - {atk} ->{target.hp - atk}");
            }
            else
            {
                Console.WriteLine($" {name} 반격 →  {target.name} HP : {target.hp} -> {target.hp} - {atk} ->{target.hp - atk}");
            }
            target.hp -= atk;
        }

        // TODO: IsDead 함수(HP <= 0이면 true) 만들기
        
        public bool IsDead(int hp)
        {
            if(hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Player : Character // TODO: Character를 상속해서 만드세요
    {
        // TODO: 경험치 필드 만들기
        public int exp;

        // TODO: 생성자 만들기
        public Player(string name, int hp, int atk) : base(name, hp, atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            exp = 0;
        }
        // TODO: GainExp(int amount) 함수 만들기
        public void GainExp(int amount)
        {
            exp += amount;
        }
    }

    class Monster : Character// TODO: Character를 상속해서 만드세요
    {
        // TODO: 랜덤 HP(20~50), ATK(2~6) 생성하는 생성자 만들기

        public Monster(string name) : base(name, new Random().Next(20, 51), new Random().Next(2, 7))
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main()
        {
            // TODO: 플레이어 생성
            Player p = new Player("용사", 100, 11);
            string monstername = "";

            // TODO: while문으로 게임 반복
            //   1) 몬스터 생성
            //   2) for문으로 전투 진행 (플레이어 선공 → 몬스터 반격)
            //   3) if로 승리/패배 판정
            //   4) 승리 시 경험치 +10
            //   5) 계속할지 입력 받기

            Console.WriteLine("=== 몬스터 사냥 콘솔 게임 ===");
            monstername = RandomName(monstername);
            while (true) 
            {
                Monster monster = new Monster(monstername);
                
                Console.WriteLine($"몬스터 등장! {monster.name} ( HP : {monster.hp}, ATK : {monster.atk} )");
                Console.WriteLine($"현재 {p.name} 상태  ( HP : {p.hp}, ATK : {p.atk} )");
                for (; !p.IsDead(p.hp) && !monster.IsDead(monster.hp); )
                {
                    //Console.WriteLine($" {p.name} 공격 →  {monster.name} HP : {monster.hp} -> {monster.hp} - {p.atk} ->{monster.hp - p.atk}");
                    p.Attack(monster);
                    //monster.hp -= p.atk;

                    if(monster.hp <= 0)
                    {
                        p.GainExp(10);
                        Console.WriteLine($" {monster.name} 처치! 경험치 + 10");
                        Console.WriteLine($"현재 경험치 : {p.exp}");
                        break;
                    }

                    //Console.WriteLine($" {monster.name} 반격 →  {p.name} HP : {p.hp} -> {p.hp} - {monster.atk} ->{p.hp - monster.atk}");
                    monster.Attack(p);
                    //p.hp -= monster.atk;

                    if (p.hp <= 0)
                    {
                        Console.WriteLine($"패배!");
                        break;
                    }
                }

                if (p.IsDead(p.hp))
                {
                    Console.WriteLine("\n 게임 종료 \n \n계속 싸우시겠습니까? (y/n) : ");

                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }
                    else
                    {
                        p = new Player("용사", 100, 11);
                    }
                    
                }
                else
                {
                    Console.WriteLine("계속 싸우시겠습니까? (y/n) : ");

                    if (Console.ReadLine() == "n")
                    {
                        break;
                    }
                }
            }
        }

        // TODO: RandomName() 함수 만들기 (몬스터 이름 랜덤 반환)
        static string RandomName(string name)
        {
            Random rand = new Random();

            switch (rand.Next(0, 3))
            {
                case 0:
                    name = "슬라임";
                    break;
                case 1:
                    name = "버섯";
                    break;
                case 2:
                    name = "밥";
                    break;
            }
            return name;
        }
    }
}
