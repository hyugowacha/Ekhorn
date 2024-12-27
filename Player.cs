using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleProject
{
    partial class Player
    {
        static int _progress;
        int _hp;
        int _mp;
        int _atk;
        string _name;
        char cursor = '▶';
        LinkedList<Item> invenlist = new LinkedList<Item>();
        Item item { get; set; }

        public LinkedList<Item> Invenlist
        {
            get { return invenlist; }
            set { invenlist = value; }
        }

        #region
        public Player(int hp, int mp, int atk, string name = "해결사")
        {
            _progress = 0;
            _hp = hp;
            _mp = mp;
            _atk = atk;
            _name = name;
        }

        public int Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int MP
        {
            get { return _mp; }
            set { _mp = value; }
        }

        public int Atk
        {
            get { return _atk; }
            set { _atk = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        
        #endregion

        public void inventory()
        {

            ConsoleKeyInfo keys;
            back.Textbox();

            bool isExit = true;

            int tempCursorX = cursorX - 2;
            int tempCursorY = cursorY;

            int tap2cursorY = cursorY + 2;
            int tap3cursorY = cursorY + 4;
            int tap4cursorY = cursorY + 6;

            int RightcursorX = cursorX + 40;

            while (isExit)
            {
                Console.SetCursorPosition(cursorX - 2, cursorY - 2);
                print.PrintPhrase("ESC를 눌러 뒤로가기");
                Thread.Sleep(500);

                Console.SetCursorPosition(cursorX-2, cursorY);
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
                return "비어있음";
            }
        }

        public void AddItem(Item item)
        {
            if(invenlist.Count < 9)
            {
               invenlist.AddLast(item);
            }

            else
            {
                Console.WriteLine("인벤토리가 꽉 찼습니다.");
            }
        }
    }
}
