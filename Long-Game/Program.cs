using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int score = 0;
            string name = null;


            Console.WriteLine("Hello Player, what's your name?");
            name = Console.ReadLine();


            Console.WriteLine("\nYour current score is: " + score);
            Console.WriteLine("To increase your score, press any key");
            Console.WriteLine("When you're ready to end the game, press Enter");
            Console.WriteLine("\nWhen you're ready to start, press Enter");
            Console.ReadLine();
            Console.WriteLine("Alright " + name + ", let's play!");
        }
    }
}
