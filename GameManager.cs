using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class GameManager
    {
        public GameManager()
        {
            Console.SetWindowSize(161, 51);

            Title title = new Title();
            Intro intro = new Intro();

            //title.PrintTitle();
            //intro.CreatePlayer();
            intro.StartAtEkhorn();
        }       
    }
}
