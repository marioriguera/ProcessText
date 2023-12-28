using System;
using System.Collections.Generic;
using System.Linq;
using ProcessText.Core.Contracts;

namespace ProcessText.Core.Business
{
    /// <summary>
    /// Represents an implementation of the IOrder interface for ordering strings alphabetically in descending order.
    /// </summary>
    internal class AlphabeticDescOrder : IOrder
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

            // Order the words alphabetically in descending order
            var orderedWordsDescending = words.OrderByDescending(word => word, StringComparer.CurrentCultureIgnoreCase);

            return orderedWordsDescending;
        }
    }
}
