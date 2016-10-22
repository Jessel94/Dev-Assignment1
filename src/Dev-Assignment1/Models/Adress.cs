namespace Dev_Assignment1.Models
{
    public class Adress
    {
        public Adress(int idAdress, string country, string city, string street, string houseNumber, string postalCode)
        {
            IdAdress = idAdress;
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }

        public int IdAdress { get; }

        public string Country { get; }

        public string City { get; }

        public string Street { get; }

        public string HouseNumber { get; }

        public string PostalCode { get; }
    }
}
