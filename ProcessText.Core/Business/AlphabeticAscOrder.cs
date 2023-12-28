using System;
using System.Collections.Generic;
using System.Linq;
using ProcessText.Core.Contracts;

namespace ProcessText.Core.Business
{
    /// <summary>
    /// Represents an implementation of the IOrder interface for ordering strings alphabetically in ascending order.
    /// </summary>
    internal class AlphabeticAscOrder : IOrder
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

            // Order the words alphabetically in ascending order
            var orderedWords = words.OrderBy(word => word, StringComparer.CurrentCultureIgnoreCase);

            return orderedWords;
        }
    }
}
