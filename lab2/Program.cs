// See https://aka.ms/new-console-template for more information
using CSharp.Choices;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics.CodeAnalysis;
using static lab2.Produs;

namespace lab2
{
internal class Program
{

    public static void Main(string[] args)
    {
        IQuantity qty, qty2;
        qty = new Kg(12.5f);
        var result = qty.Match(whenKg: q => q.kg,
                   whenUnit: q=> q.unit);
        
        qty2 = new Unit(10);

        Console.WriteLine(qty);
        Console.WriteLine(qty2);
        Console.WriteLine(result);

    }
}

}
