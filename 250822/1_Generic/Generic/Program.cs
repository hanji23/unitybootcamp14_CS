namespace _1_Generic_일반화
{
    // ↓ 추천
    // 인벤토리 - 리스트
    // 아이템 정보 - 딕셔너리
    // 맵의 오브젝트 ID - 배열

    class MyList
    {
        int[] arr = new int[10];
    }
    class MyfloatList
    {
        float[] arr = new float[10];
    }
    // 위방식은 타입, 변수, 함수등이 늘어날때마다 클래스를 새로 만들어 줘야함

    // object = C#의 "모든 타입"의 조상 클래스
    //      object obj = new MyList(); obj = "안녕"; (가능)
    // var 타입을 추론
    //      var v = true;   //v = "!";  (불가)

    // 하지만 타입을 전부 object로 만들면 박싱과 언박싱 과정으로 인해 속도가 느려짐

    //Generic(일반화) - 타입을 나중에 결정하는 설계도
    // 장점
    //  1. 타입별로 중복되는 코드를 만들 필요 없음
    //  2. object 처럼 박싱과 언박싱이 필요없으니 성능향상
    //  3. 잘못된 타입을 넣으려 하면 컴파일 시점에서 에러를 잡아줌
    // 「 사용법 (여기서 T는 관례(다른 이름으로 써도 됨) type 또는 템플릿의 약자)
    // ↓         T는 결과적으로 런타임에 우리가 지정해준 형식으로 치환됨
    class MyList<T>
    {
        T[] arr = new T[10];

        public T GetItem(int index)
        {
            return arr[index];
        }
    }

    class MyList2<T> where T : struct // T는 반드시 값형식으로만 사용할 수 있다(int, float, bool, ...)
    {
        T[] arr = new T[10];

        public T GetItem(int index)
        {
            return arr[index];
        }
    }

    class MyList3<T> where T : class // T는 반드시 참조형식으로만 사용할 수 있다(class, string, ...)
    {
        T[] arr = new T[10];

        public T GetItem(int index)
        {
            return arr[index];
        }
    }

    class MyList4<T> where T : new() // 기본생성자가 있어야만 사용할수 있다
    {
        T[] arr = new T[10];

        public T GetItem(int index)
        {
            return arr[index];
        }

        public void Test()
        {
            T t = new T();
        }
    }

    internal class Program
    {
        static public void Test<T>(T value)
        {
            Console.WriteLine($"입력값 : {value} ");
        }

        static public void Test2<T>(T value) where T : struct
        {
            Console.WriteLine($"입력값 : {value} ");
        }

        static public void Test3<T>(T value) where T : class
        {
            Console.WriteLine($"입력값 : {value} ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            object obj = new MyList();
            obj = "안녕";

            var v = true;
            //v = "!";

            //비추천
            // 박싱(boxing)     : 스택 -> 힙
            object test = 3;
            // 언박싱(Unboxing) :   힙 -> 스택
            int b = (int)test;

            MyList<int> myIntList=  new MyList<int>();
            MyList<string> myStringList = new MyList<string>();
            
            int a = myIntList.GetItem(0);
            //string b = myStringList.GetItem(0);

            Test<int>(10);
            Test<float>(3.14f);
            Test<string>("!!!!!!");
            Test<bool>(true);

            Console.WriteLine();

            Test(10);
            Test(3.14f);
            Test("!!!!!!");
            Test(true); // <T>를 넣지 않아도 해당 타입을 호출하면서 추론
            //남이 볼것을 고려하여 적어두는 것을 권장

            Console.WriteLine();

            Test2<int>(10);
            Test2<float>(3.14f);
            //Test2<string>("!!!!!!"); 참조형식 에러발생
            Test2<bool>(true);

            Console.WriteLine();

            //Test3<int>(10); 값형식 에러발생
            //Test3<float>(3.14f); 값형식 에러발생
            Test3<string>("!!!!!!");
            //Test3<bool>(true); 값형식 에러발생
        }
    }
}
