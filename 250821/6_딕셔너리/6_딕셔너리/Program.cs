using System.Threading;

namespace _6_딕셔너리
{
    class Monster
    {
        public int Id;

        public Monster(int i)
        {
            Id = i;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //딕셔너리는 해시테이블을 사용함

            //고유 키값
            // Id가 1234 몬스터 찾아서 hp 깍기
            //를 for문으로 진행할때 
            // o(n) - 3초 가 걸린다면...
            //리스트로 검색시 처음부터 끝까지 탐색 o(n)

            //Dictionary : key - value
            // o(1) - 상수시간 
            //거의 즉시 끝남
            //딕셔너리 검색시 key로 해당값을 바로 찾음 o(1)

            // key = 데이터의 이름표
            // value = 데이터(내용물)
            //Dictionary<key타입, Value타입> 변수명 = new Dictionary<key타입, Value타입>();

            //Dictionary<int, string> -> key는 int, Value는 string
            //Dictionary<int, monster> -> key는 int, Value는 monster클래스

            //Dictionary는 참조타입

            //List<Monster> monsters = new List<Monster>();
            //monsters.Add(new Monster());

            Dictionary<int, Monster> di = new Dictionary<int, Monster>();
            di.Add(1, new Monster(1));
            //di.Add(1, new Monster(2)); 이전에 등록한 키를 다시 넣으면 오류발생

            bool test = di.TryAdd(1, new Monster(2)); // Add를 시도해보고 성공하면 참, 실패하면 거짓

            di[1234] = new Monster(1234); // 이전에 키값이 없었으면 키값을 새로 생성해서 넣어줌
            di[1] = new Monster(2); // 이전에 키값이 없었으면 해당 키의 벨류를 교체

            Monster monster = di[1];
            //Monster monster2 = di[2]; // 해당하는 키가 없으면 오류발생
            Monster monster2;
            bool success = di.TryGetValue(1, out monster2); // 검색를 시도해보고 성공하면 참, 실패하면 거짓

            bool success2 = di.Remove(1);//키값을 넣어주면 해당하는 엘리먼트를 삭제한다 성공시 참 실패시 거짓

            di.Clear();// 딕셔너리에 모든값을 삭제

            //딕셔너리의 두가지 행동
            // 1 : Key값을 해시(Hash, 숫자)화 해서 인덱스로 변환하고 그걸 저장 (그리고 여러가지 뭔가함)
            // 2 : 변환된 해시값을 큰하나의 통에 통째로 넣는게 아니라 잘게 쪼갠통에 넣어줌
        }
    }
}
