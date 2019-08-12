using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class InputLab
    {
        static void Main(string[] args)
        {

            /*
             * Ask the user for the following info:
             *      - Favorite season
             *      - Favorite car
             *      - Favorite TV show
             *      - How much they spent on cable last year
             *      
             *      Give them a response using all of their info or
             *      in one statement at the end using string formatting
             *      interpolation. Use currency formatting when you display
             *      the cable bill.
             */


            Console.Title = "InputLab";

            Console.Write("Hello! What is your Favorite Season of The Office?: \n");
            string favSeason = Console.ReadLine();
            Console.WriteLine("Me too");

            Console.Write("What is your Favorite Car?: \n");
            string favCar = Console.ReadLine();
            Console.WriteLine("Really? Yikes!\n");

            Console.Write("What is your Favorite TV Show?: \n");
            string favShow = Console.ReadLine();
            Console.WriteLine("....Snore Fest");

            Console.Write("How much did you spend on Cable last year? \n");
            string cableBill = Console.ReadLine();

            Console.WriteLine("You spent " + "${0:C}" + " on cable last year", cableBill); 





        }//end Main()
    }//end class
}//end namespace
