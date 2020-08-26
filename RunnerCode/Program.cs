using System;
using System.Threading;
using Console = Colorful.Console;
using Lib;

namespace RunnerCode
{
    
    class Program
    {
        //todo find friends
        /*todo MVP(Minimal Viable Product)

            Game theme:
            {
                this is a car racing game.
                you need to get the money($)
            }

            Game:
            {
                prespective - from top
                how the game works - every half a second a layer replaces the layer under it
                looks like - you go up
            }

            Idea how to make the game:
            {
                make 2d arrays,
                choose a 2d array randomly after the old array is played,
                make 3 tyoes of levels - 20 layers            
            }

            Challanges:
            {
                use 2d arrays
                make the objects more than one character
            }

            Thing to use:
            {
                2d arrays
            }

            Things to learn:
            {
                how to use 2d arrays,
            }

            Controls:
            {
                left arrow,
                right arrow
            }

            Objects:
            {
                cars,
                money,
            }

            Sources:
            {
                ?? http://patorjk.com/software/taag/#p=display&f=Big&t=Runner - ascii art
                ?? http://colorfulconsole.com/ - colors and things
            }
        */
        /*todo to add  

            Things to add:
            {
                add more levels
            }
        */

        public static ConsoleKeyInfo cki;

        public static string[,] level3 = {
            {" ", " ", " ", "|", " ", "end", " ", "|", " ", " ", " "},
            {" ", "$", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", "o", "&", "o", "|", "o", "&", "o"},
            {" ", " ", " ", "|", "[", "V", " ", "|", "[", "P", "]"},
            {" ", " ", " ", "|", "o", "&", "o", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", "$", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", "$", " ", "|", "[", "P", "]"},
            {" ", " ", " ", "|", " ", "$", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
        };
        public static string[,] level2 = {
            {" ", " ", " ", "|", " ", "end", " ", "|", " ", " ", " "},
            {" ", "$", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", "o", "&", "o", "|", "o", "&", "o"},
            {" ", " ", " ", "|", "[", "V", " ", "|", "[", "P", "]"},
            {" ", " ", " ", "|", "o", "&", "o", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", "$", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", " ", " ", "|", "[", "P", "]"},
            {" ", " ", " ", "|", " ", "$", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
        };
        public static string[,] level1 = {
            {" ", " ", " ", "|", " ", "end", " ", "|", " ", " ", " "},
            {" ", "$", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {"o", "&", "o", "|", " ", " ", " ", "|", "o", "&", "o"},
            {"[", "V", "]", "|", " ", " ", " ", "|", "[", "P", "]"},
            {"o", "&", "o", "|", " ", "$", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {"o", "&", "o", "|", " ", " ", " ", "|", "o", "&", "o"},
            {"[", "V", "]", "|", " ", " ", " ", "|", "[", "P", "]"},
            {"o", "&", "o", "|", " ", " ", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
        };

        public static string[,] level0back = {
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
        };
        public static string[,] level0 = {
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {"R", "U", "N", "|", " ", " ", " ", "|", "N", "E", "R"},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", "$", " ", "|", " ", " ", " ", "|", " ", "$", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", "o", "#", "o", "|", " ", " ", " "},
            {" ", " ", " ", "|", "[", "@", "]", "|", " ", " ", " "},
            {" ", " ", " ", "|", "o", "#", "o", "|", " ", " ", " "},
        };
        
        //every pair of two ints represent a car's char position, first is the row then the column
        public static int[,] YouCarCoords = {
            {7, 4 /*o*/, 7, 5 /*#*/, 7, 6 /*o*/},
            {8, 4 /*[*/, 8, 5 /*C*/, 8, 6 /*]*/},
            {9, 4 /*o*/, 9, 5 /*#*/, 9, 6 /*o*/}
        };
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteAscii("         Runner");
            Lib.Class1.CenterText("┌─────────────────┐");
            Lib.Class1.CenterText("│ 1 - Start Game  │");
            Lib.Class1.CenterText("│ 2 - How To Play │");
            Lib.Class1.CenterText("│                 │");
            Lib.Class1.CenterText("└─────────────────┘");
            var key = Console.ReadKey();
            
            if(key.KeyChar == '1')
            {
                StartGame();
            }
            else if(key.KeyChar == '2')
            {
                HowToPlay();
            }
            else
            {
                Menu();
            }
        }

        public static void HowToPlay()
        {
            Console.Clear();
            Console.WriteAscii("         Runner");
            Console.WriteLine("");
            Lib.Class1.CenterText("┌───────────────────┐");      
            Lib.Class1.CenterText("│  The car with C   │");
            Lib.Class1.CenterText("│ is you            │");
            Lib.Class1.CenterText("│                   │"); 
            Lib.Class1.CenterText("│  Use the arrow    │");
            Lib.Class1.CenterText("│ keys to move left │");
            Lib.Class1.CenterText("│ and right         │");
            Lib.Class1.CenterText("│                   │");
            Lib.Class1.CenterText("│  Try to get as    │");
            Lib.Class1.CenterText("│ much money($) as  │");
            Lib.Class1.CenterText("│ you can           │");
            Lib.Class1.CenterText("│                   │");
            Lib.Class1.CenterText("└───────────────────┘");
            Console.ReadLine();
            Menu();
        }

        static void StartGame()
        {
            Console.CursorVisible = false;
            
            while (1<2)
            {
                Console.Clear(); 
                Console.WriteAscii("         Runner");
                Console.WriteLine("");
                Lib.Class1.CenterText("HighScore:" + Class1.highscore);
                Lib.Class1.CenterText("┌─────────────┐");
                Lib.Class1.WritingLevels(level0);
                Lib.Class1.CenterText("└─────────────┘");
                Console.WriteLine("");
                IfGameIsOver(false, false);
                ListenForKeys();
                Thread.Sleep(425);
                ListenForKeys();
                MovingBackground();
            }
        }

        static void ListenForKeys()
        {
            if(Console.KeyAvailable == true)
            {
                cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.LeftArrow)
                {
                    MovingLeft();
                }
                if(cki.Key == ConsoleKey.RightArrow)
                {
                    MovingRight();
                }
            }
            return;
        }

        static void MovingBackground()
        {
            bool Haslevel1Ended = 
            level0back[0, 0] == level0back[19, 0] && level0back[0, 1] == level0back[19, 1] && level0back[0, 2] == level0back[19, 2] && level0back[0, 3] == level0back[19, 3] &&
            level0back[0, 4] == level0back[19, 4] && level0back[0, 5] == level0back[19, 5] && level0back[0, 6] == level0back[19, 6] && level0back[0, 7] == level0back[19, 7] && level0back[0, 8] == level0back[19, 8] &&
            level0back[0, 9] == level0back[19, 9] ;

            if(Haslevel1Ended == true)
            {
                Random rand = new Random();
                int randIndex = rand.Next(1, 4);
                switch(randIndex)
                {
                    case 1:
                        Lib.Class1.ReplaceFullArrays(level1, level0back);
                    break;
                    case 2:
                        Lib.Class1.ReplaceFullArrays(level2, level0back);
                    break;
                    case 3:
                        Lib.Class1.ReplaceFullArrays(level3, level0back);
                    break;
                }
                
            }
           
            Class1.Replacing(level0, 8, level0, 9);
            Class1.Replacing(level0, 7, level0, 8);
            Class1.Replacing(level0, 6, level0, 7);
            Class1.Replacing(level0, 5, level0, 6);
            Class1.Replacing(level0, 4, level0, 5);
            Class1.Replacing(level0, 3, level0, 4);
            Class1.Replacing(level0, 2, level0, 3);
            Class1.Replacing(level0, 1, level0, 2);
            Class1.Replacing(level0, 0, level0, 1);

            Class1.Replacing(level0back, 19, level0, 0);
            Class1.Replacing(level0back, 18, level0back, 19);
            Class1.Replacing(level0back, 17, level0back, 18);
            Class1.Replacing(level0back, 16, level0back, 17);
            Class1.Replacing(level0back, 15, level0back, 16);
            Class1.Replacing(level0back, 14, level0back, 15);
            Class1.Replacing(level0back, 13, level0back, 14);
            Class1.Replacing(level0back, 12, level0back, 13);
            Class1.Replacing(level0back, 11, level0back, 12);
            Class1.Replacing(level0back, 10, level0back, 11);
            Class1.Replacing(level0back, 9, level0back, 10); 
            Class1.Replacing(level0back, 8, level0back, 9);
            Class1.Replacing(level0back, 7, level0back, 8);
            Class1.Replacing(level0back, 6, level0back, 7);
            Class1.Replacing(level0back, 5, level0back, 6);
            Class1.Replacing(level0back, 4, level0back, 5);
            Class1.Replacing(level0back, 3, level0back, 4);
            Class1.Replacing(level0back, 2, level0back, 3);
            Class1.Replacing(level0back, 1, level0back, 2);
            Class1.Replacing(level0back, 0, level0back, 1);

            
            Class1.YouCarRepositioning(YouCarCoords, level0);
            return;

        }

        private static void MovingLeft()
        {
            if (YouCarCoords[0, 1] > 0)
            {
                IfGameIsOver(true, true);
                if (YouCarCoords[0, 5] == 3)
                {
                    level0[YouCarCoords[0, 4], YouCarCoords[0, 5]] = "|";
                    level0[YouCarCoords[1, 4], YouCarCoords[1, 5]] = "|";
                    level0[YouCarCoords[2, 4], YouCarCoords[2, 5]] = "|";
                }
                else if (YouCarCoords[0, 5] == 7)
                {
                    level0[YouCarCoords[0, 4], YouCarCoords[0, 5]] = "|";
                    level0[YouCarCoords[1, 4], YouCarCoords[1, 5]] = "|";
                    level0[YouCarCoords[2, 4], YouCarCoords[2, 5]] = "|";
                }
                else
                {
                    level0[YouCarCoords[0, 4], YouCarCoords[0, 5]] = " ";
                    level0[YouCarCoords[1, 4], YouCarCoords[1, 5]] = " ";
                    level0[YouCarCoords[2, 4], YouCarCoords[2, 5]] = " ";
                }
                YouCarCoords[0, 1] = YouCarCoords[0, 1] - 1;
                YouCarCoords[0, 3] = YouCarCoords[0, 3] - 1;
                YouCarCoords[0, 5] = YouCarCoords[0, 5] - 1;
                YouCarCoords[1, 1] = YouCarCoords[1, 1] - 1;
                YouCarCoords[1, 3] = YouCarCoords[1, 3] - 1;
                YouCarCoords[1, 5] = YouCarCoords[1, 5] - 1;
                YouCarCoords[2, 1] = YouCarCoords[2, 1] - 1;
                YouCarCoords[2, 3] = YouCarCoords[2, 3] - 1;
                YouCarCoords[2, 5] = YouCarCoords[2, 5] - 1;
            }
            return;
        }

        static void MovingRight()
        {
            if (YouCarCoords[0, 5] < 10)
            {
                IfGameIsOver(true, false);
                if (YouCarCoords[0, 1] == 3)
                {
                    level0[YouCarCoords[0, 0], YouCarCoords[0, 1]] = "|";
                    level0[YouCarCoords[1, 0], YouCarCoords[1, 1]] = "|";
                    level0[YouCarCoords[2, 0], YouCarCoords[2, 1]] = "|";
                }
                else if (YouCarCoords[0, 1] == 7)
                {
                    level0[YouCarCoords[0, 0], YouCarCoords[0, 1]] = "|";
                    level0[YouCarCoords[1, 0], YouCarCoords[1, 1]] = "|";
                    level0[YouCarCoords[2, 0], YouCarCoords[2, 1]] = "|";
                }
                else
                {
                    level0[YouCarCoords[0, 0], YouCarCoords[0, 1]] = " ";
                    level0[YouCarCoords[1, 0], YouCarCoords[1, 1]] = " ";
                    level0[YouCarCoords[2, 0], YouCarCoords[2, 1]] = " ";
                }

                YouCarCoords[0, 1] = YouCarCoords[0, 1] + 1;
                YouCarCoords[0, 3] = YouCarCoords[0, 3] + 1;
                YouCarCoords[0, 5] = YouCarCoords[0, 5] + 1;
                YouCarCoords[1, 1] = YouCarCoords[1, 1] + 1;
                YouCarCoords[1, 3] = YouCarCoords[1, 3] + 1;
                YouCarCoords[1, 5] = YouCarCoords[1, 5] + 1;
                YouCarCoords[2, 1] = YouCarCoords[2, 1] + 1;
                YouCarCoords[2, 3] = YouCarCoords[2, 3] + 1;
                YouCarCoords[2, 5] = YouCarCoords[2, 5] + 1;
            }
            return;
        }

        static void IfGameIsOver(bool AreYouMoving, bool AreMovingLeft)
        {
            Class1.IfGameIsOver(YouCarCoords, level0, AreYouMoving, AreMovingLeft);
            return;
        }
    }
}
