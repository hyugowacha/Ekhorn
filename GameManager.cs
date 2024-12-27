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

            title.PrintTitle();
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

            player = new Player(1, 1, 1);
            

            //player.PlayerAction();
            //player.PlayerMenu();
            

        }       


    }
}
