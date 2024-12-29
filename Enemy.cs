using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject
{
    abstract class Enemy
    {
        protected string _name;
        protected int _hp;
        protected int _atk;
        protected int _def;

        public string Name { get { return _name; } }
        public int HP { get { return _hp; } set { _hp = value; } }
        public int Atk { get { return _atk; } }
        public int Def { get { return _def; } set { _def = value; } }

        public virtual void Attack(Player player) { }
        public virtual void Die(Player player) { }
    }

    class Eichmann : Enemy
    {
        int cursorX = 12;
        int cursorY = 34;

        Print print = new Print();
        backgroundManager back = new backgroundManager();

        public Eichmann()
        {
            _name = "Dr. 아이히만";
            _hp = 820;
            _atk = 5;
            _def = 20;
        }

        public override void Attack(Player player)
        {
            backgroundManager back = new backgroundManager();
            Print print = new Print();
            Random rnd = new Random();
            int pattern = rnd.Next(1, 3);

            switch (pattern)
            {
                case 1:
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("아이히만 박사의 에너지탄 공격!");
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        print.PrintPhrase($"HP가 {Atk} 감소했다!");
                        player.HP -= Atk;
                        print.next();
                        break;
                    }
                case 2:
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("아이히만 박사의 미사일 포격!");
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        print.PrintPhrase($"HP가 {Atk * 2} 감소했다!");
                        player.HP -= Atk * 2;
                        print.next();
                        break;
                    }

            }
        }

        public override void Die(Player player)
        {
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("안돼... 안돼..!!! 열등한 것들이.... 감히 나의 계획을!!!");
            print.next();

            print.PrintPhrase("일리아칸....님...!!!");
            print.next();
        }
    }

    class Fabien : Enemy
    {
        int cursorX = 12;
        int cursorY = 34;

        Print print = new Print();
        backgroundManager back = new backgroundManager();

        public Fabien()
        {
            _name = "파비안";
            _hp = 500;
            _atk = 10;
            _def = 40;
        }

        public override void Attack(Player player)
        {
            backgroundManager back = new backgroundManager();
            Print print = new Print();
            Random rnd = new Random();
            int pattern = rnd.Next(1, 3);

            switch (pattern)
            {
                case 1:
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("파비안의 샷건 연사!");
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        print.PrintPhrase($"HP가 {Atk} 감소했다!");
                        player.HP -= Atk;
                        print.next();
                        break;
                    }
                case 2:
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("파비안의 유탄 투척!");
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        print.PrintPhrase($"HP가 {Atk * 2} 감소했다!");
                        player.HP -= Atk * 2;
                        print.next();
                        break;
                    }
            }

        }
        public override void Die(Player player)
        {
            back.Textbox();
            Console.SetCursorPosition(cursorX, cursorY);
            print.PrintPhrase("크흑... 내가... 무슨... 짓을....");
            print.next();

            print.PrintPhrase($"{player.Name}...?");
            print.next();
        }
    }
}
