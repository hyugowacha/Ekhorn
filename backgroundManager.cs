using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class backgroundManager
    {
        const int width = 80;
        const int height = 15;


        private char[,] background = new char[height, width];

        public void SetBoard()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    background[i, j] = '　';
                }
            }
        }

        public void Textbox()
        {
            SetBoard();
            Console.SetCursorPosition(0, 30);

            for (int i = 0; i < width; i++)
            {
                background[0, i] = '■'; //가로줄
                background[height - 1, i] = '■';
            }

            for (int i = 0; i < height; i++)
            {
                background[i, 0] = '■'; //세로줄
                background[i, width - 1] = '■';
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(background[i, j]);
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(5, 31);
        }

        
   
    }
}
