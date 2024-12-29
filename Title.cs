using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
     class Title
    {
        backgroundManager back = new backgroundManager();
        Intro intro = new Intro();

        public void PrintTitle()
        {
            bool isExit = true;
            char cursor = '▶';
            char index = '　';

            ConsoleKeyInfo keys;
            #region
            string Titielogo = "                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                ...                                                                                                                             \r\n                              :#@@@@%%=.          ..-+%%*              ..-#%=                                                                                   \r\n                            .*@@@@@@@@@@@=.     :@@@@@@@:           .+@@@@@@=                                                                                   \r\n                           :@@@@@@@@@@@@@@@-    -@@@@@@#.           .+@@@@@@-                                                                                   \r\n                          -%@%. .:#@@@@@@@@%:   =@@@@@@*.           .+@@@@@@-                                                                                   \r\n                         .%@@+      .=%@@@@%:   +@@@@@@=.           .+@@@@@@-                                            ...                                    \r\n                         +@@@+         .*@@#.   +@@@@@@= ...-*%%.   .*@@@@@@- -%%#:.          .+%%%%%%%%*:    .#%%%%#:.+@@@@@.  ..-#%+..=%@@%*.                 \r\n                        .@@@@%.           *=    *@@@@@@- .%@@@@%    .*@@@@@@=%@@@@@@#.     ..*@@@@@@@@@@+:.   .%@@@@@==@@@@@= +@@@@@@%@@@@@@@@@=                \r\n                        -@@@@@*.                *@@@@@%- .@@@@@-    .*@@@@@@@**@@@@@@@:   .*@@@@--*@@@@@@@+   .%@@@@@*@@@@@%  =@@@@@@@+:%@@@@@@#.               \r\n                        -@@@@@@@+.              *@@@@@%- =@@@%.     .*@@@@@@- .#@@@@@@+  .%@@@@+    +@@@@@@=  .@@@@@@@@=.#@=  =@@@@@@+. =@@@@@@#.               \r\n                        .@@@@@@@@@@@*:          *@@@@@%-.@@@*...    .*@@@@@@- .=@@@@@@+  #@@@@@=    :#@@@@@*  .@@@@@@@-       =@@@@@@+. :%@@@@@#.               \r\n                      -%@@@@@@@@@@@@=           *@@@@@%-%@@@@@@%+   .*@@@@@@-  -@@@@@@= :@@@@@@#    .*@@@@@+  .@@@@@@@.       =@@@@@@*. :#@@@@@+                \r\n                   .+@@@#  ..#%@@@@-            *@@@@@@%@@@@@@@@@%:..*@@@@@@-  :%@@@@@: .@@@@@@@%:. .#@@@@%   .@@@@@@@+::.    =@@@@@@*. :%@@@@@-                \r\n                  -@@@@#.       ...             *@@@@@@@=+%@@@@@@@%..#@@@@@@-  :%@@@@@.  -@@@@@@@@%**@@@@#.   .#@@@@@@@@%.    =@@@@@@*. -%@@@@@:                \r\n                 =@@@@@+.                       *@@@@@@=. ..%@@@@*..:#@@@@@@:  -@@@@@@   ..+@@@@@@@@@@@%..    ..#@@@@@@@:     -@@@@@@*. =@@@@*..                \r\n                -@@@@@@*.                     :.*@@@#*+.     -@%:   :##***+=. .=@@@@*.       .=*%@@@*:.          .=****-.     =%#***+-..*@#:.                   \r\n                +@@@@@@@%:                 :*@+ ....         ...              .*@@-..             ..                                   .:..                     \r\n                -@@@@@@@@@@@#-::.......:=%@@@#                                .-.                                                                               \r\n                .+@@@@@@@@@@@@@@@@@@@@@@@@@@%:                                                                                                                  \r\n                  :#@@@@@@@@@@@@@@@@@@@@@@@@-.                                                                                                                  \r\n                    .:*%@@@@@@@@@@@@@@@@%#=.                                                                                                                    \r\n                        ...:--------::..                                                                                                                        \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                ";
            #endregion

            Console.Write(Titielogo);
            Console.SetCursorPosition(70, 35);
            Console.Write("게임 시작");

            Console.SetCursorPosition(70, 38);
            Console.WriteLine("게임 종료");

            while (isExit)
            {
                Console.CursorVisible = false;

                Console.SetCursorPosition(68, 35);
                Console.Write(cursor);


                while (isExit)
                {

                    keys = Console.ReadKey(true);
                   
                    if (keys.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(68, 35);
                        Console.Write(index);
                        Console.SetCursorPosition(68, 38);
                        Console.Write(cursor);

                    }

                    if (keys.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(68, 38);
                        Console.Write(index);
                        Console.SetCursorPosition(68, 35);
                        Console.Write(cursor);
                    }

                    if (Console.CursorTop == 35 && keys.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        intro.IntroCutscene();
                    }

                    if (Console.CursorTop == 38 && keys.Key == ConsoleKey.Enter)
                    {
                        isExit = false;
                    }
                }


            }
        }
    }
}
