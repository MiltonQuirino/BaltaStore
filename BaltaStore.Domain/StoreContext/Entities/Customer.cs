using System.Collections.Generic;
using System.Linq;
using BaltaStore.Domain.StoreContext.ValueObjects;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        private readonly IList<Address> _addresses;

        public Customer(
            Name name,
            Document document,
            string email,
            string phone
            )
        {
            Name = name;
            Document = document;
            Email = email;
            phone = Phone;
            _addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        public string LastName { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }


        // public DateTime BirthDate { get; private set; }
        // public decimal Salary { get; private set; }
    }

    // public class Customer : Person
    // {

    //     public void Registrer() { }

    //     public void AoRegistrar() { }

    // }

    // public class SalesMan : Person
    // {
    // }
}