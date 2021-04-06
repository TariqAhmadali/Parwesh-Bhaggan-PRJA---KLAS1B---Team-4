using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Text;

namespace ChatButler
{
    class ReserveringenTemp
    {
        public  ReserveringenTemp()
        {
            //Datum opvragen
            Console.WriteLine("Please enter a Date to see the reservations(dd/mm/yyyy): ");
            DateTime InputDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The selected date is: " + InputDate.ToString("dd/MM/yyyy"));
            string InputDateText = InputDate.ToString("dd/MM/yyyy");

            string reserveringjsontext = File.ReadAllText("testreservering.json");

            ReserveringDataTemp ResData = new ReserveringDataTemp();

            ResData = JsonSerializer.Deserialize<ReserveringDataTemp>(reserveringjsontext);

            if (InputDateText == ResData.Date)
            {
                Console.WriteLine("Reservations for this date are: ");
            }
            else
            {
                Console.WriteLine("No reservations on this date");
            }
        }



        




    }
}
