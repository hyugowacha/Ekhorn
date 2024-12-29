using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Player player;
            String Playername;

            //title.PrintTitle();
            //intro.CreatePlayer();
            //intro.StartAtEkhorn();

            //Playername = intro.playerName;
            //
            //if (Playername == null)
            //{
            //    player = new Player(100, 20, 10);
            //}
            //
            //else
            //{
            //    player = new Player(100, 20, 10, Playername);
            //}

            Region region = new Region();

            player = new Player(100, 20, 1, 1);
             

            Item ekhorn = new Gun();
            Item basicArmour = new Armour();

            player[0] = basicArmour;
            player[1] = ekhorn;
            

            region.Totrich(player);
            //region.EichmannLab(player);

        }       


    }
}
