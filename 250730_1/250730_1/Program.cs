namespace _250730_1
{
    internal class Program
    {
        #region 오버로딩
        //오버로딩 (다중 정의)
        //하나의 이름을 다중으로 정의한다
        //오버로딩 = "함수 이름 재사용"
        //매개변수가 달라야지만 재사용이 가능

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Add(int a)
        //{
        //    return a + 5;
        //}

        //static int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
        #endregion

        #region 선택적매개변수
        //static int Add(int a, int b, int c = 99)
        //{
        //    return a + b + c;
        //}

        //static int Add2(int a, int b, int c = 0, int d = 0, int e = 0)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);
        //    Console.WriteLine(d);
        //    Console.WriteLine(e);

        //    return 0;
        //}
        #endregion

        #region 과제함수
        //static int SumBetween(int a, int b)
        //{
        //    int result = 0;
        //    for (int i = a; i <= b; i++)
        //        result = result + i;
        //    return result;
        //}
        #endregion

        #region 재귀함수
        static int SumBetween(int a, int b)
        {
            if (a > b)
            {
                return 0; // 종료 조건
            }
            return a + SumBetween(a + 1, b); //재귀 함수 : 함수 안에서 자기자신을 다시 호출하는 함수
        }
        #endregion

        static void Main(string[] args)
        {
            #region 오버로딩
            //int a = 1;
            //int b = 2;
            //int c = 3;

            //int result = Add(a, b);
            //int result2 = Add(a);
            //int result3 = Add(a, b, c);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            #endregion

            #region 선택적매개변수
            //int a = 1;
            //int b = 2;

            //int result2 = Add(a, b);
            //Console.WriteLine(result2);

            //int c = 3;
            //result2 = Add(a, b, c);
            //Console.WriteLine(result2);

            //result2 = Add2(a, b, e : 4, c : 2);
            #endregion

            //화살표 함수, 로컬함수는 책으로 확인

            //int result = SumBetween(1, 6);
            //Console.WriteLine($"결과:{result}");

            #region 재귀함수

            //함수 안에서 자기자신을 다시 호출하는 함수
            //주로 for문 사용을 권장하나 재귀 함수가 쓰이는 경우가 있다
            int result = SumBetween(1, 6);
            Console.WriteLine($"결과:{result}");
            #endregion

            // F9 중단점 생성후 오른쪽 마우스를 눌러 조건을 걸수 있음(해당 조건일 때만 멈추고 디버그 확인 가능)
            // 중단점이 여러개 있을때 f5를 누르면 처음 중단점에서 멈춘 후 다시 f5를 누르면 다음 중단점으로 이동
        }
    }
}
