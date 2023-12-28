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
        public IEnumerable<string> Order(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Enumerable.Empty<string>();
            }

            // Split the string into words
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Order the words alphabetically in descending order
            var orderedWordsDescending = words.OrderByDescending(word => word, StringComparer.CurrentCultureIgnoreCase);

            return orderedWordsDescending;
        }
    }
}
