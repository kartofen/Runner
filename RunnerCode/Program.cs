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
                how the game works - every 2 second a layer replaces the layer under it
                looks like - you go up
            }

            Idea how to make the game:
            {
                make 2d arrays,
                choose a 2d array randomly after the old array is played,
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
            
            Now adding:
            {
                cheking if the game is over
                !! to be able to get money and die with the sides and front
            }

            Things to add:
            {
                move the car
                get money/highscore
                add more levels
                add menu and how to play pages

            }
        */

        public static ConsoleKeyInfo cki;

        public static string[,] level1 = {
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
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
        public static string[,] level0 = {
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", "$", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", " ", " ", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", " ", " ", "|", "[", "N", "]"},
            {" ", " ", " ", "|", " ", " ", " ", "|", "o", "&", "o"},
            {" ", " ", " ", "|", " ", " ", " ", "|", " ", " ", " "},
            {" ", " ", " ", "|", "o", "#", "o", "|", " ", " ", " "},
            {" ", " ", " ", "|", "[", "C", "]", "|", " ", " ", " "},
            {" ", " ", " ", "|", "o", "@", "o", "|", " ", " ", " "},
        };
        
        //every pair of two ints represent a car's char position, first is the row then the column
        public static int[,] YouCarCoords = {
            {7, 4 /*o*/, 7, 5 /*#*/, 7, 6 /*o*/},
            {8, 4 /*[*/, 8, 5 /*C*/, 8, 6 /*]*/},
            {9, 4 /*o*/, 9, 5 /*@*/, 9, 6 /*o*/}
        };

        public static int highscore = 0;
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.CursorVisible = false;
            while (1<2)
            {
                Console.Clear();
                Console.WriteAscii("         Runner");
                Console.WriteLine("");
                Lib.Class1.CenterText("HighScore:" + highscore);
                Lib.Class1.CenterText("┌─────────────┐");
                Lib.Class1.WritingLevels(level0);
                Lib.Class1.CenterText("└─────────────┘");
                Console.WriteLine("");
                IfGameIsOver();
                ListenForKeys();
                Thread.Sleep(300);
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
                    MovingYou("left");
                }
                if(cki.Key == ConsoleKey.RightArrow)
                {
                    MovingYou("right");
                }
            }
            return;
        }

        static void MovingBackground()
        {
            Class1.Replacing(level0, 8, level0, 9);
            Class1.Replacing(level0, 7, level0, 8);
            Class1.Replacing(level0, 6, level0, 7);
            Class1.Replacing(level0, 5, level0, 6);
            Class1.Replacing(level0, 4, level0, 5);
            Class1.Replacing(level0, 3, level0, 4);
            Class1.Replacing(level0, 2, level0, 3);
            Class1.Replacing(level0, 1, level0, 2);
            Class1.Replacing(level0, 0, level0, 1);

            Class1.Replacing(level1, 19, level0, 0);
            Class1.Replacing(level1, 18, level1, 19);
            Class1.Replacing(level1, 17, level1, 18);
            Class1.Replacing(level1, 16, level1, 17);
            Class1.Replacing(level1, 15, level1, 16);
            Class1.Replacing(level1, 14, level1, 15);
            Class1.Replacing(level1, 13, level1, 14);
            Class1.Replacing(level1, 12, level1, 13);
            Class1.Replacing(level1, 11, level1, 12);
            Class1.Replacing(level1, 10, level1, 11);
            Class1.Replacing(level1, 9, level1, 10); 
            Class1.Replacing(level1, 8, level1, 9);
            Class1.Replacing(level1, 7, level1, 8);
            Class1.Replacing(level1, 6, level1, 7);
            Class1.Replacing(level1, 5, level1, 6);
            Class1.Replacing(level1, 4, level1, 5);
            Class1.Replacing(level1, 3, level1, 4);
            Class1.Replacing(level1, 2, level1, 3);
            Class1.Replacing(level1, 1, level1, 2);
            Class1.Replacing(level1, 0, level1, 1);
            Class1.YouCarRepositioning(YouCarCoords, level0);
            return;

        }

        static void MovingYou(string direction)
        {
            return;
        }

        static void IfGameIsOver()
        {
            switch (Class1.IfGameIsOver(YouCarCoords, level0))
            {
                case "dead":
                    GameOver();
                break;

                case "money":
                    highscore =+ 1;
                    return;

                default:
                    return;
            }
            return;
        }

        static void GameOver()
        {
            Class1.CenterText("Game Over!");
        }
    }
}
