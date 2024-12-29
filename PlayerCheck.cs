using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
    partial class Player
    {
        public void CheckPlayerItem()
        {
            back.Textbox();
            Console.SetCursorPosition(cursorX - 2, cursorY - 2);
            print.PrintPhrase("착용 중인 장비");
            Thread.Sleep(1000);

            Console.SetCursorPosition(cursorX, cursorY + 1);
            Console.Write($"장비 : {playerItem[0].Name}");

            Console.SetCursorPosition(cursorX + 40, cursorY + 1);
            Console.Write(playerItem[0].Explain);

            Console.SetCursorPosition(cursorX, cursorY + 4);
            Console.Write($"무기 : {playerItem[1].Name}");

            Console.SetCursorPosition(cursorX + 40, cursorY + 4);
            Console.Write(playerItem[1].Explain);

            Console.SetCursorPosition(cursorX - 2, cursorY + 8);
            Console.Write("ESC를 눌러 뒤로가기");

            while (true)
            {
                keys = Console.ReadKey(true);

                if (keys.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            PlayerMenu();
        }

        public void CheckSkill()
        {
            back.Textbox();
            Console.SetCursorPosition(cursorX - 2, cursorY - 2);
            print.PrintPhrase("보유 스킬");
            Thread.Sleep(1000);

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("데스페라도");
            Console.SetCursorPosition(cursorX + 20, cursorY);
            Console.Write("공중으로 뛰어올라 핸드건을 난사한다. MP 8 소모");

            Console.SetCursorPosition(cursorX, cursorY + 2);
            Console.Write("퀵 샷");
            Console.SetCursorPosition(cursorX + 20, cursorY + 2);
            Console.Write("빠르게 사격하여 피해를 입힌다. MP 4 소모");

            Console.SetCursorPosition(cursorX, cursorY + 4);
            Console.Write("잔혹한 추적자");
            Console.SetCursorPosition(cursorX + 20, cursorY + 4);
            Console.Write("전방으로 핸드건을 난사하여 공격한다. MP 6 소모");

            Console.SetCursorPosition(cursorX, cursorY + 6);
            Console.Write("이퀼리브리엄");
            Console.SetCursorPosition(cursorX + 20, cursorY + 6);
            Console.Write("넓은 범위에 연사하여 적의 방어력을 감소시킨다. MP 2 소모");

            Console.SetCursorPosition(cursorX - 2, cursorY + 8);
            Console.Write("ESC를 눌러 뒤로가기");

            while (true)
            {
                keys = Console.ReadKey(true);

                if (keys.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            PlayerMenu();

        }
    }
}
