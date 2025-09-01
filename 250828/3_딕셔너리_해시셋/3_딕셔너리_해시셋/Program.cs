namespace _3_딕셔너리_해시셋_해시테이블
{
    class Monster
    {
        public int Id;

        public Monster(int id)
        {
            this.Id = id;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>();
            monsters.Add(new Monster(1));
            monsters.Add(new Monster(2));
            monsters.Add(new Monster(3));
            monsters.Add(new Monster(4));
            monsters.Add(new Monster(5));


            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            dic.Add(1, new Monster(1234214)); // 키를 통해 빠르게 찾을수 있음

            HashSet<Monster> list = new HashSet<Monster>(); // 중복되는 데이터는 넣을수 없다
            list.Add(new Monster(132432)); // 벨류가 키값
            list.Add(new Monster(132432)); // 중복으로 들어가지 않음

            list.Clear();

            //해시테이블
            // 1. 키값 입력(해시셋의 경우 값이 곧 키)
            // 2. 키값을 GetHashCode() 함수로 해시화 (숫자화)
            // ㄴ 나온 숫자값을 배열 크기만큼 나머지 연산을 한 후 나온수를 인덱스로 함 (12347918234792134(GetHashCode() 함수로 해시화 (숫자화)한 값) % 배열 크기 => 인덱스)

            // 3. 버킷이 모자르면 생성하는데 로드팩터 0.7을 유지하며, 그값이 2의 거듭제곱보다 작다면 2의 거듭제곱 값으로 만들어줌
            //                                          ㄴ(60개가 있다면 => 86개가 로드팩터이나 2의 거듭제곱중 86보다 큰 128로 만들어줌)
            // 4. 2.에서 만들어놓은 숫자화 값을 버킷의 개수로 나머지 연산함
            // 5. 나머지연산한 값이 버킷의 인덱스 번호임

            // *: 컬리전이 생기면 같은 버킷에 여러개의 요소가 연결된 형태로 들어가게됨

            //        //            딕셔너리                                        |   해시셋 
            //        // 저장요소 | Key, Value                                      |   Value(key)
            //        // 내부구조 | Entry { hashCode, Next, Key, Value }            | Entry { hashCode, Next, Value }
            //        // 값 접근  | dict[key] -> Value 반환                         | set.Contains(Value=>Key) 만 가능
            //        // 사용 목적| 키로 값 빠르게 조회                             | 중복없는 리스트, 특정 원소 존재 여부
            //        // 단점     | 현재는 저장한 순으로 정렬되나 언제 바뀔지 모름  | 정렬 안됨
        }
    }
}
