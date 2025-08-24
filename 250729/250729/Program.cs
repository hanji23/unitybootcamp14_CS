using System.Threading;

namespace _250729
{
    internal class Program
    {
        // 열거형
        // 열거형은 숫자를 대입해주지 않으면 0부터 시작한다
        // 가장 위에 숫자르르 하나 넣으면 그 숫자부터 순서대로 넣어준다
        enum game
        {
            scissors = 1, rock, paper
        }

        static void Main(string[] args)
        {
            #region if, 삼항연산자, switch
            //// if, else if, else 
            //int i = 0;

            ////===============================
            ////     [직업을 선택하세요]
            ////===============================
            //// 1. 전사, 2. 법사, 3. 도둑
            ////===============================
            ////번호를 입력하세요 : 2
            ////법사를 선택하셨습니다.

            //Console.WriteLine("===============================\n     [직업을 선택하세요]\n===============================\n1. 전사, 2. 법사, 3. 도둑\n===============================");
            //Console.Write("번호를 입력하세요 : ");

            //string s = Console.ReadLine();
            //i = int.Parse(s);

            //if (i == 1)
            //{
            //    Console.WriteLine("\n전사를 선택하셨습니다.");
            //}
            //else if (i == 2)
            //{
            //    Console.WriteLine("\n법사를 선택하셨습니다.");
            //}
            //else if (i == 3)
            //{
            //    Console.WriteLine("\n도둑을 선택하셨습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("\n잘못된 선택");
            //}

            ////삼항 연산자
            //int number = 29;
            //string numberType;

            //if (number % 2 == 0)
            //    numberType = "짝";
            //else
            //    numberType = "홀";

            ////                  조건       ?  참  : 거짓
            //numberType = (number % 2) == 0 ? "짝" : "홀";

            ////                  조건       ?  참  : 거짓, 추가조건    ?   참   :  거짓
            //numberType = (number % 2) == 0 ? "짝" : (number % 1) == 0 ? "!!!!" : "????";

            ////switch - 특정값이 조건중 어디에 해당하는지 검사해서 조건에 맞는 명령을 실행 (if와 비슷)

            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("\nswitch\n전사를 선택하셨습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("\nswitch\n법사를 선택하셨습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("\nswitch\n도둑을 선택하셨습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("\nswitch\n잘못된 선택");
            //        break;
            //}
            #endregion

            #region 가위바위보 예제

            ////상수
            ////const int scissors = 1;
            ////const int rock = 2;
            ////const int paper = 3;

            //const string scissors = "가위";
            //const string rock = "바위";
            //const string paper = "보";

            ////Console.WriteLine("========================================");
            ////Console.WriteLine("가위 바위 보 게임 (1:가위, 2:바위, 3:보)");
            ////Console.WriteLine("========================================");

            //Console.WriteLine("========================================");
            //Console.WriteLine($"{scissors} {rock} {paper} 게임 (1:{scissors}, 2:{rock}, 3:{paper})");
            //Console.WriteLine("========================================");

            //Console.Write("선택하세요 : ");

            //// 컴퓨터 선택
            //Random rand = new Random();
            //int comChoice = rand.Next(1, 4);

            //string s = Console.ReadLine();
            //int i = int.Parse(s);

            //switch (s)
            //{
            //    case scissors:
            //        switch (comChoice)
            //        {
            //            case (int)game.scissors:
            //                Console.WriteLine($"컴퓨터는 {scissors}를 냈습니다.");
            //                Console.WriteLine("비겼습니다!");
            //                break;
            //            case (int)game.rock:
            //                Console.WriteLine($"컴퓨터는 {rock}를 냈습니다.");
            //                Console.WriteLine("컴퓨터가 이겼습니다!");
            //                break;
            //            case (int)game.paper:
            //                Console.WriteLine($"컴퓨터는 {paper}를 냈습니다.");
            //                Console.WriteLine("당신이 이겼습니다!");
            //                break;
            //        }
            //        break;
            //    case rock:
            //        switch (comChoice)
            //        {
            //            case (int)game.scissors:
            //                Console.WriteLine($"컴퓨터는 {scissors}를 냈습니다.");
            //                Console.WriteLine("당신이 이겼습니다!");
            //                break;
            //            case (int)game.rock:
            //                Console.WriteLine($"컴퓨터는 {rock}를 냈습니다.");
            //                Console.WriteLine("비겼습니다!");
            //                break;
            //            case (int)game.paper:
            //                Console.WriteLine($"컴퓨터는 {paper}를 냈습니다.");
            //                Console.WriteLine("컴퓨터가 이겼습니다!");
            //                break;
            //        }
            //        break;
            //    case paper:
            //        switch (comChoice)
            //        {
            //            case (int)game.scissors:
            //                Console.WriteLine($"컴퓨터는 {scissors}를 냈습니다.");
            //                Console.WriteLine("컴퓨터가 이겼습니다!");
            //                break;
            //            case (int)game.rock:
            //                Console.WriteLine($"컴퓨터는 {rock}를 냈습니다.");
            //                Console.WriteLine("당신이 이겼습니다!");
            //                break;
            //            case (int)game.paper:
            //                Console.WriteLine($"컴퓨터는 {paper}를 냈습니다.");
            //                Console.WriteLine("비겼습니다!");
            //                break;
            //        }
            //        break;
            //    default:
            //        switch (comChoice)
            //        {
            //            case (int)game.scissors:
            //                Console.WriteLine($"컴퓨터는 {scissors}를 냈습니다.");
            //                break;
            //            case (int)game.rock:
            //                Console.WriteLine($"컴퓨터는 {rock}를 냈습니다.");
            //                break;
            //            case (int)game.paper:
            //                Console.WriteLine($"컴퓨터는 {paper}를 냈습니다.");
            //                break;
            //        }
            //        Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
            //        break;
            //}
            #endregion

            #region 반복문
            ////while 반복문

            //bool isTrue = true;
            //int i = 0;

            ////while (isTrue) //조건이 참이면 반복 거짓이면 빠져나감
            ////{
            ////    Console.WriteLine("Hello World");

            ////    if (i < 4)
            ////        i++;
            ////    else
            ////        isTrue = false;
            ////}

            //while (i++ < 4) //조건이 참이면 반복 거짓이면 빠져나감
            //{
            //    Console.WriteLine("Hello World");
            //}

            //Console.WriteLine("반복종료");

            ////do while
            //do
            //{
            //    Console.WriteLine("do while -> 처음 한번은 실행후 while의 조건이 참이라면 다시 반복");
            //} while (false);

            //for 반복문
            //for (초기화; 조건; 조건 변화)
            //{
            //      반복할 코드
            //}

            //int i = 0;
            //while (i < 10)
            //{
            //    i++;
            //}
            //// 위 식을 for문으로 치환하면
            //for (int j = 0; j < 10; j++)
            //{

            //}

            ////for (;/*조건*/ ; )// -> 조건이 없으면 true가 되어 무한루프한다
            ////{

            ////}

            ////for문 순서
            ////for (/* ①초기화 */;/* ②조건 */ ;/* ④조건 변경 */ )
            //{
            //    /* ③명령 코드 실행 */
            //}
            ////1. 초기화

            ////2. 조건
            ////3. 명령 코드 실행
            ////4. 조건 변경

            ////5. 조건
            ////6. 명령 코드 실행
            ////7. 조건변경

            //// ...
            ////즉 조건변경에서 후위연산 하나 전위연산 하나 아무런 차이 없음

            //while (true) //break는 while, for에서도 사용
            //{
            //    Console.WriteLine("while!break");
            //    break;
            //}
            //for (; ; )
            //{
            //    Console.WriteLine("for!break");
            //    break;
            //}


            //continue 해당 반복는 스킵하고 다음 반복으로 넘어감
            //for (int j = 5; j > 0; j--)
            //{
            //    if (j == 3)
            //        continue;
            //    Console.WriteLine("continue 예");
            //}
            // -> 3번째 반복은 넘어가고 4번째 반복으로 넘어감

            //break = 반복문을 아예 빠져나옴
            //continue = 이번 반복회차를 컨티뉴 키워드 이후로 건너뜀

            // 키워드 = 약속 = 예약어

            #endregion

            #region 1~10까지 홀수만 출력하는 프로그램 작성

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{i} 홀수");

            }

            #endregion 
        }
    }
}