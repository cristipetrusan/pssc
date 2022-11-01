namespace lab3
{
    [AsChoice]
    public static partial class ShoppingCart
    {
        public interface IShoppingCart{}

        public record EmptyCart : IShoppingCart
        {
            
        }
    }
}