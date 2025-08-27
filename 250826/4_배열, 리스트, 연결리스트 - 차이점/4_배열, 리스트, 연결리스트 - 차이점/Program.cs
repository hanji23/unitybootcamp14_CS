using System.Reflection;

namespace _4_배열__리스트__연결리스트___차이점
{
    //선형자료구조 - 자료를 순차적으로 나열함
    // ㄴ 배열, 리스트, 연결 리스트, 스택, 큐
    //[1][][][][][][][][][]

    //비선형 자료 구조 - 하나의 자료 구조가 올 수 있음
    // 트리, 그래프
    //[1]
    // ㄴ[2]
    // ㄴ[3]
    // ㄴ[4]
    // ㄴ[5]


    //배열
    // 배열은 [인덱스를 통한 접근 속도]가 아주 빠름 O(1)
    // 처음 설정한 크기가 고정되어 변경이 불가함
    // 메모리상에 연속된 형태로 데이터가 저장됨
    // 장점 : 데이터 연속
    // 단점 : 추가 / 삭제 불가

    //동적 배열 (List)
    // 내부적으로는 배열 기반으로 동작
    // 크기가 꽉차면 새로운 배열을 만들고 기존 데이터를 복사하여 확장함
    // 확장시 보통 1.5배~ 2배 단위로 확장 (언어 / 라이브러리마다 다름)
    // 장점 : 크기 확장 자동 처리
    // 단점 : 중간 삽입 / 삭제 느림 O(n)

    //연결 리스트 (Linked List)
    // 연결리스트는 노드를 가지고 있고, 해당 노드에는 값과 다음, 또는 이전 노드의 주소가 있음
    // 각 원소(node)가 데이터 + 다음 노드 + 이전 노드 주소(포인터)로 구성됨
    // 메모리상에 연속적으로 배치될 필요없음(화살표로 연결)
    // 장점 : 중간 삽입 / 삭제가 빠름 O(1)
    // 단점 : 특정 위치 검색이 느림

    // 실제 사용량, 배열의 크기가 얼마나 되나

    // 배열 / 리스트 -> 인덱스 접근 빠름 (O(1)), 하지만 중간 삽입/삭제 느림(O(N))
    // 연결 리스트 -> 중간 삽입/삭제 빠름 (O(1)), 하지만 인덱스 접근 느림 (O(N))

    class MyList<T>
    {
        public T[] mylist = new T[0];
        static int count = 0;

        public MyList()
        {
            mylist = new T[1];
        }

        public void Add(T t)
        {
            if (count > mylist.Length - 1)
            {
                T[] copylist = mylist;

                mylist = new T[mylist.Length * 2];

                for (int c = 0; c < copylist.Length; c++)
                {
                    mylist[c] = copylist[c];
                }
            }
            mylist[count] = t;
            count++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ml = new MyList<int>();
            ml.Add(1);
            ml.Add(2);
            ml.Add(3);
            //ml.Add(4);
           // ml.Add(5);
            //ml.Add(6);
            //ml.Add(7);
            //ml.Add(8);
            //ml.Add(9);

            for (int i = 0; i < ml.mylist.Length; i++)
            {
                Console.WriteLine($"ml.mylist {i} ->  {ml.mylist[i]} ");
            }

            Console.WriteLine();

            MyList<string> ml2 = new MyList<string>();
            ml2.Add("11");
            ml2.Add("22");
            ml2.Add("33");
            ml2.Add("44");
            ml2.Add("55");
            //ml2.Add("66");
            //ml2.Add("77");
            //ml2.Add("88");
            //ml2.Add("99");

            for (int i = 0; i < ml2.mylist.Length; i++)
            {
                Console.WriteLine($"ml2.mylist {i} ->  {ml2.mylist[i]} ");
            }

        }
    }
}
