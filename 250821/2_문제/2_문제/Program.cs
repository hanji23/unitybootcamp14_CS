namespace _2_문제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //========================
            //문제 1) 합계와 평균 구하기
            //========================
            //- 정수 배열 a = { 5, 8, 12, -3, 7 }가 있다.
            //- 배열의 합계와 평균을 출력하라.

            //[출력결과]
            //Sum = 29
            //Avg = 5.8

            int[] a1 = { 5, 8, 12, -3, 7 };

            int aplus = 0;

            foreach (int i in a1)
            {
                aplus += i;
            }
            Console.WriteLine($"Sum = {aplus}");
            Console.WriteLine($"Avg = {aplus / a1.Length}");

            //========================
            //문제 2) 최대값과 최소값 찾기
            //========================
            //- 정수 배열 a = { 15, 3, 9, 27, -5, 8 }이 있다.
            //- 배열에서 가장 큰 값과 가장 작은 값을 찾아라.

            //[출력결과]
            //Max = 27
            //Min = -5

            int [] a2 = { 15, 3, 9, 27, -5, 8 };
            int Max = 0;
            int Min = 0;

            for (int i = 0; i < a2.Length; i++)
            {
                if(i != 0)
                {
                    if (a2[i] > Max)
                    {
                        Max = a2[i];

                    }
                    else if(a2[i] < Min)
                    {
                        Min = a2[i];
                    }
                }
                else
                {
                    Max = a2[i];
                    Min = a2[i];
                }
            }
            Console.WriteLine($"Max = {Max}");
            Console.WriteLine($"Min = {Min}");

            //=====================================
            //문제 3) 빈도수 세기(작은 히스토그램)
            //=====================================
            //- 0, 1, 2만 들어있는 정수 배열 nums = { 1,0,2,2,1,0,0,2,1,1 }의
            //  각 숫자(0,1,2)가 몇 번 나오는지 출력하라.

            //[출력결과]
            //0:3 1:4 2:3

            int[] nums = { 1, 0, 2, 2, 1, 0, 0, 2, 1, 1 };

            //int zero = 0;
            //int one = 0;
            //int two = 0;

            //foreach (int i in nums)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            zero++;
            //            break;
            //        case 1:
            //            one++;
            //            break;
            //        case 2:
            //            two++;
            //            break;
            //    }

            //}
            //Console.WriteLine($"0:{zero} 1:{one} 2:{two}");

            int[] count = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }
            Console.WriteLine($"0:{count[0]} 1:{count[1]} 2:{count[2]}");

            //=====================================
            //문제 4) 배열 뒤집기(제자리 반전)
            //=====================================
            //- 정수 배열 a = { 1, 2, 3, 4, 5, 6 }을
            //  추가 배열 없이 제자리에서 뒤집어 출력하라.

            //[출력결과]
            //6 5 4 3 2 1

            int[] a4 = { 1, 2, 3, 4, 5, 6 };

            //for (int i = a4.Length - 1; i >= 0; i--) 
            //{
            //    Console.Write($"{a4[i]} ");
            //}
            //int a = 1;
            //a4 = new int[] { a4[a4.Length - a++], a4[a4.Length - a++], a4[a4.Length - a++], a4[a4.Length - a++], a4[a4.Length - a++], a4[a4.Length - a++] };
            //foreach (int i in a4)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("");

            int left = 0;
            int right = a4.Length - 1;

            while (left < right)
            {
                int tmp = a4[left];
                a4[left] = a4[right];
                a4[right] = tmp;

                left++;
                right--;
            }
            foreach (int i in a4)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("");

            //========================
            //문제 5) 배열 오름차순 정렬
            //========================
            //- 정수 배열 a = { 42, 17, 8, 99, 23 }가 있다.
            //- 배열을 오름차순으로 정렬하여 출력하라.
            //- 단, Array.Sort()는 사용하지 말고 직접 알고리즘을 구현

            //[출력결과]
            //8 17 23 42 99

            int[] a5 = { 42, 17, 8, 99, 23 };

            int[] sort = new int[a5.Length];

            //for (int j = 0; j < sort.Length; j++)
            //{

            //    for (int i = 0; i < a5.Length; i++)
            //    {
            //        if (i != 0)
            //        {
            //            if (a5[i] > Max)
            //            {
            //                Max = a5[i];
            //                sort[sort.Length - 1] = Max;

            //            }
            //            if (a5[i] < Min)
            //            {
            //                if ((j - 1) >= 0)
            //                    if (a5[i] <= sort[j - 1])
            //                    {
            //                        continue;
            //                    }

            //                Min = a5[i];
            //            }
            //        }
            //        else
            //        {
            //            Min = a5[i];
            //            Max = a5[i];
            //        }
            //    }
            //    if (sort[j] != sort[sort.Length - 1])
            //    {
            //        sort[j] = Min;
            //    }

            //    Console.Write($"{sort[j]} "); 
            //}

            for (int i =0; i<a5.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < a5.Length; j++)
                {
                    if (a5[j] < a5[minIndex])
                    {
                        minIndex = j;   
                    }
                }

                int temp = a5[i];
                a5[i] = a5[minIndex];
                a5[minIndex] = temp;
            }

            foreach (int i in a5)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
