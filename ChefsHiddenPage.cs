using System;
using System.Collections.Generic;
using System.Text;

namespace ChatButler
{
    class ChefsHiddenPage
    {
        public ChefsHiddenPage()
        {
            //Welkoms text
            Console.WriteLine("Welcome Chef, How maye i be of service to you today." + "\n");

            //Menu
            Console.WriteLine("Type the number for the desired menu option");
            Console.WriteLine("1. Reservations");
            Console.WriteLine("2. Ingredients list\n");

            string menu = Console.ReadLine();

            switch (menu)
            {

                case "1":
                    Console.WriteLine("Reservations");
                    ReserveringenTemp restemp = new ReserveringenTemp();
                    break;
                case "2":
                    Console.WriteLine("Ingredients list");
                    break;
            }

            

        }

    }
}
