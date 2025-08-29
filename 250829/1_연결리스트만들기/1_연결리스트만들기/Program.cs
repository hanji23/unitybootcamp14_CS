using static System.Net.Mime.MediaTypeNames;

namespace _1_연결리스트만들기
{
    class Node()
    {
        public int data;
        public Node Next = null;
        public Node Prev = null;
    }

    class RL
    {
        int count = 0;
        Node Head;
        Node Tail;

        public Node AddLast(int data)
        {
            Node node = new Node();
            node.data = data;

            if (Head == null)
            {
                Head = node;
            }

            if (Tail != null)
            {
                node.Prev = Tail;
                Tail.Next = node;
            }

            Tail = node;

            count++;
            return node;
        }

        public void Remove(Node data)
        {
            if (Head == data)
            {
                Head = null;
            }
            if (Tail == data)
            {
                Tail = null;
            }
            if (data.Next != null)
            {
                (data.Next).Prev = data.Prev;
            }
            if (data.Prev != null)
            {
                (data.Prev).Next = data.Next;
            }

            count--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RL rl = new RL();
            rl.AddLast(1);
            rl.AddLast(2);
            //rl.AddLast(3);
            rl.AddLast(4);
            rl.AddLast(5);
            rl.AddLast(6);

            Node node = rl.AddLast(3);

            rl.Remove(node);
        }
    }
}
