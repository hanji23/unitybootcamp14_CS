namespace mylist
{
    class MyList<T>
    {
        public T[] mylist;
        static int count = 0;

        public MyList()
        {
            mylist = new T[1];
        }

        public void Add(T t)
        {
            if (count > mylist.Length - 1)
            {
                T[] copylist = mylist;

                mylist = new T[mylist.Length * 2];

                for (int c = 0; c < copylist.Length; c++)
                {
                    mylist[c] = copylist[c];
                }
            }
            mylist[count] = t;
            count++;
        }

        public void RemoveAt(int i)
        {
            T[] copylist = mylist;
            int c2 = 0;

            for (int c = 0; c < mylist.Length; c++)
            {
                if (c == i)
                {
                    count--;
                    continue;
                }
                mylist[c2] = copylist[c];
                c2++;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int delnum = 0;
            MyList<int> ml = new MyList<int>();
            ml.Add(1);
            ml.Add(2);
            ml.Add(3);
            ml.Add(4);
            ml.Add(5);
            //ml.Add(6);
            //ml.Add(7);
            //ml.Add(8);
            //ml.Add(9);

            for (int i = 0; i < ml.mylist.Length; i++)
            {
                Console.WriteLine($"ml.mylist [{i}] ->  {ml.mylist[i]}");
            }

            delnum = 0;
            ml.RemoveAt(delnum);
            Console.WriteLine();

            for (int i = 0; i < ml.mylist.Length; i++)
            {
                Console.WriteLine($"ml.mylist [{i}] ->  {ml.mylist[i]}      [{delnum}] 삭제");
            }

            delnum = 0;
            ml.RemoveAt(delnum);
            Console.WriteLine();

            for (int i = 0; i < ml.mylist.Length; i++)
            {
                Console.WriteLine($"ml.mylist [{i}] ->  {ml.mylist[i]}      [{delnum}] 삭제");
            }

            Console.WriteLine();
            ml.Add(6);
            ml.Add(7);
            ml.Add(8);
            ml.Add(9);
            ml.Add(10);
            ml.Add(11);

            for (int i = 0; i < ml.mylist.Length; i++)
            {
                Console.WriteLine($"ml.mylist [{i}] ->  {ml.mylist[i]}      삭제한 다음 추가 ");
            }

            Console.WriteLine();

            MyList<string> ml2 = new MyList<string>();
            ml2.Add("11");
            ml2.Add("22");
            ml2.Add("33");
            ml2.Add("44");
            ml2.Add("55");
            //ml2.Add("66");
            //ml2.Add("77");
            //ml2.Add("88");
            //ml2.Add("99");

            for (int i = 0; i < ml2.mylist.Length; i++)
            {
                Console.WriteLine($"ml2.mylist {i} ->  {ml2.mylist[i]} ");
            }

            delnum = 0;
            ml2.RemoveAt(delnum);
            Console.WriteLine();

            for (int i = 0; i < ml2.mylist.Length; i++)
            {
                Console.WriteLine($"ml2.mylist [{i}] ->  {ml2.mylist[i]}    [{delnum}] 삭제 ");
            }

            delnum = 1;
            ml2.RemoveAt(delnum);
            Console.WriteLine();

            for (int i = 0; i < ml2.mylist.Length; i++)
            {
                Console.WriteLine($"ml2.mylist [{i}] ->  {ml2.mylist[i]}      [{delnum}] 삭제");
            }

            Console.WriteLine();

            ml2.Add("66");
            ml2.Add("77");
            ml2.Add("88");
            ml2.Add("99");
            ml2.Add("1010");
            ml2.Add("1111");
            for (int i = 0; i < ml2.mylist.Length; i++)
            {
                Console.WriteLine($"ml2.mylist [{i}] ->  {ml2.mylist[i]}        삭제한 다음 추가 ");
            }
        }
    }
}
