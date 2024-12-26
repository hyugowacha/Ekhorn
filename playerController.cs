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


        public void PlayerMenu()
        {
            int cursorX = 12;
            int cursorY = 34;

            ConsoleKeyInfo keys;
            bool isExit = true;

            back.Textbox();

            int tempCursorX = cursorX - 2;
            int tempCursorY = cursorY;

            int tap2cursorY = cursorY + 2;
            int tap3cursorY = cursorY + 4;
            int tap4cursorY = cursorY + 6;

            while (isExit)
            {
                Console.SetCursorPosition(cursorX - 2, cursorY - 2);
                print.PrintPhrase("무엇을 할까?");
                Thread.Sleep(500);

                Console.SetCursorPosition(cursorX, cursorY);
                Console.WriteLine("장비 확인");

                Console.SetCursorPosition(cursorX, tap2cursorY);
                Console.WriteLine("스킬 확인");

                Console.SetCursorPosition(cursorX, tap3cursorY);
                Console.WriteLine("인벤토리 확인");

                Console.SetCursorPosition(cursorX, tap4cursorY);
                Console.WriteLine("뒤로가기");

                while (isExit)
                {
                    Console.SetCursorPosition(tempCursorX, tempCursorY);
                    Console.WriteLine(cursor);
                    keys = Console.ReadKey(true);

                    if (keys.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(tempCursorX - 1, tempCursorY);
                        Console.WriteLine('　');

                        tempCursorY += 2;
                        if (tempCursorY > tap4cursorY)
                        {
                            tempCursorY = tap4cursorY;
                        }
                    }

                    if (keys.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(tempCursorX - 1, tempCursorY);
                        Console.WriteLine('　');

                        tempCursorY -= 2;
                        if (tempCursorY < cursorY)
                        {
                            tempCursorY = cursorY;
                        }
                    }

                    if (keys.Key == ConsoleKey.Enter)
                    {

                        if (tempCursorY == cursorY)
                        {
                            back.Textbox();
                            Console.WriteLine("장비 확인 실행");
                        }

                        else if (tempCursorY == tap2cursorY)
                        {
                            back.Textbox();
                            Console.WriteLine("스킬 확인 실행");
                        }

                        else if (tempCursorY == tap3cursorY)
                        {
                            back.Textbox();
                            Console.WriteLine("인벤토리 확인 실행");
                        }

                        else if (tempCursorY == tap4cursorY)
                        {
                            back.Textbox();
                            Console.WriteLine("뒤로가기 실행");
                            isExit = false;
                        }
                    }

                }
            }
        }
    }
}
