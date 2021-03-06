using System;

namespace UnityLesson_CSharp_InstantiationOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // 점(.) 연산자 - 멤버에 접근하는 연산자
            person1.age = 40;
            person1.height = 180.5f;
            person1.isResting = true;
            person1.genderChar = '여';
            person1.name = "김아무개";
             // 객체의 멤버 함수 호출
            person1.SayAll_Info();

            Person person2 = new Person();
            person2.age = 26;
            person2.height = 170.3f;
            person2.isResting = false;
            person2.genderChar = '남';
            person2.name = "김태우";
            person2.SayAll_Info();
        }
    }
    public class Person
    {
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;

        public void SayAll_Info()
        {
            SayAge();
            SayHeight();
            SayIsResting();
            SayGenderChar();
            SayName();
        }
        public void SayAge()
        {
            Console.WriteLine($"{name} 의 나이 : {age}");
        }
        public void SayHeight()
        {
            Console.WriteLine($"{name} 의 키 : {height}");
        }
        public void SayIsResting()
        {
            Console.WriteLine($"{name} 의 쉬는 여부 : {isResting}");
        }
        public void SayGenderChar()
        {
            Console.WriteLine($"{name} 의 성별 : {genderChar}");
        }
        public void SayName()
        {
            Console.WriteLine(name);

        }

    }
}
