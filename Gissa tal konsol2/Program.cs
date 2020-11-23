using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            int antal = 0;
            Random slump = new Random();
            int random = slump.Next(0, 101);
            Console.WriteLine("Gissa ett tal från 1-100: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            antal++;
            {
                while (tal != random)
                {
                    if (tal < random)
                    {
                        Console.WriteLine("Det är för lågt");
                        Console.WriteLine("Gissa igen");
                        antal++;
                    }
                    else
                    {
                        Console.WriteLine("De för högt");
                        Console.WriteLine("gissa igen");
                        antal++;
                    }
                    tal = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Din gissning var rätt");
                Console.WriteLine("Dina försök: " + antal);
            }
        }
    }
}
