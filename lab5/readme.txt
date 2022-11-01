public record ValidatedCart(Guid id,
    Client client,
    IReadOnlyCollection<OrderLine>,
    Price TotalPrice)

vrem sa modificam cantitatea unui produs (din OrderLine)

public record OrderLine(ProductId, Quantity)
{
    var orderLine = new(1, 2);
    var updatedOrderLine = orderLine where {quantity = 3};
}

AGGREGATE ROOT

public record OrderLine(Id, ProductId, Quantity)
{
}

    var orderLine = new(1, 2);
    var updatedOrderLine = orderLine where {quantity = 3};
    var validatedCart = new ValidatedCart(1, 3, [{ }, { }], 100)
    var updatedCart = validatedCart where {orderLines = newOrderLines, totalPrice = 300}


public record ValidatedCart(Guid id,
    ClientId clientId, => devine ClientId
    IReadOnlyCollection<OrderLine>,
    Price TotalPrice)


DTO
Student
    nume
    nr matricol

StudentDTO
    String nume
    String numarMatricol


record vs class
record face egalitate intre atributele clasei, class face egalitate la referinte

entity = sa putem identifica unic o instanta

empty       cart    = id
invalidated cart    = id, itemList, reason
validated   cart    = id, itemList, CLIENT
paid        cart    = id, itemList, CLIENT, date
