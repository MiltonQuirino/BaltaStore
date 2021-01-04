namespace BaltaStore.Domain.StoreContext
{
    public class Person
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }


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