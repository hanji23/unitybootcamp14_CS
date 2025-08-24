using System.Numerics;

namespace _250730_2
{
    // text rpg
    internal class Program
    {

        // struct 구조체
        // 변수들을 하나의 덩어리로 묶어서 뭉쳐서 사용할때 사용함

        struct Player
        {
            public float hp;
            public float atk;
        }

        enum playerclass
        {
            none,
            전사,
            마법사,
            도둑
        }

        static void playerstauts_class(playerclass choice, out Player player)
        {
            player.hp = 0;
            player.atk = 0;

            switch (choice)
            {
                case playerclass.전사:
                    player.hp = 100;
                    player.atk = 10;
                    break;
                case playerclass.마법사:
                    player.hp = 50;
                    player.atk = 15;
                    break;
                case playerclass.도둑:
                    player.hp = 75;
                    player.atk = 12;
                    break;
            }
            Console.WriteLine($"{choice}  hp : {player.hp}, atk : {player.atk}");
        }

        enum monsterclass
        {
            none,
            오크,
            슬라임,
            스켈레톤
        }

        struct Monster
        {
            public float hp;
            public float atk;
        }

        static void monsterstauts_class(monsterclass choice, out Monster monster)
        {
            monster.hp = 0;
            monster.atk = 0;

            Random rand = new Random();
            int ramdom_monster = rand.Next(0, 3);
            switch (ramdom_monster)
            {
                case 0:
                    choice = monsterclass.오크;
                    break;
                case 1:
                    choice = monsterclass.슬라임;
                    break;
                case 2:
                    choice = monsterclass.스켈레톤;
                    break;
            }

            switch (choice)
            {
                case monsterclass.오크:
                    monster.hp = 40;
                    monster.atk = 4;
                    break;
                case monsterclass.슬라임:
                    monster.hp = 20;
                    monster.atk = 2;
                    break;
                case monsterclass.스켈레톤:
                    monster.hp = 30;
                    monster.atk = 3;
                    break;
            }
            Console.WriteLine($"{choice}(이/가) 스폰되었습니다.");
            Console.WriteLine($"{choice}  hp : {monster.hp}, atk : {monster.atk}");
        }


        static playerclass playercheck(out Player player)
        {
            bool playercheck = true;
            string s = "";
            player.hp = 0;
            player.atk = 0;
            playerclass choice = playerclass.none;

            while (playercheck)
            {
                Console.WriteLine($"\n직업을 선택하세요!\n[1] {playerclass.전사}\n[2] {playerclass.마법사}\n[3] {playerclass.도둑}");
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        choice = playerclass.전사;
                        Console.WriteLine($"{choice} 선택!");
                        playerstauts_class(choice, out player);
                        playercheck = false;
                        break;
                    case "2":
                        choice = playerclass.마법사;
                        Console.WriteLine($"{choice} 선택!");
                        playerstauts_class(choice, out player);
                        playercheck = false;
                        break;
                    case "3":
                        choice = playerclass.도둑;
                        Console.WriteLine($"{choice} 선택!");
                        playerstauts_class(choice, out player);
                        playercheck = false;
                        break;
                    default:
                        Console.WriteLine("다시 입력해 주십시오");
                        break;
                }

            }

            return choice;
        }

        static void EnterGame()
        {
            while (true)
            {
                Console.WriteLine("게임에 접속했습니다.");
                Console.WriteLine("[1] 사냥터로 이동");
                Console.WriteLine("[2] 로비로 돌아가기");

                if (Console.ReadLine() == "1")
                    EnterField();
                else
                    break;
            }

        }

        static void EnterField()
        {
            while (true)
            {
                Console.WriteLine("사냥터에 도착했습니다.");
                monsterclass choice = monsterclass.none;
                monsterstauts_class(choice, out Monster monster);
                Console.WriteLine("[1] 전투시작");
                Console.WriteLine("[2] 도망치기");
                if (Console.ReadLine() == "1")
                    battle();
                else
                    break;
            }
        }

        static void battle()
        {
            
            //Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //float hp = 0, atk = 0;
            Player player;

            //string player = playercheck();
            

            while (true)
            {
                playerclass choice = playerclass.none;
                choice = playercheck(out player);
                EnterGame();
            }
                
        }

    }

}