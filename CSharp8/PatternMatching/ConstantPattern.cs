using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.PatternMatching
{
    internal class ConstantPattern
    {
        public ConstantPattern()
        {
            var input = "";

            // Эквивалент input == null
            if(input is null)
            {

            }
        }

        /// <remarks>
        /// Можно использовать
        /// int, float, char, string, bool, enum, const field, null
        /// </remarks>
        public decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
        {
            1 => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            4 => 32.0m,
            0 => 0.0m,
            _ => throw new ArgumentException()
        };
    }
}
