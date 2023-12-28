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
        public IEnumerable<string> Order(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Enumerable.Empty<string>();
            }

            // Split the string into words
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Order the words alphabetically in ascending order
            var orderedWords = words.OrderBy(word => word, StringComparer.CurrentCultureIgnoreCase);

            return orderedWords;
        }
    }
}
