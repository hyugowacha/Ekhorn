﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
     partial class Intro
    {
        static Player player;
        string Playername;
        backgroundManager back = new backgroundManager();
        int cursorX = 12;
        int cursorY = 34;

        #region imageSource

        string Openeye = "                                                                                                                                                                \r\n                                                                                                                                                                \r\n                     @@      @@@   @                                     @@     @@                                                                              \r\n                     @@      @@@   @                                     @@     @@                                                                              \r\n                     @@      @@@   @                                     @@     @@                                                                              \r\n                     @@      @@@   @                                     @@     @@                                                                              \r\n                     @@      @@@   @                                @@@@@@@ @@  @@                                                                              \r\n                     @@       @@   @@                          @@@@@@   @@@@@@@@@@                                                                              \r\n                     @@       @@   @@                         @@    @  @@      @@@                                                                              \r\n                     @@       @@   @@                         @@    @  @@@@@@@@@@@                                   @@@@@@@@@@@@@@                             \r\n                     @@@      @@   @@                         @@    @@  @@    @@@@                                 @@@@@@@@@@@@@@@@@@@@                         \r\n     @@@@@@@@@@@     @@@      @@   @@                         @@    @@@@@@@@@@@@@@@@@@                             @@ @@             @@                         \r\n  @@@@@@   @@@@@@    @@@      @@   @@                  @@@@@@@@@@@@@@@@@@@      @@@  @                              @ @@             @@                         \r\n  @@@@@@@@@@   @@     @@      @@   @@              @@@@@                     @@@@  @@@                              @ @@             @@                         \r\n           @@  @@     @@      @@   @@        @@@@@                         @@   @@@@@                                @@@@@@@@@@@@@@@@                           \r\n           @@ @@@     @@@     @@   @@  @@@@@@                           @@@  @@@   @@                                @ @@          @@                           \r\n  @@@@@@@@@@@@@@ @@@@@@ @@    @@   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     @@                                @ @@          @@                           \r\n           @  @@@@      @@    @@  @@                                   @@@@        @@                               @@ @@          @@                           \r\n           @  @@        @@    @@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@            @                                @ @@         @@@                           \r\n           @@ @@        @@@   @@@@  @@@ @@          @@@@@@@@@@@@@@              @@  @                                @ @@         @@                            \r\n           @@ @@        @@          @@@@@@@@@@@@@@@@                            @@@@@@@@@@@                        @@@ @@         @@                            \r\n           @@ @@ @@@@@@@@@@@@@@@@@@@@@@            @                            @@                                 @@@ @@         @@                            \r\n           @@ @@@@                                 @                            @@                                 @@@ @@@        @@                            \r\n           @@ @@@@                                 @                            @@                                 @@@ @@@        @@                            \r\n           @@  @@@                                 @                            @@                                 @@@@@@@        @@                            \r\n           @@  @@@                                 @@                           @@                                 @@  @@@@@@@@@@@@@@                           \r\n           @@  @@@@                                @@                           @@                         @@@@@@@@@@              @@                           \r\n           @@@@@ @@                     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@     @@@@             @@                           \r\n  @@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@@@@@@@@@  @@@    @@@                     @@@@@@@                                @@@            @                           \r\n            @@ @@@                              @@      @@                   @@ @@  @                                  @@@          @@                          \r\n            @@@@                                 @@       @@               @@@    @@@                                    @@@@@@@ @@@                            \r\n          @@@                                    @@@@@@     @@           @@@        @@                                     @@@   @@@                            \r\n  @@@@@@@@@                                     @@    @@@@   @@@        @@@          @@                                       @@@@@@                            \r\n    @@@@                                      @@@        @@   @@@      @@    @@@@@@@@@@                                         @@@@                            \r\n   @@                                       @@@            @   @@    @@@   @@         @@                                          @@@                           \r\n  @                                        @@@              @@@@      @@@@@            @@                                           @@@                         \r\n                                          @@                @@          @@              @@                                            @@@                       \r\n                                         @@                  @@        @@                @@                                             @@@                     \r\n                                       @@@                    @@@@@@@@@@@@@@@            @@                                               @@@                   \r\n                                      @@@           @@@@@@@@@@@@@@@@@@@@@@    @@@@@     @@@@                                                @@                  \r\n                                 @@@@@@      @@@@@@                        @@@@@@@ @@@@@@@ @@@                                                @@                \r\n                               @@@       @@@@@                                   @@@   @@@    @@                                               @@@              \r\n                                                                                                                                                                \r\n                                                                                                                                                                ";
        string Openeye2 = "                                                                                                                                                                \r\n                     @       @@   @@                                     @@     @@                                                                              \r\n                     @@      @@   @@                                     @@     @@                                                                              \r\n                     @@      @@   @@                                     @@     @@                                                                              \r\n                     @       @@   @@                                     @@     @@                                                                              \r\n                     @       @@   @@                                 @@@@@@     @@                                                                              \r\n                     @@      @@   @@                             @@@@   @@@@@@@ @@                                                                              \r\n                     @@      @@   @@                          @@   @@  @@@    @@@@                                                                              \r\n                     @@      @@   @@@                         @@   @@ @@@@@@@@@@@@                                                                              \r\n                     @@      @@   @@@                         @@   @@   @@    @@@@                                  @@@@@@@@@@@@@@@@@@@                         \r\n                     @@      @@   @@@                         @@    @@   @@   @@@@@@@@                              @@@@             @@@                        \r\n @@@@@@@@@@@@@@@     @@      @@    @@                     @@@@@@@@@@@@@@@@@@@@@@@@@@@@                              @@@@             @@                         \r\n @@@@@@@@@@@@ @@     @@      @@    @@                @@@@@@@@@@@@              @@@  @@                              @@@@@            @@                         \r\n          @@  @@     @@       @    @@           @@@@@@                      @@@@ @@@@                               @@@@@      @@@@@@@@                         \r\n          @@  @@@    @@@      @    @@     @@@@@@@                         @@@  @@@ @@                                @@@@@@@@@@@@@@@@                           \r\n          @@@@@      @@@@     @@   @@@@@@@@                            @@@  @@@    @@                                @@ @@          @                           \r\n @@@@@@@@@@@@@@ @@@@   @@     @@  @@@@@@@@@@@@@@@@@@@@@@ @@            @@@@@       @@                                @@ @@          @                           \r\n          @  @@@       @@@    @@ @@@@@@@@@@@@            @@@@@@@@@@@@@@@@@          @                                @@ @@          @                           \r\n          @@ @@        @@@@@@@@@@@@ @@ @@                        @@@@@@@@@@@@@@@@   @                                @@ @@         @@                           \r\n          @@ @@        @@@@   @@@   @@ @@          @@@@@@@@@@@@@@               @@  @ @  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@         @@                           \r\n          @@ @@@       @@@          @@@@@@@@@@@@@@@@                            @@@@@@@@@@@                        @@@@ @@         @@                           \r\n          @@ @@@@@@@@@@@@@@@@@@@@@@@@@@           @@                            @@                                 @@@@ @@         @@                           \r\n          @@ @@@@@                                @@                            @@                                 @@@@ @@         @@                           \r\n          @@ @@@@@                                @@                            @@                                 @@@@ @@         @@                           \r\n          @@  @@@@                                @@                            @@                                 @@@@@@@         @@                           \r\n          @@  @@@@                                @@@                           @@                                 @@@ @@@@@@@@@@@@@@                           \r\n           @  @@@@                                @@@                           @@                                 @@@              @@                          \r\n           @@@@ @@                               @@@@@             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@              @@                          \r\n @@@@@@@@@@@@   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    @@@                       @@@@@@                                @@@            @@                          \r\n           @@  @@@                              @      @@                    @@@    @                                  @@@          @@                          \r\n           @@@@@                                @@      @@@@                @@   @@@@                                    @@@@@@@@@@@@@                          \r\n          @@@                                    @@@       @@             @@@      @@@                                     @@@    @@                            \r\n       @@@@                                     @@@@@@@@    @@@          @@          @                                       @@@  @@                            \r\n @@@@@@@@                                     @@@       @@   @@@       @@@    @@@@@@@@@                                        @@@@@                            \r\n   @@@                                       @@          @@@   @@     @@@   @@@     @@@                                          @@@                            \r\n @@@                                        @@            @@@ @@@    @@   @@          @@                                           @@@                          \r\n                                          @@@              @@@@       @@@@@            @@@                                           @@@                        \r\n                                         @@                 @@          @@              @@@                                            @@@                      \r\n                                        @@                   @@       @@@                @@                                              @@@                    \r\n                                       @@                    @@@@@@@@@@@@@@@@@@          @@                                                @@@                  \r\n                                   @@@@@         @@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@@@@@    @@@@@                                                @@                 \r\n                                @@@@@@      @@@@@@@                        @@@@@@@ @@@@@@@  @@@                                               @@@               \r\n                              @@@@       @@@@                                    @@@   @@@    @@                                                @@@             \r\n                                                                                                                                                                ";
        string Openeye3 = "                    @@      @@   @@                                      @      @@                                                                              \r\n                    @@      @@@  @@                                      @      @@                                                                              \r\n                    @@      @@@  @@                                      @@     @@                                                                              \r\n                    @       @@@  @@                                      @@     @@                                                                              \r\n                    @       @@@  @@                                  @@@@@@     @@                                                                              \r\n                    @       @@@  @@                               @@@@@@@@@@@@@ @@                                                                              \r\n                    @@       @@  @@@                          @@@@@@@   @@    @@@@                                                                              \r\n                    @@       @@   @@                          @    @@  @@@@@@@@@@@                                                                              \r\n                    @@       @@   @@                          @    @@  @@@@@@@@@@@                                   @@@@@@@@@@@@@@@@@@                         \r\n                    @@       @@   @@                          @    @@@  @@    @@@@                                  @@@@@@@@@@@@@@@@@@@@                        \r\n   @@@@@@@@@@@      @@       @@   @@                          @     @@@@@@@@@@@@@@@@@@                               @ @@             @@                        \r\n@@@@@@   @@@@@@     @@       @@   @@                   @@@@@@@@@@@@@@@@@@@      @@@@ @                               @ @@             @@                        \r\n@@@@@@@@@@@  @@@    @@       @@   @@              @@@@@@                     @@@@  @@@                               @ @@             @@                        \r\n         @@  @@@    @@       @@   @@         @@@@@@                        @@@@ @@@@@                                @@@@@@@@@@@@@@@@@@                         \r\n         @@  @@@     @@      @@   @@    @@@@@@                           @@@  @@@  @@                                 @ @@          @@                          \r\n @@@     @@@@@    @@@@@@     @@   @@@@@@@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @@@@    @@                                 @ @@          @@                          \r\n@@@@@@@@@@@ @@@@@@@    @@    @@  @@@@@@@@@@@@@@@@@@@@@@  @             @@@@@       @@                                 @ @@          @@                          \r\n         @  @@         @@    @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           @                                @@ @@          @@                          \r\n         @@ @@         @@@@@@@@@@@ @@@ @@                   @@@@@@@@@@@@@@@@@@@@@@  @                                 @ @@          @@                          \r\n         @@ @@         @@@   @@@   @@@ @@         @@@@@@@@@@@@@@@               @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ @ @@         @@@                          \r\n         @@ @@@        @@          @@@@@@@@@@@@@@@@@                            @@@@@@@@@@@                         @@@ @@         @@@                          \r\n         @@ @@@@@@@@@@@@@@@@@@@@@@@@@@            @@                            @@                                  @@@ @@         @@@                          \r\n         @@  @@@@                                 @@                            @@                                  @@@ @@@        @@                           \r\n         @@  @@@@                                 @@                            @@                                  @@@ @@@        @@                           \r\n         @@  @@@@                                 @@                            @@                                  @@@@@@@        @@                           \r\n         @@  @@@@                                 @@                            @@                                  @@ @@@@@@@@@@@@@@@                          \r\n          @  @@@@                                 @@                            @@                                  @@              @@@                         \r\n          @ @@@@@                               @@@@@              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@               @@                         \r\n@@@@@@@@@@@@@  @@  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    @@@@@@@@@@@@@@@@@@         @@@@                                @@@@             @@                         \r\n          @@   @@@@@@@@@@@@                    @@     @@                     @@@@  @@                                  @@@           @@                         \r\n          @@@@@@                               @@@     @@@@                 @@@ @@@@@                                    @@@@@@@@@@@@@@                         \r\n          @@@@                                  @@@      @@@               @@     @@@                                     @@@@@@@  @@                           \r\n        @@@                                     @@@@@@     @@            @@@        @@                                       @@@   @@                           \r\n@@@@@@@@@                                      @@@   @@@@   @@@         @@           @@                                        @@@ @@                           \r\n   @@@@                                      @@@        @@@   @@      @@@    @@@@@@@@@@                                          @@@@                           \r\n @@@                                        @@           @@@   @     @@@   @@@       @@@                                           @@@                          \r\n@@                                         @@             @@@@@@     @@@ @@            @@                                           @@@@                        \r\n                                         @@@               @@@         @@@              @@                                            @@@                       \r\n                                        @@                  @@         @@@              @@@                                             @@@                     \r\n                                       @@                    @@       @@@                @@                                               @@@                   \r\n                                      @@                @@@@@@@@@@@@@@@@@@@@@@@@         @@                                                 @@@                 \r\n                                  @@@@@         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@  @@@@@@   @@@@@                                                @@@@               \r\n                                @@@@@      @@@@@@@                         @@@@@@@ @@@@@@@  @@@                                                @@@              \r\n                              @@@       @@@@@                                    @@@@  @@@    @@                                                 @@@            ";
        string EkhornOffice = "                         @                           @ @              @ @@                                  @      @      @                          @@         \r\n                      @@@@@@                         @ @             @@ @@                                 @@     @@      @@                         @@         \r\n                       @ @@@                         @ @              @@@@  @@@@@@                         @@     @@      @                          @@         \r\n                       @@@@@                      @@@@@@@@@@@@@@@@@@@@@@@@@@     @@@@@@@@                  @@     @@      @                          @@         \r\n                       @@@  @@@@@@@@@@@@@@@@@@@@@   @@                @@@@@@@@@@@          @@@@@@@@@@      @@     @@      @                         @@@@@@@@@@  \r\n                       @ @@@@@  @@               @@@@@@@@@@@@@@@@@@@@@@@@@  @@@@@@@@@@@           @@@@@@@  @@     @@      @                     @@@@          @@\r\n                       @ @@@@@@@@@@@@ @@@@@@         @@@              @@@@           @@@@@@@@@@@@@@@       @@     @       @                     @@            @@\r\n                       @ @@@@   @@ @                 @@@@             @@@@            @@@@       @@@        @     @       @                     @@            @@\r\n                       @ @@@@   @@ @                 @@@@             @@@@            @@ @@      @@@        @     @       @                     @@            @@\r\n                       @@@@@@   @@ @                 @@@@             @@@@            @@ @@       @@@       @     @       @                     @            @@@\r\n@                      @@ @@@   @@ @@                @@@@             @@@@            @@@@        @@@       @     @       @       @@@@@@@@@@@@@@@@          @@  \r\n                       @@ @@@@   @ @@               @@@@@             @@@@            @@@@   @@@@@@@@       @     @       @ @@@@@@               @@@@@@@@@@@    \r\n                       @@ @@@@@@@@ @@@ @@@@@@@@@@@@@@@@@@             @@@@@@@@       @@@@@@@@      @@       @     @       @ @     @@@@@@@                     @@\r\n                  @@@@@@@@@@@@@@@@  @@@@@  @@@@@@@@@@@@@@  @@@@@@@@@            @@@@@@@@@@@        @@       @@    @       @  @@@@@@      @@@@@@@@  @@@@@@@@@@   \r\n          @@@@@@@@@@@@@@@@@@@@   @  @@@@@@@          @@@@@@                          @@   @@@      @@       @@    @       @   @@ @@@@@@@@@@@     @@@       @@@@@\r\n@@@@@@@        @   @@      @ @   @@ @@               @@@@      @@         @@          @@    @@     @@       @@    @   @@  @   @@ @@         @@@@@@@@@@@@@@@     \r\n                     @@    @ @   @@  @               @@@@     @@         @@            @@   @@      @       @@ @@@ @@@  @@@@@@@@ @@             @@ @@           \r\n                      @@@@ @ @    @  @               @@@@@   @@          @@            @@@@@@@      @       @@@   @@@     @@  @@@@              @@ @@           \r\n                    @@@@@@@@@@@@@@@  @               @@@@ @@@@@@@@@@@@ @@@           @@@@@  @@@@@@@@@      @@       @@     @@   @@              @@@@@           \r\n      @@@@@@@@@@@@@@ @@@@@@@@@@@@@@@ @             @@@@@@@@@@@@@      @@ @@@@@@@@@@@@@ @@  @@@     @@@@@@@@   @@@@@    @    @@@  @@             @@@@            \r\n@@@@@@               @@          @@@ @    @@@@@@@@@          @@@@@@      @@            @@@@@      @@@              @@  @@@@@@@@@@@@ @@@@         @@@            \r\n            @@@@@@@@@@             @@@@@@@                         @@@@  @@          @@@            @              @@@@         @@@@    @@@@@@@                 \r\n@@@@@@@@@@@        @@@               @                                     @@@@@@@@@@@                  @@@@@ @@@@        @@@@@                 @@@@@@          \r\n                   @@                @@                                                                             @@@@@@                       @@@@@          \r\n                   @@                @@                                                                       @@@@@@@                     @@@@@@@               \r\n                   @@                @@                                                                   @@@@                      @@@@@@                      \r\n                    @@               @                                                              @@@@@@                    @@@@@@                            \r\n                     @@             @@                                      @@@@@@@            @@@@@                    @@@@@@                                  \r\n               @@@@@@@@@            @@                                  @@@@      @@@@@@      @@@                 @@@@@@                                        \r\n      @@@@@@@@@        @@          @@                               @@@@                @@@@@@  @@@@         @@@@@                                              \r\n@@@@@@@                 @@@@@@@@@@@                        @@@@    @@                         @@@@@@@@@@@@@@@                                                   \r\n                                           @@@@@@@@@@@@@@@@   @@@  @@@@@                             @@  @                                                      \r\n                             @@@@@@@@@@@@@@                    @@@     @@@@@@@                     @@@                                                          \r\n                   @@@@@@@@@@@                                   @@          @@@@@@@@@           @@@                                                            \r\n           @@@@@@@@                                               @@      @@@@@@@     @@@@@@@ @@@                                                               \r\n @@@@@@@@@@                                                        @@@@@@@                   @@                                                                 \r\n@                                                                    @@                                                                                         \r\n                                                                      @@                                                                                        \r\n                                                                       @@                                                                                       \r\n                                                                        @@                                                                                      \r\n                                                                         @@@                                                                                    \r\n                                                                           @@                                                                                   \r\n                                                                            @@                                                                                  ";

        #endregion


        public void CreatePlayer()
        {
            Console.SetCursorPosition(70, 20);
            print.PrintPhrase("나의 이름은?\n");
            Console.SetCursorPosition(50, 22);
            print.PrintPhrase("(아무것도 입력하지 않을 시 기본 이름으로 생성됩니다.)\n");

            Console.SetCursorPosition(72, 25);
            Playername = Console.ReadLine();
            
            if(Playername == null)
            {
                player = new Player(100, 20, 10);
            }

            else
            {
                player = new Player(100, 20, 10, Playername);
            }            
            
            Thread.Sleep(1000);

            StartAtEkhorn();
        }

        public void StartAtEkhorn()
        {
            

            
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 0);
            Console.Write(Openeye);
            Thread.Sleep(500);
            print.printindex();

            Console.Write(Openeye2);
            Thread.Sleep(500);
            print.printindex();

            Console.Write(Openeye3);
            Thread.Sleep(1000);

            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase(".......");
            print.next();

            print.PrintPhrase("무슨 꿈이었던 걸까. 잘 기억이 나지 않는다.");
            print.next();

            print.PrintPhrase("파비안은 지금 사무소에 없는 것 같다. 책상 위에 쪽지가 있는 것 같으니 확인해보자.");
            print.next();

            Console.SetCursorPosition(0, 0);
            print.printindex();

            Console.Write(EkhornOffice);
            FabienNote();

            print.PrintPhrase("쪽지 옆에 있는 이 총이 에크혼 알파인 것 같다. 가져가자.");
            print.next();

            print.PrintPhrase("사무소를 나가 충분한 준비를 한 후 아이히만 박사의 연구소로 출발하자.");
            print.next();

            print.PrintPhrase("'에크혼 알파'를 획득하였습니다.");
            print.next();
        }

        public void FabienNote()
        {
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);

            print.PrintPhrase("여! 이 쪽지를 읽고 있다면 드디어 잠에서 깨어났다는 뜻이겠지.");
            print.next();

            print.PrintPhrase("새로운 의뢰가 들어와서 말이야. 난 미리 준비하러 나가야 할 것 같아.");
            print.next();

            print.PrintPhrase("최근 토트리치 근처에서 사람들이 실종되는 일이 발생하고 있다고 해.");
            print.next();

            print.PrintPhrase("이것이 아이히만 박사의 소행이고, 그 배후에 악마의 힘이 담긴 루비아이라는 물건이 있다는 정보가 들어왔어.");
            print.next();

            print.PrintPhrase("이 루비아이를 탈환하는 것이 이번 임무야.");
            print.next();

            print.PrintPhrase("꽤 어려운 의뢰라고는 하지만, 그만큼 보수는 짭짤하다고.");
            print.next();

            print.PrintPhrase("쪽지 옆에 이번에 만든 신작이 있으니까, 한번 확인해 봐!");
            print.next();

            print.PrintPhrase("이름하야 에크혼 알파! 베타랑 감마도 만들어 두었지. 하하...하!");
            print.next();

            print.PrintPhrase("...뭐, 이게 중요한 건 아니지만.");
            print.next();

            print.PrintPhrase("먼저 아이히만 박사의 연구실 근처로 가있을테니, 마을에서 충분한 준비가 끝나면 오도록 해.");
            print.next();

            print.PrintPhrase("빨리 끝내고 한 잔 하러 가자고.   -파비안");
            print.next();
        }

    }
}
