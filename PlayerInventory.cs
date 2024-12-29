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
        public void inventory()
        {
            ConsoleKeyInfo keys;
            back.Textbox();

            int tempCursorX = cursorX - 2;
            int tempCursorY = cursorY;

            int tap2cursorY = cursorY + 2;
            int tap3cursorY = cursorY + 4;
            int tap4cursorY = cursorY + 6;

            int RightcursorX = cursorX + 40;


            #region 인벤토리목록
            Console.SetCursorPosition(cursorX - 2, cursorY - 2);
            Console.Write("ESC를 눌러 뒤로가기");

            Console.SetCursorPosition(cursorX - 2, cursorY);
            Console.WriteLine($"1. {PrintItemName(0)}");

            Console.SetCursorPosition(cursorX - 2, tap2cursorY);
            Console.WriteLine($"2. {PrintItemName(1)}");

            Console.SetCursorPosition(cursorX - 2, tap3cursorY);
            Console.WriteLine($"3. {PrintItemName(2)}");

            Console.SetCursorPosition(cursorX - 2, tap4cursorY);
            Console.WriteLine($"4. {PrintItemName(3)}");

            Console.SetCursorPosition(RightcursorX - 2, cursorY);
            Console.WriteLine($"5. {PrintItemName(4)}");

            Console.SetCursorPosition(RightcursorX - 2, tap2cursorY);
            Console.WriteLine($"6. {PrintItemName(5)}");

            Console.SetCursorPosition(RightcursorX - 2, tap3cursorY);
            Console.WriteLine($"7. {PrintItemName(6)}");

            Console.SetCursorPosition(RightcursorX - 2, tap4cursorY);
            Console.WriteLine($"8. {PrintItemName(7)}");
            #endregion

            while (true)
            {
                keys = Console.ReadKey(true);

                if (keys.Key == ConsoleKey.D1 || keys.Key == ConsoleKey.D2 || keys.Key == ConsoleKey.D3 || keys.Key == ConsoleKey.D4 ||
                    keys.Key == ConsoleKey.D5 || keys.Key == ConsoleKey.D6 || keys.Key == ConsoleKey.D7 || keys.Key == ConsoleKey.D8 ||
                    keys.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            #region 인벤토리 번호 입력 시 선택지
            if (keys.Key == ConsoleKey.D1)
            {
                printItemExplain(1);
            }

            if (keys.Key == ConsoleKey.D2)
            {
                printItemExplain(2);
            }

            if (keys.Key == ConsoleKey.D3)
            {
                printItemExplain(3);
            }

            if (keys.Key == ConsoleKey.D4)
            {
                printItemExplain(4);
            }

            if (keys.Key == ConsoleKey.D5)
            {
                printItemExplain(5);
            }

            if (keys.Key == ConsoleKey.D6)
            {
                printItemExplain(6);
            }

            if (keys.Key == ConsoleKey.D7)
            {
                printItemExplain(7);
            }

            if (keys.Key == ConsoleKey.D8)
            {
                printItemExplain(8);
            }

            if (keys.Key == ConsoleKey.Escape)
            {
                PlayerMenu();
            }
            #endregion

        }

        public void printItemExplain(int count)
        {
            Item tempItem;
            int Count = 0;

            if (count > invenlist.Count)
            {
                Console.SetCursorPosition(cursorX + 80, cursorY);
                Console.Write("인벤토리가 비어있습니다.");
                Thread.Sleep(2000);
                Console.SetCursorPosition(cursorX + 80, cursorY);
                Console.Write("                             ");
                inventory();
            }

            else
            {
                foreach (Item item in invenlist)
                {
                    tempItem = item;
                    Count++;

                    if (Count == count)
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase(tempItem.Explain);
                        UseItem(tempItem);
                        break;
                    }
                }
                inventory();
            }

        }

        public string PrintItemName(int arraynum)
        {
            Item[] items = new Item[8];

            int count = 0;

            foreach (Item item in invenlist)
            {
                items[count] = item;
                count++;
            }

            if (items[arraynum] != null)
            {
                Item ChoosenItem = items[arraynum];

                return ChoosenItem.Name;
            }

            else
            {
                return "　";
            }
        }

        public void AddItem(Item item)
        {
            if (invenlist.Count < 9)
            {
                invenlist.AddLast(item);
            }
        }

        public void UseItem(Item item)
        {
            Console.SetCursorPosition(cursorX, cursorY + 2);

            if (item.Category == Category.Armour || item.Category == Category.weapon || item.Category == Category.useable)
            {
                print.PrintPhrase("아이템을 사용하시겠습니까?");

                Console.SetCursorPosition(cursorX + 2, cursorY + 4);
                Console.Write("네");
                Console.SetCursorPosition(cursorX + 2, cursorY + 5);
                Console.Write("아니오");

                Console.SetCursorPosition(cursorX, cursorY + 4);

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
                        Console.SetCursorPosition(cursorX, cursorY + 4);
                        Console.Write('　');
                        Console.SetCursorPosition(cursorX, cursorY + 5);
                    }

                    if (keys.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(cursorX, cursorY + 5);
                        Console.Write('　');
                        Console.SetCursorPosition(cursorX, cursorY + 4);
                    }

                    if (keys.Key == ConsoleKey.Enter)
                    {
                        if (Console.CursorTop == cursorY + 4)
                        {
                            SetItem(item);
                            back.Textbox();
                            Console.SetCursorPosition(cursorX, cursorY);

                            if (item.Category == Category.Armour || item.Category == Category.weapon)
                            {
                                Console.Write("아이템을 장비했습니다.");
                            }

                            else if (item.Category == Category.useable)
                            {
                                Console.Write("아이템을 사용했습니다.");
                            }

                            Thread.Sleep(2000);
                            break;
                        }

                        else if (Console.CursorTop == cursorY + 5)
                        {
                            break;
                        }
                    }

                }

            }

        }

        public void SetItem(Item item)
        {
            Item temp;

            if (item.Category == Category.Armour)
            {
                temp = playerItem[0];
                playerItem[0] = item;
                Invenlist.Remove(item);
                Invenlist.AddLast(temp);
                item.ItemEffect(this);
            }

            if (item.Category == Category.weapon)
            {
                temp = playerItem[1];
                playerItem[1] = item;
                Invenlist.Remove(item);
                Invenlist.AddLast(temp);
                item.ItemEffect(this);
            }

            if (item.Category == Category.useable)
            {
                Invenlist.Remove(item);
                item.ItemEffect(this);
            }
        }
    }
}
