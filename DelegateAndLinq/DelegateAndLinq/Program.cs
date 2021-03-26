using System;
using System.Linq;

namespace DelegateAndLinq
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var del = new Delegate();
            del.Run();
            Console.WriteLine();

            var contact = new Contact();
            var contacts = contact.GetContactList();
            var contacts2 = contact.GetContactList();
            var phoneOperator = new PhoneOperator();
            var phoneOperators = phoneOperator.GetOperators();

            var selectedContacts = contacts
                .Where(w => w.FullName.StartsWith("C"))
                .OrderBy(o => o.FullName)
                .Select(s => new { s.FullName, s.PhoneNumber });

            foreach (var item in selectedContacts)
            {
                Console.WriteLine($"{item.FullName} {item.PhoneNumber}");
            }

            Console.WriteLine();

            var selectedContacts2 = contacts
                .Where(w => w.PhoneNumber.StartsWith("050"))
                .OrderBy(o => o.FullName)
                .ThenBy(t => t.Company)
                .Select(s => new { s.FullName, s.Company, s.PhoneNumber });
            foreach (var item in selectedContacts2)
            {
                Console.WriteLine($"{item.FullName} {item.Company} {item.PhoneNumber}");
            }

            Console.WriteLine();

            var selectedContacts3 = contacts.FirstOrDefault(f => f.FirstName.Contains("l", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine($"{selectedContacts3.FirstName} {selectedContacts3.PhoneNumber} {selectedContacts3.Company}");

            Console.WriteLine();

            var selectedContacts4 = contacts.Skip(2).Take(2);
            foreach (var item in selectedContacts4)
            {
                Console.WriteLine($"{item.FullName} {item.Company} {item.PhoneNumber}");
            }

            Console.WriteLine();

            var selectedContacts5 = contacts
                .Where(w => w.FullName.Contains("l", StringComparison.InvariantCultureIgnoreCase))
                .Select(s => s.Company)
                .Distinct();

            foreach (var item in selectedContacts5)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();

            var selectedContacts6 = contacts
               .GroupBy(g => new { g.Company, g.FirstName })
               .OrderBy(o => o.Key.Company);

            foreach (var item in selectedContacts6)
            {
                Console.WriteLine($"{item.Key.Company} {item.Key.FirstName} : {item.Count()}");
            }

            Console.WriteLine();

            var selectedContacts7 = contacts.Union(contacts2);

            foreach (var item in selectedContacts7)
            {
                Console.WriteLine($"{item.Company} {item.FirstName}");
            }

            var selectedContacts8 = contacts.Join(
                phoneOperators,
                c => c.OperatorName,
                o => o.Name,
                (c, o) => new { c.FullName, o.Country });

            Console.WriteLine();

            foreach (var item in selectedContacts8)
            {
                Console.WriteLine($"{item.FullName} {item.Country}");
            }
        }
    }
}
