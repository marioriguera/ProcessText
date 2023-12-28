using System.Collections.Generic;

namespace ProcessText.Core.Contracts
{
    /// <summary>
    /// Represents an interface for ordering operations on a collection of strings.
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Orders the provided text and returns an IEnumerable of strings.
        /// </summary>
        /// <param name="text">The input text to be ordered.</param>
        /// <returns>An IEnumerable of strings representing the ordered elements.</returns>
        IEnumerable<string> Order(string text);
    }
}
