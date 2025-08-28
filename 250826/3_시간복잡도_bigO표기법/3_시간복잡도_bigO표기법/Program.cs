using System.Diagnostics;

namespace _3_시간복잡도_bigO표기법
{
    // 시간복잡도 = 어떠한 알고리즘이 실행되는데 걸리는 시간
    //  ㄴ 주요 로직의 반복 횟수를 중점으로 측정

    //(공간복잡도 = 메모리를 얼마나 사용하는가) 중요하진않음

    // Big-O : 반복해서 몇번 연산되는지 "대충" 판단
    // ㄴ 1단계 : 시간복잡도 구하기
    // ㄴ 2단계 : 가장 오래걸리는 애만 남기기
    // ㄴ 3단계 : 상수항은 탈락시킨다(버린다)  (여기까지 하면 시간복잡도)
    // ㄴ 4단계 : 여기서 나온 시간복잡도에 O()안에 넣으면 빅오표기법 완료

    //업엔다운 게임이 대표적인 O(log n) 알고리즘 이다.

    internal class Program
    {
        static void test1(int n)
        {
            int sum = n;
            // 시간복잡도 :
            // = 1
        }

        static void test2(int n)
        {
            int sum = n;

            for (int i = 0; i < n; i++)
            {
                sum++;
            }
            // 시간복잡도 :
            // = n + 1
            // -> n (가장 오래걸리는 애만 남기기)

            // 빅오 표기법 :
            // O(n)
        }

        static void test3(int n)
        {
            int sum = 0;

            for(int i = 0; i< n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    sum++;
                }
            }
            // 시간복잡도 :
            // = n^2 + 1
            // -> n^2 (가장 오래걸리는 애만 남기기)

            // 빅오 표기법 :
            // O(n^2)
        }

        static void test4(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum++;
            }

            for (int j = 0; j < 2 * n; j++)
            {
                for (int k = 0; k < 2 * n; k++)
                {
                    sum++;
                }
            }
            sum = -100;
            // 시간복잡도 :
            // = 1 + n + 4n^2 + 1
            // -> 4n^2 (가장 오래걸리는 애만 남기기)
            // -> n^2  (상수항 버리기)

            // 빅오 표기법 :
            // O(n^2)
        }

        static void Main(string[] args)
        {
            //일반 시간 측정
            Stopwatch sw = Stopwatch.StartNew();

            int sum = 0;

            for(int i = 0; i< 1_000_000; i++)
            {
                sum++;
            }

            sw.Stop();

            Console.WriteLine($"총 걸린시간 : {sw.Elapsed.TotalMilliseconds} ms");
            //컴퓨터 성능, 컴퓨터 상태, 환경에 따라 걸린 시간이 다름
        }
    }
}
