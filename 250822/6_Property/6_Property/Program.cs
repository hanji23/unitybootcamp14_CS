namespace _6_Property
{
    class Knight
    {
        //public int hp; // 공개된 필드 -> 외부에서 바로 접근 가능

        //private int hp; // 외부접근 불가 이방식을 사용하면 기존엔 함수를 이용하여 접근

        //public void SetHp(int hp)
        //{
        //    this.hp = hp;
        //}
        //public int GetHp()
        //{
        //    return hp;
        //}

        //public int hp
        //{
        //    get
        //    {
        //        return hp;
        //    }
        //    set
        //    {
        //        hp = value;
        //    }
        //}
        // ↓ get과 set은 둘다 써야하는 것은 아니며 protected, private를 사용해 일부 접근만 막을 수 있음
        public int Hp
        {
            get
            {
                return Hp;
            }
            protected set
            {
                Hp = value;
            }
        }

        public int Hp2 { get; protected set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            //knight.hp = 100; //(public)외부에서 직접 수정가능하며 나중에 누가 수정했는지 찾기힘듬


        }
    }
}
