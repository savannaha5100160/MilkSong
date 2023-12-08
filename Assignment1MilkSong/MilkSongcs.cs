using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1MilkSong
{
    internal class MilkSongcs
    {
        public void sing()
        {
            for (int i = 99; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("No more bottles of milk on the wall, no more bottles of milk.");
                    Console.WriteLine("Go to the store and buy some more,99 bottles of milk on the wall.");
                }
                else if (i == 1)
                {
                    Console.WriteLine("1 bottle of milk on the wall, 1 bottles of milk.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of milk on the wall.");
                }
                else
                {
                    Console.WriteLine(i + "bottles of milk on the wall,"  + i + "bottles of milk.");
                    Console.WriteLine("Take one down and pass it around," + (i - 1) + "bottles of milk on the wall.");
                }
                 
                {
                    Console.WriteLine(" 1 bottle of milk on the wall," + " 1 bottle of milk.");
                }
                

            }

        }



    }
}