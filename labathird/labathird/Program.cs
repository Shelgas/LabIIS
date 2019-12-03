using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labathird
{
    class Program
    {
        static void Main(string[] args)
        {


            Hero charactere = СharactereMenu.СreateHero();
            Console.WriteLine(charactere.GetCharacteristics());
            charactere.ShowImage();
           
            while (true)
            {
                Console.WriteLine("Enter 1 to go right");
                Console.WriteLine("Enter 2 to gp left");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        new Battle(charactere, new Lich(charactere));
                        break;
                    case "2":
                        new Battle(charactere, new Skeleton());
                        break;
                    default:
                        Console.WriteLine("Error, try again");
                        break;
                }
            }

            Console.Read();
        }
    }
}
