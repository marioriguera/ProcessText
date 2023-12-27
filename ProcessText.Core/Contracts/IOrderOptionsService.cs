using System.Collections.Generic;
using ProcessText.Core.Contracts.Models;

namespace ProcessText.Core.Contracts
{
    /// <summary>
    /// Defines the contract for an order options service.
    /// </summary>
    public interface IOrderOptionsService
    {
        /// <summary>
        /// Retrieves a enumerable collection of order options.
        /// </summary>
        /// <returns>A enumerable collection  of the order options.</returns>
        IEnumerable<IOrderOption> GetOrderOptions();

        /// <summary>
        /// Set order options.
        /// </summary>
        /// <param name="options">Enumerable collection of order options.</param>
        void SetOrderOptions(IEnumerable<IOrderOption> options);
    }
}
