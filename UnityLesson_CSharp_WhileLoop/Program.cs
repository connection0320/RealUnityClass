using System;

namespace UnityLesson_CSharp_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//while의 구조
            while (조건)
            {
                조건이 참일때 반복할 내용
            }
            // 무한루프 ( while 의 조건이 항상 참일경우)
            // 절대 코드에 있어서 안되는 존재
            while (true)
            {
                
            }*/
            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "김태우";
            arr_PersonName[1] = "최재은";
            arr_PersonName[2] = "최수민";

            int length = arr_PersonName.Length;
            int count = 0;

            while (count < length)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }


            /*
            while (true)
            {
                if(count < length)
                {
                    Console.WriteLine(arr_PersonName[count]);
                }
                else
                {
                    break;
                }
                count++;
             
            } */ // 사용하면 안되는 예시 (무한루프)
            
            
        } 
    }
}
