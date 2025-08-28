namespace _2_연결리스트_만들기
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;
    }

    class MyLinkedList
    {
        public Node Head = null;
        public Node Tail = null;
        public int count;

        public Node AddLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            // TODO : 구현
            if (Head == null)
            {
                Head = newNode;
            }

            //if (Tail == null)
            //{
            //    Tail = newNode;
            //}
            //else
            //{
            //    //Node ett = new Node(); //새 객체를 만들이유가 없음

            //    Tail.Next = newNode;
            //    //ett = Tail; ↓
            //    Node ett = Tail;
            //    Tail = newNode;
            //    Tail.Prev = ett;
            //} 
            //↑생각한 대로 만든 방식 

            if (Tail != null)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
            }
            Tail = newNode;

            count++;

            return newNode;
        }

        public void Remove(Node node)
        {
            // TODO : 구현
            if (node == Head)
            {
                Head = Head.Next;
                
            }
            if (node == Tail)
            {
                Tail = Tail.Prev;
            }
            if (node.Prev != null)
            {
                (node.Prev).Next = node.Next;
            }
            if(node.Next != null)
            {
                (node.Next).Prev = node.Prev;
            }
            count--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddLast(1);
            myLinkedList.AddLast(2);
            //myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(5);
            myLinkedList.AddLast(6);

            Node mynode = myLinkedList.AddLast(3);
            myLinkedList.Remove(mynode);
        }
    }
}
