namespace _3_클래스_형식변환
{
    //클래스 형식변환

    class Player
    {
        public int hp;
        public int atk;

        public void Attack()
        {

        }
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }
    internal class Program
    {
        //static void EnterGame(Knight knight) //오버로딩으로 해결은 가능하나 수가 늘었을 때 불편하고 힘듬
        //{

        //}
        //static void EnterGame(Mage mage)
        //{

        //} 

        static void EnterGame(Player player)  // 자식 클래스는 부모 클래스이기도 해서 Knight, Mage 사용가능
        {
            //player.mp;//다만 mp는 Mage만 있어서 그냥 사용은 못함

            //Mage mage = (Mage)player; // 명시적 형변환
            //mage.mp = 10; // 명시적 형변환

            //Mage mage0 = (Mage)player;// <- 이걸 그대로 사용하는 것은 추천하지 않음 

            //안정성 검사
            bool isMage = (player is Mage); // is 방식 (true / false 반환) 값 형식
            if (isMage) 
            {
                Mage mage = (Mage)player;
                mage.mp = 10;
            }

            Mage mage2 = (player as Mage); // as 방식 (null 반환) 참조형식
            if (mage2 != null)
            {
                mage2.mp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.hp = 10;
            Mage mage = new Mage();

            Player magePlayer = mage; // 명시적 형변환
            Mage mage2 = (Mage)magePlayer; // 이방법은 안전하진 않음

            EnterGame(knight);
        }
    }
}
