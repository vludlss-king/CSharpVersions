using System;
using System.Collections.Generic;

namespace CSharp8.PatternMatching
{
    internal class DeclarationPattern
    {
        public DeclarationPattern()
        {
            // Можно проверять тип во время выполнения + преобразовывать данные к этому типу
            object greeting = "Hello World";
            if(greeting is string message)
            {
                Console.WriteLine(message.ToLower());
            }
        }

        // Можно проверять тип во время выполнения + преобразовывать данные к этому типу
        int GetSourceLabel<T>(IEnumerable<T> source) => source switch
        {
            Array array => 1,
            ICollection<T> collection => 2,
            _ => 3,
        };

        public abstract class Vehicle { }
        public class Car : Vehicle { }
        public class Truck : Vehicle { }

        public class TollCalculator
        {
            // Можно проверять тип во время выполнения + отбрасывать данные
            public decimal CalculateToll(Vehicle vehicle) => vehicle switch
            {
                Car _ => 2.00m,
                Truck _ => 7.50m,
                null => throw new ArgumentNullException(nameof(vehicle)),
                _ => throw new ArgumentException("Unknown type of a vehicle"),
            };
        }
    }
}
