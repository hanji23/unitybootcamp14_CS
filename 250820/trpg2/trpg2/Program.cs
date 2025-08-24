namespace TextRPG
{
    // TODO: CreatureType 이라는 enum을 만들어주세요.
    public enum CreatureType
    {
        //  > None, Player, Monster 를 0, 1, 2 값으로 갖도록 해주세요.
        None, Player, Monster
    }


    // TODO: Creature 라는 클래스를 만들어주세요.
    class Creature
    {
        //  > CreatureType 타입의 creatureType 멤버변수를 만들어주세요.
        protected CreatureType creatureType;
        //  > int 타입의 hp, atk 멤버변수를 만들어주세요 (기본값 0).
        protected int hp = 0;
        protected int atk = 0;
        //  > creatureType을 매개변수로 받는 protected 생성자를 만들어주세요.
        protected Creature(CreatureType creatureType)
        {
            this.creatureType = creatureType;
        }
        //  > SetStat(int hp, int atk) 메서드를 만들어 hp와 atk를 설정하게 해주세요.
        public void SetStat(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }
        //  > GetHp(), GetAtk() 메서드를 만들어 각각 hp와 atk를 반환하게 해주세요.
        public int GetHp() { return hp; }
        public int GetAtk() { return atk; }
        //  > IsDead() 메서드를 만들어 hp가 0 이하이면 true를 반환하게 해주세요.
        public bool IsDead()
        {
            return hp <= 0;
        }
        //  > OnDamaged(int damage) 메서드를 만들어 hp를 damage만큼 감소시키고, 0 이하가 되면 0으로 설정되게 해주세요.
        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp <= 0)
                hp = 0;
        }
    }


    // TODO: PlayerType 이라는 enum을 만들어주세요.
    public enum PlayerType
    {
        //  > None, Knight, Archer, Mage 를 0, 1, 2, 3 값으로 갖도록 해주세요.
        None, Knight, Archer, Mage
    }

    // TODO: Player 클래스를 Creature로부터 상속받아 만들어주세요.
    class Player : Creature
    {
        //  > PlayerType 타입의 playerType 멤버변수를 만들고 기본값을 None으로 설정해주세요.
        protected PlayerType playerType = PlayerType.None;
        //  > PlayerType을 매개변수로 받는 protected 생성자를 만들고,
        //    creatureType을 CreatureType.Player로 설정한 뒤 playerType을 대입해주세요.
        protected Player(PlayerType playerType) : base(CreatureType.Player)
        {
            this.playerType = playerType;
        }
    }


    // TODO: Knight, Archer, Mage 클래스를 Player로부터 상속받아 만들어주세요.
    class Knight : Player
    {
        //  > 각 생성자에서 base()로 해당 PlayerType을 넘기고,
        //    SetStat()을 사용해 Knight(100,10), Archer(75,12), Mage(50,15)로 설정해주세요.
        public Knight() : base(PlayerType.Knight)
        {
            SetStat(100, 10);
        }
    }
    class Archer : Player
    {
        //  > 각 생성자에서 base()로 해당 PlayerType을 넘기고,
        //    SetStat()을 사용해 Knight(100,10), Archer(75,12), Mage(50,15)로 설정해주세요.
        public Archer() : base(PlayerType.Archer)
        {
            SetStat(75, 12);
        }
    }
    class Mage : Player
    {
        //  > 각 생성자에서 base()로 해당 PlayerType을 넘기고,
        //    SetStat()을 사용해 Knight(100,10), Archer(75,12), Mage(50,15)로 설정해주세요.
        public Mage() : base(PlayerType.Mage)
        {
            SetStat(50, 15);
        }
    }

    // TODO: MonsterType 이라는 enum을 만들어주세요.
    public enum MonsterType
    {
        //  > None, Slime, Orc, Skeleton 를 0, 1, 2, 3 값으로 갖도록 해주세요.
        None, Slime, Orc, Skeleton
    }

    // TODO: Monster 클래스를 Creature로부터 상속받아 만들어주세요.
    class Monster : Creature
    {
        //  > MonsterType 타입의 type 멤버변수를 만들고 기본값을 None으로 설정해주세요.
        protected MonsterType type = MonsterType.None;
        //  > MonsterType을 매개변수로 받는 protected 생성자를 만들고,
        //    creatureType을 CreatureType.Monster로 설정한 뒤 type을 대입해주세요.
        public Monster(MonsterType monsterType) : base(CreatureType.Monster)
        {
            this.type = monsterType;
        }

        //  > GetMonsterType() 메서드를 만들어 type을 반환하게 해주세요.

        public MonsterType GetMonsterType()
        {
            return type;
        }

    }


    // TODO: Slime, Orc, Skeleton 클래스를 Monster로부터 상속받아 만들어주세요.
    //  > 각 생성자에서 base()로 해당 MonsterType을 넘기고,
    class Slime : Monster
    {
        //  > 각 생성자에서 base()로 해당 PlayerType을 넘기고,
        //    SetStat()을 사용해 Slime(10,1), Orc(20,2), Skeleton(15,5)로 설정해주세요.
        public Slime() : base(MonsterType.Slime)
        {
            SetStat(10, 1);
        }
    }
    class Orc : Monster
    {
        //  > 각 생성자에서 base()로 해당 MonsterType 넘기고,
        //    SetStat()을 사용해 Slime(10,1), Orc(20,2), Skeleton(15,5)로 설정해주세요.
        public Orc() : base(MonsterType.Orc)
        {
            SetStat(20, 2);
        }
    }
    class Skeleton : Monster
    {
        //  > 각 생성자에서 base()로 해당 MonsterType 넘기고,
        //    SetStat()을 사용해 Slime(10,1), Orc(20,2), Skeleton(15,5)로 설정해주세요.
        public Skeleton() : base(MonsterType.Skeleton)
        {
            SetStat(15, 5);
        }
    }

    // ==============================
    // 전제: 아래 타입들은 이전 과제에서 이미 구현되어 있다고 가정
    // namespace Other 내부에 다음 클래스/열거형이 존재해야 함:
    // - enum PlayerType { None, Knight, Archer, Mage }
    // - class Player { /* GetHp(), GetAtk(), IsDead(), OnDamaged(int) 등 */ }
    //      - class Knight : Player
    //      - class Archer : Player
    //      - class Mage   : Player
    // - enum MonsterType { None, Slime, Orc, Skeleton }
    // - class Monster { /* GetHp(), GetAtk(), IsDead(), OnDamaged(int) 등 */ }
    //      - class Slime   : Monster
    //      - class Orc     : Monster
    //      - class Skeleton: Monster
    // ==============================

    // TODO: GameMode 라는 enum을 만들고 Lobby, Town, Field 값을 갖도록 하세요.
    public enum GameMode
    {
        Lobby, Town, Field
    }

    // TODO: Game 클래스를 만들고, 아래 필드를 추가하세요.
    //  - GameMode mode  // 기본값: GameMode.Lobby
    //  - Player player  // 기본값: null
    //  - Monster monster // 기본값: null
    //  - Random rand    // new Random() 으로 초기화
    class Game
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null;
        private Monster monster = null;
        private Random rand = new Random();

        // TODO: public void Process() 메서드를 만들고,
        //  mode 값에 따라 아래 메서드를 호출하도록 switch 문을 작성하세요.
        //  - Lobby  → ProcessLobby()
        //  - Town   → ProcessTown()
        //  - Field  → ProcessField()
        public void Process()
        {
            switch (mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        // TODO: ProcessLobby()
        //  - "직업을 선택하세요", "[1] 기사", "[2] 궁수", "[3] 법사" 출력
        //  - Console.ReadLine() 으로 입력을 받고, 입력값에 따라 player 생성
        //      "1" → new Knight()
        //      "2" → new Archer()
        //      "3" → new Mage()
        //  - 유효한 선택이면 mode = GameMode.Town;
        //  - 잘못된 입력이면 재입력 유도 문구 출력
        private void ProcessLobby()
        {
            // TODO
            Console.WriteLine("\"직업을 선택하세요\",\n \"[1] 기사\", \"[2] 궁수\", \"[3] 법사\"");
            switch (Console.ReadLine())
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
                default:
                    Console.WriteLine("다시 입력해 주세요");
                    break;
            }

        }

        // TODO: ProcessTown()
        //  - "마을에 입장했습니다.", "[1] 필드로 가기", "[2] 로비로 돌아가기" 출력
        //  - 입력 "1" → mode = GameMode.Field
        //  - 입력 "2" → mode = GameMode.Lobby
        //  - 잘못된 입력이면 재입력 유도 문구 출력
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다.\n\"[1] 필드로 가기\", \"[2] 로비로 돌아가기\"");
            switch (Console.ReadLine())
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
                default:
                    Console.WriteLine("다시 입력해 주세요");
                    break;
            }
        }

        // TODO: ProcessField()
        //  - "필드에 입장했습니다.", "[1] 싸우기", "[2] 일정 확률로 마을로 도망가기" 출력
        //  - CreateRandomMonster() 호출하여 monster 랜덤 생성
        //  - 입력 "1" → ProcessFight()
        //  - 입력 "2" → TryEscape()
        //  - 그 외 → 잘못된 입력 문구 출력
        private void ProcessField()
        {
            // TODO
            Console.WriteLine("필드에 입장했습니다.\n\"[1] 싸우기\", \"[2] 일정 확률로 마을로 도망가기\"");
            CreateRandomMonster();

            switch (Console.ReadLine())
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
                default:
                    Console.WriteLine("잘못된 입력 문구");
                    break;
            }
        }

        // TODO: CreateRandomMonster()
        //  - rand.Next(0, 3) 으로 0~2 난수 생성
        //  - 0 → monster = new Slime();     "슬라임이 생성되었습니다." 출력
        //  - 1 → monster = new Orc();       "오크가 생성되었습니다."   출력
        //  - 2 → monster = new Skeleton();  "스켈레톤이 생성되었습니다." 출력


        private void CreateRandomMonster()
        {
            // TODO

            switch (rand.Next(0, 3))
            {
                case 0:
                    monster = new Slime();
                    break;
                case 1:
                    monster = new Orc();
                    break;
                case 2:
                    monster = new Skeleton();
                    break;
            }
        }

        // TODO: ProcessFight()
        //  - while 루프로 전투 반복:
        //    (1) 플레이어 공격: monster.OnDamaged(player.GetAtk());
        //    (2) 몬스터 사망 체크:
        //        - 죽었으면 "승리했습니다!" 출력
        //        - 플레이어 남은 HP 출력 (예: $"남은 HP: {player.GetHp()}")
        //        - 전투 종료(return 또는 break)
        //    (3) 몬스터 반격: player.OnDamaged(monster.GetAtk());
        //    (4) 플레이어 사망 체크:
        //        - 죽었으면 "패배했습니다..." 출력
        //        - mode = GameMode.Lobby;
        //        - 전투 종료(return 또는 break)
        //  - 필요 시 타격 직후 HP 로그 출력:
        //      $"플레이어 HP: {player.GetHp()} / 몬스터 HP: {monster.GetHp()}"
        private void ProcessFight()
        {
            Console.WriteLine($"몬스터 {monster.GetMonsterType()} 등장!\n 몬스터 HP: {monster.GetHp()} , 몬스터 ATK: {monster.GetAtk()}");
            // TODO
            while (true)
            {
                monster.OnDamaged(player.GetAtk());
                Console.WriteLine($"플레이어 HP: {player.GetHp()} / 몬스터 HP: {monster.GetHp()}");
                
                if (monster.GetHp() <= 0)
                {
                    Console.WriteLine($"승리했습니다!\n남은 HP: {player.GetHp()}");
                    break;
                }
                player.OnDamaged(monster.GetAtk());
                Console.WriteLine($"플레이어 HP: {player.GetHp()} / 몬스터 HP: {monster.GetHp()}");
                if (player.IsDead())
                {
                    Console.WriteLine("패배했습니다...");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }

        // TODO: TryEscape()
        //  - rand.Next(0, 100) 으로 0~99 난수 생성
        //  - 33% 확률(0~32)이면 도망 성공:
        //      "도망에 성공했습니다! 마을로 돌아갑니다." 출력
        //      mode = GameMode.Town;
        //  - 실패면:
        //      "도망에 실패했습니다! 전투를 시작합니다." 출력
        //      ProcessFight() 호출
        private void TryEscape()
        {
            // TODO
            if (rand.Next(0, 100) <= 32)
            {
                Console.WriteLine("도망에 성공했습니다! 마을로 돌아갑니다.");
                mode = GameMode.Town;
            }
            else
            {
                Console.WriteLine("도망에 실패했습니다! 전투를 시작합니다.");
                ProcessFight();
            }
        }
    }

    // (선택) 실행 진입부
    class Program
    {
        static void Main()
        {
            // TODO: Game game = new Game();
            // TODO: while (true) { game.Process(); }
            Game game = new Game();
            while (true) { game.Process(); }
        }
    }
}

