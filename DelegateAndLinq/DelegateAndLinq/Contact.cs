namespace DelegateAndLinq
{
    public class Contact
    {
        public string FullName => FirstName + " " + LastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
