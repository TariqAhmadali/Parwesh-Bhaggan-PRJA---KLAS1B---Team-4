using System;
using System.Collections.Generic;
using System.Text;

namespace ChatButler
{
    class MemberLoginMenu
    {
        public MemberLoginMenu() {

            Console.WriteLine("Insert email: ");
            string emailInput = Console.ReadLine();
            Console.WriteLine("Insert membership code: ");
            string membershipCodeInput = Console.ReadLine();

            string email = emailInput;
            string memberShipcode = membershipCodeInput;
            LoginFunction lgf = new LoginFunction(email, memberShipcode);

        }
    }
}
