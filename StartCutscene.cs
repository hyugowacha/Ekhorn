using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
     partial class Intro
    {
        static Player player;

        public void CreatePlayer()
        {
            Console.SetCursorPosition(70, 20);
            print.PrintPhrase("나의 이름은?\n");
            Console.SetCursorPosition(50, 22);
            print.PrintPhrase("(아무것도 입력하지 않을 시 기본 이름으로 생성됩니다.)");

            Console.ReadLine();

            player = new Player(1, 1, 1);
        }
    }
}
