using System;
using System.Collections.Generic;
using ProcessText.Core.Contracts;
using ProcessText.Core.Contracts.Factory;

namespace ProcessText.Core.Business.Factory
{
    /// <summary>
    /// Represents a factory for creating ordered sequences of strings based on a specific order.
    /// </summary>
    internal class OrderFactory : IOrderFactory
    {
        private ITextAnalyzer _textAnalyzer;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFactory"/> class.
        /// </summary>
        /// <param name="textAnalyzer">The ITextAnalyzer instance used for text analysis.</param>
        public OrderFactory(ITextAnalyzer textAnalyzer)
        {
            _textAnalyzer = textAnalyzer;
        }

        /// <inheritdoc/>
        public IEnumerable<string> GetOrderText(string order, string text)
        {
            var instance = GetInstance(order);
            return instance.Order(_textAnalyzer.SplitText(text));
        }

        /// <summary>
        /// Gets an instance of an object implementing the IOrder interface based on the specified order.
        /// </summary>
        /// <param name="order">The order criteria for selecting the appropriate IOrder implementation.</param>
        /// <returns>An instance of the IOrder interface corresponding to the specified order.</returns>
        private IOrder GetInstance(string order)
        {
            switch (order)
            {
                case "AlphabeticAsc":
                    return new AlphabeticAscOrder();
                case "AlphabeticDesc":
                    return new AlphabeticDescOrder();
                case "LengthAsc":
                    return new LengthAscOrder();
                default:
                    throw new ArgumentOutOfRangeException(nameof(order), "Not a valid order option.");
            }
        }
    }
}
