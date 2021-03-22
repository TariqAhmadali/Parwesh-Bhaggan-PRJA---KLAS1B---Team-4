using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace ChatButler
{
    class MembersFunction
    {
        Member member1 = new Member()
        {


            FirstName = "Parwesh",
            LastName = "Bhaggan",
            EmailAdress = "bhaggan17@outlook.com",
            Continent = "EU",
            CreditCardNumber = "123438126",
            MembershipCode = "RandomGenerator",
            AccountStatus = "Bronze"
            
        };
        public MembersFunction() 
        {
            string memberjsonText;
            memberjsonText = JsonSerializer.Serialize<Member>(member1);
            File.WriteAllText("members.json", memberjsonText);
            Console.WriteLine("Converted to json successfully");

        }
        
    }
}
