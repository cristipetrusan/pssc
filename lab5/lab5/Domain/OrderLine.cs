namespace Domain
{
    public record OrderLine
    {
        public int ID { get; }
        public int ProductId { get; }
        public int Quantity { get; }

        public OrderLine(int id, int productId, int quantity)
        {
            ID = id;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}