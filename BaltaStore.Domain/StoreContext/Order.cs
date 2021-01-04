namespace BaltaStore.Domain.StoreContext
{
    public class Order
    {
        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Status { get; private set; }
        public IList<OrdemItem> Items { get; private set; }
        public IList<Delivery> Deliveries { get; private set; }

        //To Place An Order
        public void Place() { }

    }
}