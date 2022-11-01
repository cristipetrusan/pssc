using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [AsChoice]
    public static partial class Produs
    {
        // ChoiceType
        public interface IQuantity {}
        public record Kg(float kg) : IQuantity;
        public record Unit(int unit) : IQuantity;
    }
}
