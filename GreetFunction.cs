using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChatButler
{
    
    class GreetFunction
    {
        private static Greetings greetfile = new Greetings();
        public GreetFunction() {
            string json_greeting = File.ReadAllText("greetings.json");
            greetfile = JsonSerializer.Deserialize<Greetings>(json_greeting);
            Console.WriteLine(greetfile.nl);

        }

    }
}
