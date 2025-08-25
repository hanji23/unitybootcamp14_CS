namespace _1_delegate_대리자_그리고이벤트
{
    //delegate = 대리자
    //  콜백을 가능하게 해주는 도구
    //  함수 자체를 인자로 넘겨주는 방식

    // * 함수를 매개변수로 넘겨주는 방식 *

    //함수 자체를 인자로 넘겨주는 방식이 가능하게 함
    //즉 함수를 타입화 시켜줌 -> int라는 타입 = 정수형식을 int라는 이름으로 부름
    //delegate void Onclicked(); void를 반환하고 매개변수가 없는 타입을 Onclicked라고 부르겠다는 것

    //delegate는 상정외 상황에서 외부에서 작동할 수 있지만 event를 사용하면 해당 경우를 막을수 있음

    //delegate 핵심은 타입화

    internal class Program
    {
        //delegate 타입 함수이름();
        //형식은 형식인데, 함수자체를 인자로 넘겨주는 형식
        delegate int Onclick();
        //↑ 반환 : int, 입력 : void, Onclick이 delegate 형식의 이름


        delegate void Onclicked();

        event Onclicked onCliked;

        //static void buttonevent(Onclick onclick /* ← 함수 받음*/)
        //{
        //    onclick();
        //    onclick.Invoke();
        //}

        static void buttonevent(Onclicked onCliked)
        {
            onCliked.Invoke();
        }

        static int Test()
        {
            Console.WriteLine("넘겨주는 함수 1");
            return 0;
        }

        static int Test2()
        {
            Console.WriteLine("넘겨주는 함수 2");
            return 0;
        }

        static void Attack() { }

        static void Main(string[] args)
        {
            //buttonevent(Test);
            Onclick onclick = new Onclick(Test);
            onclick += Test2;//구독

            //buttonevent(Test);
        }
    }
}
