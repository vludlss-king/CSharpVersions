using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.PatternMatching
{
    internal class PropertyPattern
    {
        // можно проверять свойства на равенство
        public bool Classify(PropertyPatternExample measurement) => measurement is { Prop1: 1 , Prop2: 2 };

        // тут также только в switch expression
        public string TakeFive(object input) => input switch
        {
            string { Length: 5 } s => s.Substring(0, 5),
            string s => s,
            _ => null,
        };
    }

    class PropertyPatternExample
    {
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
}
