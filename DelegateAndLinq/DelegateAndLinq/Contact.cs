using System.Collections.Generic;

namespace DelegateAndLinq
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public List<Contact> Contacts { get; set; }
        public string OperatorName { get; set; }

        public List<Contact> GetContactList()
        {
            return new List<Contact>
            {
                new Contact
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                PhoneNumber = "0576364873",
                Company = "Lord Of The Rings",
                OperatorName = "Ukrtelecom"
            },
                new Contact
            {
                FirstName = "Luke",
                LastName = "Skywalker",
                PhoneNumber = "0638158536",
                Company = "StarWars",
                OperatorName = "Life"
            },
                new Contact
            {
                FirstName = "Gandalf ",
                LastName = "the grey",
                PhoneNumber = "0636548121",
                Company = "Lord Of The Rings",
                OperatorName = "Life"
            },
                new Contact
            {
                FirstName = "Leia",
                LastName = "Princess",
                PhoneNumber = "050264589",
                Company = "StarWars",
                OperatorName = "Vodafone"
            },
                new Contact
            {
                FirstName = "Chewbacca",
                PhoneNumber = "050264589",
                Company = "StarWars",
                OperatorName = "Vodafone"
            },
                new Contact
            {
                FirstName = "Frodo",
                LastName = "Baggins",
                PhoneNumber = "0576364873",
                Company = "Lord Of The Rings",
                OperatorName = "Ukrtelecom"
            }
            };
        }
    }
}