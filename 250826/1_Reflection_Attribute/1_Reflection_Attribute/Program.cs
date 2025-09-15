#define TEST
//↑선언

using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _1_Reflection_Attribute
{
    //Reflection = 클래스용 x-rey 촬영
    // 런타임중 클래스에 대한 정보
    //자주사용하지 않음 - 그래도 개념은 숙지 할것

    //Attribute (관례적으로 이름에 'Attribute'를 붙임 ImportantAttribute)

    //[Conditional("TEST")] //#define TEST가 선언 되어있다면 실행

    //[Obsolete] // 빌드는 되지만 사용하지 말라고 뜸
    //[Obsolete("더이상 사용하지 않는다는 별도의 설명을 따로 적어줄수 있음")]
    //[Obsolete("개별 설명과 같이 실행도 못하게 오류도 나오게함", true)]

    //[DllImport("User32.dll")]// 닷넷 환경 밖에서 개발된 코드를 가져오고 싶을때

    class ImportantAttribute : Attribute
    {
        public string message;

        public ImportantAttribute(string message)
        {
            this.message = message;
        }

    }

    [ImportantAttribute("이건 중요한 메세지, 런타임에서 확인")]
    class Monster
    {
        // 닷넷 환경 밖에서 개발된 코드를 가져오고 싶을때
        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string Text, string Title, int i);

        [Obsolete]
        public static void Test3()
        {
            Console.WriteLine("Test1 호출!");
        }

        [Obsolete("더이상 사용안함 실행 ㄴㄴ")]
        public static void Test3_2()
        {
            Console.WriteLine("Test3_2 호출!");
        }

        [Obsolete("더이상 사용안함 실행도 못하게 오류도 나오게함", true)]
        public static void Test3_3()
        {
            Console.WriteLine("Test3_3 호출!");
        }

        public int hp;
        protected int atk;
        private float speed;

        public static void Test()
        {
            Test2();
        }

        // 해당 문서(이문서) 최상단에 #define 으로 정의한내용이 없으면 실행안되게
        // 즉, if문처럼 맨 위에 #define TEST 이거 없으면 이 함수 호출해도 실행 안됨
        [Conditional("TEST")]
        static void Test2()
        {
            Console.WriteLine("테스트 호출");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Monster.MessageBox(0, "1", "234", 0);

            Monster.Test();

            Monster.Test3();
            Monster.Test3_2();
            //Monster.Test3_3();

            Monster monster = new Monster();

            //Reflection을 이용한 기능
            Type type = monster.GetType(); // 형식 즉 클래스에 대한 정보를 반환

            Console.WriteLine($"\n GetType() {type.Name} \n ");

            var fields = type.GetFields(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Static |
                BindingFlags.Instance
                );
            // 필드(맴버변수) 가져옴

            Console.WriteLine($"\n type.GetFields() {fields} \n ");
            Console.WriteLine($"\n type.GetFields() {fields} \n ");

            foreach (var field in fields)
            {
                string access = "Protected";
                if (field.IsPublic == true)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                Console.WriteLine($"{access}, 타입 {field.FieldType.Name}, 이름 : {field.Name} \n"); //float = single
            }

            var attributes = type.GetCustomAttributes();
            foreach (var attribute in attributes)
            {
                //ImportantAttribute important = (ImportantAttribute)attribute;
                ImportantAttribute important = attribute as ImportantAttribute; //타입형태가 맞다면 변환, 아니라면 null
                if (important != null)
                {
                    Console.WriteLine(important.message);
                }
            }
        }
    }
}