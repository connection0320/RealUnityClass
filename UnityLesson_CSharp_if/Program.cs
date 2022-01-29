using System;

namespace UnityLesson_CSharp_if
{
    internal class Program
    {
        //static 함수에서는 static 변수/static 함수만 사용 가능하다.
        static bool condition1;
        static bool condition2; 
        static bool condition3;

        static void Main(string[] args)
        {

            condition1 = false;
            condition2 = true;
            condition3 = false;

            if (condition1)
            {
                Console.WriteLine(condition1 + " 조건 1은 참이다"); //조건 1이 참일때 실행할 내용
            }
            else if (condition2)
            {
                Console.WriteLine(condition2 + " 조건 2은 참이다"); //조건 2이 참일때 실행할 내용
            }
            else if (condition3)
            {
                Console.WriteLine(condition3 + " 조건 3은 참이다"); //조건 3이 참일때 실행할 내용
            }
            else
            {
                Console.WriteLine("전부 거짓이다."); // 위의 조건이 모두 참이 아닐대 실행할 내용
            }
            
        }
    }
}
