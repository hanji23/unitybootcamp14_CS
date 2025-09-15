namespace _4_Exception
{
    class Player
    {
        public void attack()
        {

        }
    }

    class Mage : Player
    {

    }

    class Knight : Player
    {

    }

    class testException : Exception //직접만든 에러 상황
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1];

            int x = 10;
           
            try
            {
                int a = arr[2]; // 오류발생
                int y = x / 0;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex); // 오류내용 출력
            }

            try
            {
                int y = x / 0; // 오류발생
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine("\n0으로 나눔");
                }
                else
                {
                    Console.WriteLine("\n아님");
                }
                   // Console.WriteLine($"\n{ex}"); // 오류내용 출력
            }

            //Player p =new Knight();
            //Mage m = (Mage)p; // 오류발생
            //m.attack();

            try
            {
                Player p = new Knight();
                Mage m = (Mage)p; // 오류발생
                m.attack();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex}"); // 오류내용 출력
            }

            try
            {
                int a = 10;
                if (a == 10)
                    throw new testException();//특정 상황에 직접만든 Exception 호출
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex}"); // 오류내용 출력
            }
            finally
            {
                Console.WriteLine("\n 예외가 있던 없던 무조건 finally에 있는 것은 무조건 실행됨");
            }
        }
    }
}
