namespace BaltaStore.Domain.StoreContext
{
    public class OrderItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}