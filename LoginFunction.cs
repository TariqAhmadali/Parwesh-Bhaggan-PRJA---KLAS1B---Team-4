using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace ChatButler
{
    class LoginFunction
    {
        static Member memberValidation = new Member();

        public LoginFunction(string email, string memberShipCode) {

            JsonToTextConverter();
            loginValidation(email, memberShipCode);
        }

        private static void JsonToTextConverter() {
            string memberJsonText = File.ReadAllText("members.json");
            memberValidation = JsonSerializer.Deserialize<Member>(memberJsonText);
            
        }

        public static void loginValidation(string email, string memberShipCode) {
            
            if (email == memberValidation.EmailAdress && memberShipCode == memberValidation.MembershipCode)
            {
                Console.WriteLine("Login successfully");
            }
            else {
                Console.WriteLine("Incorrect email/membershipcode! Please Try Again!");
            }

        }

    }
}
