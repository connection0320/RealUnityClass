using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Human : Creature, ITwoLeggedWalker
    {
        public float height;

        public override void Breath()
        {
            base.Breath();
            height += 0.00004f;
            weight += 0.00002f;
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }
}
    