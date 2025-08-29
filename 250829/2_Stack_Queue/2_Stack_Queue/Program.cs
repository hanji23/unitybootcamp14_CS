namespace _2_Stack_Queue
{
    //  선형 자료 구조 - 배열, 리스트, 연결리스트, 스택, 큐
    //비선형 자료 구조 - 그래프, 트리, 딕셔너리, 해시셋

    //스택 - LIFO(Last in  first out) 후 입 선 출  나중에 들어온게 먼저 나감
    // 원칙 : LIFO
    // 삽입(push) : 맨뒤(Top)에만 가능
    // 삭제(pop) : 맨뒤(Top)에서만 가능
    //즉, 마지막에 넣은 것만 꺼낼수 있음

    //  큐 - FIFO(First in first out) 선 입 선 출  먼저 들어온게 먼저 나감
    // 원칙 : FIFO
    // 삽입(enqueue) : 맨뒤(Rear)에만 가능
    // 삭제(dequeue) : 맨앞(Front)에서만 가능
    //즉, 먼저 넣은 것만 꺼낼수 있음

    //스택, 큐 : 고정되어있는 사용방식을 자료구조로 만들어 둠  

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();   
            stack.Push(1); //맨앞에 데이터 넣기
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            // 0  1  2  3  4 
            //[5][4][3][2][1]

            int number = stack.Pop(); //맨뒤에서 아예 뽑아옴
            // 0  1  2  3  
            //[4][3][2][1]

            int number2 = stack.Peek(); //맨뒤에서 하나를 엿보기
            // 0  1  2  3  
            //[4][3][2][1]

            int result;
            bool test = stack.TryPop(out result);
            // 0  1  2 
            //[3][2][1]

            Queue<int> queue = new Queue<int>();    
            queue.Enqueue(1); //맨뒤에 데이터 넣기
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            // 0  1  2  3  4 
            //[1][2][3][4][5]

            int number3 = queue.Dequeue(); //맨앞에서 아예 뽑아옴
            // 0  1  2  3 
            //[2][3][4][5]

            int number4 = queue.Peek();//맨앞에서 하나를 엿보기
            // 0  1  2  3 
            //[2][3][4][5]
        }
    }
}
