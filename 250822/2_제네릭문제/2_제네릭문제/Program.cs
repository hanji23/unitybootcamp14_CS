using System;

namespace _2_제네릭문제
{
    // 문제
    // 인벤토리 라는 이름의 제네릭 클래스를 만들고, 아래 3개의 함수를 구현하세요.

    //  int Count() → 현재 인벤토리에 들어있는 아이템 개수를 반환
    //  void Add(T item) → 인벤토리에 아이템을 추가
    //  T Get(int index) → 인벤토리에서 해당 위치(index)의 아이템을 가져오기

    //  그리고 Main 함수에서 아래와 같이 사용해 보세요.
    //  Inventory<int>를 만들어 10, 20을 추가한 뒤, 개수와 인덱스 1의 값을 출력
    //  Inventory<string>을 만들어 "Sword", "Potion"을 추가한 뒤, 개수와 인덱스 0의 값을 출력

    // 출력결과
    //  Count:Int = 2
    //  Item: Int[1] = 20
    //  Count: String = 2
    //  Item: String[0] = Sword

    class Inventory<T>
    {
        List<T> list = new List<T>();

        public int Count()
        {
            return list.Count;
        }

        public void Add(T item) 
        {
            list.Add(item);
        }
        public T Get(int index) 
        { 
            return list[index]; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Hello, World!");
            Inventory<int> listint = new Inventory<int>();
            listint.Add(10);
            listint.Add(20);

            Console.WriteLine($"Count:{listint.Count()}");
            Console.WriteLine($"Item: Int[{i}] = {listint.Get(i)}");

            i = 0;

            Inventory<string> liststring = new Inventory<string>();
            liststring.Add("Sword");
            liststring.Add("Potion");

            Console.WriteLine($"Count:{liststring.Count()}");
            Console.WriteLine($"Item: string[{i}] = {liststring.Get(i)}");
        }
    }
}
