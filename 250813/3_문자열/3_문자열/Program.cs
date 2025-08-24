using System.Xml.Linq;

namespace _3_문자열
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CheckId("Hong GilDong", "hong gildong"));
            Console.WriteLine(CheckId("Kim", "lee"));

            Console.WriteLine(CheckId(Console.ReadLine(), Console.ReadLine()));

            Console.WriteLine("Hello, World!");

            string name = "Hong GilDong";
            Console.WriteLine(name);

            // 1. 조회 / 찾기
            bool found = name.Contains("s");// 존재하는지 확인
            Console.WriteLine(name);
            int a = name.IndexOf("g"); // 0부터 시작해서 몇번째에 있는지 확인 존재하지 않으면 -1를 반환
            Console.WriteLine(name);

            // 2. 문자열 변형
            name = name + " Power";
            Console.WriteLine(name);
            name = name.ToLower(); // 전부 소문자로 바꿔버림
            Console.WriteLine(name);
            name = name.ToUpper(); // 전부 대문자로 바꿔버림
            Console.WriteLine(name);
            name = name.Replace("G", "L"); // "G"를 "L"로 바꿔 버림
            Console.WriteLine(name);

            // 3. 분리
            String[] names = name.Split(new char[] {' '}); //  ' '을 기준으로 문자열을 잘라 문자열에 저장
            Console.WriteLine(names[0] + " / " + names[1]);
            name = name.Substring(3); //앞에 3글자를 자르기
            Console.WriteLine(name);

            // 추가
            name = name + " (clone) (clone)";
            Console.WriteLine(name);
            name = name.Remove(name.Length - 8, 8);  // 시작점을 기준으로 n글자 지우기
            Console.WriteLine(name);

            name = name.Remove(name.Length - 14); // 시작점 뒤에 글자 전부 제거
            Console.WriteLine(name);
        }

        static string CheckId(string oldId, string newId)
        {
            oldId = oldId.Replace(" ", "-");
            newId = newId.Replace(" ", "-");

            oldId = oldId.ToUpper();
            newId = newId.ToUpper();

            if (oldId == newId)
            {
                return "중복";
            }
            else
            {
                return "사용 가능";
            }
            
        }
    }
}
