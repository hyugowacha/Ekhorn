using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
    partial class Player
    {
        Print print = new Print();
        backgroundManager back = new backgroundManager();
        Region region = new Region();
        
        int cursorX = 12;
        int cursorY = 34;
        ConsoleKeyInfo keys;


        public void PlayerAction()
        {
            back.Textbox();

            Console.SetCursorPosition(cursorX - 2, cursorY - 2);
            print.PrintPhrase("무엇을 할까?");
            Thread.Sleep(500);

            Console.SetCursorPosition(cursorX + 2, cursorY + 2);
            Console.WriteLine("지역 이동");

            Console.SetCursorPosition(cursorX + 2, cursorY + 4);
            Console.WriteLine("플레이어 메뉴");

            Console.SetCursorPosition(cursorX, cursorY + 2);

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
                        PlayerMove();
                    }

                    else if (Console.CursorTop == cursorY + 4)
                    {
                        PlayerMenu();
                    }
                }

            }


        }

        public void PlayerMove()
        {
            back.Textbox();

            int tempCursorX = cursorX;
            int tempCursorY = cursorY;

            int tap2cursorY = cursorY + 2;
            int tap3cursorY = cursorY + 4;
            int tap4cursorY = cursorY + 6;

            Console.SetCursorPosition(cursorX - 2, cursorY - 2);
            print.PrintPhrase("어디로 이동할까?");
            Thread.Sleep(500);

            Console.SetCursorPosition(cursorX + 2, cursorY);
            Console.WriteLine("에크혼 용병 사무소");

            Console.SetCursorPosition(cursorX + 2, tap2cursorY);
            Console.WriteLine("황금 연료 주점");

            if (_progress == 0)
            {
                Console.SetCursorPosition(cursorX + 2, tap3cursorY);
                Console.WriteLine("아이히만의 연구기지");
            }

            else if (_progress == 1)
            {
                Console.SetCursorPosition(cursorX + 2, tap3cursorY);
                Console.WriteLine("크라테르의 사원");
            }

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
                        region.Ekhorn(this);
                    }

                    else if (tempCursorY == tap2cursorY)
                    {
                        region.Store(this);
                    }

                    else if (tempCursorY == tap3cursorY)
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX - 2, cursorY - 1);
                        print.PrintPhrase("출발 전에 정말 준비가 다 되었는지 확인해보자.");

                        Console.SetCursorPosition(cursorX + 2, cursorY + 2);
                        Console.WriteLine("준비는 충분하다. 어서 출발하자.");

                        Console.SetCursorPosition(cursorX + 2, cursorY + 4);
                        Console.WriteLine("아직 준비가 다 되지 않았다.");

                        Console.SetCursorPosition(cursorX, cursorY + 2);

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
                                    region.BeforeEichmann(this);
                                }

                                else if (Console.CursorTop == cursorY + 4)
                                {
                                    region.Totrich(this);
                                }
                            }
                        }
                    }

                    else if (tempCursorY == tap4cursorY)
                    {
                        PlayerAction();
                    }
                }
            }

        }

        public void PlayerMenu()
        {
            
            ConsoleKeyInfo keys;
            back.Textbox();

            int tempCursorX = cursorX;
            int tempCursorY = cursorY;

            int tap2cursorY = cursorY + 2;
            int tap3cursorY = cursorY + 4;
            int tap4cursorY = cursorY + 6;


            Console.SetCursorPosition(cursorX - 2, cursorY - 2);
            print.PrintPhrase("무엇을 할까?");
            Thread.Sleep(500);

            Console.SetCursorPosition(cursorX + 2, cursorY);
            Console.WriteLine("장비 확인");

            Console.SetCursorPosition(cursorX + 2, tap2cursorY);
            Console.WriteLine("스킬 확인");

            Console.SetCursorPosition(cursorX + 2, tap3cursorY);
            Console.WriteLine("인벤토리 확인");

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
                        CheckPlayerItem();
                    }

                    else if (tempCursorY == tap2cursorY)
                    {
                        CheckSkill();
                    }

                    else if (tempCursorY == tap3cursorY)
                    {                    
                        inventory();
                    }

                    else if (tempCursorY == tap4cursorY)
                    {
                        PlayerAction();
                    }
                }

            }

        }

    }
}
