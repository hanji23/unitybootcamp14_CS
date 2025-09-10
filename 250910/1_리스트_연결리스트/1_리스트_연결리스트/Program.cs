namespace _1_리스트_연결리스트
{
    class MyList<T>
    {
        public T[] list = new T[1];

        int count = 0;

        //인덱서는 잠시 패스

        public void add(T t)
        {
            if (count >= list.Length)
            {
                T[] listCopy = new T[list.Length * 2];


                for (int i = 0; i < count; i++)
                {
                    listCopy[i] = list[i];
                }

                list = listCopy;
            }

            list[count] = t;
            count++;
        }

        public void removeAt(int index)
        {
            T[] listCopy = new T[list.Length];
            int c = 0;

            for (int i = index; i < count; i++)
            {
                list[i] = list[i + 1];
                c++;
            }
            count--;
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node prev;
    }

    class MyList2
    {
        int count = 0;

        public Node head;
        public Node tail;

        public Node AddLast(int data)
        {
            Node node = new Node();
            node.data = data;

            if (head == null)
            {
                head = node;
            }

            if (tail != null)
            {
                tail.next = node;
                node.prev = tail;
                
            }

            tail = node;
            count++;
            return node;
        }

        public void Remove(Node data) 
        {

            if (data == head)
            {
                //head = null;
                head = head.next;
            }

            if (data == tail)
            {
                tail = tail.prev;
            }

            if (data.prev != null)
            {
                (data.prev).next = data.next;
            }

            if (data.next != null)
            {
                (data.next).prev = data.prev;
            }
            
            count--;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> i = new MyList<int> ();

            i.add(1);
            i.add(2);
            i.add(3);
            i.add(4);
            i.add(5);

            foreach (int x in i.list) 
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            i.removeAt(3);

            foreach (int x in i.list)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            MyList2 i2 = new MyList2();

            Node n = i2.AddLast(1);
            i2.AddLast(2);
            i2.AddLast(3);
            i2.AddLast(4);
            i2.AddLast(5);

            i2.Remove(n);
        }
    }
}
