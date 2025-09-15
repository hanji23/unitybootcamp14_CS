namespace _1_리스트연결리스트
{
    class Mylist<T>
    {
        T[] array;

        int count = 0;

        public Mylist() 
        {
            array = new T[1];
        }

        public void Add(T t)
        {
            if (count >= array.Length)
            {
                T[] coptarray = new T[array.Length * 2];

                for (int i = 0; i < array.Length; i++)
                {
                    coptarray[i] = array[i];
                }
                array = coptarray;
            }

            array[count] = t;
            count++;
        }

        public void removeAt(int c)
        {
            for (int i = c; i < count; i++) 
            {
                array[i] = array[i + 1];
            }

            count--;
        }
    }

    class Node
    {
        public int data;
        public Node Next;
        public Node Prev;
    }

    class MyList2
    {
        Node Head;
        Node Tail;

        int count = 0;

        public Node AddLast(int i)
        {
            Node node = new Node();

            node.data = i;

            if (Head == null)
            {
                Head = node;
            }

            if (Tail != null)
            {
                Tail.Next = node;
                node.Prev = Tail;
            }

            Tail = node;

            count++;
            return node;
        }

        public void remove(Node i)
        {
            if (Head == i)
            {
                Head = Head.Next;
            }

            if (Tail == i)
            {
                Tail = Tail.Prev;
            }

            if (i.Next != null)
            {
                (i.Next).Prev = i.Prev;
            }

            if (i.Prev != null)
            {
                (i.Prev).Next = i.Next;
            }

            count--;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mylist<int> mylist = new Mylist<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);

            mylist.removeAt(3);

            MyList2 myList2 = new MyList2();

            Node i = myList2.AddLast(1);
            myList2.AddLast(2);
            myList2.AddLast(3);
            myList2.AddLast(4);
            myList2.AddLast(5);

            myList2.remove(i);
        }
    }
}
