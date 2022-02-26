using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    //게임 시작시 맵을 생성하고 (칸들 생성)
    // 맵에 대한 정보를 가지고 있을 클래스
    internal class TileMap
    {
        public Dictionary<int, Tileinfo> mapinfo = new Dictionary<int, Tileinfo>();
        public void MapSetup(int maxTileNum)
        {
            for (int i = 1; i <= maxTileNum; i++)
            {
                // 5배수 , 즉 샛별칸을 생성함 (5로 나누었을때 나머지가 0인것)
                if (i%5 == 0)
                {
                    Tileinfo_Star tileinfo_Star = new Tileinfo_Star();
                    tileinfo_Star.index = i;
                    tileinfo_Star.name = "Star";
                    tileinfo_Star.discription = "This is star tile";
                    mapinfo.Add(i, tileinfo_Star);
                }
                //일반칸 생성
                else
                {
                    Tileinfo tileinfo = new Tileinfo();
                    tileinfo.index = i;
                    tileinfo.name = "Dummy";
                    tileinfo.discription = "this is dummy tile";
                    mapinfo.Add(i, tileinfo);
                }
            }
            Console.WriteLine($"Maps setup complete. Max tile num {maxTileNum}"); 

        }
    }
}
