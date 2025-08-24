using System.ComponentModel;

namespace _1_자료구조
{
    // ↓ 추천
    // 인벤토리 - 리스트
    // 아이템 정보 - 딕셔너리
    // 맵의 오브젝트 ID - 배열

    class Player
    {

    }
    class Monster
    {
        public int hp;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //배열 = 같은 종류의 데이터를 한줄로 묶어놓은 연속된 저장공간
            // 일반배열 = 고정된 배열 - 크기를 수정하지 못함 
            // 배열은 참조형식

            // 값형식 배열 -> int, float, bool -> 값형식, 값 그자체가 저장됨
            // 참조형식 배열 -> class, array -> 힙영역에 생성 그 주소가 스택에 저장됨

            //foreach는 읽기전용 반복문
            //엘리먼트는  읽기 전용이라 변경 불가
            //값 형식은 엘리먼트 자체에 값이 들어가있어 변경불가
            //참조형식은 엘리먼트 주소이기에 그걸 타고 들어가서 내부 필드에 접근하여 내부 필드 값 변경이 가능
            // 단순 조회, 출력, 합계, 검색 최적
            // 그래서 데이터를 읽기만 할때는 foreach가 유용
            // 배열의 요소를 수정할 때는 for 문을 사용

            int[] a = new int[6];
            //a[][][][][][]
            //  0 1 2 3 4 5
            a[0] = 10;
            for (int i = 0; i< 6; i++)
            {
                a[i/*인덱스*/] = i;

                //a[0][1][2][3][4][5]
            }
            a = new int[7];
            //아예 새로운 배열을 만들고 변수의 참조를 변경 기존 배열은 메모리 어딘가에 남아있다가 나중에 삭제됨

            int[] b = { 1, 2, 3, 4, 5, 6 };

            Monster[] monsters = new Monster[6];

            for(int j = 0; j<monsters.Length; j++)//~.Length : 배열 길이
            {
                a[j] = j;
            }

            //foreach는 읽기전용 foreach가 받아온 엘리먼는 수정 불가
            foreach (int item in a) //a 배열에 있는 값들을 하나씩 item에 넣어주고 a배열 값 개수만큼 반복
            {
                Console.WriteLine(item);

                //item = item + 1; foreach는 읽기전용 foreach 변수는 수정 불가
            }


            foreach (Monster monster in monsters) //a 배열에 있는 값들을 하나씩 item에 넣어주고 a배열 값 개수만큼 반복
            {
                //monster = new Monster(); 엘리먼트 자체는 수정불가
                monster.hp = 10; // 엘리먼트 내부 필드는 수정가능
                //item = item + 1; foreach는 읽기전용 foreach 변수는 수정 불가
            }

        }
    }
}
