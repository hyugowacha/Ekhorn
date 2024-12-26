using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(161, 51);

            Title title = new Title();
            Intro intro = new Intro();

            //title.PrintTitle();
            intro.CreatePlayer();

        }
    }
}
