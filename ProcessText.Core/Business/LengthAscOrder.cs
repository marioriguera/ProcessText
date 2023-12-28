using System;
using System.Collections.Generic;
using System.Linq;
using ProcessText.Core.Contracts;

namespace ProcessText.Core.Business
{
    /// <summary>
    /// Represents an implementation of the IOrder interface for ordering strings by length in ascending order.
    /// </summary>
    internal class LengthAscOrder : IOrder
    {
        /// <inheritdoc/>
        public IEnumerable<string> Order(IEnumerable<string> textArray)
        {
            if (!textArray.ToList().Any())
            {
                return Enumerable.Empty<string>();
            }

            // Transform to array.
            string[] words = textArray.ToArray();

            // Order the words by length from shortest to longest
            var orderedWords = words.OrderBy(word => word.Length);

            return orderedWords;
        }
    }
}
