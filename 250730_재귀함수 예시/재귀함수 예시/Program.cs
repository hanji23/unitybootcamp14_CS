namespace 재귀함수_예시
{
    internal class Program
    {
        // 재귀함수 - 함수 안에서 자기 자신을 다시 호출하는 함수
        /*
SumBetween(1, 6)
return = 1 + SumBetween(2, 6)
return = 1 + 2 + SumBetween(3, 6)
return = 1 + 2 + 3 + SumBetween(4, 6)
return = 1 + 2 + 3 + 4 + SumBetween(5, 6)
return = 1 + 2 + 3 + 4 + 5 + SumBetween(6, 6)
return = 1 + 2 + 3 + 4 + 5 + 6 + SumBetween(7, 6)
return = 1 + 2 + 3 + 4 + 5 + 6 + 0 (종료)
→ 결과: 21
/

/
return = 1 + SumBetween(2, 6)
return =     (       2      ) + SumBetween(3, 6)
return =                        (       3      ) + SumBetween(4, 6)
return =                                           (       4      ) + SumBetween(5, 6)
return =                                                              (       5      ) + SumBetween(6, 6)
return =                                                                                 (       6      ) + SumBetween(7, 6)
                                                                                                            (       0      )
*/

        static int SumBetween(int a, int b)
        {
            if (a > b)
                return 0;

            return a + SumBetween(a + 1, b);
        }

        static void Main(string[] args)
        {
            // 1 + 2 + 3 + 4 + 5 + 6 = 21
            int result = SumBetween(1, 6);
            Console.WriteLine($"결과: {result}");

            // F9 중단점 생성후 오른쪽 마우스를 눌러 조건을 걸수 있음(해당 조건일 때만 멈추고 디버그 확인 가능)
            // 중단점이 여러개 있을때 f5를 누르면 처음 중단점에서 멈춘 후 다시 f5를 누르면 다음 중단점으로 이동
        }
    }
}
