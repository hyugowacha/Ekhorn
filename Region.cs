using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
    partial class Region
    {
        int cursorX = 12;
        int cursorY = 34;
        backgroundManager back = new backgroundManager();
        Print print = new Print();
        ConsoleKeyInfo keys;
        char cursor = '▶';
        bool isExit = true;

        public void Totrich(Player player)
        {
            string Totrich = "       @@                            @@@@@@@@@                                                                                                                  \r\n       @@                            @@    @@@@@@@@@@@@@@@@@                                                                                                    \r\n       @@              @            @@@  @@@ @@   @@@   @@@@@@@@@@@@@@@@@@@@@                                                                                   \r\n       @@           @@@@@@@@@@@@@@@@@ @@@     @@    @@@ @@    @@  @@   @@   @@@@@@@@@@@@@@@                                                                     \r\n        @@@@@@@@@@@@@@  @@ @@  @@@    @@      @@    @@@@@@@@@@@@  @@   @@ @@             @@@@@                                                                  \r\n                    @@  @@@@@  @@@@@@@@@@@@@@@ @@@@@   @@         @@@@@@@@@@@@@@@@@@@@@    @@@@@@                                                               \r\n                    @@  @  @@  @      @        @@@@@   @@@@@@@@@@@@@@@   @@   @@     @@        @@@@@@                                                           \r\n                    @@  @@ @@ @@      @     @@@ @@  @@@@@                @@   @@    @@@          @@@@@@@                                                        \r\n                    @@  @@@@@ @@      @@ @@@    @@     @@@               @@   @@@@@@@@               @@@@@@                                                     \r\n                    @@ @@  @  @@       @@@       @@   @@ @@            @@@@ @@      @@@@@@@@@@@@@@@@@@@ @@@@@@            @@@                                   \r\n                    @@ @@  @  @@      @@@@        @  @@   @@@@@@@@@@@@@@@@@@@     @@@             @@    @@@@@@@@          @@@                                   \r\n                    @@ @@@@@  @@@@@@@@@@ @@@@@@@@@@@@@@@  @ @@@@@@@@@@@@@@@@@@  @@@@@@@@         @@@        @@            @@@                                   \r\n                     @ @@  @@ @@       @ @@        @@@@@@@@@@                       @@@@@@     @@ @@ @@@@   @@          @@@@@                                   \r\n                    @@ @@  @@ @@       @ @@        @@@@@@@@@@                         @@    @@@@@@@@      @@@@@@@@@@@@@@@ @@@                                   \r\n                    @@@@@  @@ @@       @ @@        @@@@@@@@@@    @@@@@@@@@@@@@@@@@@@@ @@   @@  @  @@             @@@@@    @@@                                   \r\n         @@@@@@     @@@@@  @@ @@       @ @@         @@@@@@@@@    @   @@        @@@@@@@@@   @@ @@@@@@@@@@@@@@@@@@@         @@@                                   \r\n        @    @@@@@@@@@@@@  @@ @@       @@@          @@@@ @@@@    @   @@          @  @ @@   @@@             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                      \r\n       @@  @@@   @@@@@@@@@  @ @@       @@@          @@@@ @@@@    @   @           @  @ @@                   @@             @@@   @@@     @@                      \r\n       @@ @@@       @  @@   @@@@       @@@          @@@@ @@@     @   @           @  @ @                    @@@@@@@@@@@@@@@@@ @@@  @    @@@@@@                   \r\n       @@@@@@@@@    @ @    @@@@@       @@@@         @@@@@@@@     @   @           @  @ @      @@@@  @@@@@@@@@@@  @@    @@  @@      @   @@ @@@@                   \r\n     @@@      @@@@@@@@@@@@ @@@@@       @@@@         @@@    @     @  @@           @  @ @    @@@@@@@@@@      @@@ @@    @@   @@      @  @@@@@@@                    \r\n   @@           @@@@@@@@@@@@@@@@       @@@@@        @@     @    @@  @@           @  @ @@   @      @@        @@@@     @   @@@      @@@@   @@                     \r\n  @@             @@         @@@@       @@@@       @ @@     @    @@  @@          @@  @ @@   @      @@        @@@@    @@  @@@@      @@     @@                     \r\n @                @@        @ @@       @@@@      @@ @@     @    @@  @@          @@  @ @@  @@      @@        @@@     @   @ @@      @@     @@                     \r\n@@    @@@  @@@     @@@@@@@@@   @@      @@@@      @@ @@  @@@@    @@  @@          @@  @ @@  @@      @@@       @@     @@  @@ @@      @@     @@                     \r\n@   @@  @     @@    @   @@@@@@   @@      @@@@                  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          @@@@@        @@@  @@@@@@@@@@@@@                     \r\n@ @@@   @@     @@   @  @@    @@   @@@@@@@@@@                                    @@@@                        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                    \r\n  @     @@      @@  @@  @@@  @@   @@     @@@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @                        @@@@@@@@                    @@@@@@                 \r\n @@     @@@     @@   @@   @@  @@   @     @@@                                      @@@@                         @@@@@@@@                     @@@@@@@             \r\n@@    @@@  @@@   @   @@    @  @@   @@    @@@          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @             \r\n@@@@@@@      @@  @@   @@@@@@  @@   @@@   @ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                        @@@ @@@                       @@@@@@@@@@@@@@@@\r\n       @@@@@@@@@@@@  @@  @ @@@ @    @    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                     \r\n       @@@@         @@@@@@@@  @@    @@@@              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                             @@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@@@@@@@@@@@                                                                     @@@@@@@@@@@@   @@@@@@@@@@            @@@     \r\n  @@@@@@@@@@@@@@@@@         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@        @@@@@@@@@@@@@@@@@@@@ @@        \r\n@                            @@                        @@@@@@@@@@                                @@@@        @@@@@  @@ @@@@@@@@@@@@@@@        @@@@@@@@@         \r\n                    @@@@@@@@                                 @                              @@@@@         @@@@@@    @@@ @@@        @@   @@@@@@@@@@@@@@@         \r\n             @@@@@@               @@@@@@@@@@@@@        @@@@@                             @@@           @@@@@          @@@  @@@       @@               @         \r\n  @@@@@@@@@  @@    @@@@@@@@@@@@@                   @@@                              @@@@            @@@@@@             @@@@@@@@@@@     @@@            @@@       \r\n      @@@@@@@@@@@@@@@@@@@                                                       @@@@             @@@@@@                   @@@@@@@@@@@    @@@@   @@@@@@@ @@@@    \r\n@@@@@@                    @@@@@@@@@@@@@@@                                   @@@@              @@@ @@@                        @@@ @@ @@@  @@@@@@@            @@@@\r\n@                                      @@@@@@@@@@@@@@@@                 @@@@               @@@  @@                             @@ @@  @@@       @@@@ @@@@@@@@@@@\r\n                                       @@@@@     @@      @@@@@@@@@@@ @@@@               @@@  @@@                                @@ @@  @@ @@@@@@@@@@@           \r\n                                  @@@@@          @@               @@@                 @@   @@                                    @@@@@@@                        ";

            Console.SetCursorPosition(0, 0);
            print.printindex();
            Console.Write(Totrich);

            player.PlayerAction();
        }

        public void Ekhorn(Player player)
        {
            string EkhornOffice = "                            @@          @@                                              @                                                                       \r\n                            @@          @@                                              @                                                                       \r\n                            @@           @                                              @                                                                       \r\n                            @@           @                                             @@                                                                       \r\n                            @@           @                                             @@                                                                       \r\n                            @@           @                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                                                       \r\n                            @            @@@@@@@@@@@@@                                                                                                          \r\n                            @                                                                                                                                   \r\n                            @                                                                                                                                   \r\n                            @                                                                                                                                   \r\n                            @@                                                                                                  @@@@@@@@@@@@@@                  \r\n                            @@                                                                                                 @@              @@@@@@@@@@@@@@@@@\r\n                            @@                                                                                                 @                               @\r\n                            @@                                                                                                @@                            @@@ \r\n                            @@                                                                                                @@                         @@@    \r\n                            @@                                                                                                @@                       @@@      \r\n                            @@                           @@@@@@@@@@@@@@@@                                                     @@                    @@@         \r\n                            @@                          @@               @@                                                   @@                  @@            \r\n                            @@                          @                 @                                                   @@               @@@              \r\n                            @@                          @                @@@@@@@@@                                            @              @@@                \r\n                            @@                          @                @@      @@                                           @            @@@                  \r\n                            @@                          @                @@      @@                                           @           @                     \r\n                            @@                         @@                @@      @@                                          @@        @@@                      \r\n                            @@                         @@                @@      @@                                          @@      @@@                        \r\n                            @@                         @@                @@      @@                                          @     @@                           \r\n             @@@@@@@@@@@@@@@@@@@@@@@                   @@                @@      @@                                         @@   @@                             \r\n        @@@                            @@@@@           @@                @@@@@@@@@                                          @@@@@                               \r\n         @@                              @@            @@                @@                                                 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n          @@                           @@@             @@                @@                                                 @@                                 @\r\n           @@@                        @@               @@ @@@@@@@@@@@@@@@@@@@@@@@@@@@                                       @@                              @@@ \r\n@@@@@@@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                       @@                                      @                             @@    \r\n                                                                                    @@                                      @                          @@@      \r\n                                                                                    @@                                      @                        @@@        \r\n                                                                                    @@                                      @                      @@@          \r\n                                                                                    @@                                      @                    @@@            \r\n                                                                                    @@                                      @                  @@               \r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                      @               @@@                 \r\n                          @@                                       @            @                                           @             @@@                   \r\n                          @@                                       @           @@                                          @@           @@                      \r\n                          @@                                      @@           @@                                          @@        @@                         \r\n                          @@                                      @@           @@                                          @@     @@@                           \r\n                          @@                                      @@           @@                                          @@   @@                              \r\n                          @@                                      @@           @@                                          @  @                                 ";

            Console.Clear();
            Console.Write(EkhornOffice);
            Thread.Sleep(1000);

            if(player.Progress == 0)
            {
                back.Textbox();
                Console.SetCursorPosition(cursorX, cursorY);
                print.PrintPhrase($"게오르그 : 뭐야. {player.Name}, 두고 간 물건이라도 있어? 파비안이 기다릴테니 어서 가보라고.");
                print.next();
            }

            else if(player.Progress == 1)
            {
                back.Textbox();
                Console.SetCursorPosition(cursorX, cursorY);
                print.PrintPhrase("사무실 안은 쥐 죽은 듯 고요하다....");
                print.next();
            }
            

            while (true)
            {
                isExit = true;
                back.Textbox();

                Console.SetCursorPosition(cursorX - 2, cursorY - 2);
                print.PrintPhrase("무엇을 할까?");
                Thread.Sleep(500);

                Console.SetCursorPosition(cursorX + 2, cursorY + 2);
                Console.WriteLine("둘러보기");

                Console.SetCursorPosition(cursorX + 2, cursorY + 4);
                Console.WriteLine("나가기");

                Console.SetCursorPosition(cursorX, cursorY + 2);

                while (isExit)
                {
                    Console.Write(cursor);

                    while (true)
                    {
                        keys = Console.ReadKey(true);

                        if (keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }

                    if (keys.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        Console.Write('　');
                        Console.SetCursorPosition(cursorX, cursorY + 4);
                    }

                    if (keys.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(cursorX, cursorY + 4);
                        Console.Write('　');
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                    }

                    if (keys.Key == ConsoleKey.Enter)
                    {
                        if (Console.CursorTop == cursorY + 2)
                        {
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);

                            if(player.Progress == 0)
                            {
                                print.PrintPhrase("게오르그, 파비안, 내가 일하는 용병 사무소다.");
                                Console.SetCursorPosition(cursorX, cursorY + 2);
                                print.PrintPhrase("일상은 반복될것이다. 늘 그랬듯이.");
                                print.next();
                            }
                            
                            else if(player.Progress == 1)
                            {
                                print.PrintPhrase("파비안을... 막으러 가야만 한다.");                                
                                print.next();
                            }

                            isExit = false;
                        }

                        else if (Console.CursorTop == cursorY + 4)
                        {
                            Totrich(player);
                        }
                    }
                }
            }
        }

        public void Store(Player player)
        {
            string Store = "        @@   @              @@    @@                   @   @             @@    @                    @@   @@                              @@               @@    \r\n        @@   @@             @@    @@                   @   @             @@   @@                    @@   @@   @@   @@@                   @@@@@@@@@@@@@@@@@@@    \r\n        @@   @@             @@    @                    @@  @@            @@   @@                    @@   @@   @@     @@@@@@@@@@@         @                @@    \r\n        @@    @             @@    @                    @@  @@            @@   @                     @@   @@   @@     @         @         @                @@    \r\n         @    @@            @@   @@                    @@  @@            @@  @@                     @@   @@   @@     @         @@        @@               @     \r\n         @@   @@            @    @@                     @   @@           @   @@                     @@   @@    @@@@@@@@@@@@@@@@@@@@       @@            @@@@@@  \r\n          @@   @@@         @@    @                      @@   @@         @@  @@                      @@    @@@@                           @@@@@@@     @@@ @@    @\r\n @@@@@@@@@@@     @@@      @@    @@                       @   @@@       @@   @@                      @                                   @@    @@    @@    @@    \r\n          @@@       @@@@@@     @@                        @@    @@@   @@    @@                       @                                 @@@@@ @@@@@  @@@@  @@@   @\r\n           @@@                @@                          @@      @@     @@@                        @      @@@@@@@@@@@@@@@@@@@@@@@@@@@@       @ @@@  @@@@  @@   \r\n            @@@@@           @@                              @@         @@@                          @     @@                         @@      @@      @@     @@  \r\n             @@ @@@@@@@@@@@@                                  @@@@@@@@@   @@@@@@    @@@@@@@@        @      @                         @       @@      @@     @@  \r\n              @@                                                         @@    @@   @      @        @      @                        @@       @@      @@      @  \r\n               @@@@@                                                     @@    @@   @      @        @      @@                       @@       @@      @       @@ \r\n                     @@@           @@@@@@@@@@@@@@@                       @@    @@   @     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n                       @@         @@               @@                    @@    @@   @    @@                                                                     \r\n                        @@        @     @@    @@     @                   @     @@   @    @@                                                                     \r\n                         @       @@     @      @@    @@                 @@     @@   @    @@                                                                     \r\n                          @@     @@    @@      @@    @@@@@@@@@@@@       @@     @@   @    @@                                                                     \r\n                          @@     @@    @@      @@     @         @@      @@     @@   @    @@                                                                     \r\n                        @@@      @     @@      @@     @@         @      @@     @@   @    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n                @@@@@@@@         @     @@      @@     @@         @      @@     @@   @    @@                                                                     \r\n@@@@@@@@@@@@@@        @@         @@    @@      @@     @@         @      @@    @@    @    @@                                                                     \r\n                      @@    @@@@@@@@@  @@      @@     @@         @      @@    @@    @    @@                                                                     \r\n                      @@@@@@        @@  @            @@         @@@@@@@@@@     @@@@ @@   @@                                                                     \r\n                      @@  @          @ @@@@@@@  @@@@   @   @@@@@         @@@  @@@ @@@@@@@@@                                                                     \r\n@@@@ @@@@@@@@@@@@@@@@@@  @@          @@               @@@@@@@@              @@           @@                                                                     \r\n                         @@          @@              @       @@                          @@                                                                     \r\n                 @@@@@@@@@@          @@@@@@@@@@@@@@@@@       @@@@                        @@                                                                     \r\n              @@@        @@          @@              @       @@  @@@                     @@                                                                     \r\n            @@            @@         @               @@@@@@@@@@     @@                   @@                                                                     \r\n           @@             @@@@@@@@@@@                                @@                  @@                                                                     \r\n           @@                                                        @@                   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                               \r\n             @@@@@@                                           @@@@@@@                                                              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n              @@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@      @                                                                                             \r\n              @@     @@                                   @@      @                                                                                             \r\n              @@     @@                                   @@      @                                                                                             \r\n              @@     @@                                   @@      @                                                                                             \r\n              @@     @@                                   @@      @                                                                                             \r\n              @@     @@                                   @@      @                                                                                             \r\n              @@      @                                   @@      @                                                                                             \r\n              @@      @                                   @@     @@                                                                                             \r\n              @@      @                                   @@     @@                                                                                             ";

            Console.Clear();
            Console.Write(Store);
            Thread.Sleep(1000);

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("주점 마스터 : 어서 와. 한 잔 하고 갈 텐가?");
            print.next();
            SelectStoreMenu(player);
        }

        public void SelectStoreMenu(Player player)
        {
            while (true)
            {
                isExit = true;
                int tempCursorX = cursorX;
                int tempCursorY = cursorY + 2;

                int tap2cursorY = cursorY + 4;
                int tap3cursorY = cursorY + 6;

                back.Textbox();

                Console.SetCursorPosition(cursorX - 2, cursorY - 2);
                print.PrintPhrase("무엇을 할까?");
                Thread.Sleep(500);

                Console.SetCursorPosition(cursorX + 2, cursorY + 2);
                Console.WriteLine("둘러보기");

                Console.SetCursorPosition(cursorX + 2, cursorY + 4);
                Console.WriteLine("아이템 구매하기");

                Console.SetCursorPosition(cursorX + 2, cursorY + 6);
                Console.WriteLine("나가기");

                Console.SetCursorPosition(cursorX, cursorY + 2);

                while (isExit)
                {
                    Console.Write(cursor);

                    while (true)
                    {
                        keys = Console.ReadKey(true);

                        if (keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }

                    if (keys.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                        Console.WriteLine('　');
                        tempCursorY += 2;

                        if (tempCursorY > tap3cursorY)
                        {
                            tempCursorY = tap3cursorY;
                        }

                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                    }

                    if (keys.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                        Console.WriteLine('　');
                        tempCursorY -= 2;

                        if (tempCursorY < cursorY + 2)
                        {
                            tempCursorY = cursorY + 2;
                        }
                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                    }

                    if (keys.Key == ConsoleKey.Enter)
                    {

                        if (tempCursorY == cursorY + 2)
                        {
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);
                            print.PrintPhrase("토트리치에 있는 유일한 술집이다.");
                            Console.SetCursorPosition(cursorX, cursorY + 2);
                            print.PrintPhrase("말이 술집이지 이것저것 잡동사니를 다 파는 것 같다.");
                            print.next();
                            isExit = false;
                        }

                        else if (tempCursorY == tap2cursorY)
                        {
                            BuyItem(player);
                        }

                        else if (tempCursorY == tap3cursorY)
                        {
                            Totrich(player);
                        }

                    }

                }
            }
        }

        public void BuyItem(Player player)
        {
            Item gun = new Gun(1000);
            Item potion = new Potion(200);
            Item armour = new Armour(500);

            while (true)
            {
                back.Textbox();

                int tempCursorX = cursorX;
                int tempCursorY = cursorY;

                int tap2cursorY = cursorY + 2;
                int tap3cursorY = cursorY + 4;
                int tap4cursorY = cursorY + 6;

                Console.SetCursorPosition(cursorX - 2, cursorY - 2);
                print.PrintPhrase("무엇을 살까?");
                Thread.Sleep(500);

                Console.SetCursorPosition(cursorX + 20, cursorY - 2);
                Console.Write($"보유 금액 : {player.Silling}");

                Console.SetCursorPosition(cursorX + 2, cursorY);
                Console.WriteLine($"마력이 깃든 방어구: {armour.Explain} 500실링");

                Console.SetCursorPosition(cursorX + 2, tap2cursorY);
                Console.WriteLine($"사냥용 총 : {gun.Explain}. 1000실링");

                Console.SetCursorPosition(cursorX + 2, tap3cursorY);
                Console.WriteLine($"X-090892 : {potion.Explain}. 200실링");

                Console.SetCursorPosition(cursorX + 2, tap4cursorY);
                Console.WriteLine("뒤로가기");

                Console.SetCursorPosition(tempCursorX, tempCursorY);

                while (true)
                {
                    Console.Write(cursor);

                    while (true)
                    {
                        keys = Console.ReadKey(true);

                        if (keys.Key == ConsoleKey.DownArrow || keys.Key == ConsoleKey.UpArrow || keys.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }

                    if (keys.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                        Console.WriteLine('　');
                        tempCursorY += 2;

                        if (tempCursorY > tap4cursorY)
                        {
                            tempCursorY = tap4cursorY;
                        }

                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                    }

                    if (keys.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                        Console.WriteLine('　');
                        tempCursorY -= 2;

                        if (tempCursorY < cursorY)
                        {
                            tempCursorY = cursorY;
                        }
                        Console.SetCursorPosition(tempCursorX, tempCursorY);
                    }

                    if (keys.Key == ConsoleKey.Enter)
                    {

                        if (tempCursorY == cursorY)
                        {
                            if (player.Invenlist.Count >= 8)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("인벤토리에 빈 공간이 부족합니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }

                            else if (player.Silling < 500)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("잔액이 부족합니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }

                            else if (player.Silling > 500)
                            {
                                player.Invenlist.AddLast(armour);
                                player.Silling -= 500;
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("아이템을 성공적으로 구매했습니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }
                        }

                        else if (tempCursorY == tap2cursorY)
                        {
                            if (player.Invenlist.Count > 7)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("인벤토리에 빈 공간이 부족합니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }

                            else if (player.Silling < 1000)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("잔액이 부족합니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }

                            else if (player.Silling > 1000)
                            {
                                player.Invenlist.AddLast(gun);
                                player.Silling -= 1000;
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("아이템을 성공적으로 구매했습니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }
                        }

                        else if (tempCursorY == tap3cursorY)
                        {
                            if (player.Invenlist.Count > 7)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("인벤토리에 빈 공간이 부족합니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }

                            else if (player.Silling < 200)
                            {
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("잔액이 부족합니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }

                            else if (player.Silling > 200)
                            {
                                player.Invenlist.AddLast(potion);
                                player.Silling -= 200;
                                back.Textbox();
                                Console.SetCursorPosition(cursorX, cursorY);
                                Console.Write("아이템을 성공적으로 구매했습니다.");
                                Thread.Sleep(1000);
                                BuyItem(player);
                            }
                        }

                        else if (tempCursorY == tap4cursorY)
                        {
                            SelectStoreMenu(player);
                        }
                    }

                }
            }
        }

        public void BeforeEichmann(Player player)
        {
            string Load = "                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                   @@@                                                                            \r\n   @@@                                                                         @@  @                                                                            \r\n                                                                              @@   @                                  @@                                        \r\n                                                                             @@   @@                          @@                   @@@@@@@          @@@@@@@@@@@@\r\n                                                                            @@    @@                         @                                                  \r\n                       @    @      @                                      @@      @                         @                                                   \r\n                       @    @@     @                                    @@        @                         @                                                   \r\n                       @@   @@    @@                                  @@          @                        @@                                                   \r\n                       @@    @    @                                @@@            @                        @@                                                   \r\n                                                                 @@@             @@                        @@                                                   \r\n                                                               @@                @@                        @                                                    \r\n                                                             @@                  @@                        @                                                    \r\n                                                           @@                    @@                       @@                                                    \r\n                                                          @@                     @@                       @                                                     \r\n                                                         @@                      @@                      @@                                                     \r\n                                                       @@                        @@                     @@                                                      \r\n                                                      @@                         @@                     @                                                       \r\n                                                    @@           @@              @@                   @@                                                        \r\n                                                   @@            @@              @@                  @@                              @  @@       @@             \r\n                                                 @@              @@              @@                @@                                @   @@      @              \r\n                                              @@                 @@              @@              @@@                                 @                          \r\n                                           @@@                   @@              @@            @@                                                               \r\n        @                                @@@                     @@              @@          @@                                                                 \r\n    @@  @@     @@                       @@                       @@              @@         @                                                                   \r\n    @@  @@     @                      @@                         @               @@        @@                                                                   \r\n         @                           @@                          @               @@        @@                                                                   \r\n                                  @@@                            @               @@         @                                                                   \r\n                                @@@                              @               @@         @                                                                   \r\n                              @@                                 @               @@         @@                                                                  \r\n                            @@                                   @@              @@         @@                                                                  \r\n                         @@@                 @                   @@              @@         @                                                                   \r\n                       @@@                   @                   @               @@        @@                                                                   \r\n                     @@                      @                   @               @@       @@                                                                    \r\n                   @@                        @                                   @@     @@                                                                      \r\n                 @@                          @                                   @@   @@                                                                        \r\n               @@                            @                                   @@@@@                                                                          \r\n             @@                              @                                  @@@                                                                             ";

            Console.Clear();
            Console.Write(Load);
            Thread.Sleep(2000);

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("나는 협곡을 넘어 아이히만의 연구기지로 향했다.");
            print.next();

            print.PrintPhrase("....그런데 어째서일까, 예감이 좋지 않다.");
            print.next();

            print.PrintPhrase("하지만 걸음을 늦출 수는 없다. 서둘러 가자.");
            print.next();

            EichmannLab(player);
        }

        public void EichmannLab(Player player)
        {
            Console.Clear();
            #region
            string eichmannLab1 = "                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n               *    +  **  +                 *          +       ++      *    ++         *+     +         *+                   ++   +   +  **                    \r\n               +    *  **  +                 +          +    ++       *+       +*         +*+  *          +++**+*+++*+++***+*+**   +   +  **                    \r\n               +    +  ++  *********++++**** +          * ++*       **          ++          ++ +          ***+***+*+***++++++***   +  +*  **                    \r\n               *    *  *+  +                 +          **+        *+            ++          +++          *                   +*   +  +*  ++                    \r\n               +*   *  +*  +                 *          *+         ++             **          +*+*****++++*                   ++   *   +  **                    \r\n               +*   +  *+  *                ++**+++**+*+**+        +++          ***+*++**+++++**+*+***+++*+      +++*+     +****+++**+***+*++**+                \r\n               *+   *  ++  *  +   +  +*+    +***+***+**** ******    *+            *        ++ +*          +     **   +     *+                  *+               \r\n             +*++********+*+**+*  *  + **    *          * ++        *+            +        *+ **          *     +  + *+    +** +***+**++*++**+**                \r\n             +                *+  *  * ++    +          *  +         **           *        ** **          +     *  * **     **               ++                 \r\n             ++           **+**   +  * ++    *          *  *    *+**              +++*****++* *           +     +  * ++     *+               *+                 \r\n             **              **   *  * ++    *         +++*+***+****+*+*++*****+***+++*++****+**+**+**++**+     *  + *      **               **                 \r\n             *+               *   *  * ++    **+*+++*+*+*            **++     **++            +***++***++**     +  * *      *                +*                 \r\n             *+               +   +  + **    *         **          +*+           *+           +          ++     +  * *     ***+*++++++++++++++*                 \r\n             +**++       **+++++  *  * **    *+***+*+**+*         **               +          *          **     *  + *     *                  ++                \r\n             +                **  *  * **    +         **        **                +*         *          ++     *  + *     ++******+++*+++**+*+                 \r\n             *+*+***+*+**+++***   +  *+**    *         ++       +*                  *+        *          *     ++  +*+       *    *   +*   *                    \r\n                +  *+  *+  *      *  ++**    *         **      ++                    *+       *          *     +*  *+*       +    *   +*   +                    \r\n                +  **  +*  +      +  *+*+    *         **      *                     +*       +          *     ++  +*+       *    +   +*   +                    \r\n                *  ++  ++  +      *  **+*    *         +      +*                      ++     *+          +     ++  +++       +    *   **   *                    \r\n                *  +   *+  +      +  ****    *         *     *+                       +*     ++         +*      *  +++       +    *   +*   *                    \r\n                +  +   +*  *  *+* *  ***+    *         *     +*                       ++     ++         +++*+**+*  +**+++*+++*+  ++   **   +++++                \r\n             ***   *   **  **    **  ****+**++         ++*   +***+++*****++**++********+*+*++*          +*     +*  ++*       *   ++   +*   +     +***           \r\n          ++*  **++*++++***+     **  ++*+   *+       +**                                     *          ++     +++*++*       *+*+**+*++****          *++*       \r\n       ++*                                                                                                                                                +**   \r\n    ***                                                                                                                                                         \r\n   *                                                                                                                                                            \r\n                                                                                                 ++                                                             \r\n                   ++****+                                                                                                                                      \r\n                                                                                                    **+*+                                                       \r\n                         ++**+*+                                                                                                                                \r\n                                                                                        ***++++++                         +*++*****+                            \r\n                               ****                                                                                                                             \r\n                                                                                                         **+**++                                                \r\n         +**+*+                                                                                                                                                 \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                ";
            string eichmannLab2 = "                                                                                                                                                                \r\n                                                                                                                                                                \r\n              **   *   #  #*                *          *#       ##      #    ##         ##     #          *                    #    #   #  *#                   \r\n              *    #   *  #*                #          *#    ##       **       ##         ##   *          **#####*##############    #   *  **                   \r\n              *    #   #  ###*######**#######          ##  *        ##          #*          *# #          *       ***###**##   #    #  #*  ##                   \r\n              *    #   #  ##                #          ###*         #            #*          ##*          *                    #    #  *#  **                   \r\n              ##   #   *  #*                *          #**         *#             ##          ##   **#*** #                    #    #  #*  #*                   \r\n              *#   *   #  ##                *###**###**#*##*###################################*          #       #*#        #*##  *#  *#  #  *#                \r\n              **   #   *  **      #####     #*##*#*#***#* ####*####*#             *#*######## *##**##*##*#*      #   **     ##             *    #               \r\n             **##*#############   #   *#    #          #* #*        #*            #        #* *#          #      #   ##     #*         ##*###*###               \r\n            #  *             **   # **##    #          #* #*        ##            #        #* *#          *      # #*#*     ###*#****         *#                \r\n            ######*#*##########   # ***#    *          #*  ##*####**###           #*######### ##          #     *# ****     #*                *#                \r\n            ##               #    # *###    *          #*          #**#####*#**#**#*          *#*#        #     #* ##*#     ##                *#                \r\n            *#               #    # ####    #          **#***#*        #########      #*#**##*##   ###*##*#     ## ###      ##                ##                \r\n            ##               #    # ####    ############            #*#         **            #*#*####### #     *# *##      **                ##                \r\n            ##               #    # #*##    *      #*##*           **            ##*          **          #     #  *##     ##*#######*        **                \r\n            #######*#*#######*#   # **##    *##*       *          ##               **         #*          #     #  *#*     *#                  #                \r\n            ##               *#   # ###*    ##         #        *#                  ##        #*          *     #  *##     *##**###**###**#### *                \r\n            ##*#####***#*##*#*    * ####    #*         #        ##                   #        **         **     #  ###        #   *#   *#  *#                   \r\n               *# ##  ##  ##      # ####    ##         #       *#                    **       #          **    *#* #**#       #   *#   *#  **                   \r\n               ## *#  *#  ##      # *#*#    #*         *      *#                     *#       #          **    *#  **#*       #   **   ##  **                   \r\n               ## ##   *  **      * ##*#    *#         #      #                       ##     ##          *      #  ##*       ##   #*   **  **                   \r\n               ** #*   #  #*     *# ##*#    ##         #     *#                       ##     **         ##      #  *###      ##   *#   **  ##                   \r\n               *# #*  *#  *#     #* ####    #*         *     #                        ##     *#         #*      #  *###########   *#   ##  *##**                \r\n             #*#  #   *#  *#     #  *###*   *         **##  #**##***######*##**###############          *#     **  ###        #   #    #*  ##    ####           \r\n          ##* *##*#***####*#    #*  ***#    *        *##                                     *          ##     *####*#       #########*#*#**          ###       \r\n       #**                        * ***     ########   #                                      ######*#  #                                                 *###  \r\n    ##*                                                                                                                                                         \r\n  ##                                                                                                                                                            \r\n                                                                                                                                                                \r\n                  *####*#*##****##                                                               **###*#*                                                       \r\n                                                                                                      **##                                    #####             \r\n                             *                                                                                                                                  \r\n                                                                                                                                                                \r\n                                                                                        **#*#***                          ***#*#**##                            \r\n                              ####*                                                                                *                                            \r\n                                                                                                          #***#                                                 \r\n        #*###*                                                                                                                                                  \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                ";
            string eichmannLab3 = "                                                                                                                                                                \r\n             ##   #   #  ##                 #          #        ##      #    ##        ###     ##         #%                    #   ##  #   #                   \r\n             ##   #%  #  ##     %%%##    #%%#          #     ##       ##       ##         ##   #          #######################   ##  ##  #                   \r\n             ##   ##  #% ################## #          ## %#%       ##          ##          ## #          ##                    #   ##  #   #                   \r\n             ##   #%  ## ##                 #          # ##         #            ##          ###          ##%#%#%%##     ###### #   ##  #   #                   \r\n             #%   ##  ## ##                 #          ###         #%             #           ##          ##                    #   ##  #   #                   \r\n             ##   ##  #  ##                 ########%######################################### #############                    #   ##  ##  #                   \r\n             ##   ##  #  %#      %###%#    %#          #  #%#########              ##########  #############     %#####     ######################              \r\n             ##   #% %#  #%###   #    #    ###%%%#######  #         #             #        ##  #          ##     #    #     %#                  ##              \r\n           ######            #   # %# #%    #          #  #         ##            #        ##  #          ##     # %# #     #####################               \r\n           ##                #   #  # ##    #          #  #%         ##           #        ##  #          %#     #  # #      ##                ##               \r\n           %#           %#####   #  # ##    #          #  %#    %###              ###########  #          %#     #  # #      ##                ##               \r\n           ##               ##   #  # ##    #         ####################################    ##############     #  # #      ##                ##               \r\n           %#               %#   #  # ##    #         ##              ###    ####             #######%%%  ##     #  # #      #                 ##               \r\n           ##               ##   #  # ##    #######%####            ##          ###           ##          #%    ##  # #      ####################               \r\n           ##               ##   #  # ##    ############          ##              ##          ##          ##    ##  # #     ##                 ##               \r\n           ################# #   #  # ##    #         ##         ##                ##         ##          #     ##  # #     ##                ###               \r\n           ##                #   #  ####    #         ##        ##                  #%        ##          #     ##  # #     #############%% ##                  \r\n           ######### ##  ####    #  ####    #         #%        #                    #        ##          #     ##  ###       ##   ##   #   ##                  \r\n              ## ##  ##  ##      #  ####    #         #%       #                     ##       ##         ##     ##  ###       #%   #%   #   ##                  \r\n              %# ##   #  ##      #  ####    #         #%      ##                      #       ##         ##     ##  ###       ##   ##   #   ##                  \r\n              ## #%   #  %#      #  ####    #         ##      #                       ##      #          ##     ##  #%#       #%   #    #   ##                  \r\n              ## ##   #   #      #  ####    #         ##     #%                       ##     ##          #      %#  ###       ##   #    #   ##                  \r\n              ## ##   #   #      #  ####    #         ##     #                        %%     %#          #      ##  ############   #    #   #####               \r\n             ##  ##  %#  #########  ####    #         #########################################          #########  #%#       ##  ##    #   #%   ####           \r\n          ###%####%%#######     ##  #########         ##                                     ##          #      #   ###       #% #####%####%#        %###       \r\n       ###                      ########   %###########                                      #############     ######                                     ####  \r\n    ###                                                                                                                                                       # \r\n ###                                                                                                                                                            \r\n                                                                                                                                                                \r\n                                                                                                 ########%                                                      \r\n                 ######%                                                                                                                                        \r\n                                                                                                     %%###                                     ##%%#            \r\n                        #######                                                                                                                                 \r\n                                                                                             ####                             ##%####                           \r\n                                                                                                                                                                \r\n                             #####                                                                          #%%#####                                            \r\n                                                                                                                                                                \r\n       # %##                                                                                                                                                    \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                ";
            string eichmannLab4 = "            @@   @   @   @                 @           @        @@      @    @@        @@@@    @@         @@                    @@   @   @  @@                  \r\n            @@   @@  @@  @@@@@@@@@@@@@@@@@@@           @     @@       @@       @@         @@@  @@          @@@@@@@@@@@@@@@@@@@@@@@   @   @   @                  \r\n            @@   @@  @@  @@@@@@@@@@@@@@@@@ @           @  @@@       @@          @@          @@ @@          @                    @@   @   @  @@                  \r\n            @@   @@  @@  @                 @           @ @@        @@            @@          @@@@          @@@@@@@@@@    @@@@@@@@@   @  @@  @@                  \r\n            @@   @@  @@  @                 @           @@@         @@             @           @@@          @                    @@   @@ @@  @@                  \r\n             @   @@  @   @                 @           @@  @@@@@  @@    @@@       @@           @@@@@@@@@@@@@                    @@   @   @  @@                  \r\n             @   @@  @   @                 @@@@@@@@@@@@@@@      @@@@@@          @@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@@@@      @@@@@@@@@@@@@@@@@@@@@@             \r\n             @   @@  @   @  @    @ @@@    @@@@@@@@@@@@@@ @@@@@@    @@             @         @  @           @      @   @      @@                   @             \r\n           @@@@@@@@@@@@@@@@@@@   @   @@    @           @ @@         @@            @         @  @           @      @   @@     @@         @@@@@@@@@@@             \r\n          @@                @@   @ @ @@    @           @ @@         @@            @         @  @           @      @ @ @@     @@@@@@@@           @@              \r\n          @@@@@@@@@@@@@@@@@@@@   @ @ @@    @@          @  @@@@@@@@@@@@@           @@@@@@@@@@@  @           @     @@ @ @@      @                 @@              \r\n          @@               @@    @ @ @@    @@          @           @@@@@@@@@@@@@@@@@           @@@         @     @@ @ @@      @                 @@              \r\n           @                @    @ @ @@    @@         @@@@@@@@@        @@@@@@@@@      @@@@@@@@@@    @@@@@@@@     @@ @ @       @                 @@              \r\n           @                @    @ @ @@    @@@@@@@@@@@@@            @@@@       @@@            @@@@@@@@@@@@@@     @@ @ @       @                 @               \r\n           @                @    @ @ @@    @@         @@           @@            @@           @@          @@     @@ @ @      @@@@@@@@@@@@@@@@@@@@@              \r\n          @@ @@         @@@@@@   @ @ @@    @@@@@@@@@@@@@          @@              @@          @@          @@     @  @ @     @@@                 @@              \r\n          @@      @@@       @@   @ @ @@    @@         @@         @@                @@         @@          @@     @  @ @     @@          @@@@@@@@@@              \r\n          @@                @@   @ @@@@    @@         @@        @@                  @@        @@          @      @  @ @      @@@@@@@@@  @@   @@                 \r\n           @@@@@@@@  @  @@@@    @@ @@@@    @@         @@       @@                    @@       @@          @     @@  @ @        @    @    @   @@                 \r\n             @@  @   @   @      @@ @@@@    @@         @@      @@                     @@       @@          @     @@  @ @@       @    @    @   @@                 \r\n             @@  @   @   @      @@ @@@@    @@         @@      @                       @       @@          @     @@  @@@        @    @   @@   @@                 \r\n             @@ @@   @   @      @@ @@@@    @@         @@     @@                       @@      @           @      @  @@@       @@    @   @@   @@                 \r\n             @@ @@   @   @      @@ @@@@    @@         @      @                        @@      @          @@      @  @@@@      @@    @   @@   @@                 \r\n             @@ @@   @   @      @@ @@@@    @@         @      @                        @@     @@          @@      @  @@@@@@@@@@@@   @@   @@   @@@@               \r\n            @@  @@   @   @@@@@@@@@ @@@@    @@        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@          @@@@@@@@@  @@@        @   @@   @@   @@  @@@@           \r\n         @@@ @  @@   @   @@    @@  @@@@@@@@@          @                                      @@          @@     @   @@@       @@   @    @@   @        @@@       \r\n       @@@    @@@@@@@@@@@@     @@@@@@@@    @@  @@@@@@@@                                      @@@@@@@@@@@@@@     @@@@@@         @@@@@  @@@@@@@            @@@@   \r\n    @@@                                                                                                                                                      @@@\r\n @@@                                                                                                                                                            \r\n@@                                                                                                                                                              \r\n                                                                                                                                                                \r\n                @@@@@@@@@@@@@@@@                                                                  @@@@@@@                                                       \r\n                                                                                                       @@@                                     @@@@@@           \r\n                                                                                                                                                                \r\n                        @@                                                                                                                                      \r\n                                                                                        @@@@@@@@@                          @@@@@@@@@@@                          \r\n                             @@@@@                                                                                                                              \r\n                                                                                                           @@@@@@@@@@                                           \r\n       @   @                                                                                                                                                    \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                ";
            string eichmannLab5 = "            @@   @   @   @                 @           @        @@      @    @@        @@@@    @@         @@                    @@   @   @  @@                  \r\n            @@   @@  @@  @@@@@@@@@@@@@@@@@@@           @     @@       @@       @@         @@@  @@          @@@@@@@@@@@@@@@@@@@@@@@   @   @   @                  \r\n            @@   @@  @@  @@@@@@@@@@@@@@@@@ @           @  @@@       @@          @@          @@ @@          @                    @@   @   @  @@                  \r\n            @@   @@  @@  @                 @           @ @@        @@            @@          @@@@          @@@@@@@@@@    @@@@@@@@@   @  @@  @@                  \r\n            @@   @@  @@  @                 @           @@@         @@             @           @@@          @                    @@   @@ @@  @@                  \r\n             @   @@  @   @                 @           @@  @@@@@  @@    @@@       @@           @@@@@@@@@@@@@                    @@   @   @  @@                  \r\n             @   @@  @   @                 @@@@@@@@@@@@@@@      @@@@@@          @@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@@@@      @@@@@@@@@@@@@@@@@@@@@@             \r\n             @   @@  @   @  @    @ @@@    @@@@@@@@@@@@@@ @@@@@@    @@             @         @  @           @      @   @      @@                   @             \r\n           @@@@@@@@@@@@@@@@@@@   @   @@    @           @ @@         @@            @         @  @           @      @   @@     @@         @@@@@@@@@@@             \r\n          @@                @@   @ @ @@    @           @ @@         @@            @         @  @           @      @ @ @@     @@@@@@@@           @@              \r\n          @@@@@@@@@@@@@@@@@@@@   @ @ @@    @@          @  @@@@@@@@@@@@@           @@@@@@@@@@@  @           @     @@ @ @@      @                 @@              \r\n          @@               @@    @ @ @@    @@          @           @@@@@@@@@@@@@@@@@           @@@         @     @@ @ @@      @                 @@              \r\n           @                @    @ @ @@    @@         @@@@@@@@@        @@@@@@@@@      @@@@@@@@@@    @@@@@@@@     @@ @ @       @                 @@              \r\n           @                @    @ @ @@    @@@@@@@@@@@@@            @@@@       @@@            @@@@@@@@@@@@@@     @@ @ @       @                 @               \r\n           @                @    @ @ @@    @@         @@           @@            @@           @@          @@     @@ @@@   @  @@@@@@@@@@@@@@@@@@@@@              \r\n          @@ @@         @@@@@@   @ @ @@    @@@@@@@@@@@@@          @@              @@          @@          @@     @@@@@@@@@@@@@@@@@              @@              \r\n          @@      @@@       @@   @ @ @@    @@         @@         @@                @@         @@          @@     @@@@@@  @@@@@@ @       @@@@@@@@@@              \r\n          @@                @@   @ @@@@    @@         @@        @@                  @@        @@          @     @  @@@@@@@     @@@@@@@  @@   @@                 \r\n           @@@@@@@@  @  @@@@    @@ @@@@    @@         @@       @@                    @@       @@          @   @@@@@            @@   @    @   @@                 \r\n             @@  @   @   @      @@ @@@@    @@         @@      @@                     @@       @@          @ @@               @@@    @    @   @@                 \r\n             @@  @   @   @      @@ @@@@    @@         @@      @                       @       @@          @@@           @@@@@@@@    @   @@   @@                 \r\n             @@ @@   @   @      @@ @@@@    @@         @@     @@                       @@      @           @@@@@@@@@@@    @@@@@@@    @   @@   @@                 \r\n             @@ @@   @   @      @@ @@@@    @@         @      @                        @@      @           @     @       @@@@@@@@    @   @@   @@                 \r\n             @@ @@   @   @      @@ @@@@    @@         @      @                        @@     @@          @@     @@@@    @@@@@@@@@@ @@   @@   @@@@               \r\n            @@  @@   @   @@@@@@@@@ @@@@    @@        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@          @@@@@@@@@  @@@@@       @@ @@   @@   @@  @@@@           \r\n         @@@ @  @@   @   @@    @@  @@@@@@@@@          @                                      @@          @@     @@@@            @  @@   @@   @        @@@       \r\n       @@@    @@@@@@@@@@@@     @@@@@@@@    @@  @@@@@@@@                                      @@@@@@@@@@@@@    @@              @@@@@@@@@@@@@@@            @@@@   \r\n    @@@                                                                                                       @@       @@@@@@@@                              @@@\r\n @@@                                                                                                           @@ @@@@@  @@@   @@                               \r\n@@                                                                                                              @       @       @@                              \r\n                                                                                                                @     @@         @                              \r\n                @@@@@@@@@@@@@@@@                                                                  @@@@@@@      @@     @           @                             \r\n                                                                                                       @@@    @@          @@@@@@@@@@           @@@@@@           \r\n                                                                                                              @                   @@                            \r\n                        @@                                                                                   @@                    @                            \r\n                                                                                        @@@@@@@@@            @      @              @@@                          \r\n                             @@@@@                                                                          @@      @              @                            \r\n                                                                                                          @@@      @@             @@                            \r\n       @   @                                                                                               @@      @              @@                            \r\n                                                                                                           @@     @@              @@                            \r\n                                                                                                           @      @               @                             \r\n                                                                                                          @@      @               @                             \r\n                                                                                                          @@      @              @                              ";
            string IneichmannLab = "     @@@@@@@@@@@@@@@@@@             @                      @@         @@@@@@@@@@@@@@@@@@@@@@@@      @@                                @@        @               \r\n     @@@@@@@@@@@@@@@@@@             @                      @@         @@@@@@@@@@@@@@@@@@@@@@@@      @@                                @@        @               \r\n     @@@@@@@@@@@@@@@@@@             @                      @@         @@@@@@@@@@@@@@@@@@@@@@@@      @@                                @@        @               \r\n     @@@@@@@@@@@@@@@@@@@            @                      @@  @@@     @@@@@@@@@@@@@@@@@@@@@@@      @@                                @        @@               \r\n     @@@@@@@@@@@@@@@@@@@            @                      @@@@@@@@    @@@@@@@@@@@@@@@@@@@@@@@      @@                               @@        @@               \r\n      @@@@@@@@@@@@@@@@@@@           @                      @@ @@@@@    @@@@@@@@@@@@@@@@@@@@@@@      @@                               @@        @@               \r\n      @@@@@@@@@@@@@@@@@@@@          @                      @@       @@@ @@@@@@@@@@@@@@@@@@@@@@      @@                               @@        @@               \r\n      @@@@@@@@@@@@@@@@@@@@@@        @                      @@        @   @@@@@@@@@@@@@@@@@@@@@      @@                               @@        @@               \r\n       @@@@@@@@@@@@@@@@@@@@@@      @@                      @@             @@@@@@@@@@@@@@@@@@@       @@                               @         @@               \r\n         @@@@@@@@@@@@@@@@@@@@@      @                      @@      @@@@    @@@@@@@@@@@@@@@@@        @@                              @@         @@               \r\n           @@@@@@@@@@@@@@@@@@@      @                      @@       @@@    @@@@@@@@@@@@@@@@         @@                              @@         @                \r\n             @@@@@@@@@@@@@@@@@      @@                     @                @@@@@@@@@@@@@@@         @@                              @@        @@                \r\n               @@@@@@@@@@@@@@@      @@                     @                @@@@@@@@@@@@@@          @@                              @@        @@                \r\n @@@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@@@@@@@@@@@@@@@@@@@@@@@       @@@@@@@@@@@@@@@@@@@@@@@@@@@@      @     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n                  @@@@@@@@@@@@       @                     @                @@@@@@@@@@@@@@           @             @@                                @@         \r\n@@                 @@@@@@@@@@@       @                     @                @@@@@@@@@@@@@@           @           @@                                @@           \r\n@@@@               @@@@@@@@@@@       @                     @                @@@@@@@@@@@@@@       @   @          @@                               @@     @       \r\n@@@@                @@@@@@@@@@       @                     @                @@@@@@@@@@@@@@      @@  @@         @@                              @@     @@        \r\n@@@@                @@@@@@@@@        @                     @@               @@@@@@@@@@@@@@     @@    @       @@                             @@@     @@@       @@\r\n@@                  @@@@@@@@@        @                     @@               @@@@@@@@@@@@@      @     @      @@                            @@@      @@        @@ \r\n                     @@@@@@@@        @                     @@               @@@@@@@@@@@@@     @@     @    @@                            @@@      @@        @@   \r\n  @@@                @@@@@@@         @                     @@               @@@@@@@@@@@@     @@      @   @@                           @@@      @@         @@    \r\n                      @@@@@          @                     @@                @@@@@@@@@@     @@       @  @@@@@@@@@@                  @@@      @@         @@      \r\n       @@@                           @                     @@                @@@@@@@@       @        @               @@@@@@@@     @@@      @@         @@@       \r\n       @@@                           @              @@@@@@@@@       @@@@@@@@@@@@@@         @@        @                          @@@      @@          @@         \r\n                                    @@             @@ @@  @@@                             @@         @                        @@@      @@          @@           \r\n                                 @@@@@           @@@ @@   @@@@@@                                   @@@                      @@@      @@           @@            \r\n@@@@@@@                     @@@@@@   @          @@  @@    @@@   @@@@@@@                         @@@@@@                    @@@      @@           @@              \r\n         @@@@@@@@@@@@@@@@@@         @@         @@  @@     @@@          @@@@@@@@@@@@@@@@@@@@@@@@@    @@                  @@@      @@@          @@@               \r\n                                    @@       @@   @@   @@@@@@                                       @@                @@@      @@           @@@                 \r\n                                   @@       @@   @   @@   @@@                                       @               @@       @@            @@                   \r\n                                @@@        @@  @@   @@      @@                                    @@              @@@     @@@            @@                     \r\n@@@@@@@                  @@@@@@@          @@   @   @@         @@@@@                           @@@@              @@      @@@            @@@                      \r\n        @@@@@@@@@@@@@@@@                 @   @@    @               @@@@@@@@@@@@     @@@@@@@@@@               @@@      @@@            @@@                        \r\n                                       @@    @    @                                                        @@       @@              @@                          \r\n                                      @@   @@    @@                                                      @@       @@@             @@                            \r\n                                     @@    @    @@                                                    @@@       @@@             @@           @@@@@@@@@@@@       \r\n                                   @@@   @@    @@                                                   @@@       @@@             @@                          @@@@@@\r\n                                  @@     @    @@                                                  @@@        @@             @@                                  \r\n                                 @@    @@    @                                                  @@@        @@             @@@                                   \r\n                               @@@     @   @@                                                 @@         @@@             @@                                     \r\n                              @@     @@   @@                                                @@         @@@             @@                                       \r\n                            @@      @@   @@                                               @@                          @@                                        ";
            string IneichmannLab2 = "        @@                                 @@                                                     @   @@                                            @         @@\r\n         @@                                @@                                   @                @@   @@                                          @@        @@@ \r\n          @@                               @@@@@@@@  @@@@@@@@@@@@       @@     @@@               @@   @@                                        @@@       @@@   \r\n@@          @@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@      @ @@@@@@@@@@              @@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        @@     \r\n  @@                                                      @@@   @    @@  @@    @@ @@             @@                                                    @@       \r\n   @@@                                                     @@   @   @@   @     @@  @@             @                                                  @@         \r\n     @@                         @@@@@@@@@@@@@@              @   @  @@   @@     @@   @@            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          @@@          \r\n      @@@@@@@@@@@@@@@@@@@@@@@@             @  @@@@@@@       @   @  @@   @@     @@   @@                  @                                 @@@@@@@@@             \r\n                                           @        @@     @@   @   @@  @@     @@  @@                   @                                                       \r\n                                           @        @@     @@  @@    @@ @@@@@@@@@ @@                   @@ @@                                                    \r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @        @@     @@  @@    @@ @@     @@@@                    @@                                                       \r\n                                                    @@     @@  @@      @@@     @@                      @@                                     @@@@@@@           \r\n                                                    @      @@  @@              @                       @@         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@    @@           \r\n                                                   @@      @@  @@                                      @ @@     @@                            @     @@@@@@@@@@@@\r\n                                                   @@      @@  @@                                     @@ @@   @@                              @    @@           \r\n@@@@@@@@@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@         @@      @    @                                     @@     @@                              @@    @@           \r\n                                          @@       @@      @    @@@@@@@@@@@@@@@@@@@@    @@@@          @@    @@                               @@    @@           \r\n                                           @       @    @@@@@@                                @@@@@@@@@@@   @                                @     @@           \r\n                                           @@@@@@@@@@@@@@                                        @@        @@            @@@@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@   \r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          @           @                                          @        @@         @@@                   @@     @@           \r\n                                   @@      @          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@       @@         @                      @@@@@@@            \r\n                                    @@     @         @@                                            @@      @          @                                         \r\n                                    @@     @        @@                                             @@     @@         @@                                         \r\n @@@@@@@@@@@@@@@@@@@@@@@@@@         @@     @       @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    @@         @                                          \r\n@                          @        @@    @@       @@                                                @    @@         @                                          \r\n                           @@       @@    @@      @@                                                 @@   @@        @@                                          \r\n                           @@       @@    @@     @@                                                   @   @@        @                                           \r\n                           @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@       \r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@               @                 @                                                              @@@                            @@@\r\n                    @@                       @               @@                                  @@                              @@                             \r\n                  @@                       @@                @                                 @@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                           \r\n                @@                         @                @@                                  @@                                   @@                         \r\n              @@@                        @@                @@                                    @@                                    @@                       \r\n             @@                          @                @@                                      @                                      @@@                    \r\n           @@     @@@@@@@@@@@          @@           @@@@@@@                    @@@@@@@@@@@@@@@@@@@@@                                       @@@                  \r\n         @@@                @@         @        @@@                            @@                  @@                                         @@                \r\n       @@@                 @          @        @@                              @@                   @@@                                         @@@             \r\n      @@                 @@          @        @@                               @@                     @                                           @@@           \r\n    @@                  @@          @         @                                @@                      @@                                           @@@         \r\n  @@@                  @@          @         @                                 @                        @                                             @@@       \r\n @@                  @@@         @@         @@                                 @                         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@       @@@     \r\n@                   @@          @@         @@                                  @                                                                   @@@@@@@@@@   \r\n                   @@          @@         @@                                   @                                                                            @@@ ";
            string Mobeichmann = "                                                                                                                                                                \r\n                                              @@@@@@@@@@@@@@@@@                                                                                                 \r\n                                        @@@@@                  @@                     @@  @@@@@@@@                                                              \r\n                                    @@@@                        @                    @@             @@@@@@@@@                                                   \r\n                                   @@                           @@                   @@                       @@@@@                                             \r\n                                   @                            @@                  @@                            @@                                            \r\n                                   @          @@@@@@@@@@@@@@@@@@@@                  @@@@@@@@@@                    @@                                            \r\n                                   @@   @@@@@                   @@   @@@@@@@@@@@   @@         @@@@@@@@            @@                                            \r\n                                   @@@@                         @@ @@           @@@@@                  @@@@@@     @@                                            \r\n                                    @@                        @@@@@@              @@ @@@                     @@@@ @                                             \r\n                                    @@                      @   @@@@          @@   @@@ @@                        @@                                             \r\n                                    @@                     @@@@@@@@        @@    @@@@@@@@@                       @                                              \r\n                                     @                  @@@@@@@@@@@     @@@@@    @@@@@@@@@@@@                    @                                              \r\n                                     @                   @@@@@@@@@@        @@@   @@@@@@@@@@@                    @@                                              \r\n                                     @@                   @@@@@@@@@           @@@@ @@@@@@@@                     @                                               \r\n                                      @                   @ @@@@@@@                @@@@  @@                    @@                 @@@@@@@@@@                    \r\n              @@@@ @@@@@              @@                 @@@@@@@@@@@              @@@@@@ @@                    @                @@@  @@ @@  @@                  \r\n            @@     @@   @@            @@@@@@@@@@@        @@   @@@@@@@            @@@@@    @                @  @@              @@@   @     @@ @@@                \r\n           @@   @@  @@   @           @@@   @    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@      @@     @@@@@@@@@@@@@@@@           @@  @@  @     @@ @@@@               \r\n          @@@   @@   @   @@         @@     @    @@              @@     @@     @    @@@@@@@@@@@@@     @@    @@    @@       @@@    @@ @@  @@@ @@  @@              \r\n         @ @@   @@  @@   @ @@@      @      @    @@             @@      @      @      @@              @@     @     @@     @@      @@@@       @     @@            \r\n       @@    @         @@    @@     @@    @@    @@            @@      @@      @      @@@             @@     @    @@    @@       @   @@@   @@       @@           \r\n      @@      @@     @@@@@    @@     @@@  @@    @@           @@       @@      @@       @@            @@     @@ @@@   @@       @@     @@@@           @@          \r\n    @@         @@@ @@    @@     @@      @@@@    @@          @@        @@      @@       @@             @    @@@@    @@@      @@        @@ @@          @@         \r\n   @@            @@@      @@     @@     @@  @@@@@@          @         @@      @@        @@      @@@@@@@@@@ @      @@      @@        @@     @@          @@       \r\n @@@            @@@@       @@     @@     @        @@@@@@@@@@@         @@      @          @@@@@@@           @    @@      @@       @@@        @@@         @@      \r\n @            @@   @@       @@      @@   @@         @@     @@         @@      @@         @@    @          @@  @@      @@       @@@            @@         @@     \r\n            @@       @        @@     @@   @      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     @@ @@      @@       @@@                @@         @@   \r\n          @@@        @@@       @@     @@  @@   @@@         @@               @             @@        @@@  @ @      @@       @@@                   @@         @@  \r\n         @@            @@       @@      @@@@ @@@          @@                @              @@          @@@@     @@       @@@                       @@        @@ \r\n       @@               @@       @@      @@ @@            @                 @               @@           @@    @@       @@                          @@        @ \r\n     @@                  @@       @@      @@             @@                 @                @            @@@@@       @@@                             @         \r\n    @@                    @@        @@    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@   @@ @@@@@@@@@@@@@       @@   @                             @@       \r\n  @@                     @@ @@       @@    @@                                                              @      @@@     @@                            @@      \r\n @@                     @@   @@       @@    @                                                             @@     @@        @@                            @@     \r\n                       @@      @       @@   @@                                                           @@    @@           @@                            @@    \r\n                      @@        @@      @@   @                                                           @   @@@              @@                           @@   \r\n                    @@           @@       @@ @@                                                          @  @@                 @@                           @@  \r\n                   @@             @@      @@@ @@                                                        @@ @@                   @@                           @@ \r\n                  @@                @@      @@@@                                                        @@@                      @@                           @ \r\n                 @@                  @@      @@@                                                        @@                        @@                            \r\n               @@                     @@      @@                                                       @@                           @                           \r\n                                                                                                                                                                ";
            string rubyEye = "                                                                                                                                                                \r\n        @@                                                                                                                                      @@              \r\n          @@                                                                                                                                  @@@               \r\n           @@@                                                                                                                              @@@                 \r\n             @@@            @@                                                                               @                                                  \r\n                @@         @                                                   @                              @@@                                               \r\n                         @@                                            @      @@                                @@            @@                                \r\n                         @          @     @@                    @@    @@@     @@@      @@                         @@           @@                               \r\n @@@                    @          @    @@                    @@@@    @@@     @@@      @@@                         @@           @@                              \r\n     @@@@              @          @@   @@                   @@@ @     @@@     @@@@     @@@@@                 @@     @            @@                             \r\n         @@@@         @@         @@   @@                   @@   @    @@@@     @@@@     @@  @@                 @@                  @@                 @@@@@@@@@@ \r\n                     @@          @    @                  @@     @    @ @@     @@ @@    @@    @@                @@                  @                            \r\n                     @          @@   @                 @@       @   @@@@       @@@@@   @@      @@               @@                  @                           \r\n                    @@          @@  @@                  @@     @@@@        @@      @@@ @@    @@                  @                  @@                          \r\n                   @@           @@  @@                  @@@@@ @@          @@@         @@@  @@@@                  @                  @@                          \r\n                   @@           @@  @@               @@@     @@          @@@@           @@@   @@                 @@                 @@                          \r\n                   @@           @@                 @@@        @         @@@@@@          @@     @@                                    @                          \r\n                   @@                           @@@          @@ @@@    @@@@@@@     @@@  @@       @@                                 @@                          \r\n                   @@                             @@        @@         @@@@@@@@          @@     @@                                  @@                          \r\n                                                  @@@       @@         @@@@@@@@          @@   @@@@@                                 @@             @            \r\n                                                @@   @@     @          @@@@@@@@          @@  @@    @@                               @@              @@@@@@@     \r\n                                              @@        @@ @@          @@@@@@@            @@@        @@@                            @                           \r\n      @@@@@@                              @@@             @@  @@@      @@@@@@@      @@     @@          @@                                                       \r\n                                          @@@             @ @          @@@@@@@            @@@@        @@                                                        \r\n                                             @@          @@@@@          @@@@@            @@@@@@      @@                                                         \r\n                              @@               @@@      @@ @@@@         @@@@@           @@@   @@   @@@               @                                          \r\n                              @@                  @@@@@@@    @@@@        @@@@          @@      @@ @@@@               @@                                         \r\n                              @@              @@@@    @@       @@@@@      @         @@@@            @@@              @                                          \r\n                               @                 @@@            @@@ @@@@@      @@@@@ @@         @@@@            @@   @                                          \r\n                               @                    @@@          @@   @@       @@   @@        @@@               @   @@                                          \r\n                               @@     @                @@@     @@@     @@     @@     @@@@@  @@                @@   @@                                           \r\n                          @@    @@    @@                  @@@@@        @@     @@      @@                     @@               @                                 \r\n       @@@                @@           @@                  @   @@@      @     @@    @@                      @@                @                    @@           \r\n   @@@@                    @            @@                        @@@   @     @@  @@@                     @@                 @@                      @@@@@@@@@@ \r\n @@                        @@             @@                        @@@ @@    @@ @@                     @@                 @@                                   \r\n                            @@              @@@                       @@@@    @ @@                                       @@@                                    \r\n                             @@                @                        @@    @@@                                      @@                                       \r\n                              @@                                              @@                                     @@                                         \r\n                @               @@@                                                                                                        @@                   \r\n               @                                                                                                                             @@                 \r\n             @@                                                                                                                                @@               \r\n           @@                                                                                                                                    @@             \r\n                                                                                                                                                                ";

            Console.SetCursorPosition(0, 0);
            Console.Write(eichmannLab1);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Console.Write(eichmannLab2);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Console.Write(eichmannLab3);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Console.Write(eichmannLab4);
            Thread.Sleep(500);
            #endregion

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase("저기가 아이히만의 연구소인것 같다.");
            print.next();

            print.PrintPhrase("파비안: 여! 여기야, 파트너!");
            print.next();

            Console.Clear();
            Console.Write(eichmannLab5);
            Thread.Sleep(500);
            back.Textbox();

            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("네가 오기 전에 주변을 미리 둘러봤는데, 다른 누군가의 기척은 느껴지지 않았어.");
            print.next();

            print.PrintPhrase("이제 슬슬 잠입해보자고. 저 안에서 무슨 일이 일어나고 있는지 알아야 하지 않겠어?");
            print.next();

            print.PrintPhrase("늘 그랬듯이 엄호는 나에게 맡기라고.");
            print.next();

            Console.Clear();
            Console.Write(IneichmannLab);
            Thread.Sleep(1000);
            back.Textbox();

            #region 연구소 스크립트
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("나는 앞을 가로막는 장애물을 하나하나 격파하며 전진하기 시작했다.");
            print.next();

            print.PrintPhrase("그런데 저 비커 안에 있는건...");
            print.next();

            print.PrintPhrase("파비안: (치지직-) 저 비커... 뭔가 수상한걸. 설마...");
            print.next();

            print.PrintPhrase("파직-");
            Thread.Sleep(1500);

            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("비커를 부수자, 안에 갇혀있던 사람들이 나타났다.");
            print.next();

            print.PrintPhrase("파비안: 젠장, 아이히만 박사가 생체 실험을 한다는 소문이 사실이었군.");
            Console.SetCursorPosition(cursorX, cursorY + 2);
            print.PrintPhrase("더 이상의 피해는 막아야 해. 어서 가보자고!");
            print.next();

            print.PrintPhrase("나는 막아서는 적을 해치우며, 함정을 돌파하며 계속해서 앞으로 내달렸다.");
            Console.SetCursorPosition(cursorX, cursorY + 2);
            print.PrintPhrase("아이히만 박사를 저지하고 루비아이를 탈환하기 위해서.");
            print.next();

            print.PrintPhrase("파비안: (치지직-) 이제 곧 아이히만 박사의 연구실이야. 아무래도 아이히만 박사는....(치직)");
            Console.SetCursorPosition(cursorX, cursorY + 2);
            print.PrintPhrase("이ㅂ....통신이...(치직-) 내 말 들ㄹ... 대답...!(뚝-)");
            print.next();

            Console.Clear();
            Console.Write(IneichmannLab2);
            Thread.Sleep(1000);
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase("아이히만 박사 : 나의 보물을 노리고 여기까지 온 거냐.");
            print.next();

            print.PrintPhrase("아이히만 박사 : 킬킬킬... 그분이... 세상을 바꿀 것이다!");
            print.next();

            print.PrintPhrase("아이히만 박사 : 나 아이히만의 연구가 세상을 바꿀 거란 말이다!");
            print.next();

            print.PrintPhrase("아이히만 박사 : 알아 들었나 애송이! 알아 들었으면... 도망쳐 봐.");
            print.next();

            print.PrintPhrase("아이히만 박사가 전투를 걸어왔다!");
            print.next();
            #endregion

            Console.Clear();
            Console.Write(Mobeichmann);

            Enemy eichmann = new Eichmann();
            player.PlayerFight(eichmann);

            Console.Clear();
            Console.Write(IneichmannLab2);
            Thread.Sleep(1000);
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase("성공적으로 아이히만 박사를 저지했다.");
            print.next();

            print.PrintPhrase("---! 아이히만 박사의 몸이...!");
            print.next();

            print.PrintPhrase("아이히만 박사의 몸은 뒤에 조용히 떠 있던 루비아이에게 흡수되었다.");
            print.next();

            print.PrintPhrase("도대체 얼마나 많은 사람들이 이것에게 희생당한 걸까...");
            print.next();

            Console.Clear();
            Console.Write(rubyEye);
            Thread.Sleep(1000);
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase("이것이 이번 이뢰의 목표다... 가지고 가야 한다.");
            print.next();

            print.PrintPhrase("?!");
            print.next();           

            print.PrintPhrase("루비아이에 접촉하자, 내 머릿속에 알 수 없는 속삭임이 흘러들어오기 시작했다.");
            print.next();

            print.PrintPhrase("너도...그분!@%!^의...힘을....!@^");
            print.next();

            print.PrintPhrase("!@#$%!@#%&어서..!#@$^&!. 우리와 함께...!!@#$^&!#");
            print.next();

            print.PrintPhrase("!@#$%깔깔깔깔깔깔깔깔깔깔깔깔깔깔깔@#%^@#%");
            print.next();

            print.PrintPhrase("...안돼.");
            print.next();

            print.PrintPhrase("나는 이런 곳에서 쓰러질 수 없다.");
            print.next();

            print.PrintPhrase("악마의 속삭임에 굴복할 수는 없다.");
            print.next();

            Console.Clear();
            Console.Write(IneichmannLab2);
            Thread.Sleep(1000);
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase("나는 속삭임을 이겨내고 가까스로 정신을 차렸다.");
            print.next();

            print.PrintPhrase("파비안 : (치직-) 뭐야, 이제 들리는 거야? 후우, 걱정했잖아.");
            print.next();

            print.PrintPhrase("파비안 : 정말 이상한 의뢰였네. 어서 복귀해.");
            Console.SetCursorPosition(cursorX, cursorY+2);
            print.PrintPhrase("오늘은 주점에서 한 잔 하자고.");
            print.next();

            print.PrintPhrase("...어서 연구소에서 나가자.");
            print.next();

            AfterEichmann(player);
        }

        public void AfterEichmann(Player player)
        {
            string Road = "                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                                                                                                                                \r\n                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                                   @@@                                                                            \r\n   @@@                                                                         @@  @                                                                            \r\n                                                                              @@   @                                  @@                                        \r\n                                                                             @@   @@                          @@                   @@@@@@@          @@@@@@@@@@@@\r\n                                                                            @@    @@                         @                                                  \r\n                       @    @      @                                      @@      @                         @                                                   \r\n                       @    @@     @                                    @@        @                         @                                                   \r\n                       @@   @@    @@                                  @@          @                        @@                                                   \r\n                       @@    @    @                                @@@            @                        @@                                                   \r\n                                                                 @@@             @@                        @@                                                   \r\n                                                               @@                @@                        @                                                    \r\n                                                             @@                  @@                        @                                                    \r\n                                                           @@                    @@                       @@                                                    \r\n                                                          @@                     @@                       @                                                     \r\n                                                         @@                      @@                      @@                                                     \r\n                                                       @@                        @@                     @@                                                      \r\n                                                      @@                         @@                     @                                                       \r\n                                                    @@           @@              @@                   @@                                                        \r\n                                                   @@            @@              @@                  @@                              @  @@       @@             \r\n                                                 @@              @@              @@                @@                                @   @@      @              \r\n                                              @@                 @@              @@              @@@                                 @                          \r\n                                           @@@                   @@              @@            @@                                                               \r\n        @                                @@@                     @@              @@          @@                                                                 \r\n    @@  @@     @@                       @@                       @@              @@         @                                                                   \r\n    @@  @@     @                      @@                         @               @@        @@                                                                   \r\n         @                           @@                          @               @@        @@                                                                   \r\n                                  @@@                            @               @@         @                                                                   \r\n                                @@@                              @               @@         @                                                                   \r\n                              @@                                 @               @@         @@                                                                  \r\n                            @@                                   @@              @@         @@                                                                  \r\n                         @@@                 @                   @@              @@         @                                                                   \r\n                       @@@                   @                   @               @@        @@                                                                   \r\n                     @@                      @                   @               @@       @@                                                                    \r\n                   @@                        @                                   @@     @@                                                                      \r\n                 @@                          @                                   @@   @@                                                                        \r\n               @@                            @                                   @@@@@                                                                          \r\n             @@                              @                                  @@@                                                                             ";

            Console.Clear();
            Console.Write(Road);
            Thread.Sleep(2000);

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("나와 파비안은 연구소에서 탈출하여 토트리치로 향했다.");
            print.next();

            print.PrintPhrase("파비안: 그래서, 그 루비아이를 만져도 넌 아무렇지 않은 거야?");
            Console.SetCursorPosition(cursorX, cursorY + 2);
            print.PrintPhrase("거 참 대단한 정신력이군.");
            print.next();

            print.PrintPhrase("파비안: 도대체 얼마나 많은 민간인이 희생당한건지... 알 수가 없... 잠깐, 저 앞에..!");
            print.next();

            print.PrintPhrase("--!");
            print.next();

            print.PrintPhrase("수많은 악마 무리가 나타나 길을 가로막기 시작했다..!");
            print.next();

            print.PrintPhrase("파비안: 루비아이를 노리는 건가..! 달려! 어서!");
            print.next();

            print.PrintPhrase("파비안과 나는 앞길을 막는 악마를 하나 둘 처치하며 앞으로 달려나가기 시작했다.");
            print.next();

            print.PrintPhrase("파비안 : 젠장, 수가 너무 많아..! 이대로 가다간...! 잠깐, 너 뭐하는 거야!");
            print.next();

            print.PrintPhrase("나는 파비안에게 루비아이를 맡기고 등을 밀쳤다.");
            print.next();

            print.PrintPhrase($"{player.Name}: 여긴 내가 막고 있을 테니, 먼저 의뢰를 완수하러 가. 어서!");
            print.next();

            print.PrintPhrase("파비안: 뭐...?! ...젠장. 사람들을 불러올 테니, 살아만 있으라고! ");
            print.next();

            print.PrintPhrase("파비안을 보낸 후 나는 남은 악마들을 상대하기 시작했다.");
            print.next();

            print.PrintPhrase("젠장... 수가 점점 많아지고 있다. 파비안이 올 때까지 버틸 수 있을까.");
            print.next();

            print.PrintPhrase("--!");
            print.next();

            print.PrintPhrase("결국 벼랑 끝까지 내몰린 나는 공격의 여파로 절벽 밑으로 떨어지고 말았다.");
            print.next();

            print.PrintPhrase("안돼... 파비안..!");
            print.next();

            Console.Clear();
            Thread.Sleep(3000);

            player.Progress = 1;
            secondEkforn(player);
        }

        public void secondEkforn(Player player)
        {
            player.HP = 100;
            player.MP = 20;
            player.Silling += 2000;
            string Openeye = "                    @@      @@   @@                                      @      @@                                                                              \r\n                    @@      @@@  @@                                      @      @@                                                                              \r\n                    @@      @@@  @@                                      @@     @@                                                                              \r\n                    @       @@@  @@                                      @@     @@                                                                              \r\n                    @       @@@  @@                                  @@@@@@     @@                                                                              \r\n                    @       @@@  @@                               @@@@@@@@@@@@@ @@                                                                              \r\n                    @@       @@  @@@                          @@@@@@@   @@    @@@@                                                                              \r\n                    @@       @@   @@                          @    @@  @@@@@@@@@@@                                                                              \r\n                    @@       @@   @@                          @    @@  @@@@@@@@@@@                                   @@@@@@@@@@@@@@@@@@                         \r\n                    @@       @@   @@                          @    @@@  @@    @@@@                                  @@@@@@@@@@@@@@@@@@@@                        \r\n   @@@@@@@@@@@      @@       @@   @@                          @     @@@@@@@@@@@@@@@@@@                               @ @@             @@                        \r\n@@@@@@   @@@@@@     @@       @@   @@                   @@@@@@@@@@@@@@@@@@@      @@@@ @                               @ @@             @@                        \r\n@@@@@@@@@@@  @@@    @@       @@   @@              @@@@@@                     @@@@  @@@                               @ @@             @@                        \r\n         @@  @@@    @@       @@   @@         @@@@@@                        @@@@ @@@@@                                @@@@@@@@@@@@@@@@@@                         \r\n         @@  @@@     @@      @@   @@    @@@@@@                           @@@  @@@  @@                                 @ @@          @@                          \r\n @@@     @@@@@    @@@@@@     @@   @@@@@@@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@@@    @@                                 @ @@          @@                          \r\n@@@@@@@@@@@ @@@@@@@    @@    @@  @@@@@@@@@@@@@@@@@@@@@@  @             @@@@@       @@                                 @ @@          @@                          \r\n         @  @@         @@    @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           @                                @@ @@          @@                          \r\n         @@ @@         @@@@@@@@@@@ @@@ @@                   @@@@@@@@@@@@@@@@@@@@@@  @                                 @ @@          @@                          \r\n         @@ @@         @@@   @@@   @@@ @@         @@@@@@@@@@@@@@@               @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @ @@         @@@                          \r\n         @@ @@@        @@          @@@@@@@@@@@@@@@@@                            @@@@@@@@@@@                         @@@ @@         @@@                          \r\n         @@ @@@@@@@@@@@@@@@@@@@@@@@@@@            @@                            @@                                  @@@ @@         @@@                          \r\n         @@  @@@@                                 @@                            @@                                  @@@ @@@        @@                           \r\n         @@  @@@@                                 @@                            @@                                  @@@ @@@        @@                           \r\n         @@  @@@@                                 @@                            @@                                  @@@@@@@        @@                           \r\n         @@  @@@@                                 @@                            @@                                  @@ @@@@@@@@@@@@@@@                          \r\n          @  @@@@                                 @@                            @@                                  @@              @@@                         \r\n          @ @@@@@                               @@@@@              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@               @@                         \r\n@@@@@@@@@@@@@  @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@         @@@@                                @@@@             @@                         \r\n          @@   @@@@@@@@@@@@                    @@     @@                     @@@@  @@                                  @@@           @@                         \r\n          @@@@@@                               @@@     @@@@                 @@@ @@@@@                                    @@@@@@@@@@@@@@                         \r\n          @@@@                                  @@@      @@@               @@     @@@                                     @@@@@@@  @@                           \r\n        @@@                                     @@@@@@     @@            @@@        @@                                       @@@   @@                           \r\n@@@@@@@@@                                      @@@   @@@@   @@@         @@           @@                                        @@@ @@                           \r\n   @@@@                                      @@@        @@@   @@      @@@    @@@@@@@@@@                                          @@@@                           \r\n @@@                                        @@           @@@   @     @@@   @@@       @@@                                           @@@                          \r\n@@                                         @@             @@@@@@     @@@ @@            @@                                           @@@@                        \r\n                                         @@@               @@@         @@@              @@                                            @@@                       \r\n                                        @@                  @@         @@@              @@@                                             @@@                     \r\n                                       @@                    @@       @@@                @@                                               @@@                   \r\n                                      @@                @@@@@@@@@@@@@@@@@@@@@@@@         @@                                                 @@@                 \r\n                                  @@@@@         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@  @@@@@@   @@@@@                                                @@@@               \r\n                                @@@@@      @@@@@@@                         @@@@@@@ @@@@@@@  @@@                                                @@@              \r\n                              @@@       @@@@@                                    @@@@  @@@    @@                                                 @@@            ";

            Console.Clear();
            Console.Write(Openeye);
            Thread.Sleep(2000);

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("...여긴? 사무소..?");
            print.next();

            print.PrintPhrase($"크라테르의 사제 : 눈을 뜨셨군요. 절벽 밑에 쓰러져 계시던 {player.Name}님을 제가 구조하여 모시고 왔습니다.");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 상처가 컸는데... 눈을 뜨셔서 정말 다행입니다.");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 이제 정신을 차리신 분께는 전달하기 염려스럽습니다만... 좋지 않은 소식이 있습니다.");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 파비안이 루비아이에 현혹되어... 민간인을 납치하고 생체 실험을 자행하고 있습니다.");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 마치 아이히만 박사 때 처럼...");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 해결사님. 부디... 파비안을 제압하고 루비아이를 탈환하는 것을 도와주시지 않으시겠습니까?");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 더 이상 피해가 커지는 것은 위험합니다.");
            print.next();

            print.PrintPhrase("....파비안이...");
            print.next();

            print.PrintPhrase(".......");
            print.next();

            print.PrintPhrase("나는 조용히 고개를 끄덕였다.");
            print.next();

            print.PrintPhrase("내 친구의 명예를 더럽히게 한 악마를... 용서할 수 없다.");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 오 크라테르시여... 정말 감사합니다.");
            print.next();

            print.PrintPhrase("크라테르의 사제 : 파비안은 납치당한 사람들을 데리고 크라테르의 사원으로 향했다고 합니다.");
            Console.SetCursorPosition(cursorX, cursorY + 2);
            print.PrintPhrase("준비를 마친 후 크라테르의 사원으로 와 주십시오. 저 또한 바로 출발하겠습니다.");
            print.next();

            print.PrintPhrase("준비를 마치고 크라테르의 사원으로 향하자.");
            print.next();

            Totrich(player);
        }       
    }
}

