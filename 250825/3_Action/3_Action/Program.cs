namespace _3_Action
{
    //Action = void 형식의 델리게이트를 미리 언어차원에서 선언해둔것
    // 매개변수를 최대 16개까지 받을수 있다
    //외부에서도 이 액션에 대해서 Invoke를 통해 외부에서도 호출해 줄수 있다

    //action도 외부에서 접근이 가능함 이를 방지하고 싶으면 event 사용

    class InputManager
    {
        public Action<int, string> action;

        public void Update()
        {
            action.Invoke(10, "a");
        }
    }

    internal class Program
    {
        delegate void Action();
        // ↓
        Action action;
        // Action = 반환값이 존재하지않은 델리게이트에 대해서 C#언어 차원에서 미리 만들어둔 키워드
        //      Action은 매개변수를 최대 16개까지 받을수 있음

        delegate void Action2(int a);           //매개변수 (T t)
        // ↓
        Action<int> action2;                    //<T>

        delegate void Action3(int a, string s); //매개변수 (T t, T t)
        // ↓
        Action<int, string> action3;            //<T, T>

        static void Test(int i, string s)
        {

        }

        static void Main(string[] args)
        {
            InputManager input = new InputManager();
            input.action += Test;

            input.action.Invoke(10, "b");
        }
    }
}
