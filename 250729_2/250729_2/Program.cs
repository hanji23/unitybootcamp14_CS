namespace _250729_2
{
    internal class Program
    {
        #region 메소드, 함수
        //한정자 - 스테틱, 접근 지정자...
        //한정자 반환형식(타입) 함수이름(매개변수 들)
        //{
        //
        //}

        //함수의 값들은 스택 메모리에 저장 된 후 함수가 끝나면 사라진다 
        //함수가 실행 될때 [스텍 메모리]에 메모리 등재, 함수가 종료되면 메모리에서 해제
        // 별개로 Main 함수는  프로그램이 완전 종료되면 해제됨

        //함수로 값을 보낼땐
        //!!!! 값전달 - 값을 *복사* 해서 전달함 !!!!

        //!!!!참조전달 - *주소 공유* !!!! - ref 키워드 레퍼런스
        //값이 아닌 주소를 공유 (실제변수를 전달 해준다)
        //변수를 만들면 ram에 올라가고 ram에는 각각의 주소가 있다.
        // 다만 범용성과 안정성 때문에 값전달, return 사용을 권장함 (값을 아예 뒤바꾸는 경우 등등을 제외하고는 ref c#에선 잘 쓰지는 않음)

        //out - 보통 다중 반환할때 사용한다.

        //ref, out 차이                  [ref][out][일반변수]
        //주소공유 방식                  [ O ][ O ][값전달(복사)]
        //함수 호출전 반드시 초기화?     [ O ][ X ][ O ]
        //함수 내에서 반드시 값쓰기?     [ X ][ O ][ X ]
        //함수 안에서 읽기 가능?         [ O ][ X ][ O ]
        //                                      ↑단, out의 값을 모두 썼다면 읽기가능

        ///XML 문서 주석 ↓예시

        /// <summary>
        /// 이 함수가 무얼 의미 하는지, 무슨기능인지 설명
        /// </summary>
        /// <param name="a">이 매개 변수가 뭘 의미하는지 설명</param>
        /// <param name="b">이 매개 변수가 뭘 의미하는지 설명</param>
        /// <returns>얘가 반환할 값이 무엇인지 설명</returns>
        static int add(int a, int b) // return으로 값을 반환해야함
        {
            //int sum = a + b;
            //return sum;

            return a + b;
        }
        static void sum(int a, int b) // void는 반환값이 필요없음
        {
            Console.WriteLine(a + b);
        }

        static void add2(ref int number) //ref를 붙이면 값전달(복사)이 아닌 참조전달을 함
        {
            number++;
        }

        static void asfd(out int gold, out int exp, out string item, ref int a)
        {
            int temp = a;  //안정성의 규칙의 의해 읽어올순 있으나 함수로 넘어오기전에 초기화
            //temp = gold; //안정성의 규칙의 의해 불가능
            gold = 0;
            exp = 0;
            item = "";

            temp = gold; //값을 모두다 입혔다면 그다음부터는 읽을수 있음
        }

        //static void choice(int a_number)
        //{
        //    int number = a_number;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        int j = int.Parse(Console.ReadLine());

        //        if (j == number)
        //        {
        //            Console.WriteLine("정답");
        //            break;
        //        }
        //    }
        //}


        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        #endregion

        static void Main(string[] args)
        {
            //메소드 - 개념적으로는 코드를 재사용
            //기능의 묶음

            // c# - 메소드, c++ Function ... 프로시저 등등을 함수라 부른다
            //int a = 1;
            //int b = 2;

            //int c = /*Program.*/add(a, b); //!!!! 값전달 - 값을 *복사* 해서 전달 !!!!
            //Console.WriteLine(c);

            //choice(int.Parse(Console.ReadLine()));

            //int a = 99;
            //add2(ref a);//참조전달을 사용할땐 ref사용
            //Console.WriteLine(a);

            //ref로 변수 전달하려면 초기화 되어 있어야 함
            int a = 99;
            int b = 1;

            Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}