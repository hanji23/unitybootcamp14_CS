namespace _1_리스트_만들기_복습
{
    class MyList<T>
    {
        public T[] list;
        int count = 0;

        public MyList() 
        {
            list = new T[1];
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return list[index];
            }
            set
            {
                if (index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                list[index] = value;
            }

        }

        public void Add(T t)
        {
            if (count > list.Length - 1)
            {
                T[] copylist;
                copylist = new T[list.Length * 2];

                for (int i = 0; i < list.Length; i++)
                {
                    copylist[i] = list[i];
                }

                list = copylist;
            }

            list[count] = t;
            count++;
        }

        //public void RemoveAt(int i) 
        //{

        //    T[] copylist = list;
        //    int c = 0;

        //    for (int j = 0; j < list.Length; j++)
        //    {
        //        if (j == i)
        //        {
        //            count--;
        //            continue;
        //        }
        //        list[c] = copylist[j];
        //        c++;
        //    }
        //}

        public void RemoveAt(int index)
        {
            for (int i = index; i < count; i++)
            {
                list[i] = list[i + 1];
            }
            count--;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<int> mylist = new MyList<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);

            mylist.RemoveAt(3);

            int a = mylist[1];
        }

        
    }
}
