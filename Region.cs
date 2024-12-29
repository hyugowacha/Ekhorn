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
    class Region
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

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("게오르그 : 뭐야, 두고 간 물건이라도 있어? 파비안이 기다릴테니 어서 가보라고.");
            print.next();

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
                            print.PrintPhrase("게오르그, 파비안, 내가 일하는 용병 사무소다.");
                            Console.SetCursorPosition(cursorX, cursorY + 2);
                            print.PrintPhrase("일상은 반복될것이다. 늘 그랬듯이.");
                            print.next();
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
                            if (player.Invenlist.Count > 7)
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

                            else if (player.Silling < 500)
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

                            else if (player.Silling < 500)
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

            Console.SetCursorPosition(0, 0);
            print.printindex();
            Console.Write(Load);
            Thread.Sleep(2000);
            

        }

        public void EichmannLab(Player player)
        {

        }
    }
}

