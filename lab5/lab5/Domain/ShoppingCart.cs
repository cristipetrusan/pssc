using CSharp.Choices;

namespace Domain
{
    [AsChoice]
    public static partial class ShoppingCart
    {
        public interface IShoppingCart { }

        public record EmptyCart(int cartID) : IShoppingCart
        {
            public int CartID { get; }
        }

        public record InvalidatedCart(int cartID, IReadOnlyCollection<OrderLine> itemList, string reason) : IShoppingCart;

        public record ValidatedCart(int cartID, IReadOnlyCollection<OrderLine> itemList, int clientId) : IShoppingCart;

        public record PaidCart(int cartID, IReadOnlyCollection<OrderLine> itemList, int clientId, DateTime paidDate) : IShoppingCart;
    }
}
