using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndLinq
{
    public class PhoneOperator
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public List<PhoneOperator> GetOperators()
        {
            return new List<PhoneOperator>
            {
            new PhoneOperator
            {
            Country = "Ukraine",
            Name = "Ukrtelecom"
            },
            new PhoneOperator
            {
            Country = "Ukraine",
            Name = "Life"
            },
            new PhoneOperator
            {
            Country = "UK",
            Name = "Vodafone"
            }
            };
        }
    }
}
