﻿using System.Collections.Generic;

namespace ProcessText.Core.Contracts.Factory
{
    /// <summary>
    /// Represents an interface for creating ordered sequences of strings based on a specific order.
    /// </summary>
    public interface IOrderFactory
    {
        /// <summary>
        /// Gets the ordered text based on the specified order and input text.
        /// </summary>
        /// <param name="order">The order criteria for arranging the text.</param>
        /// <param name="text">The input text to be ordered.</param>
        /// <returns>An IEnumerable of strings representing the ordered elements.</returns>
        IEnumerable<string> GetOrderText(string order, string text);
    }
}
