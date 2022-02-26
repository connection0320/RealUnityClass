using System;
using System.Collections.Generic;
namespace DiceGame
{
    internal class Program
    {
        static private int totalTile = 20; // 총 칸의 갯수
        static private int totalDiceNumber = 20; // 총 주사위 갯수
        static private Random random;
        static void Main(string[] args)
        {
            int currentTileIndex = 0; // 현재 칸의 인덱스
            int currentStarPoint = 0;
            int previousTileIndex = 0;
            
            TileMap map = new TileMap();
            map.MapSetup(totalTile); // 맵 생성

            int currentDiceNum = totalDiceNumber;
            //주사위 게임 시작
            while (currentDiceNum > 0)
            { 
                int diceValue = RollDice(); // 주사위 굴리기
                currentDiceNum--; // 주사위 굴렸으니까 남은 주사위갯수 차감
                currentTileIndex += diceValue; // 플레이어 주사위 눈금만큼 전진

                //현재칸이 최대칸을 넘어가버렸을때
                if(currentTileIndex > totalTile)
                {
                    currentTileIndex -= (totalTile);
                }
                Console.WriteLine($"현재 플레이어 위치 {currentTileIndex}");+
                if (currentTileIndex / 5 > previousTileIndex / 5)
                {
                    int passedStarTileIndex = currentTileIndex / 5 * 5;
                    Tileinfo_Star tileinfo_Star = map.mapinfo.GetValueOrDefault(passedStarTileIndex) as Tileinfo_Star;
                    if (tileinfo_Star != null)
                    {
                        currentStarPoint += tileinfo_Star.starValue;
                    }
                }
                // 현재 칸의 정보를 받아봄
                Tileinfo info = map.mapinfo.GetValueOrDefault(currentTileIndex);
               if(info == null)
                {
                    //Failed to get tileinfo. Check parameters.
                    return;
                }
                info.TileEvent(); //칸의 이벤트 호출
                
            

                previousTileIndex = currentTileIndex;
                Console.WriteLine($"현재 샛별 점수 : {currentStarPoint}");
                Console.WriteLine($"남은 주사위 갯수 : {currentDiceNum}");
            }
            Console.WriteLine($"Game Finished ! You got total {currentStarPoint} stars");
        }






        static int RollDice()
        {
            string userinput = "Default";
            while (userinput != "")
            {
                Console.WriteLine("Roll A Dice ! Press Enter");
                userinput = Console.ReadLine();
            }
            random = new Random();
            int diceValue = random.Next(1, 7);
            Console.WriteLine($"DiceValue{diceValue}");
            DisplayDice(diceValue);
            return diceValue;
        }

        static void DisplayDice(int diceValue)
        {
            switch (diceValue)
            {
                case 1:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("└───────────┘");
                    break;
                case 2:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 3:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 4:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 5:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 6:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                default:
                    break;
            }
        }

       
    }
}
