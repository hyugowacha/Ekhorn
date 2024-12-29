﻿using System;
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
    }

    class Eichmann : Enemy
    {
        int cursorX = 12;
        int cursorY = 34;

        public Eichmann()
        {
            _name = "Dr. 아이히만";
            _hp = 820;
            _atk = 5;
            _def = 10;
        }

        public override void Attack(Player player)
        {
            backgroundManager back = new backgroundManager();
            Print print = new Print();
            Random rnd = new Random();
            int pattern = rnd.Next(1,3);

            switch (pattern)
            {
                case 1:
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("아이히만 박사의 에너지탄 공격!");
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        print.PrintPhrase("HP가 5 감소했다!");
                        player.HP -= 5;
                        print.next();
                        break;
                    }
                case 2:
                    {
                        back.Textbox();
                        Console.SetCursorPosition(cursorX, cursorY);
                        print.PrintPhrase("아이히만 박사의 미사일 포격!");
                        Console.SetCursorPosition(cursorX, cursorY + 2);
                        print.PrintPhrase("HP가 10 감소했다!");
                        player.HP -= 10;
                        print.next();
                        break;
                    }               
                 
            }
        }
    }
}