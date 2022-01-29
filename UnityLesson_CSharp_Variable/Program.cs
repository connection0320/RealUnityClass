using System;

namespace UnityLesson_CSharp_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        // Person 클래스의 멤버 변수(필드) 아래내용들이 모두 멤버 변수이며 필드라고도 표현을 한다
        // = 은 대입연산자 , 우변의 값을 좌변에 대입
        int age = 26;
        // int : 4 byte 의 정수 
        float height = 170.3f;
        // float : 4 byte 의 실수
        bool isResting = true;
        // bool : 1 byte 논리
        char genderChar = 'a';
        // char : 2 byte 문자
        string name = 'Taewoo';
        // string : 문자갯수 * 2 byte 문자열
        // double : 8 byte 의 실수
        // long : 8 byte 의 정수
    }

    // bit(비트)      = 한자리 이진수 ( 0 , 1 ) ( 정보처리의 최소 단위 )
    // byte(바이트)   = 8 bit ( CPU 의 데이터 처리 최소 단위 )
    // 4 byte = 32 bit
    // 4 byte 가 표현할 수 있는 수의 범위 2^(bit 수)
}
