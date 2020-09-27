using System;
using Console = Colorful.Console;

namespace Lib
{
    public class Class1
    {
        public static int highscore = 0;

        public static void WritingLevels(string[,] levels)
        {
            int b = 0;
            for(int i = 0; i < 10; i++)
            {
                CenterText("│" +" "+ levels[i, b] + levels[i, b + 1] + levels[i, b + 2] + levels[i, b + 3] + levels[i, b + 4] + levels[i, b + 5] + levels[i, b + 6] + levels[i, b  + 7] + levels[i, b + 8] + levels[i, b + 9] + levels[i, b + 10] +" "+ "│");
            }
        }

        public static void CenterText(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }

        public static void Replacing(string[,] source, int sourceRow, string[,] target, int targetRow)
        {
            for(int i = 0; i < 11; i++)
            {
                target[targetRow, i] = source[sourceRow, i];
            }
        }

        public static void YouCarRepositioning(int[,] coords, string[,] level0)
        {
            level0[coords[0, 0], coords[0, 1]] = "o";
            level0[coords[0, 2], coords[0, 3]] = "#";
            level0[coords[0, 4], coords[0, 5]] = "o";
            level0[coords[1, 0], coords[1, 1]] = "[";
            level0[coords[1, 2], coords[1, 3]] = "@";
            level0[coords[1, 4], coords[1, 5]] = "]";
            level0[coords[2, 0], coords[2, 1]] = "o";
            level0[coords[2, 2], coords[2, 3]] = "#";
            level0[coords[2, 4], coords[2, 5]] = "o";
        }

        public static void IfGameIsOver(int[,] coords, string[,] level, bool AreYouMoving, bool AreYouMovingLeft)
        {
            if(AreYouMoving == true)
            {
                if(AreYouMovingLeft == true)
                {
                    if(level[coords[0, 0] , coords[0, 1] - 1] != " ")
                    {
                        IfYouHaveSomethingOnSide(level, coords, 0, 0, "left");
                    }
                    if(level[coords[1, 0] , coords[1, 1] - 1] != " ")
                    {
                        IfYouHaveSomethingOnSide(level, coords, 1, 0, "left");
                    }
                    if(level[coords[2, 0] , coords[2, 1] - 1] != " ")
                    {
                        IfYouHaveSomethingOnSide(level, coords, 2, 0, "left");
                    }
                }
                if(AreYouMovingLeft == false)
                {
                    if(level[coords[0, 4] , coords[0, 5] + 1] != " ")
                    {
                        IfYouHaveSomethingOnSide(level, coords, 0, 4, "right");
                    }
                    if(level[coords[1, 4] , coords[1, 5] + 1] != " ")
                    {
                        IfYouHaveSomethingOnSide(level, coords, 1, 4, "right");
                    }
                    if(level[coords[2, 4] , coords[2, 5] + 1] != " ")
                    {
                        IfYouHaveSomethingOnSide(level, coords, 2, 4, "right");                   
                    }
                }
            }
            if(level[coords[0, 0] - 1, coords[0, 1]] != " ")
            {
                IfYouHaveSomethingInFront(level, coords, 0, 0);
            }
            if(level[coords[0, 2] - 1, coords[0, 3]] != " ")
            {
                IfYouHaveSomethingInFront(level, coords, 0, 2);        
            }
            if(level[coords[0, 4] - 1, coords[0, 5]] != " ")
            {
                IfYouHaveSomethingInFront(level, coords, 0, 4);   
            }
            return;
        }

        public static void IfYouHaveSomethingInFront(string[,] level, int[,] coords, int coordRow, int coordColumn)
        {
            if(level[coords[coordRow, coordColumn] - 1, coords[coordRow, coordColumn + 1]] == "$")
            {
                highscore++;
            }
            else if(level[coords[coordRow, coordColumn] - 1, coords[coordRow, coordColumn + 1]] == "|")
            {
            }
            else
            {
                GameOver();
            }
            return;
        }

        public static void IfYouHaveSomethingOnSide(string[,] level, int[,] coords, int coordRow, int coordColumn, string selection)
        {
            switch (selection)
            {
                case "left":
                    if(level[coords[coordRow, coordColumn], coords[coordRow, coordColumn + 1] - 1] == "$")
                    {
                        highscore++;
                    }
                    else if(level[coords[coordRow, coordColumn], coords[coordRow, coordColumn + 1] - 1] == "|")
                    {
                    }
                    else
                    {
                        GameOver();
                    }
                break;
                case "right":
                    if(level[coords[coordRow, coordColumn], coords[coordRow, coordColumn + 1] + 1] == "$")
                    {
                        highscore++;
                    }
                    else if(level[coords[coordRow, coordColumn], coords[coordRow, coordColumn + 1] + 1] == "|")
                    {
                    }
                    else
                    {
                        GameOver();
                    }
                break;
            }
            return;
        }

        public static void ReplaceFullArrays(string[,] newlevel, string[,] level0back)
        {
            for(int i = 0; i < 20; i++)
            {
                Replacing(newlevel, i, level0back, i);
            }
            return;
        }

        public static void GameOver()
        {
            Class1.CenterText("Game Over!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static bool IfLevelIsDuplicated(string[,] level0back, string endOftheLevel)
        {
            if(level0back[0, 5] == endOftheLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
