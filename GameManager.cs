using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Region region = new Region();

            //title.PrintTitle();
            //intro.CreatePlayer();

            //Playername = intro.playerName;
            //
            //if (Playername == "")
            //{
            //    player = new Player(100, 20, 1, 10, 3000);
            //}
            //
            //else if(Playername != "")
            //{              
            //    player = new Player(100, 20, 10, 1, 3000, Playername);
            //}
            //
            //else
            //{
            //    player = new Player(100, 20, 1, 10, 3000);
            //}
                       
            Item ekhorn = new Gun();
            Item basicArmour = new Armour();

            player = new Player(100, 20, 10, 1, 3000);//임시
            player[0] = basicArmour;
            player[1] = ekhorn;
            basicArmour.ItemEffect(player);
            ekhorn.ItemEffect(player);          

            region.Totrich(player);
        }       


    }
}
