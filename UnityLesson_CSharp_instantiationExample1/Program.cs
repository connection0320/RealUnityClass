using System;

namespace UnityLesson_CSharp_instantiationExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.weight = 200f;
            orc1.height = 240.2f;
            orc1.genderChar = '남';
            orc1.age = 140;
            orc1.isResting = false;

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.weight = 140.4f;
            orc2.height = 120f;
            orc2.age = 60;
            orc2.genderChar = '여';
            orc2.isResting = true;

            if (orc1.isResting)
            {
                orc1.Smash();
                orc1.Jump(); 
            }
            else
            {
                Console.WriteLine($"{orc1.name}(이)가 바쁘다");
            }
            if (orc2.isResting)
            {
                orc2.Smash();
                orc2.Jump();
            }
            else
            {
                Console.WriteLine($"{orc2.name}(이)가 바쁘다");
            }
        }
   
    }
}
public class Orc
{
    public int age;
    public float height;
    public bool isResting;
    public char genderChar;
    public string name;
    public float weight;

    public void Smash()
    {
        Console.WriteLine($"{name} (이)가 휘둘렀다.");
            
    }
    public void Jump()
    {
        Console.WriteLine($"{name} (이)가 점프했다.");
    }

}

