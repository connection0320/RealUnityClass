using System;

namespace UnityLesson_CSharp_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for 문
            // 기본형태
            /*for (인덱스용 변수 선언 및 초기화; for문을 실행할 조건; 루프가 한번 실행 될 때마다 마지막에 실행할 문장)
            {
                반복수행시 실행할 내용
            }*/
            
            string[] arr_PersonName = new string[12];
            arr_PersonName[0] = "김태우";
            arr_PersonName[1] = "최재은";
            arr_PersonName[2] = "최수민";
            arr_PersonName[3] = "김태우";
            arr_PersonName[4] = "최재은";
            arr_PersonName[5] = "최수민";
            arr_PersonName[6] = "김태우";
            arr_PersonName[7] = "최재은";
            arr_PersonName[8] = "최수민";
            arr_PersonName[9] = "김태우";
            arr_PersonName[10] = "최재은";
            arr_PersonName[11] = "최수민";

            int length = arr_PersonName.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr_PersonName[i]);
            }

            // 김태만 출력을 하고 싶다. 김태우의 인덱스 규칙은 : 3n
            // 모든 배열 요소를 검색하는 예시
            Console.WriteLine("김태우만 출력 번째 방식");
            for (int i = 0; i < length; i++)
            {
                if(arr_PersonName[i] == "김태우")
                {
                    Console.WriteLine(arr_PersonName[i]);
                }
            }
            Console.WriteLine("김태우만 출력 2번째 방식");
            // 인덱스 규칙을 사용한 예시
            for (int i = 0; i < length; i+=3)
            {
                Console.WriteLine(arr_PersonName[i]);
            }
        }
    }
}
