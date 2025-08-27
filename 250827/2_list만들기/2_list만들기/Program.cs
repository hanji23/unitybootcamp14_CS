using System;

namespace _2_list만들기
{
    class MyList<T>
    {
        T[] _data = new T[1];
        public int count { get; set; }
        public int capacity { get { return _data.Length; } }

        //인덱서
        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return _data[index];
            }
            set
            {
                if (index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                _data[index] = value;
            }

        }

        public void Add(T item)
        {
            if(count >= capacity /*_data.Length*/)
            {
                T[] newArr = new T[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newArr[i] = _data[i];
                }

                _data = newArr;
            }

            _data[count] = item;
            
            count++;
        }

        public void RemovewAt(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            count--;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            myList.RemovewAt(2);

            int a = myList[2];
        }
    }
}
