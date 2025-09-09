namespace _1_힙트리_우선순위큐
{
    //힙 트리 Heap Tree (힙메모리와 관련없음)
    // 구조조건 2가지
    //  1. 부모가 항상 자식보다 크거나(최대힙) 작음(최소 힙)
    //  2. 마지막 레벨 바로 위 레벨까지는 항상 꽉차있어야함

    // 위 구조로 인해 노드의 개수를 알면 트리의 구조를 머리속으로 그릴수 있음

    // 배열(리스트)로 만들수 있기 때문에 공식 적용이 가능함
    //  [i]번 노드의   왼쪽 자식 접근 : (2 * i) + 1
    //  [i]번 노드의 오른쪽 자식 접근 : (2 * i) + 2
    //  [i]번 노드의        부모 접근 : (i - 1) / 1

    // 삽입
    // 1. 배열(리스트)의 가장 마지막에 일단 삽입
    // 2. 삽입된 위치로 부터 부모접근(공식 (i - 1) / 2) 하여 비교 통해 위치 변경
    // 3. 반복

    // 삭제
    // 1. 가장 처음것을 뽑아냄(힙트리를 사용하는 이유)
    // 2. 가장 마지막 노드를  뽑아서 루트로 올림
    // 3. 루트부터 자기왼쪽과 오른쪽을 비교해서
    //    최대힙일 경우 "더 큰", 최소힙일 경우 "더 작은" 쪽으로 위치 변경
    // 4. 반복

    //결과적으로 항상 정렬된 값을 가져올 수 있음
    //이러한 최소, 최대 힙 구조를 이용해서 힙정렬을 할 수 있고 우선순위 큐 또한 구현 가능

    //특정조건에 의한 가장 좋은 솔루션을 뽑아올때 프라이오리티 큐를 이용하면 광장히 바르게 연산 가능
    // 삽입 삭제가 O(log n)이 걸림

    //우선순위 큐
    class PriorityQueue
    {
        List<int> _heap = new List<int>();
        public void push(int data)
        {
            _heap.Add(data);
            int now = _heap.Count - 1;

            while (now > 0) 
            {
                //부모 구하기
                int next = (now - 1) / 2;

                // 부모보다 작다면 브레이크
                if (_heap[now] < _heap[next])
                    break;
                                  
                //부모랑 나의 위치를 교환
                int temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                //포인터 위치 이동
                now = next;
            }
        }

        public int pop()
        {
            //반환 데이터 저장
            int ret = _heap[0];

            //마지막 인덱스 가져오기
            int lastIndex = _heap.Count - 1;

            //루트 노드의 데이터를 마지막 데이터와 교체하기
            _heap[0] = _heap[lastIndex];

            //마지막 노드 삭제
            _heap.RemoveAt(lastIndex);

            lastIndex--;

            int now = 0;

            while (true) 
            {
                //왼쪽 자식 구하기
                int left = 2 * now + 1;
            
                //오른쪽자식 구하기
                int right = 2 * now + 2;

                int next = now;

                if (left <= lastIndex && _heap[next] < _heap[left])
                    next = left;

                if (right <= lastIndex && _heap[next] < _heap[right])
                    next = right;

                //만약 , 왼쪽 , 오른쪽 모두 ,now 보다 작다면 종료
                if (next == now)
                    break;

                // 이제 두값을 교체
                int temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;
            }

            return ret;
        }

        public int Count()
        {
            return _heap.Count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue q = new PriorityQueue();
            q.push(20);
            q.push(10);
            q.push(30);
            q.push(90);
            q.push(40);

            while (q.Count() > 0)
            {
                Console.WriteLine(q.pop());
            }

            PriorityQueue q2 = new PriorityQueue();
            q2.push(-20);
            q2.push(-10);
            q2.push(-30);
            q2.push(-90);
            q2.push(-40);

            while (q2.Count() > 0)
            {
                Console.WriteLine(-q2.pop());
            }

        }
    }
}
