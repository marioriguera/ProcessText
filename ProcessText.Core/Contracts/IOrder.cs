﻿using System.Collections.Generic;

namespace ProcessText.Core.Contracts
{
    /// <summary>
    /// Represents an interface for ordering operations on a collection of strings.
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Orders the provided text IEnumerable and returns an IEnumerable of strings.
        /// </summary>
        /// <param name="textArray">The input text array to be ordered.</param>
        /// <returns>An IEnumerable of strings representing the ordered elements.</returns>
        IEnumerable<string> Order(IEnumerable<string> textArray);
    }
}
