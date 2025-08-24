namespace _5_리스트
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인벤토리, 채팅기록등 추후에 얼마나 늘어날지 예상할 수 없는 정보들은 배열로 사용하기엔 부적합함 
            //List  - 필요할 때 자동으로 커지는 배열
            //내부적으로는 배열, 클래스 내부에서 배열을 관리

            //[0][1][2][3] //꽉참
            //      ↓
            //[0][1][2][3][_][_][_].... // 더큰 배열로 교체

            //List<타입> 이름 = new List<타입>();
            //제네릭 문법 <> : 여기안에 저장할 데이터의 타입을 지정
            //인덱스를 통해 접근
            List<int> numbers = new List<int>();
            
            numbers.Add(10); // [0] -> 1 - 리스트에 1 추가
            numbers.Add(20); // [1] -> 2
            numbers.Add(30); // [2] -> 3

            numbers.Insert(1, 25); // 1번 인덱스 위치에 25 삽입 (이전 1번 인덱스 변경 X) 최대범위를 벗어나면 오류발생

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i}  {numbers[i]}");
            //}
            

            for (int i = 0; i < numbers.Count; i++) //  list는 Count로 전체 범위를 알수 있음
            {
                Console.WriteLine($"{numbers[i]}");
            }
            Console.WriteLine();

            numbers.Remove(10);  // 리스트에 10이 있으면 삭제
            numbers.Remove(444); // 해당 리스트에 해당 값이 없으면 넘어감
            //Remove는 bool를 리턴 지우는데 성공시 참 실패시 거짓
            bool b = numbers.Remove(20);

            numbers.RemoveAt(1); // 해당 인덱스를 삭제
            //numbers.RemoveAt(6); // 인덱스를 초과하면 오류발생
            
            foreach (int cal in numbers)
            {
                Console.WriteLine(cal);
            }
            Console.WriteLine();

            numbers.Clear(); // 리스트에 모든 내용을 삭제

            //리스트는 삽입과 삭제에 시간이 오래걸린다
            //O(n) - 선형시간

            //데이터 갯수가 변하지 않는다면 배열, 변한다면 리스트를 사용

            foreach (int cal in numbers)
            {
                Console.WriteLine(cal);
            }
            Console.WriteLine();



        }
    }
}
