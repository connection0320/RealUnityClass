using System;
// structure (구조체)
// 멤버 변수를 가지는 타입 
namespace UnityLesson_CSharp_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.stats._STR = 10;
            warrior.stats._DEX = 10;
            warrior.stats._CON = 10;
            warrior.stats._WIS = 10;
            warrior.stats._INT = 10;
            warrior.stats._REG = 10;
           
            Wizzard wizzard = new Wizzard();
            wizzard.stats._STR = 10;
            wizzard.stats._DEX = 10;
            wizzard.stats._CON = 10;
            wizzard.stats._WIS = 10;
            wizzard.stats._INT = 10;
            wizzard.stats._REG = 10;

            Warrior[] arr_Warrior = new Warrior[10];
            int length = arr_Warrior.Length;

            // 멤버 변수 stats 의 멤버 변수를 for 문에서 초기화 하는 방법
            for (int i = 0; i < length; i++)
            {
                arr_Warrior[i] = new Warrior();
                arr_Warrior[i].stats._STR = 10;
                arr_Warrior[i].stats._DEX = 10;
                arr_Warrior[i].stats._CON = 10;
                arr_Warrior[i].stats._WIS = 10;
                arr_Warrior[i].stats._INT = 10;
                arr_Warrior[i].stats._REG = 10;
            }

            // 지역변수 stats 을 초기화한 후 for 문에서 멤버변수 stats을 초기화 하는 방법
            Stats tmpStats = new Stats();
            tmpStats.stats._STR = 10;
            tmpStats.stats._DEX = 20;
            tmpStats.stats._CON = 30;
            tmpStats.stats._WIS = 40;
            tmpStats.stats._INT = 50;
            tmpStats.stats._REG = 60;
            for (int i = 0; i < length; i++)
            {
                arr_Warrior[i].stats = tmpStats;
            }

            // 멤버변수 stats 을 초기화하는 멤버함수 SetStats을 호출하는 방법
            for (int i = 0; i < length; i++)
            {
                arr_Warrior[i].SetStats(10, 20, 30, 40, 50, 60);
            }




        }
    }
}
