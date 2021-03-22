using System;
using System.Collections.Generic;
using System.Text;

namespace ChatButler
{
    class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNumber { get; set; }
        public string Continent { get; set; }
        public string EmailAdress { get; set; }
        public string MembershipCode { get; set; }

        public string AccountStatus { get; set; }
    }

   /* Member member1 = new Member()
    {

        FirstName = "Parwesh",
        LastName = "Bhaggan",
        EmailAdress = "bhaggan17@outlook.com",
        Continent = "EU",
        CreditCardNumber = "123438126",
        MembershipCode = "RandomGenerator"

    };*/

    //acc status: bronze, silver, gold, platinum
}
