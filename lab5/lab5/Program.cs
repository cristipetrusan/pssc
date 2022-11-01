// See https://aka.ms/new-console-template for more information

using Domain;
using static Domain.ShoppingCart;
// using System;
// using System.Collections.Generic;

Random random = new Random();

void print(string s)
{
    Console.WriteLine(s);
}

string? ReadValue(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine();
}

List<OrderLine> ReadListOfProducts()
{
    List<OrderLine> listOfProducts = new();
    for (int i = 0; i < 3; i++)
    {
        int id = Int32.Parse(ReadValue("ID: "));
        int itemId = Int32.Parse(ReadValue("ItemId: "));
        int quantity = Int32.Parse(ReadValue("Quantity: "));
        listOfProducts.Add(new (id, itemId, quantity));
    }
    return listOfProducts;
}

IShoppingCart ValidateShoppingCart(EmptyCart emptyCart, IReadOnlyCollection<OrderLine> listOfProducts) =>
    // random.Next(100) > 50 ?
    5 > 50 ?
    new InvalidatedCart(emptyCart.CartID, listOfProducts, "Random errror")
    : new ValidatedCart(emptyCart.CartID, listOfProducts, 123987);

///////////////////////////////////////////////////////

// IReadOnlyCollection<string> stringList = new List<string> { "123", "456" };
// foreach (var string2 in stringList)
// {
//     print(string2);
// }

var listOfProducts = ReadListOfProducts();
foreach(OrderLine product in listOfProducts)
{
    print(product.ID.ToString());
}

EmptyCart emptyCart = new(1);

IShoppingCart result = ValidateShoppingCart(emptyCart, listOfProducts);

result.Match(
    whenEmptyCart: emptyCart => emptyCart,
    whenInvalidatedCart: invalidatedCart => invalidatedCart,
    whenValidatedCart: validatedCart => validatedCart,
    whenPaidCart: paidCart => paidCart
);

print(result.ToString());

