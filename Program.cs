using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChatButler
{
    class Program
    {

        static void Main(string[] args)
        {
    
            
            Console.WriteLine("Welcome" + "\n");
            Console.WriteLine("Type the number for the desired menu option");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Review");
            Console.WriteLine("3. New member");
            Console.WriteLine("4. exit");

            string menuInput = Console.ReadLine();

            switch (menuInput)
            {

                case "1":
                    Console.WriteLine("Login Screen");
                    MemberLoginMenu lgm = new MemberLoginMenu();
                    break;
                case "2":
                    Console.WriteLine("Review Screen");
                    break;
                case "3":
                    Console.WriteLine("New member");
                    break;
                case "4":
                    Console.WriteLine("Exiting");
                    Environment.Exit(0);
                    break;
                case "sesame":
                    Console.WriteLine("Chefs Page");
                    ChefsHiddenPage chefspage = new ChefsHiddenPage();
                    break;
                default:
                    Console.WriteLine("Input Error");
                    break;



            }

        }


    }
}
