namespace _3_연결리스트
{
    // 배열 / 리스트 -> 인덱스 접근 빠름 (O(1)), 하지만 중간 삽입/삭제 느림(O(N))
    // 연결 리스트 -> 중간 삽입/삭제 빠름 (O(1)), 하지만 인덱스 접근 느림 (O(N))

    class Node
    {
        public int Data;

        public Node Next;
        public Node Prev;
    }

    class MyLinkedList
    {
        public Node Head = null; // 처음
        public Node Tail = null; // 마지막

        public int count = 0;

        public Node AddLast(int data) 
        {
            Node newNode = new Node();
            newNode.Data = data;

            if(Head == null)
            {
                Head = newNode;
            }

            if(Tail != null)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
            }

            Tail = newNode;
            count++;
            return newNode;
            
            // O(1)
        }

        public void Remove(Node node)
        {
            if (Head == node)
            {
                Head = Head.Next;
            }

            if (Tail == node)
            {
                Tail = Tail.Prev;
            }

            //지우려는 노드의 이전 노드가 있는지 확인
            if (node.Prev != null)
            {
                //(지우려는 노드의 이전 노드)의 다음 노드를 "지우려는 노드의 (다음 노드)" 로 번경
                (node.Prev).Next = node.Next;
            }
            //지우려는 노드의 다음 노드가 있는지 확인
            if (node.Next != null)
            {
                //(지우려는 노드의 다음 노드)의 이전 노드를 "지우려는 노드의 (이전 노드)" 로 번경
                (node.Next).Prev = node.Prev;
            }

            // [node.Prev] <-> [node] <-> [node.Next]
            //
            //   이전노드     지울 노드    다음노드

            //                   ↓

            //           <-    [node]   ->
            //[node.Prev] <-------------> [node.Next]
            //                  ->
            //     (node.Prev).Next = node.Next;
            //                  <-
            //     (node.Next).Prev = node.Prev;
            
            count--;
            //O(1)
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 연결 리스트는  노드를 리스트로 들고 있다
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            //연결 리스트 노드는 연결 리스트의 하나의 요소이다
            LinkedListNode<int> node = list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);

            list.Remove(node); // 인덱스값이 아닌 노드값을 제거

            // 직접만든 연결리스트
            MyLinkedList mylist = new MyLinkedList();
            mylist.AddLast(1);
            mylist.AddLast(2);
            Node mynode = mylist.AddLast(3);
            mylist.AddLast(4);
            mylist.AddLast(5);
            mylist.AddLast(6);

            mylist.Remove(mynode);
        }
    }
}
